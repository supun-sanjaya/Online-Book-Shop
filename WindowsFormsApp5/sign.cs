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
    public partial class sign : Form
    {
        public sign()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlDataAdapter adp;

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            int id;
            int password;

            id =Convert.ToInt32( txt_ID.Text);
            password =Convert.ToInt32(txt_password.Text);

           
             adp = new SqlDataAdapter("Select *from password_detials where ID_ ='" + txt_ID.Text + "' and p_assword ='" + txt_password.Text + "'", con);
            DataTable dt = new DataTable();

             adp.Fill(dt);

            if (dt.Rows.Count>0)
            {
                MessageBox.Show("Login successfull");

               this.Hide();
                mainpage m = new mainpage();
                m.Show();
            }
            else
            {
                MessageBox.Show("Email or Passord is incorrect", "Error ", MessageBoxButtons.OK);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Hide();
            register reg = new register();
            reg.ShowDialog();

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Hide();
            this.Close();
            mainpage M = new mainpage();
            M.ShowDialog();
        }

        private void sign_Load(object sender, EventArgs e)
        {
             con = new SqlConnection("Data Source=DESKTOP-S5GCSME;Initial Catalog=e_library;Integrated Security=True");
        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {
            Hide();
            this.Close();
            Form1 s = new Form1();
            s.ShowDialog();

        }
    }
}
