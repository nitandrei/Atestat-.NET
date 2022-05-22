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

namespace Atestat.NET
{
    public partial class LoadingScreen : Form
    {
        bool init = false;
        public LoadingScreen()
        {
            InitializeComponent();
            timer1.Start();
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

        private void LoadingScreen_Validated(object sender, EventArgs e)
        {

        }

        private void GIFcontainer_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {

        }

        private void LoadingScreen_Activated(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (LoadingBar.Value >= 60 && init == false)
            {
                Components.initComponents();
                init = true;
            }
            if (LoadingBar.Value >= 95)
            {
                this.timer1.Stop();
                LoadingBar.Refresh();
                Thread.Sleep(200);
                this.Close();
            }    
            else LoadingBar.Value += 5;
        }
    }
}
