namespace DeskEnv
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.deleteEnvBtn = new System.Windows.Forms.Button();
            this.editEnvBtn = new System.Windows.Forms.Button();
            this.addEnvBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.envsList = new System.Windows.Forms.ListBox();
            this.deleteTaskBtn = new System.Windows.Forms.Button();
            this.editTaskBtn = new System.Windows.Forms.Button();
            this.addTaskBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tasksList = new System.Windows.Forms.ListBox();
            this.startBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.deleteEnvBtn);
            this.splitContainer1.Panel1.Controls.Add(this.editEnvBtn);
            this.splitContainer1.Panel1.Controls.Add(this.addEnvBtn);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.envsList);
            this.splitContainer1.Panel1MinSize = 180;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.deleteTaskBtn);
            this.splitContainer1.Panel2.Controls.Add(this.editTaskBtn);
            this.splitContainer1.Panel2.Controls.Add(this.addTaskBtn);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.tasksList);
            this.splitContainer1.Panel2.Controls.Add(this.startBtn);
            this.splitContainer1.Size = new System.Drawing.Size(750, 381);
            this.splitContainer1.SplitterDistance = 183;
            this.splitContainer1.TabIndex = 11;
            // 
            // deleteEnvBtn
            // 
            this.deleteEnvBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteEnvBtn.Enabled = false;
            this.deleteEnvBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteEnvBtn.Location = new System.Drawing.Point(84, 345);
            this.deleteEnvBtn.Name = "deleteEnvBtn";
            this.deleteEnvBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.deleteEnvBtn.Size = new System.Drawing.Size(30, 25);
            this.deleteEnvBtn.TabIndex = 14;
            this.deleteEnvBtn.Text = "D";
            this.deleteEnvBtn.UseVisualStyleBackColor = true;
            this.deleteEnvBtn.Click += new System.EventHandler(this.deleteEnvBtn_Click);
            // 
            // editEnvBtn
            // 
            this.editEnvBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.editEnvBtn.Enabled = false;
            this.editEnvBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editEnvBtn.Location = new System.Drawing.Point(48, 345);
            this.editEnvBtn.Name = "editEnvBtn";
            this.editEnvBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.editEnvBtn.Size = new System.Drawing.Size(30, 25);
            this.editEnvBtn.TabIndex = 13;
            this.editEnvBtn.Text = "E";
            this.editEnvBtn.UseVisualStyleBackColor = true;
            this.editEnvBtn.Click += new System.EventHandler(this.editEnvBtn_Click);
            // 
            // addEnvBtn
            // 
            this.addEnvBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addEnvBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEnvBtn.Location = new System.Drawing.Point(12, 345);
            this.addEnvBtn.Name = "addEnvBtn";
            this.addEnvBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.addEnvBtn.Size = new System.Drawing.Size(30, 25);
            this.addEnvBtn.TabIndex = 12;
            this.addEnvBtn.Text = "A";
            this.addEnvBtn.UseVisualStyleBackColor = true;
            this.addEnvBtn.Click += new System.EventHandler(this.addEnvBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Environments";
            // 
            // envsList
            // 
            this.envsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.envsList.FormattingEnabled = true;
            this.envsList.Location = new System.Drawing.Point(12, 26);
            this.envsList.Name = "envsList";
            this.envsList.Size = new System.Drawing.Size(165, 316);
            this.envsList.TabIndex = 10;
            this.envsList.SelectedIndexChanged += new System.EventHandler(this.envsList_SelectedIndexChanged);
            // 
            // deleteTaskBtn
            // 
            this.deleteTaskBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteTaskBtn.Enabled = false;
            this.deleteTaskBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteTaskBtn.Location = new System.Drawing.Point(78, 345);
            this.deleteTaskBtn.Name = "deleteTaskBtn";
            this.deleteTaskBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.deleteTaskBtn.Size = new System.Drawing.Size(30, 25);
            this.deleteTaskBtn.TabIndex = 16;
            this.deleteTaskBtn.Text = "D";
            this.deleteTaskBtn.UseVisualStyleBackColor = true;
            this.deleteTaskBtn.Click += new System.EventHandler(this.deleteTaskBtn_Click);
            // 
            // editTaskBtn
            // 
            this.editTaskBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.editTaskBtn.Enabled = false;
            this.editTaskBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editTaskBtn.Location = new System.Drawing.Point(42, 345);
            this.editTaskBtn.Name = "editTaskBtn";
            this.editTaskBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.editTaskBtn.Size = new System.Drawing.Size(30, 25);
            this.editTaskBtn.TabIndex = 14;
            this.editTaskBtn.Text = "E";
            this.editTaskBtn.UseVisualStyleBackColor = true;
            this.editTaskBtn.Click += new System.EventHandler(this.editTaskBtn_Click);
            // 
            // addTaskBtn
            // 
            this.addTaskBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addTaskBtn.Enabled = false;
            this.addTaskBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTaskBtn.Location = new System.Drawing.Point(6, 345);
            this.addTaskBtn.Name = "addTaskBtn";
            this.addTaskBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.addTaskBtn.Size = new System.Drawing.Size(30, 25);
            this.addTaskBtn.TabIndex = 13;
            this.addTaskBtn.Text = "A";
            this.addTaskBtn.UseVisualStyleBackColor = true;
            this.addTaskBtn.Click += new System.EventHandler(this.addTaskBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Programs";
            // 
            // tasksList
            // 
            this.tasksList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tasksList.FormattingEnabled = true;
            this.tasksList.Location = new System.Drawing.Point(6, 26);
            this.tasksList.Name = "tasksList";
            this.tasksList.Size = new System.Drawing.Size(545, 316);
            this.tasksList.TabIndex = 11;
            this.tasksList.DoubleClick += new System.EventHandler(this.editTaskBtn_Click);
            // 
            // startBtn
            // 
            this.startBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.startBtn.Enabled = false;
            this.startBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBtn.Location = new System.Drawing.Point(467, 347);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(84, 23);
            this.startBtn.TabIndex = 15;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 381);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "DeskEnv";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button deleteEnvBtn;
        private System.Windows.Forms.Button editEnvBtn;
        private System.Windows.Forms.Button addEnvBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox envsList;
        private System.Windows.Forms.Button deleteTaskBtn;
        private System.Windows.Forms.Button editTaskBtn;
        private System.Windows.Forms.Button addTaskBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox tasksList;
        private System.Windows.Forms.Button startBtn;
    }
}

