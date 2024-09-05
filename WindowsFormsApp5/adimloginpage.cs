using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp5
{
    public partial class adimloginpage : Form
    {
        public adimloginpage()
        {
            InitializeComponent();
        }
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter adp;

        private void btn_login_Click(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter("Select *from Admin_table where Admin_id ='" + txt_adminid.Text + "' and Admin_password ='" + txt_adminpass.Text + "'", con);
            DataTable dtt = new DataTable();

            adp.Fill(dtt);

            if (dtt.Rows.Count > 0)
            {

                this.Hide();
                MessageBox.Show("Login successfull");
                AdminLog ad = new AdminLog();
                ad.Show();

                
            }
            else
            {
                MessageBox.Show("Email or Passord is incorrect", "Error ", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

    }
}

