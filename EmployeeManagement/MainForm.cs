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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

   

       SqlConnection con = new SqlConnection(@"Data Source=PKINUX9838\SQLEXPRESS;Initial Catalog=EmployeeManage;Integrated Security=True;Pooling=False");
       private void MainForm_Load(object sender, EventArgs e)
        {
           Login lg = new Login();
           //lg.MdiParent = this;
           lg.ShowDialog();
 
        }

       private void newToolStripMenuItem_Click(object sender, EventArgs e)
       {
           NewEmp ne = new NewEmp();
           ne.MdiParent = this;
           ne.WindowState = FormWindowState.Maximized;
           ne.Show();

       }

       private void viewEmployeeInfoToolStripMenuItem_Click(object sender, EventArgs e)
       {
           DetailForm df = new DetailForm();
           df.MdiParent = this;
           df.WindowState = FormWindowState.Maximized;
           df.Show();
       }

       private void manageEmployeeInfoToolStripMenuItem_Click(object sender, EventArgs e)
       {
           ManageForm mf = new ManageForm();
           mf.MdiParent = this;
           mf.WindowState = FormWindowState.Maximized;
           mf.Show();
       }


       private void NewBtn_Click_1(object sender, EventArgs e)
       {
           NewEmp ne = new NewEmp();
           ne.MdiParent = this;
           ne.WindowState = FormWindowState.Maximized;
           ne.Show();
       }

       private void ViewBtn_Click(object sender, EventArgs e)
       {
           DetailForm df = new DetailForm();
           df.MdiParent = this;
           df.WindowState = FormWindowState.Maximized;
           df.Show();
       }

       private void ManageBtn_Click(object sender, EventArgs e)
       {
           ManageForm mf = new ManageForm();
           mf.MdiParent = this;
           mf.WindowState = FormWindowState.Maximized;
           mf.Show();
       }

       private void ExitBtn_Click(object sender, EventArgs e)
       {
           Application.Exit();
       }

       private void timer1_Tick(object sender, EventArgs e)
       {
           toolStripStatusLabel1.Text = DateTime.Now.ToString("dd MMMM yyy hh:mm:ss");
       }

       private void exitToolStripMenuItem_Click(object sender, EventArgs e)
       {
           Application.Exit();
       }
    }
}
