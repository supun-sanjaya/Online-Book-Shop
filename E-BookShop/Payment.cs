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
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }
        SqlCommand cmd;
        SqlConnection con;
        private void btn_back_Click(object sender, EventArgs e)
        {
            Hide();
            this.Close();
            mainpage M = new mainpage();
            M.ShowDialog();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            int id; string card_holders_name; int card_no;
            DateTime date; int cvv;


            id = Convert.ToInt32(txt_uname.Text);
            card_holders_name = txt_hname.Text;
            card_no = Convert.ToInt32(txt_cardno.Text);
            date = date_picker_payemntmethod.Value;
            cvv = Convert.ToInt32(txt_cvv.Text);

        
           
        
            try
            {

                
                if (txt_cvv.Text.Length != 3)

                    MessageBox.Show("Please Check the CVV agian ", "Error", MessageBoxButtons.OK);

                else if (txt_cardno.Text.Length !=16)
                
                    MessageBox.Show("Please Check the that the Card Number is correct  ", "Error", MessageBoxButtons.OK);  
                
            } 
            catch (FormatException)
            {
                MessageBox.Show("Please Check the Formate you have enterd  ", "Error", MessageBoxButtons.OK);
            }
            catch(NullReferenceException)
            {
                MessageBox.Show("Please enter all the required details  ", "Error", MessageBoxButtons.OK);
            }
            catch(Exception)
            {

            }

            {
                con.Open();
                cmd = new SqlCommand("insert into payment_detials values('" + txt_uname + "','" + txt_hname + "','"+this.date_picker_payemntmethod.Text+"','" + txt_cardno + "','" + txt_cvv + "')", con);

                int i = cmd.ExecuteNonQuery();
                if (i == 1)

                    MessageBox.Show("Information Successfully Saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Unsuccessfully Registerd", "Information", MessageBoxButtons.OK);
                con.Close();
                cmd.Dispose();


            }
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=DESKTOP-D19T640;Initial Catalog=OnlineLibrary;Integrated Security=True");
        }
    }
}
