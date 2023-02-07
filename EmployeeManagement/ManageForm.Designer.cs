namespace EmployeeManagement
{
    partial class ManageForm
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
            this.EmpGrid = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.DelBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.NameTb = new System.Windows.Forms.TextBox();
            this.SurTb = new System.Windows.Forms.TextBox();
            this.NickTb = new System.Windows.Forms.TextBox();
            this.AddrTb = new System.Windows.Forms.TextBox();
            this.PhoneTb = new System.Windows.Forms.TextBox();
            this.EduTb = new System.Windows.Forms.TextBox();
            this.PosTb = new System.Windows.Forms.TextBox();
            this.SarTb = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.IdTb = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.EmpGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // EmpGrid
            // 
            this.EmpGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmpGrid.Location = new System.Drawing.Point(12, 13);
            this.EmpGrid.Name = "EmpGrid";
            this.EmpGrid.Size = new System.Drawing.Size(819, 330);
            this.EmpGrid.TabIndex = 0;
            this.EmpGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmpGrid_CellContentClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(585, 518);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "เงินเดือน";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(367, 518);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "ต่ำแหน่ง";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 518);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "วุฒิการศึกษา";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 441);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "เบอร์โทรศัพท์";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(351, 398);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "ที่อยู่";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 401);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "วัน/เดือน/ปีเกิด";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(655, 367);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "ชื่อเล่น";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(472, 367);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "นามสกุล";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(328, 367);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "ชื่อ";
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(404, 591);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(75, 23);
            this.UpdateBtn.TabIndex = 21;
            this.UpdateBtn.Text = "แก้ไขข้อมูล";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // DelBtn
            // 
            this.DelBtn.Location = new System.Drawing.Point(498, 590);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(75, 23);
            this.DelBtn.TabIndex = 22;
            this.DelBtn.Text = "ลบข้อมูล";
            this.DelBtn.UseVisualStyleBackColor = true;
            this.DelBtn.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(596, 591);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(75, 23);
            this.ClearBtn.TabIndex = 23;
            this.ClearBtn.Text = "เคลียร์";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(700, 591);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 24;
            this.CancelBtn.Text = "ยกเลิก";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // NameTb
            // 
            this.NameTb.Location = new System.Drawing.Point(354, 360);
            this.NameTb.Name = "NameTb";
            this.NameTb.Size = new System.Drawing.Size(100, 20);
            this.NameTb.TabIndex = 25;
            // 
            // SurTb
            // 
            this.SurTb.Location = new System.Drawing.Point(524, 360);
            this.SurTb.Name = "SurTb";
            this.SurTb.Size = new System.Drawing.Size(125, 20);
            this.SurTb.TabIndex = 26;
            // 
            // NickTb
            // 
            this.NickTb.Location = new System.Drawing.Point(700, 360);
            this.NickTb.Name = "NickTb";
            this.NickTb.Size = new System.Drawing.Size(100, 20);
            this.NickTb.TabIndex = 27;
            // 
            // AddrTb
            // 
            this.AddrTb.Location = new System.Drawing.Point(384, 395);
            this.AddrTb.Multiline = true;
            this.AddrTb.Name = "AddrTb";
            this.AddrTb.Size = new System.Drawing.Size(416, 94);
            this.AddrTb.TabIndex = 28;
            // 
            // PhoneTb
            // 
            this.PhoneTb.Location = new System.Drawing.Point(119, 434);
            this.PhoneTb.Name = "PhoneTb";
            this.PhoneTb.Size = new System.Drawing.Size(145, 20);
            this.PhoneTb.TabIndex = 29;
            // 
            // EduTb
            // 
            this.EduTb.Location = new System.Drawing.Point(119, 515);
            this.EduTb.Name = "EduTb";
            this.EduTb.Size = new System.Drawing.Size(232, 20);
            this.EduTb.TabIndex = 30;
            // 
            // PosTb
            // 
            this.PosTb.Location = new System.Drawing.Point(420, 515);
            this.PosTb.Name = "PosTb";
            this.PosTb.Size = new System.Drawing.Size(134, 20);
            this.PosTb.TabIndex = 31;
            // 
            // SarTb
            // 
            this.SarTb.Location = new System.Drawing.Point(642, 515);
            this.SarTb.Name = "SarTb";
            this.SarTb.Size = new System.Drawing.Size(158, 20);
            this.SarTb.TabIndex = 32;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(130, 395);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 33;
            // 
            // IdTb
            // 
            this.IdTb.Location = new System.Drawing.Point(116, 360);
            this.IdTb.Name = "IdTb";
            this.IdTb.Size = new System.Drawing.Size(196, 20);
            this.IdTb.TabIndex = 35;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(41, 367);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 13);
            this.label11.TabIndex = 34;
            this.label11.Text = "รหัสพนักงาน";
            // 
            // ManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 664);
            this.Controls.Add(this.IdTb);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.SarTb);
            this.Controls.Add(this.PosTb);
            this.Controls.Add(this.EduTb);
            this.Controls.Add(this.PhoneTb);
            this.Controls.Add(this.AddrTb);
            this.Controls.Add(this.NickTb);
            this.Controls.Add(this.SurTb);
            this.Controls.Add(this.NameTb);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.DelBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EmpGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ManageForm";
            this.Load += new System.EventHandler(this.ManageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmpGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView EmpGrid;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button DelBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.TextBox NameTb;
        private System.Windows.Forms.TextBox SurTb;
        private System.Windows.Forms.TextBox NickTb;
        private System.Windows.Forms.TextBox AddrTb;
        private System.Windows.Forms.TextBox PhoneTb;
        private System.Windows.Forms.TextBox EduTb;
        private System.Windows.Forms.TextBox PosTb;
        private System.Windows.Forms.TextBox SarTb;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox IdTb;
        private System.Windows.Forms.Label label11;
    }
}