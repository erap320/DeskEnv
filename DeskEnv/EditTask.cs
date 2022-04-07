using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace DeskEnv
{
    public partial class EditTask : Form
    {
        public string name;
        public string path;
        public string args;   
        public bool minimized;
        public bool asAdmin;

        public EditTask()
        {
            InitializeComponent();
        }

        public static bool ExistsOnPath(string fileName)
        {
            return GetFullPath(fileName) != null;
        }

        public static string GetFullPath(string fileName)
        {
            if (File.Exists(fileName))
                return Path.GetFullPath(fileName);

            var values = System.Environment.GetEnvironmentVariable("PATH");
            foreach (var path in values.Split(';'))
            {
                var fullPath = Path.Combine(path, fileName);
                if (File.Exists(fullPath))
                    return fullPath;
            }
            return null;
        }

        private void EditTask_Load(object sender, EventArgs e)
        {
            openFileDialog.InitialDirectory = @"C:\ProgramData\Microsoft\Windows\Start Menu\Programs";
            Text = "Edit " + name;
            nameTxt.Text = name;
            pathTxt.Text = path;
            argsTxt.Text = args;
            minBox.Checked = minimized;
            adminBox.Checked = asAdmin;
            if(File.Exists(pathTxt.Text)) pictureBox.Image = pictureBox.Image = Icon.ExtractAssociatedIcon(GetFullPath(pathTxt.Text)).ToBitmap();
            Console.WriteLine(GetFullPath(pathTxt.Text));
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (nameTxt.Text != "" && pathTxt.Text != "")
            {
                if (ExistsOnPath(pathTxt.Text))
                {
                    name = nameTxt.Text;
                    path = pathTxt.Text;
                    args = argsTxt.Text;
                    minimized = minBox.Checked;
                    asAdmin = adminBox.Checked;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("The program can't be found, the path looks to be incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("The program's name and path can't be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void EditTask_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                saveBtn_Click(saveBtn, e);
            }
        }

        private void browse_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                nameTxt.Text = openFileDialog.SafeFileName;
                pathTxt.Text = openFileDialog.FileName;
                pictureBox.Image = Icon.ExtractAssociatedIcon(GetFullPath(pathTxt.Text)).ToBitmap();
                Console.WriteLine(GetFullPath(pathTxt.Text));
            }
        }
    }
}
