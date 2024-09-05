using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WindowsFormsApp5
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        
       

        private void guna2HtmlLabel6_Click(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Hide();
            this.Close();
            mainpage M = new mainpage();
            M.ShowDialog();
        }
        private void date_picker_reg_ValueChanged(object sender, EventArgs e)
        {
            
        }
        private void register_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=DESKTOP-D19T640;Initial Catalog=OnlineLibrary;Integrated Security=True");
        }
        private void btn_reg_Click(object sender, EventArgs e)
        {
            
            try
            {
                con.Open();
                cmd = new SqlCommand("insert into User_Register values('" + txt_id.Text + "','" + txt_firstname.Text + "','" + txt_lastname.Text + "','" + txt_age.Text + "','" + txt_address.Text + "','" + txt_country.Text + "','" + txt_city.Text + "', '" + txt_status.Text + "','" + txt_zipcode.Text + "','" + txt_personalnumber.Text+ "','" + txt_homenumber.Text + "')", con);
               


                int i = cmd.ExecuteNonQuery();
                if (i == 1)

                    MessageBox.Show(this," Sucsusfully registerd   ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show(this," Cannot save ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                con.Close();
                cmd.Dispose();

            }
            catch (FormatException)
            {
                MessageBox.Show(this,"Please Check the Formate you have enterd  ", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
          
            
            catch(OutOfMemoryException)
            {
                MessageBox.Show(this,"Memory Error,Please Try Again   ", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
            


        }

        

        
    }
}
