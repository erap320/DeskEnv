using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Drawing.Text;

using Newtonsoft.Json;
using System.IO;
using System.Diagnostics;

namespace DeskEnv
{
    public partial class MainForm : Form
    {
        private static string envsFileDir = System.Environment.ExpandEnvironmentVariables(@"%appdata%/DeskEnv/");
        private static string envsFileName = "environments.json";
        private static string envsFilePath = envsFileDir + envsFileName;

        //Start font loading
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
            IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private PrivateFontCollection fonts = new PrivateFontCollection();
 
        Font fontawesome;
        //End font loading

        private BindingList<Environment> envs = new BindingList<Environment>();

        public MainForm()
        {
            InitializeComponent();

            //Font loading
            byte[] fontData = Properties.Resources.FontAwesome;
            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            uint dummy = 0;
            fonts.AddMemoryFont(fontPtr, Properties.Resources.FontAwesome.Length);
            AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.FontAwesome.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);

            fontawesome = new Font(fonts.Families[0], 8.0F);
        }

        private void UpdateFile() {
            File.WriteAllText(System.Environment.ExpandEnvironmentVariables(envsFilePath), JsonConvert.SerializeObject(envs));
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            addEnvBtn.Font = editEnvBtn.Font = addTaskBtn.Font = editTaskBtn.Font = deleteEnvBtn.Font = deleteTaskBtn.Font = fontawesome;

            addEnvBtn.Text =  addTaskBtn.Text = "\xF067";
            editEnvBtn.Text = editTaskBtn.Text = "\xF040";
            deleteEnvBtn.Text = deleteTaskBtn.Text = "\xF1F8";

            if (Directory.Exists(envsFileDir))
            {
                if (File.Exists(envsFilePath))
                {
                    envs = JsonConvert.DeserializeObject<BindingList<Environment>>(File.ReadAllText(envsFilePath));
                    addTaskBtn.Enabled = editEnvBtn.Enabled = deleteEnvBtn.Enabled = (envs.Count() > 0);
                    if (envs.Count() <= 0)
                    {
                        editTaskBtn.Enabled = deleteTaskBtn.Enabled = startBtn.Enabled = false;
                    }
                }
            }
            else //First run, set everything up
            {
                try
                {
                    Directory.CreateDirectory(envsFileDir);
                }
                catch {
                    MessageBox.Show("Can't start the program because creation of the settings folder in %appdata% failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }

            tasksList.DisplayMember = "Name";
            envsList.DisplayMember = "Name";
            envsList.DataSource = envs;
        }

        private void envsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (envsList.SelectedIndex >= 0)
            {
                tasksList.DataSource = envs[envsList.SelectedIndex].Tasks;
                editTaskBtn.Enabled = deleteTaskBtn.Enabled = startBtn.Enabled = (envs[envsList.SelectedIndex].Tasks.Count() > 0);
            }
        }

        private void addEnvBtn_Click(object sender, EventArgs e)
        {
            EditEnvironment form = new EditEnvironment();
            form.name = "New Environment";

            if (form.ShowDialog() == DialogResult.OK)
            {
                Environment newEnv = new Environment();
                newEnv.Name = form.name;
                envs.Add(newEnv);

                envsList.SelectedIndex = envs.Count() - 1;

                editEnvBtn.Enabled = true;
                deleteEnvBtn.Enabled = true;
                addTaskBtn.Enabled = true;
            }

            UpdateFile();
        }

        private void editEnv()
        {
            Environment selected = envs[envsList.SelectedIndex];

            EditEnvironment form = new EditEnvironment();
            form.name = selected.Name;

            if (form.ShowDialog() == DialogResult.OK)
            {
                selected.Name = form.name;

                //Refresh names
                envsList.DisplayMember = "";
                envsList.DisplayMember = "Name";
            }

            UpdateFile();
        }

        private void editEnvBtn_Click(object sender, EventArgs e) => editEnv();

        private void addTaskBtn_Click(object sender, EventArgs e)
        {
            Environment selected = envs[envsList.SelectedIndex];

            EditTask form = new EditTask();
            form.name = "New Program";
            form.path = "";
            form.args = "";
            form.minimized = false;
            form.asAdmin = false;

            if (form.ShowDialog() == DialogResult.OK)
            {
                Task newTask = new Task();
                newTask.Name = form.name;
                newTask.Path = form.path;
                newTask.Args = form.args;
                newTask.Minimized = form.minimized;
                newTask.AsAdmin = form.asAdmin;
                selected.Tasks.Add(newTask);

                tasksList.DataSource = null;
                tasksList.DataSource = selected.Tasks;
                tasksList.DisplayMember = "Name";

                tasksList.SelectedIndex = selected.Tasks.Count() - 1;

                editTaskBtn.Enabled = true;
                deleteTaskBtn.Enabled = true;
                startBtn.Enabled = true;
            }

            UpdateFile();
        }

        private void editTask()
        {
            Environment selected = envs[envsList.SelectedIndex];
            int index = tasksList.SelectedIndex;
            Task current = selected.Tasks[index];

            EditTask form = new EditTask();
            form.name = current.Name;
            form.path = current.Path;
            form.args = current.Args;
            form.minimized = current.Minimized;
            form.asAdmin = current.AsAdmin;

            if (form.ShowDialog() == DialogResult.OK)
            {
                current.Name = form.name;
                current.Path = form.path;
                current.Args = form.args;
                current.Minimized = form.minimized;
                current.AsAdmin = form.asAdmin;

                //Refresh names
                tasksList.DisplayMember = "";
                tasksList.DisplayMember = "Name";

                tasksList.SelectedIndex = index;
            }

            UpdateFile();
        }

        private void editTaskBtn_Click(object sender, EventArgs e) => editTask();

        private void deleteEnvBtn_Click(object sender, EventArgs e)
        {
            Environment selected = envs[envsList.SelectedIndex];
            envs.Remove(selected);

            addTaskBtn.Enabled = editEnvBtn.Enabled = deleteEnvBtn.Enabled = (envs.Count() > 0);
            if (envs.Count() <= 0)
            {
                editTaskBtn.Enabled = deleteTaskBtn.Enabled = startBtn.Enabled = false;
                tasksList.DataSource = null;
            }

            UpdateFile();
        }

        private void deleteTaskBtn_Click(object sender, EventArgs e)
        {
            Environment selected = envs[envsList.SelectedIndex];

            selected.Tasks.Remove(selected.Tasks[tasksList.SelectedIndex]);

            tasksList.DataSource = null;
            tasksList.DataSource = selected.Tasks;
            tasksList.DisplayMember = "Name";

            editTaskBtn.Enabled = deleteTaskBtn.Enabled = startBtn.Enabled = (envs[envsList.SelectedIndex].Tasks.Count() > 0);

            UpdateFile();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            Environment selected = envs[envsList.SelectedIndex];
            Process process;

            foreach (Task task in selected.Tasks)
            {
                process = new Process();

                process.StartInfo.FileName = task.Path;
                process.StartInfo.Arguments = task.Args;

                if (task.Minimized) process.StartInfo.WindowStyle = ProcessWindowStyle.Minimized;
                else process.StartInfo.WindowStyle = ProcessWindowStyle.Normal;

                if (task.AsAdmin) {
                    process.StartInfo.UseShellExecute = true;
                    process.StartInfo.Verb = "runas";
                }

                try
                {
                    process.Start();
                }
                catch (Win32Exception ex)
                {
                    //Code 1223 means the user cancelled running a program as admin
                    if (ex.NativeErrorCode != 1223) 
                    {
                        MessageBox.Show("Couldn't start " + task.Name, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void tasksList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = tasksList.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                editTask();
            }
        }

        private void envsList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = tasksList.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                editEnv();
            }
        }
    }
}