using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EmployeeManagement
{
    public partial class NewEmp : Form
    {

        public NewEmp()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=PKINUX9838\SQLEXPRESS;Initial Catalog=EmployeeManage;Integrated Security=True;Pooling=False");

        private void NewEmp_Load(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            int va;
            va = int.Parse(EmpSar.Text);
            if (EmpID.Text == "" || EmpName.Text == "" || EmpSur.Text == "" || EmpNick.Text == "" || EmpPhone.Text == "")
            {
                MessageBox.Show("กรุณากรอกขอมูลให้ครบถ้วน");
            }
            else {
                try {
                    con.Open();
                    string query = "Insert Into EmployeeTb values('" + EmpID.Text + "' , '" + EmpName.Text + "', '" + EmpSur.Text + "', '" + EmpNick.Text + "', '" + EmpDob.Value.Date + "', '" + EmpAddr.Text + "', '" + EmpPhone.Text + "', '" + EmpEdu.Text + "', '" + EmpPos.Text + "', '" + va + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    EmpID.Clear();
                    EmpName.Clear();
                    EmpSur.Clear();
                    EmpAddr.Clear();
                    EmpPhone.Clear();
                    EmpEdu.Clear();
                    EmpPos.Clear();
                    EmpSar.Clear();
                    MessageBox.Show("บันทึกข้อมูลเรียบร้อย");
                    con.Close();
                }
                catch(Exception Ex) {
                    MessageBox.Show(Ex.Message);
                }
            }


        }

        private void CanBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
