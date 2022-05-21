using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atestat.NET.UserControls
{
    public partial class MetodeDeProgramare : UserControl
    {
        public MetodeDeProgramare()
        {
            InitializeComponent();
        }
        private void buttonMouseEnter(object sender, EventArgs e)
        {
            (sender as Button).BackgroundImage = global::Atestat.NET.Properties.Resources.Buton_MDP_Mov;
        }
        private void buttonMouseLeave(object sender, EventArgs e)
        {
            (sender as Button).BackgroundImage = global::Atestat.NET.Properties.Resources.Buton_MDP_Albastru;
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

    }
}
