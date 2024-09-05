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
    public partial class Thrillers_book : Form
    {
        public Thrillers_book()
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

        private void btn_Shadow_Click(object sender, EventArgs e)
        {
            Hide();
            Tom_Clancy_Shadow Tom = new Tom_Clancy_Shadow();
            Tom.ShowDialog();
        }

        private void btn_Petsematary_Click(object sender, EventArgs e)
        {
            Hide();
            Pet_Sematary Pet = new Pet_Sematary();
            Pet.ShowDialog();
        }
    }
}
