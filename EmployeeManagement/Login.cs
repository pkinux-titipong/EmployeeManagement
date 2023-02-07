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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=PKINUX9838\SQLEXPRESS;Initial Catalog=EmployeeManage;Integrated Security=True;Pooling=False");

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = string.Format("select * from PasswordTbl where UserName='{0}' AND Password='{1}'", UsernameTb.Text, PassTb.Text);
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (UsernameTb.Text == "" && PassTb.Text == "")
            {
                MessageBox.Show("กรุณากรอก Username และ Password");
            }
            else if(dt.Rows.Count == 1) {
                try {
                    string name = dt.Rows[0]["UserName"].ToString();
                    MessageBox.Show("Welcome " + name);
                    this.Close();
                
                }
                catch(Exception Ex){
                    MessageBox.Show(Ex.Message);
                }
            
            }

            con.Close();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

   
    }
}
