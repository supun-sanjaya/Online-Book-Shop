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
    public partial class OrderBook : Form
    {
        public OrderBook()
        {
            InitializeComponent();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Hide();
            this.Close();
            mainpage M = new mainpage();
            M.ShowDialog();
        }

        private void btn_order_Click(object sender, EventArgs e)
        {
            string bcode;
            string authername;
            int qty;
            double price;
            double tot;

            bcode = txt_bcode.Text;
            authername = txt_aname.Text;
            qty = Convert.ToInt32(txt_qty.Text);
            price = Convert.ToDouble(txt_price.Text);
            tot = qty * price;
            txt_total.Text = tot.ToString();


        }
    }
}
