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
        private int timp;
        public Teste()
        {
            InitializeComponent();
            Components.randomizeQuestions();
            Components.splitArrayQuestions(ref randomizedQuestions);
            timp = Components.numberOfQuestions * 90;
            labelPunctaj.Text = "Punctaj: " + puncte.ToString("D2") + "\\" + Components.numberOfQuestions;
            labelTimp.Text = "Timp: " + (timp / 60).ToString("D2") + ":" + (timp % 60).ToString("D2");
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
            Image old = pictureBox.Image;
            pictureBox.Image = Image.FromFile(Path.Combine(Components.pathToTestsFolder,randomizedQuestions[question - 1, 0]));
            //pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            answer = int.Parse(randomizedQuestions[question - 1, 1]);
            if( old != null )
                old.Dispose();
        }
        private void colorButton(Button button)
        {
            if (button.TabIndex == answer)
                button.BackColor = Color.Green;
            else button.BackColor = Color.Red;
        }
        private void ShowAllControls(bool show)
        {
            pictureBox.Visible = show;
            buttonA.Visible = show;
            buttonB.Visible = show;
            buttonC.Visible = show;
            buttonD.Visible = show;
            labelPunctaj.Visible = show;
            labelTimp.Visible = show;
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
                labelPunctaj.Text = "Punctaj: " + puncte.ToString("D2") + "\\" + Components.numberOfQuestions;
            }
            colorButton(buttonA);
            colorButton(buttonB);
            colorButton(buttonC);
            colorButton(buttonD);
        }
        private void timerTimp_Tick(object sender, EventArgs e)
        {
            if(timp <= 0)
            {
                timerTimp.Stop();
            }
            else
            {
                timp--;
                labelTimp.Text = "Timp: " + (timp/60).ToString("D2") + ":" + (timp%60).ToString("D2");
            }
        }
        private void buttonNext_Click(object sender, EventArgs e)
        {
            question++;
            if (question == 1)
            {
                timerTimp.Start();
                Image old = Components.teste.BackgroundImage;
                Components.panelRight.SuspendLayout();
                ShowAllControls(true);
                Components.teste.BackgroundImage = null;
                if (old != null)
                    old.Dispose();
                Components.panelRight.ResumeLayout(true);
            }
            if(question > Components.numberOfQuestions)
            {
                Components.panelRight.SuspendLayout();
                timerTimp.Stop();
                ShowAllControls(false);
                buttonNext.Visible = false;
                Components.teste.BackgroundImage = global::Atestat.NET.Properties.Resources.Teste_Background2;
                labelPunctajFinal.Text = puncte.ToString("D2") + "\\" + Components.numberOfQuestions;
                labelTimpFinal.Text = ( (Components.numberOfQuestions * 90 - timp) / 60).ToString("D2") + ":" + ( (Components.numberOfQuestions * 90 - timp) % 60).ToString("D2");
                labelPunctajFinal.Visible = true;
                labelTimpFinal.Visible = true;
                Components.panelRight.ResumeLayout(true);
                return;
            }
            resetLayout();
            showQuestion();
        }
        private void button_Click(object sender, EventArgs e)
        {
            checkAnswer((sender as Control).TabIndex);
        }
    }
}
