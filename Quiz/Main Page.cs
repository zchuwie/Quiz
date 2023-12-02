using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class Main : Form
    {
        public static bool easyB = false;
        public static bool aveB = false;
        public static bool hardB = false;

        public Main()
        {
            InitializeComponent();
            Done();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Denz Christian G. Sabalboro\nBSCS 1A\nFundamentals of Programming", "Programmer Info");
            Application.Exit();
        }

        private void easyBtn_Click(object sender, EventArgs e)
        {
            if (!easyB)
            {
                easyB = true;
                var easy = new EasyForm();
                easy.Show();
                this.Visible = false;
            }
            
            else if (easyB)
            {
                MessageBox.Show("You already took this category.");
            }
        }

        private void aveBtn_Click(object sender, EventArgs e)
        {
            if (!aveB)
            {
                aveB = true;
                var ave = new AveForm();
                ave.Show();
                this.Visible = false;
            }

            else if (aveB)
            {
                MessageBox.Show("You already took this category.");
            }
        }

        private void hardBtn_Click(object sender, EventArgs e)
        {
            if (!hardB)
            {
                hardB = true;
                var hard = new HardForm();
                hard.Show();
                this.Visible = false;
            }

            else if (easyB)
            {
                MessageBox.Show("You already took this category.");
            }
        }

        private void Done()
        {
            if (easyB == true && aveB == true && hardB == true)
            {
                easyB = false;
                aveB = false;
                hardB = false;
                int eValue = EasyForm.easyscore;
                int aValue = AveForm.avescore;
                int hValue = HardForm.hardscore;
                MessageBox.Show($"Your score for all the categories:\nEasy: {eValue}/3\nMedium: {aValue}/15\nHard: {hValue}/15");
            }
        }
    }
}
