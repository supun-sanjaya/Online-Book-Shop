using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        string randomcode;
        public static string to;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            string from, pass, messagebody;
            Random rand = new Random();
            randomcode = (rand.Next(10000)).ToString(); //random codes upto 1000;
            MailMessage message = new MailMessage();
            to = (txt_email.Text).ToString();
            from = "stefnjk@gmail.com";// The email that the code is sending stefan.jehan37@gmail.com
            pass = " Jehan0762374112 "; //code sending email orginal password
            messagebody = $"Your reset code is {randomcode}";
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = messagebody;
            message.Subject = "Password Reset Code";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;//chnge
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;

            smtp.Credentials = new NetworkCredential(from, pass);


            try
            {
                smtp.Send(message);
                MessageBox.Show("Code Sent Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_verify_Click(object sender, EventArgs e)
        {
            if(randomcode==(txt_code.Text).ToString())
            {
                to = txt_code.Text;
                resetpassword r = new resetpassword();
                r.Show();

            }
            else
            {
                MessageBox.Show("Wrong Code ,Please Try Again");
            }
        }
    }
}
