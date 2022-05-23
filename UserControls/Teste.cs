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
        private int question = 0, puncte = 0;
        private string[,] randomizedQuestions;
        private int timp;
        private int[] lockedAnswers;
        private int[] answers;
        bool showAnswers = false;
        public Teste()
        {
            InitializeComponent();
            Components.randomizeQuestions();
            Components.splitArrayQuestions(ref randomizedQuestions);
            timp = Components.numberOfQuestions * 90;
            labelTimp.Text = "Timp: " + (timp / 60).ToString("D2") + ":" + (timp % 60).ToString("D2");
            lockedAnswers = new int[Components.numberOfQuestions + 1];
            answers = new int[Components.numberOfQuestions + 1];
    }
        private void resetButtons()
        {
            buttonA.BackColor = Color.White;
            buttonB.BackColor = Color.White;
            buttonC.BackColor = Color.White;
            buttonD.BackColor = Color.White;
        }
        private void resetButtonsBorder()
        {
            buttonA.FlatAppearance.BorderSize = 1;
            buttonA.FlatAppearance.BorderColor = Color.Black;
            buttonB.FlatAppearance.BorderSize = 1;
            buttonB.FlatAppearance.BorderColor = Color.Black;
            buttonC.FlatAppearance.BorderSize = 1;
            buttonC.FlatAppearance.BorderColor = Color.Black;
            buttonD.FlatAppearance.BorderSize = 1;
            buttonD.FlatAppearance.BorderColor = Color.Black;
        }
        private void loadLayout()
        {
            if(showAnswers)
            {
                colorButton(buttonA, answers[question], Color.Green, Color.Red);
                colorButton(buttonB, answers[question], Color.Green, Color.Red);
                colorButton(buttonC, answers[question], Color.Green, Color.Red);
                colorButton(buttonD, answers[question], Color.Green, Color.Red);
                if (lockedAnswers[question] == 0)
                {
                    resetButtonsBorder();
                    return;
                }
                colorButtonBorder(buttonA, lockedAnswers[question], Color.Orange, Color.Black);
                colorButtonBorder(buttonB, lockedAnswers[question], Color.Orange, Color.Black);
                colorButtonBorder(buttonC, lockedAnswers[question], Color.Orange, Color.Black);
                colorButtonBorder(buttonD, lockedAnswers[question], Color.Orange, Color.Black);
                return;
            }
            if (lockedAnswers[question] == 0)
            {
                resetButtons();
                return;
            }
            colorButton(buttonA, lockedAnswers[question], Color.Orange, Color.White);
            colorButton(buttonB, lockedAnswers[question], Color.Orange, Color.White);
            colorButton(buttonC, lockedAnswers[question], Color.Orange, Color.White);
            colorButton(buttonD, lockedAnswers[question], Color.Orange, Color.White);
        }
        private void showQuestion()
        {
            Image old = pictureBox.Image;
            pictureBox.Image = Image.FromFile(Path.Combine(Components.pathToTestsFolder,randomizedQuestions[question - 1, 0]));
            //pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            if( old != null )
                old.Dispose();
        }
        private void colorButtonBorder(Button button, int value, Color correct, Color def)
        {
            if (button.TabIndex == value)
            {
                button.FlatAppearance.BorderSize = 5;
                button.FlatAppearance.BorderColor = correct;
            }
            else
            {
                button.FlatAppearance.BorderSize = 1;
                button.FlatAppearance.BorderColor = def;
            }
        }
        private void colorButton(Button button, int value, Color correct, Color def)
        {
            if (button.TabIndex == value)
                button.BackColor = correct;
            else button.BackColor = def;
        }
        private void ShowChoiceControls(bool show)
        {
            pictureBox.Visible = show;
            buttonA.Visible = show;
            buttonB.Visible = show;
            buttonC.Visible = show;
            buttonD.Visible = show;
        }
        private void enableAllButtons(bool enable)
        {
            buttonA.Enabled = enable;
            buttonB.Enabled = enable;
            buttonC.Enabled = enable;
            buttonD.Enabled = enable;
        }
        /*private void checkAnswer(int tabIndex)
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
        }*/
        private void checkAnswers()
        {
            for(int i = 1; i <= Components.numberOfQuestions; i++)
            {
                answers[i] = int.Parse(randomizedQuestions[i - 1, 1]);
                if (answers[i] == lockedAnswers[i])
                    puncte++;
            }
        }
        private void lockAnswer(int tabIndex)
        {
            lockedAnswers[question] = tabIndex;
            colorButton(buttonA, tabIndex, Color.Orange, Color.White);
            colorButton(buttonB, tabIndex, Color.Orange, Color.White);
            colorButton(buttonC, tabIndex, Color.Orange, Color.White);
            colorButton(buttonD, tabIndex, Color.Orange, Color.White);
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

        private void buttonBack_Click(object sender, EventArgs e)
        {
            question--;
            if (question <= 1)
            {
                buttonBack.Visible = false;
                question = 1;
            }
            if (question == Components.numberOfQuestions - 1)
            {
                buttonNext.Visible = true;
            }
            if (question == Components.numberOfQuestions + 1)
            {
                question = 1;
                Image old = Components.teste.BackgroundImage;
                Components.panelRight.SuspendLayout();
                ShowChoiceControls(true);
                enableAllButtons(false);
                buttonNext.Visible = true;
                buttonBack.Visible = false;
                labelPunctaj.Visible = true;
                labelTimp.Visible = true;
                labelPunctajFinal.Visible = false;
                labelTimpFinal.Visible = false;
                buttonSubmit.Visible = false;
                Components.teste.BackgroundImage = null;
                if (old != null)
                    old.Dispose();
                Components.panelRight.ResumeLayout(true);
            }
            loadLayout();
            showQuestion();
        }
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            checkAnswers();
            Components.panelRight.SuspendLayout();
            timerTimp.Stop();
            ShowChoiceControls(false);
            showAnswers = true;
            question = Components.numberOfQuestions + 2;
            buttonBack.Visible = true;
            labelTimp.Visible = false;
            buttonSubmit.Visible = false;
            buttonNext.Visible = false;
            Components.teste.BackgroundImage = global::Atestat.NET.Properties.Resources.Teste_Background2;
            labelPunctaj.Text = "Punctaj: " + puncte.ToString("D2") + "\\" + Components.numberOfQuestions;
            labelPunctajFinal.Text = puncte.ToString("D2") + "\\" + Components.numberOfQuestions;
            labelTimp.Text = labelTimpFinal.Text = ((Components.numberOfQuestions * 90 - timp) / 60).ToString("D2") + ":" + ((Components.numberOfQuestions * 90 - timp) % 60).ToString("D2");
            labelPunctajFinal.Visible = true;
            labelTimpFinal.Visible = true;
            Components.panelRight.ResumeLayout(true);
        }
        private void buttonNext_Click(object sender, EventArgs e)
        {
            question++;
            if (question == 1)
            {
                timerTimp.Start();
                Image old = Components.teste.BackgroundImage;
                Components.panelRight.SuspendLayout();
                ShowChoiceControls(true);
                labelTimp.Visible = true;
                buttonSubmit.Visible = true;
                Components.teste.BackgroundImage = null;
                if (old != null)
                    old.Dispose();
                Components.panelRight.ResumeLayout(true);
            }
            if (question == 2)
            {
                buttonBack.Visible = true;
            }
            /*if (question > Components.numberOfQuestions)
            {
                Components.panelRight.SuspendLayout();
                timerTimp.Stop();
                ShowAllControls(false);
                buttonNext.Visible = false;
                Components.teste.BackgroundImage = global::Atestat.NET.Properties.Resources.Teste_Background2;
                labelPunctajFinal.Text = puncte.ToString("D2") + "\\" + Components.numberOfQuestions;
                labelTimpFinal.Text = ((Components.numberOfQuestions * 90 - timp) / 60).ToString("D2") + ":" + ((Components.numberOfQuestions * 90 - timp) % 60).ToString("D2");
                labelPunctajFinal.Visible = true;
                labelTimpFinal.Visible = true;
                Components.panelRight.ResumeLayout(true);
                return;
            }*/
            if(question >= Components.numberOfQuestions)
            {
                buttonNext.Visible = false;
                question = Components.numberOfQuestions;
            }
            loadLayout();
            showQuestion();
        }

        private void button_Click(object sender, EventArgs e)
        {
            //checkAnswer((sender as Control).TabIndex);
            lockAnswer((sender as Control).TabIndex);
        }
    }
}
