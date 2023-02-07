namespace EmployeeManagement
{
    partial class DetailForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.EmpIdTb = new System.Windows.Forms.TextBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ExtBtn = new System.Windows.Forms.Button();
            this.NameLbl = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SurLbl = new System.Windows.Forms.Label();
            this.NickLbl = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.AddrLbl = new System.Windows.Forms.Label();
            this.PhoneLbl = new System.Windows.Forms.Label();
            this.EduLbl = new System.Windows.Forms.Label();
            this.PosLbl = new System.Windows.Forms.Label();
            this.SarLbl = new System.Windows.Forms.Label();
            this.IdLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "กรุณากรอกรหัสพนักงานเพื่อค้นหาข้อมูล";
            // 
            // EmpIdTb
            // 
            this.EmpIdTb.Location = new System.Drawing.Point(57, 98);
            this.EmpIdTb.Name = "EmpIdTb";
            this.EmpIdTb.Size = new System.Drawing.Size(100, 20);
            this.EmpIdTb.TabIndex = 1;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(180, 98);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(75, 20);
            this.SearchBtn.TabIndex = 2;
            this.SearchBtn.Text = "ค้นหา";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ชื่อ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(209, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "นามสกุล";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(377, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "ชื่อเล่น";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "วัน/เดือน/ปีเกิด";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "ที่อยู่";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 364);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "เบอร์โทรศัพท์";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(286, 364);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "วุฒิการศึกษา";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(54, 415);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "ต่ำแหน่ง";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(286, 415);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "เงินเดือน";
            // 
            // ExtBtn
            // 
            this.ExtBtn.Location = new System.Drawing.Point(357, 499);
            this.ExtBtn.Name = "ExtBtn";
            this.ExtBtn.Size = new System.Drawing.Size(98, 23);
            this.ExtBtn.TabIndex = 12;
            this.ExtBtn.Text = "จบการทำงาน";
            this.ExtBtn.UseVisualStyleBackColor = true;
            this.ExtBtn.Click += new System.EventHandler(this.ExtBtn_Click);
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Location = new System.Drawing.Point(85, 175);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(61, 13);
            this.NameLbl.TabIndex = 13;
            this.NameLbl.Text = "ชื่อพนักงาน";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(54, 137);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "รหัสพนักงาน";
            // 
            // SurLbl
            // 
            this.SurLbl.AutoSize = true;
            this.SurLbl.Location = new System.Drawing.Point(276, 175);
            this.SurLbl.Name = "SurLbl";
            this.SurLbl.Size = new System.Drawing.Size(67, 13);
            this.SurLbl.TabIndex = 25;
            this.SurLbl.Text = "สกุลพนักงาน";
            // 
            // NickLbl
            // 
            this.NickLbl.AutoSize = true;
            this.NickLbl.Location = new System.Drawing.Point(444, 175);
            this.NickLbl.Name = "NickLbl";
            this.NickLbl.Size = new System.Drawing.Size(80, 13);
            this.NickLbl.TabIndex = 26;
            this.NickLbl.Text = "ชื่อเล่นพนักงาน";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(157, 208);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 27;
            // 
            // AddrLbl
            // 
            this.AddrLbl.AutoSize = true;
            this.AddrLbl.Location = new System.Drawing.Point(96, 261);
            this.AddrLbl.Name = "AddrLbl";
            this.AddrLbl.Size = new System.Drawing.Size(68, 13);
            this.AddrLbl.TabIndex = 28;
            this.AddrLbl.Text = "ที่อยู่พนักงาน";
            // 
            // PhoneLbl
            // 
            this.PhoneLbl.AutoSize = true;
            this.PhoneLbl.Location = new System.Drawing.Point(145, 364);
            this.PhoneLbl.Name = "PhoneLbl";
            this.PhoneLbl.Size = new System.Drawing.Size(90, 13);
            this.PhoneLbl.TabIndex = 29;
            this.PhoneLbl.Text = "เบอร์โทรพนักงาน";
            // 
            // EduLbl
            // 
            this.EduLbl.AutoSize = true;
            this.EduLbl.Location = new System.Drawing.Point(377, 364);
            this.EduLbl.Name = "EduLbl";
            this.EduLbl.Size = new System.Drawing.Size(110, 13);
            this.EduLbl.TabIndex = 30;
            this.EduLbl.Text = "วุฒิการศึกษาพนักงาน";
            // 
            // PosLbl
            // 
            this.PosLbl.AutoSize = true;
            this.PosLbl.Location = new System.Drawing.Point(121, 415);
            this.PosLbl.Name = "PosLbl";
            this.PosLbl.Size = new System.Drawing.Size(88, 13);
            this.PosLbl.TabIndex = 31;
            this.PosLbl.Text = "ตำแหน่งพนักงาน";
            // 
            // SarLbl
            // 
            this.SarLbl.AutoSize = true;
            this.SarLbl.Location = new System.Drawing.Point(377, 415);
            this.SarLbl.Name = "SarLbl";
            this.SarLbl.Size = new System.Drawing.Size(92, 13);
            this.SarLbl.TabIndex = 32;
            this.SarLbl.Text = "เงินเดือนพนักงาน";
            // 
            // IdLbl
            // 
            this.IdLbl.AutoSize = true;
            this.IdLbl.Location = new System.Drawing.Point(136, 137);
            this.IdLbl.Name = "IdLbl";
            this.IdLbl.Size = new System.Drawing.Size(67, 13);
            this.IdLbl.TabIndex = 33;
            this.IdLbl.Text = "รหัสพนักงาน";
            // 
            // DetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 542);
            this.Controls.Add(this.IdLbl);
            this.Controls.Add(this.SarLbl);
            this.Controls.Add(this.PosLbl);
            this.Controls.Add(this.EduLbl);
            this.Controls.Add(this.PhoneLbl);
            this.Controls.Add(this.AddrLbl);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.NickLbl);
            this.Controls.Add(this.SurLbl);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.ExtBtn);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.EmpIdTb);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DetailForm";
            this.Load += new System.EventHandler(this.DetailForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EmpIdTb;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button ExtBtn;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label SurLbl;
        private System.Windows.Forms.Label NickLbl;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label AddrLbl;
        private System.Windows.Forms.Label PhoneLbl;
        private System.Windows.Forms.Label EduLbl;
        private System.Windows.Forms.Label PosLbl;
        private System.Windows.Forms.Label SarLbl;
        private System.Windows.Forms.Label IdLbl;
    }
}