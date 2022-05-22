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
            Components.panelLeft = this.panel1;
            Components.panelRight = this.panel2;
            Components.panelLeftInitialWidth = this.panel1.Width;
            //fac un UserControl cu instructiuni, care apoi isi ia delete oricum
        }
        private void button_Meniu_Click(object sender, EventArgs e)
        {
            timer_Meniu.Start();
        }
        private void timer_Meniu_Tick(object sender, EventArgs e)
        {
            if(!strans)
            {
                Components.panelLeft.Width -= 5;
                if(Components.panelLeft.Width <= Components.panelLeftCollapsedWidth)
                {
                    timer_Meniu.Stop();
                    strans = true;
                    this.Refresh();
                }
            }
            else
            {
                Components.panelLeft.Width += 5;
                if (Components.panelLeft.Width >= Components.panelLeftInitialWidth)
                {
                    timer_Meniu.Stop();
                    strans = false;
                    this.Refresh();
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Components.Show(ref Components.metodeDeProgramare, true);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Components.Show(ref Components.teorie, true);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Components.Show(ref Components.teste, true);
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
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

