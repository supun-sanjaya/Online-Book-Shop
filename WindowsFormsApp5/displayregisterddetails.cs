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
    public partial class displayregisterddetails : Form
    {
        public displayregisterddetails()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adp;
        private void displayregisterddetails_Load(object sender, EventArgs e)
        {
           // con = new SqlConnection("Data source=");
        }

        private void txt_update_Click(object sender, EventArgs e)
        {
            Close();
            regupdate r = new regupdate();
            r.Show();

        }

        private void txt_delect_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Delect from user_detials_ where ID ='" + txt_idorfname + "'", con);
                int i = cmd.ExecuteNonQuery();
                if (i == 1)
                    MessageBox.Show("Data Updated Successfully", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Error , Fail To Delect", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
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

        private void txt_add_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                // SqlCommand cmd = new SqlCommand("Insert into user_detials_  ID ='" + txt_idorfname + "',First_name ='" + txt_firstname + "',Last_name ='" + txt_lastname + "',DOB='" + date_picker_reg.Value + "'," +
                //  "Address_='" + txt_address + "',country='" + txt_country + "',city='" + txt_city + "',status_='" + txt_status + "',zip_code='" + txt_zipcode + "',personal_num='" + txt_personalnumber + "'" +
                //   ",home_num='" + txt_homenumber + "'", con);

                int i = cmd.ExecuteNonQuery();
                if (i == 1)
                    MessageBox.Show("Data Added Successfully", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Error , fail to add data", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                con.Close();
                cmd.Dispose();

            }
            catch (SqlException)
            {
                MessageBox.Show("Database Error", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

            catch (Exception )
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                if(rdiobtn_id.Checked==true)
                {
                    con.Open();
                    adp = new SqlDataAdapter("select*from user_detials_Where  ID ='" + txt_idorfname + "' ", con);
                    DataTable d = new DataTable();
                    adp.Fill(d);
                    guna2DataGridView1.DataSource = d;
                    con.Close();

                    
                }
                else if(rdiobtn_fname.Checked==true)
                {
                    con.Open();
                    adp = new SqlDataAdapter("select*from user_detials where First_name LIKE'" + txt_idorfname.Text + "%'", con);
                    DataTable d = new DataTable();
                    adp.Fill(d);
                    guna2DataGridView1.DataSource = d;
                    con.Close();
                }
          
            
            }
            catch (SqlException)
            {
                MessageBox.Show("Database Error", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

            catch (Exception)
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }


        }

        private void btn_displayall_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                adp = new SqlDataAdapter("Select * from user_detials", con);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                guna2DataGridView1.DataSource = dt;
                con.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show("Database Error", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

            catch (Exception)
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
    } 
    
}
