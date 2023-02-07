namespace EmployeeManagement
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dBFunctionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewEmployeeInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageEmployeeInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.NewBtn = new System.Windows.Forms.Button();
            this.ViewBtn = new System.Windows.Forms.Button();
            this.ManageBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1236, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // dBFunctionToolStripMenuItem
            // 
            this.dBFunctionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewEmployeeInfoToolStripMenuItem,
            this.manageEmployeeInfoToolStripMenuItem});
            this.dBFunctionToolStripMenuItem.Name = "dBFunctionToolStripMenuItem";
            this.dBFunctionToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.dBFunctionToolStripMenuItem.Text = "DB Function";
            // 
            // viewEmployeeInfoToolStripMenuItem
            // 
            this.viewEmployeeInfoToolStripMenuItem.Name = "viewEmployeeInfoToolStripMenuItem";
            this.viewEmployeeInfoToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.viewEmployeeInfoToolStripMenuItem.Text = "View Employee Info";
            this.viewEmployeeInfoToolStripMenuItem.Click += new System.EventHandler(this.viewEmployeeInfoToolStripMenuItem_Click);
            // 
            // manageEmployeeInfoToolStripMenuItem
            // 
            this.manageEmployeeInfoToolStripMenuItem.Name = "manageEmployeeInfoToolStripMenuItem";
            this.manageEmployeeInfoToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.manageEmployeeInfoToolStripMenuItem.Text = "Manage Employee Info";
            this.manageEmployeeInfoToolStripMenuItem.Click += new System.EventHandler(this.manageEmployeeInfoToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please Select Function To Operate";
            // 
            // NewBtn
            // 
            this.NewBtn.Location = new System.Drawing.Point(25, 86);
            this.NewBtn.Name = "NewBtn";
            this.NewBtn.Size = new System.Drawing.Size(300, 40);
            this.NewBtn.TabIndex = 3;
            this.NewBtn.Text = "New Employee Data";
            this.NewBtn.UseVisualStyleBackColor = true;
            this.NewBtn.Click += new System.EventHandler(this.NewBtn_Click_1);
            // 
            // ViewBtn
            // 
            this.ViewBtn.Location = new System.Drawing.Point(25, 150);
            this.ViewBtn.Name = "ViewBtn";
            this.ViewBtn.Size = new System.Drawing.Size(300, 40);
            this.ViewBtn.TabIndex = 4;
            this.ViewBtn.Text = "View Employee Information";
            this.ViewBtn.UseVisualStyleBackColor = true;
            this.ViewBtn.Click += new System.EventHandler(this.ViewBtn_Click);
            // 
            // ManageBtn
            // 
            this.ManageBtn.Location = new System.Drawing.Point(25, 209);
            this.ManageBtn.Name = "ManageBtn";
            this.ManageBtn.Size = new System.Drawing.Size(300, 45);
            this.ManageBtn.TabIndex = 5;
            this.ManageBtn.Text = "Manage Employee Information";
            this.ManageBtn.UseVisualStyleBackColor = true;
            this.ManageBtn.Click += new System.EventHandler(this.ManageBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ExitBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ManageBtn);
            this.panel1.Controls.Add(this.NewBtn);
            this.panel1.Controls.Add(this.ViewBtn);
            this.panel1.Location = new System.Drawing.Point(899, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 665);
            this.panel1.TabIndex = 7;
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(25, 526);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(300, 53);
            this.ExitBtn.TabIndex = 6;
            this.ExitBtn.Text = "Exit Program";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 641);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1236, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // aboutMeToolStripMenuItem
            // 
            this.aboutMeToolStripMenuItem.Name = "aboutMeToolStripMenuItem";
            this.aboutMeToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem1.Text = "File";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1236, 663);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Employee Management Program";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dBFunctionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewEmployeeInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageEmployeeInfoToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button NewBtn;
        private System.Windows.Forms.Button ViewBtn;
        private System.Windows.Forms.Button ManageBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
    }
}

