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
        public MainForm()
        {
            InitializeComponent();
            Components.panelLeft = this.panel1;
            Components.panelRight = this.panel2;
            //fac un UserControl cu instructiuni, care apoi isi ia delete oricum
        }
        private void button1_Click(object sender, EventArgs e)
        {
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

