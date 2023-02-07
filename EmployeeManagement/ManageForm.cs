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
    public partial class ManageForm : Form
    {
        public ManageForm()
        {
            InitializeComponent();
        }

        //สร้างการเชื่อมต่อฐานข้อมูล
        SqlConnection con = new SqlConnection(@"Data Source=PKINUX9838\SQLEXPRESS;Initial Catalog=EmployeeManage;Integrated Security=True;Pooling=False");
        
        
        private void ManageForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        //แสดงข้อมูล
        private void populate() {
            con.Open();
            string query = "select * from EmployeeTb";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            EmpGrid.DataSource = ds.Tables[0];

            con.Close();
        }


        //ลบข้อมูล
        private void DelBtn_Click(object sender, EventArgs e)
        {
            if (IdTb.Text == "")
            {
                MessageBox.Show("กรุณากรอกรหัสพนักงาน");
            }
            else {
                try {
                    con.Open();
                    string query = "delete from EmployeeTb where EmpID='"+IdTb.Text+"';";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("ลบข้อมูลเรียบร้อย");
                    con.Close();

                    populate();
                }
                catch(Exception ex){
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            IdTb.Clear();
            NameTb.Clear();
            SurTb.Clear();
            NickTb.Clear();
            AddrTb.Clear();
            PhoneTb.Clear();
            EduTb.Clear();
            PosTb.Clear();
            SarTb.Clear();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            int va;
            va = int.Parse(SarTb.Text);
            if (IdTb.Text == "" || NameTb.Text == "" || SurTb.Text == "" || NickTb.Text == "" || AddrTb.Text == "" || PhoneTb.Text == "" || EduTb.Text == "" || PosTb.Text == "" || SarTb.Text == "")
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบถ้วน");
            }
            else { 
                try{

                    con.Open();
                    string query = "update EmployeeTb set EmpName='"+NameTb.Text+"', EmpSur='"+SurTb.Text+"', EmpNick='"+NickTb.Text+"', EmpDob='"+dateTimePicker1.Value.Date+"', EmpAddr='"+AddrTb.Text+"', EmpPhone='"+PhoneTb.Text+"',EmpEdu='"+EduTb.Text+"', EmpPos='"+PosTb.Text+"', EmpSar='"+ va +"' where EmpID='"+IdTb.Text+"';";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("แก้ไขข้อมูลพนักงานเรียบร้อย");
                    con.Close();
                    populate();
                
                }catch(Exception Ex){
                    MessageBox.Show(Ex.Message);
                }
            
            }

        }

        private void EmpGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) {
                return;
            }

            DataGridViewRow dr = EmpGrid.Rows[e.RowIndex];
            IdTb.Text = dr.Cells[0].Value.ToString();
            NameTb.Text = dr.Cells[1].Value.ToString();
            SurTb.Text = dr.Cells[2].Value.ToString();
            NickTb.Text = dr.Cells[3].Value.ToString();
            dateTimePicker1.Text = dr.Cells[4].Value.ToString();
            AddrTb.Text = dr.Cells[5].Value.ToString();
            PhoneTb.Text = dr.Cells[6].Value.ToString();
            EduTb.Text = dr.Cells[7].Value.ToString();
            PosTb.Text = dr.Cells[8].Value.ToString();
            SarTb.Text = dr.Cells[9].Value.ToString();

            dr.Selected = true;


        }

      
    }
}
