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
    public partial class classic_book : Form
    {
        public classic_book()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Hide();
            this.Close();
            mainpage M = new mainpage();
            M.ShowDialog();
        }

        private void btn_Essayselia_Click(object sender, EventArgs e)
        {
            Hide();
            The_Essays_of_Elia Essys = new The_Essays_of_Elia();
            Essys.ShowDialog();
        }

        private void btn_Themoon_Click(object sender, EventArgs e)
        {
            Hide();
            Glimpses_of_the_Moon Moon = new Glimpses_of_the_Moon();
            Moon.ShowDialog();
        }

        private void btn_Unclecabin_Click(object sender, EventArgs e)
        {
            Hide();
            Uncle_Toms_Cabin C=new Uncle_Toms_Cabin();
            C.ShowDialog();
        }
    }
}
