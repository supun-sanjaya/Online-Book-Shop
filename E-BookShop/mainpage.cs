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
    public partial class mainpage : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private object panelTitleBar;
        private object panelLogo;
        private object btnCloseChildForm;
        public mainpage()
        {
            InitializeComponent();
            random = new Random();
        }

        private Color SelectThemeColor()
        {
            int index = random.Next(Themecolor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(Themecolor.ColorList.Count);
            }
            tempIndex = index;
            string color = Themecolor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panel2.BackColor = color;
                   
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in Panel1.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void mainpage_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            Hide();
            classic_book C= new classic_book();
            C.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            Hide();
          Kids_book K = new Kids_book();
            K.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            Hide();
            Romance_Book RB = new Romance_Book();
            RB.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            Hide();
            Thrillers_book T = new Thrillers_book();
            T.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            Hide();
            Classic_booknext CB = new Classic_booknext();
            CB.ShowDialog();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            Hide();
            sign S = new sign();
            S.ShowDialog();
        }

            private void button7_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            Hide();
            register R = new register();
            R.ShowDialog();
        }
        private int imageNumber = 1;
       

        private void LoadNextImage()
        {
            if (imageNumber == 10)
            {
                imageNumber = 1;
            }
            slidePic.ImageLocation = string.Format(@"Images\{0}.jpg", imageNumber);
            imageNumber++;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadNextImage();
        }
    }
}
