using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }
    }
}
