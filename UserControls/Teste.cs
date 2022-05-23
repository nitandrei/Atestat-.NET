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
            label2.Visible = show;
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
        private void buttonNext_Click(object sender, EventArgs e)
        {
            question++;
            if (question == 1)
            {
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
