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
    public partial class resetpassword : Form
    {
        string username;
        public resetpassword()
        {
            InitializeComponent();
        }

        private void txt_reset_Click(object sender, EventArgs e)
        {
            int id;
            int pass;
            id= Convert.ToInt32(txt_id.Text);
            pass = Convert.ToInt32(txt_newpassword.Text);
            



            if(txt_newpassword.Text==txt_confirmpassword.Text)
            {
                 SqlConnection con = new SqlConnection("Data Source=DESKTOP-S5GCSME;Initial Catalog=e_library;Integrated Security=True");
                SqlCommand cmd = new SqlCommand(" UPDATE password_detials SET p_assword = '" + txt_newpassword.Text + "'WHERE ID_ ='" + txt_id.Text + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Successfully Password Reset");
            }
            else
            {
                MessageBox.Show("Unsuccessfull");
            }
        }

        private void resetpassword_Load(object sender, EventArgs e)
        {
           
        }
    }
}
