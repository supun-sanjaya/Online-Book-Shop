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
    public partial class Anna_s_Dream_House : Form
    {
        public Anna_s_Dream_House()
        {
            InitializeComponent();
        }

        private void btn_backclassic_Click(object sender, EventArgs e)
        {
            Hide();
            this.Close();
             Classic_booknext ClaN = new Classic_booknext();
              ClaN.ShowDialog();
        }
    }
}
