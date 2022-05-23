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
    public partial class Backtracking : UserControl
    {
        public Backtracking()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Components.Show(ref Components.metodeDeProgramare, false);
            Components.Hide(ref Components.backtracking);
        }
    }
}
