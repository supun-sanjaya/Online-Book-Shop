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
    public partial class regupdate : Form
    {
        public regupdate()
        {
            InitializeComponent();
        }
        SqlCommand cmd;
        SqlConnection con;
        private void txt_firstname_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_updateinfo_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Update user_detials_ set First_name ='" + txt_firstname + "',Last_name ='" + txt_lastname + "',DOB='" + date_picker_reg.Value + "'," +
                "Address_='" + txt_address + "',country='" + txt_country + "',city='" + txt_city + "',status_='" + txt_status + "',zip_code='" + txt_zipcode + "',personal_num='" + txt_personalnumber + "'" +
                ",home_num='" + txt_homenumber + "'", con);
                int i = cmd.ExecuteNonQuery();
                if (i == 1)
                    MessageBox.Show("Data Delect Successfully", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Error , Fail To Update", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                con.Close();
                cmd.Dispose();
            }
            catch (SqlException)
            {
                MessageBox.Show("Database Error", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }


        }

        private void regupdate_Load(object sender, EventArgs e)
        {
            con=new SqlConnection("data source =kjjjijhih");
        }
    }
}





            
           
