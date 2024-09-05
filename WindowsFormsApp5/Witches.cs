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
    public partial class Witches : Form
    {
        public Witches()
        {
            InitializeComponent();
        }

        private void btn_backclassic_Click(object sender, EventArgs e)
        {
            Hide();
            this.Close();
            Kids_book kid=new Kids_book();
            kid.ShowDialog();
        }

        private void Witches_Load(object sender, EventArgs e)
        {

        }
    }
}
