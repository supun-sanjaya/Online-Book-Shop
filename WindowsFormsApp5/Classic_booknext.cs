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
    public partial class Classic_booknext : Form
    {
        public Classic_booknext()
        {
            InitializeComponent();
        }

        private void btn_main_Click(object sender, EventArgs e)
        {
            mainpage main =new mainpage();
            main.Show();
            this.Hide();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_exit_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Hide();
            this.Close();
            mainpage M = new mainpage();
            M.ShowDialog();
        }

        private void btn_peter_Click(object sender, EventArgs e)
        {
            Hide();
            The_Tale_of_Peter_Rabbit Rabbit = new The_Tale_of_Peter_Rabbit();
            Rabbit.ShowDialog();
        }

        private void btn_anneshouse_Click(object sender, EventArgs e)
        {
            Hide();
            Anna_s_Dream_House House = new Anna_s_Dream_House();
            House.ShowDialog();
        }
    }
}
