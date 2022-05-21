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
    public partial class Teorie : UserControl
    {
        public Teorie()
        {
            InitializeComponent();
        }
        private void buttonMouseEnter(object sender, EventArgs e)
        {
            (sender as Button).BackgroundImage = global::Atestat.NET.Properties.Resources.Buton_Carte_Mov;
        }
        private void buttonMouseLeave(object sender, EventArgs e)
        {
            (sender as Button).BackgroundImage = global::Atestat.NET.Properties.Resources.Buton_Carte_Negru;
        }
    }
}
