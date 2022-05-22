using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atestat.NET.UserControls
{
    public partial class Grafuri1 : UserControl
    {
        public Grafuri1()
        {
            InitializeComponent();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            Components.Show(ref Components.grafuri2, false);
            Components.Hide(ref Components.grafuri1);
        }
    }
}
