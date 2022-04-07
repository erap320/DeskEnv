namespace DeskEnv
{
    partial class EditTask
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditTask));
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pathTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.argsTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.minBox = new System.Windows.Forms.CheckBox();
            this.adminBox = new System.Windows.Forms.CheckBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.browse = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(57, 12);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(173, 20);
            this.nameTxt.TabIndex = 4;
            this.nameTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EditTask_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name:";
            // 
            // pathTxt
            // 
            this.pathTxt.Location = new System.Drawing.Point(57, 38);
            this.pathTxt.Name = "pathTxt";
            this.pathTxt.Size = new System.Drawing.Size(173, 20);
            this.pathTxt.TabIndex = 6;
            this.pathTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EditTask_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Path:";
            // 
            // argsTxt
            // 
            this.argsTxt.Location = new System.Drawing.Point(57, 64);
            this.argsTxt.Name = "argsTxt";
            this.argsTxt.Size = new System.Drawing.Size(173, 20);
            this.argsTxt.TabIndex = 8;
            this.argsTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EditTask_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Args:";
            // 
            // minBox
            // 
            this.minBox.AutoSize = true;
            this.minBox.Location = new System.Drawing.Point(16, 90);
            this.minBox.Name = "minBox";
            this.minBox.Size = new System.Drawing.Size(94, 17);
            this.minBox.TabIndex = 9;
            this.minBox.Text = "Run minimized";
            this.minBox.UseVisualStyleBackColor = true;
            this.minBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EditTask_KeyDown);
            // 
            // adminBox
            // 
            this.adminBox.AutoSize = true;
            this.adminBox.Location = new System.Drawing.Point(16, 113);
            this.adminBox.Name = "adminBox";
            this.adminBox.Size = new System.Drawing.Size(122, 17);
            this.adminBox.TabIndex = 10;
            this.adminBox.Text = "Run as administrator";
            this.adminBox.UseVisualStyleBackColor = true;
            this.adminBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EditTask_KeyDown);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(329, 165);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 11;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // browse
            // 
            this.browse.Location = new System.Drawing.Point(236, 38);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(58, 20);
            this.browse.TabIndex = 12;
            this.browse.Text = "Browse...";
            this.browse.UseVisualStyleBackColor = true;
            this.browse.Click += new System.EventHandler(this.browse_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(374, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(30, 30);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 13;
            this.pictureBox.TabStop = false;
            // 
            // EditTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 200);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.browse);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.adminBox);
            this.Controls.Add(this.minBox);
            this.Controls.Add(this.argsTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pathTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditTask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EditTask";
            this.Load += new System.EventHandler(this.EditTask_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EditTask_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pathTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox argsTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox minBox;
        private System.Windows.Forms.CheckBox adminBox;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}