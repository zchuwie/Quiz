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
    public partial class HardForm : Form
    {
        string correctAnswer;
        int questionN = 1;
        int totalQ = 3;
        public static int hardscore = 0;

        public HardForm()
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
                    MessageBox.Show("You earned 5 point! Good Job");
                    questionN++;
                    totalQ--;
                    textBox2.Text = null;
                    hardscore += 5; 
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

        private void givenQuestion(int n)
        {
            switch (questionN)
            {
                case 1:
                    labelN.Text = $"Question No. {n}";
                    labelQ.Text = "125 gallons of a mixture contains 20% water. What amount of additional water should be added such that water content be raised to 25%?";
                    correctAnswer = "8 1/3";
                    break;

                case 2:
                    labelN.Text = $"Question No. {n}";
                    labelQ.Text = " 106 × 106 – 94 × 94 = ?";
                    correctAnswer = "2400";
                    break;

                case 3:
                    labelN.Text = $"Question No. {n}";
                    labelQ.Text = "The wages of 10 workers for a six-day week is $ 1200. What are the one day’s wages of 4 workers?";
                    correctAnswer = "80";
                    break;
            }
        }
    }
}
