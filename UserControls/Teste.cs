using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atestat.NET
{
    public partial class Teste : UserControl
    {
        private int question = 0, answer, puncte = 0;
        private string[,] randomizedQuestions;
        public Teste()
        {
            InitializeComponent();
            Components.randomizeQuestions();
            Components.splitArrayQuestions(ref randomizedQuestions);
        }
        private void resetLayout()
        {
            enableAllButtons(true);
            buttonA.BackColor = Color.White;
            buttonB.BackColor = Color.White;
            buttonC.BackColor = Color.White;
            buttonD.BackColor = Color.White;
        }
        private void showQuestion()
        {
            pictureBox1.Image = Image.FromFile(Path.Combine(Components.pathToTestsFolder,randomizedQuestions[question, 0]));
            answer = int.Parse(randomizedQuestions[question, 1]);
        }
        private void colorButton(Button button)
        {
            if (button.TabIndex == answer)
                button.BackColor = Color.Green;
            else button.BackColor = Color.Red;
        }
        private void enableAllButtons(bool enable)
        {
            buttonA.Enabled = enable;
            buttonB.Enabled = enable;
            buttonC.Enabled = enable;
            buttonD.Enabled = enable;
        }
        private void checkAnswer(int tabIndex)
        {
            enableAllButtons(false);
            if(tabIndex == answer)
            {
                puncte++;
                labelPunctaj.Text = "Punctaj: " + puncte.ToString() + "\\" + Components.numberOfQuestions;
            }
            colorButton(buttonA);
            colorButton(buttonB);
            colorButton(buttonC);
            colorButton(buttonD);
        }
        private void button_Click(object sender, EventArgs e)
        {
            checkAnswer((sender as Control).TabIndex);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            resetLayout();
            showQuestion();
            question++;
        }
    }
}
