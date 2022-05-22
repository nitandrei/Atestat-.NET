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
        private void buttonCitirea_Click(object sender, EventArgs e)
        {
            Components.Show(ref Components.citirea, false);
            Components.Hide(ref Components.teorie);
        }

        private void buttonTU_Click(object sender, EventArgs e)
        {
            Components.Show(ref Components.tablouriUnidimensionale, false);
            Components.Hide(ref Components.teorie);
        }

        private void buttonTB_Click(object sender, EventArgs e)
        {
            Components.Show(ref Components.tablouriBidimensionale, false);
            Components.Hide(ref Components.teorie);
        }

        private void buttonSDC_Click(object sender, EventArgs e)
        {
            Components.Show(ref Components.sirDeCaractere1, false);
            Components.Hide(ref Components.teorie);
        }

        private void buttonSubprograme_Click(object sender, EventArgs e)
        {
            Components.Show(ref Components.subprogram, false);
            Components.Hide(ref Components.teorie);
        }

        private void buttonRecursivitate_Click(object sender, EventArgs e)
        {
            Components.Show(ref Components.recursivitate, false);
            Components.Hide(ref Components.teorie);
        }

        private void buttonListe_Click(object sender, EventArgs e)
        {
            Components.Show(ref Components.liste1, false);
            Components.Hide(ref Components.teorie);
        }

        private void buttonGrafuri_Click(object sender, EventArgs e)
        {
            Components.Show(ref Components.grafuri1, false);
            Components.Hide(ref Components.teorie);
        }
    }
}
