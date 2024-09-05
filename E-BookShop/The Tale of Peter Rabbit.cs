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
    public partial class The_Tale_of_Peter_Rabbit : Form
    {
        public The_Tale_of_Peter_Rabbit()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Hide();
            this.Close();
            Classic_booknext claN = new Classic_booknext();
            claN.ShowDialog();
        }
    }
}
