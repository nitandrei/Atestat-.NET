using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Atestat.NET.Properties;

namespace Atestat.NET
{
    public partial class MainForm : Form
    {
        private bool strans = false;
        public MainForm()
        {
            InitializeComponent();
            init();
            Components.Show(ref Components.instructiuni, false);
        }
        private void init()
        {
            Components.panelLeft = this.panel1;
            Components.panelRight = this.panel2;
            Components.panelMini = this.panel3;
            Components.panelLeftInitialWidth = this.panel1.Width;
            /*this.buttonTeorie.Font = new Font(Components.pfc.Families[0], 14.25F);
            this.buttonExit.Font = new Font(Components.pfc.Families[0], 14.25F);
            this.buttonMDP.Font = new Font(Components.pfc.Families[0], 14.25F);
            this.buttonADB.Font = new Font(Components.pfc.Families[0], 14.25F);*/
        }
        private void button_Meniu_Click(object sender, EventArgs e)
        {
            timer_Meniu.Start();
        }
        private void timer_Meniu_Tick(object sender, EventArgs e)
        {
            if (!strans)
            {
                Components.panelLeft.Width -= 5;
                if(Components.panelLeft.Width <= Components.panelLeftCollapsedWidth)
                {
                    timer_Meniu.Stop();
                    strans = true;
                }
            }
            else
            {
                Components.panelLeft.Width += 5;
                if (Components.panelLeft.Width >= Components.panelLeftInitialWidth)
                {
                    timer_Meniu.Stop();
                    strans = false;
                }
            }
        }
        private void buttonTeorie_Click(object sender, EventArgs e)
        {
            Components.Show(ref Components.teorie, true);
            updatePanelMini(sender as Button);
        }
        private void buttonMDP_Click(object sender, EventArgs e)
        {
            Components.Show(ref Components.metodeDeProgramare, true);
            updatePanelMini(sender as Button);
        }
        private void buttonADB_Click(object sender, EventArgs e)
        {
            Components.Show(ref Components.algoritmiDeBaza, true);
            updatePanelMini(sender as Button);
        }

        private void buttonTDA_Click(object sender, EventArgs e)
        {
            Components.Show(ref Components.teste, true);
            updatePanelMini(sender as Button);
        }
        private void codeEducationLogo_Click(object sender, EventArgs e)
        {
            Components.Show(ref Components.instructiuni, true);
            Components.panelMini.Location = new Point(Components.panelMini.Location.X, 721);
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void updatePanelMini(Button button)
        {
            int oldX = Components.panelMini.Location.X;
            int newY = button.Location.Y;
            Components.panelMini.Location = new Point(oldX, newY);
        }
        //magie?
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }
    }
}

