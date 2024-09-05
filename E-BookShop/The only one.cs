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
    public partial class The_only_one : Form
    {
        public The_only_one()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {

            Hide();
            this.Close();
            Romance_Book romance = new Romance_Book();
            romance.ShowDialog();
        }
    }
}
