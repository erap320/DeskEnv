using System;
using System.Windows.Forms;

namespace DeskEnv
{
    public partial class EditEnvironment : Form
    {
        public string name;

        public EditEnvironment()
        {
            InitializeComponent();
        }

        private void EditEnvironment_Load(object sender, EventArgs e)
        {
            Text = "Edit " + name;
            nameTxt.Text = name;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (nameTxt.Text != "")
            {
                name = nameTxt.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("The environment's name can't be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void EditEnvironment_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                saveBtn_Click(saveBtn, e);
            }
        }
    }
}
