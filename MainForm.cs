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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Components.Show(ref Components.metodeDeProgramare);
        }


        private void button3_Click(object sender, EventArgs e)
        {
            Components.Hide(ref Components.metodeDeProgramare);
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

