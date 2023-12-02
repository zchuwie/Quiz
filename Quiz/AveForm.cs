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
    public partial class AveForm : Form
    {
        int totalQ = 5;
        int questionN = 1;
        string correctAnswer;
        public static int avescore = 0;
        public AveForm()
        {
            InitializeComponent();
            givenQuestion(questionN);
        }

        private void givenQuestion(int n)
        {
            switch (questionN)
            {
                case 1:
                    labelN.Text = $"Question No. {n}";
                    labelQ.Text = "Which number is the equivalent to 3 raised to 4 divided by 3 raised to 2?";
                    correctAnswer = "9";
                    break;

                case 2:
                    labelN.Text = $"Question No. {n}";
                    labelQ.Text = "What do you called the value of 3.14?";
                    correctAnswer = "pi";
                    break;

                case 3:
                    labelN.Text = $"Question No. {n}";
                    labelQ.Text = "The number of 3-digit numbers divisible by 6, is...";
                    correctAnswer = "150";
                    break;

                case 4:
                    labelN.Text = $"Question No. {n}";
                    labelQ.Text = "1004 divided by 2 is...";
                    correctAnswer = "502";
                    break;

                case 5:
                    labelN.Text = $"Question No. {n}";
                    labelQ.Text = "What is the simpliest form of 1.5:2.5?";
                    correctAnswer = "3:5";
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string btnTag = textBox2.Text;

            if (textBox2.Text.Length > 0 && totalQ > 0)
            {
                if (btnTag == correctAnswer)
                {
                    MessageBox.Show("You earned 3 point! Good Job");
                    questionN++;
                    totalQ--;
                    avescore += 3;
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
    }
}
