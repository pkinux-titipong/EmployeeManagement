namespace EmployeeManagement
{
    partial class Login
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
            this.idlabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.UsernameTb = new System.Windows.Forms.TextBox();
            this.PassTb = new System.Windows.Forms.TextBox();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // idlabel
            // 
            this.idlabel.AutoSize = true;
            this.idlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idlabel.Location = new System.Drawing.Point(742, 375);
            this.idlabel.Name = "idlabel";
            this.idlabel.Size = new System.Drawing.Size(80, 13);
            this.idlabel.TabIndex = 0;
            this.idlabel.Text = "USER NAME";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(743, 401);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(78, 13);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "PASSWORD";
            // 
            // UsernameTb
            // 
            this.UsernameTb.Location = new System.Drawing.Point(833, 375);
            this.UsernameTb.Name = "UsernameTb";
            this.UsernameTb.Size = new System.Drawing.Size(100, 20);
            this.UsernameTb.TabIndex = 2;
            // 
            // PassTb
            // 
            this.PassTb.Location = new System.Drawing.Point(833, 401);
            this.PassTb.Name = "PassTb";
            this.PassTb.Size = new System.Drawing.Size(100, 20);
            this.PassTb.TabIndex = 3;
            // 
            // LoginBtn
            // 
            this.LoginBtn.Location = new System.Drawing.Point(875, 444);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(58, 23);
            this.LoginBtn.TabIndex = 4;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(802, 444);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(58, 23);
            this.CancelBtn.TabIndex = 5;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(599, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "WELCOME TO EMPLOYEE MANAGEMENT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(879, 506);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 7);
            this.label2.TabIndex = 7;
            this.label2.Text = "Develop By PK";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(957, 531);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.PassTb);
            this.Controls.Add(this.UsernameTb);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.idlabel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idlabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox UsernameTb;
        private System.Windows.Forms.TextBox PassTb;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}