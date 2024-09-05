using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Romance_Book : Form
    {
        public Romance_Book()
        {
            InitializeComponent();
        }

        private void btn_main_Click(object sender, EventArgs e)
        {
            mainpage main = new mainpage();
            main.Show();
            this.Hide();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Hide();
            this.Close();
            mainpage M = new mainpage();
            M.ShowDialog();
        }

        private void btn_onlyone_Click(object sender, EventArgs e)
        {
            Hide();    
            The_only_one Only = new The_only_one();
            Only.ShowDialog();
        }

        private void btn_marriagepossession_Click(object sender, EventArgs e)
        {
            Hide();
            The_Marriage_Possession Marry = new The_Marriage_Possession();
            Marry.ShowDialog();
        }

        private void btn_outofcontrol_Click(object sender, EventArgs e)
        {
            Hide();
            Out_of_Control Out = new Out_of_Control();
            Out.ShowDialog();
        }
    }
}
