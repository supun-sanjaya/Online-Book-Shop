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
    public partial class Uncle_Toms_Cabin : Form
    {
        public Uncle_Toms_Cabin()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Hide();
            this.Close();
            classic_book cla= new classic_book();
            cla.ShowDialog();
        }
    }
}
