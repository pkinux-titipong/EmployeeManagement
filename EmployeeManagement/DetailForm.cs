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
    public partial class DetailForm : Form
    {
        public DetailForm()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=PKINUX9838\SQLEXPRESS;Initial Catalog=EmployeeManage;Integrated Security=True;Pooling=False");

        private void fetchData() {
            con.Open();
            string query = "select * from EmployeeTb where EmpID='"+EmpIdTb.Text+"'";
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows) {
                IdLbl.Text = dr["EmpID"].ToString();
                NameLbl.Text = dr["EmpName"].ToString();
                SurLbl.Text = dr["EmpSur"].ToString();
                NickLbl.Text = dr["EmpNick"].ToString();
                dateTimePicker1.Text = dr["EmpDob"].ToString();
                AddrLbl.Text = dr["EmpAddr"].ToString();
                PhoneLbl.Text = dr["EmpPhone"].ToString();
                EduLbl.Text = dr["EmpEdu"].ToString();
                PosLbl.Text = dr["EmpPos"].ToString();
                SarLbl.Text = dr["EmpSar"].ToString();
            }
            con.Close();
        }



        private void ExtBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            fetchData();
        }

        private void DetailForm_Load(object sender, EventArgs e)
        {

        }
    }
}
