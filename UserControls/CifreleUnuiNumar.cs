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
    public partial class CifreleUnuiNumar : UserControl
    {
        public CifreleUnuiNumar()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Components.Show(ref Components.algoritmiDeBaza, false);
            Components.Hide(ref Components.cifreleUnuiNumar);
        }
    }
}
