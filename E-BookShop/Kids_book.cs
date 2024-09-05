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
    public partial class Kids_book : Form
    {
        public Kids_book()
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

        private void btn_littlestar_Click(object sender, EventArgs e)
        {
            Hide();
            Little_star Little = new Little_star();
            Little.ShowDialog();
        }

        private void btn_storysnail_Click(object sender, EventArgs e)
        {
            Hide();
            story_snail story = new story_snail();
            story.ShowDialog();

        }

        private void btn_witches_Click(object sender, EventArgs e)
        {
            Hide();
            Witches W = new Witches();
            W.ShowDialog();
        }
    }
}
