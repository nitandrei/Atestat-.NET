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
    public partial class AlgoritmiDeBaza : UserControl
    {
        public AlgoritmiDeBaza()
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
        private void buttonSSD_Click(object sender, EventArgs e)
        {
            Components.Show(ref Components.sumaDiferenta, false);
            Components.Hide(ref Components.algoritmiDeBaza);
        }

        private void buttonDiviz_Click(object sender, EventArgs e)
        {
            Components.Show(ref Components.divizibilitate, false);
            Components.Hide(ref Components.algoritmiDeBaza);
        }

        private void buttonCUN_Click(object sender, EventArgs e)
        {
            Components.Show(ref Components.cifreleUnuiNumar, false);
            Components.Hide(ref Components.algoritmiDeBaza);
        }

        private void buttonSLF_Click(object sender, EventArgs e)
        {
            Components.Show(ref Components.fibonacci, false);
            Components.Hide(ref Components.algoritmiDeBaza);
        }

        private void buttonSSD_MouseEnter(object sender, EventArgs e)
        {
            (sender as Button).BackgroundImage = global::Atestat.NET.Properties.Resources.Buton_SumaSiDiferenta_Hover;
        }

        private void buttonSSD_MouseLeave(object sender, EventArgs e)
        {
            (sender as Button).BackgroundImage = global::Atestat.NET.Properties.Resources.Buton_SumaSiDiferenta;
        }

        private void buttonDiviz_MouseEnter(object sender, EventArgs e)
        {
            (sender as Button).BackgroundImage = global::Atestat.NET.Properties.Resources.Buton_Divizibilitate_Hover;
        }

        private void buttonDiviz_MouseLeave(object sender, EventArgs e)
        {
            (sender as Button).BackgroundImage = global::Atestat.NET.Properties.Resources.Buton_Divizibilitate;
        }

        private void buttonCUN_MouseEnter(object sender, EventArgs e)
        {
            (sender as Button).BackgroundImage = global::Atestat.NET.Properties.Resources.Buton_CifreleUnuiNumar_Hover;
        }

        private void buttonCUN_MouseLeave(object sender, EventArgs e)
        {
            (sender as Button).BackgroundImage = global::Atestat.NET.Properties.Resources.Buton_CifreleUnuiNumar;
        }

        private void buttonSLF_MouseEnter(object sender, EventArgs e)
        {
            (sender as Button).BackgroundImage = global::Atestat.NET.Properties.Resources.Buton_SirulLuiFibonacci_Hover;
        }

        private void buttonSLF_MouseLeave(object sender, EventArgs e)
        {
            (sender as Button).BackgroundImage = global::Atestat.NET.Properties.Resources.Buton_SirulLuiFibonacci;
        }
    }
}
