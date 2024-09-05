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
    public partial class The_Essays_of_Elia : Form
    {
        public The_Essays_of_Elia()
        {
            InitializeComponent();
        }

        private void The_Essays_of_Elia_Load(object sender, EventArgs e)
        {

        }

        private void btn_backclassic_Click(object sender, EventArgs e)
        {
            Hide();
            this.Close();
            classic_book cla= new classic_book();
            cla.ShowDialog();
        }
    }
}
