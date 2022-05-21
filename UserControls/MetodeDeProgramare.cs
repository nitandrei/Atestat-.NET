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

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackgroundImage = global::Atestat.NET.Properties.Resources.Buton_MDP_Mov;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackgroundImage = global::Atestat.NET.Properties.Resources.Buton_MDP_Albastru;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackgroundImage = global::Atestat.NET.Properties.Resources.Buton_MDP_Mov;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackgroundImage = global::Atestat.NET.Properties.Resources.Buton_MDP_Albastru;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.BackgroundImage = global::Atestat.NET.Properties.Resources.Buton_MDP_Mov;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackgroundImage = global::Atestat.NET.Properties.Resources.Buton_MDP_Albastru;
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.BackgroundImage = global::Atestat.NET.Properties.Resources.Buton_MDP_Mov;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackgroundImage = global::Atestat.NET.Properties.Resources.Buton_MDP_Albastru;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
