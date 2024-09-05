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
    public partial class Tom_Clancy_Shadow : Form
    {
        public Tom_Clancy_Shadow()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Hide();
            this.Close();
            Thrillers_book thriller = new Thrillers_book();
            thriller.ShowDialog();
        }
    }
}
