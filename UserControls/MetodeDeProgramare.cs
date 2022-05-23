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
        private void buttonDEI_Click(object sender, EventArgs e)
        {
            Components.Show(ref Components.divideEtImpera, false);
            Components.Hide(ref Components.metodeDeProgramare);
        }
        private void buttonGreedy_Click(object sender, EventArgs e)
        {
            Components.Show(ref Components.greedy, false);
            Components.Hide(ref Components.metodeDeProgramare);
        }

        private void buttonBacktracking_Click(object sender, EventArgs e)
        {
            Components.Show(ref Components.backtracking, false);
            Components.Hide(ref Components.metodeDeProgramare);
        }

        private void buttonPD_Click(object sender, EventArgs e)
        {
            Components.Show(ref Components.programareDinamica, false);
            Components.Hide(ref Components.metodeDeProgramare);
        }
    }
}
