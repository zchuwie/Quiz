using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class EasyForm : Form
    {
        string correctAnswer;
        int questionN = 1;
        int totalQ = 3;
        public static int easyscore = 0;

        public EasyForm()
        {
            InitializeComponent();
            givenQuestion(questionN);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string btnTag = textBox2.Text;
            
            if (textBox2.Text.Length > 0 && totalQ > 0)
            {
                if (btnTag == correctAnswer)
                {
                    MessageBox.Show("You earned 1 point! Good Job");
                    questionN++;
                    totalQ--;
                    easyscore++;
                    textBox2.Text = null;
                }                           

                else
                {
                    MessageBox.Show($"Nuh uh, You are wrong..\nThe correct answer is {correctAnswer}");
                    totalQ--;
                    questionN++;
                    textBox2.Text = null;
                }
            }

            else
            {
                MessageBox.Show("Oops.. You need to enter something");
            }

            if (totalQ == 0)
            {
                var main = new Main();
                main.Show();
                this.Close();
            }

            givenQuestion(questionN);
        }

        private void givenQuestion (int n)
        {
            switch (questionN)
            {
                case 1:
                    labelN.Text = $"Question No. {n}";
                    labelQ.Text = "What is 7 * 6?";
                    correctAnswer = "42";

                    break;

                case 2:
                    labelN.Text = $"Question No. {n}";
                    labelQ.Text = "What is 8 / 2?";
                    correctAnswer = "4";
                    break;

                case 3:
                    labelN.Text = $"Question No. {n}";
                    labelQ.Text = "What is 143 + 23?";
                    correctAnswer = "166";
                    break;
            }
        }
    }
}
