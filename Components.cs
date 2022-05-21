using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Atestat.NET.Properties;
using Atestat.NET.UserControls;

namespace Atestat.NET
{
    public static class Components
    {
        public static MainForm mainForm;
        public static Panel panelLeft;
        public static Panel panelRight;
        public static MetodeDeProgramare metodeDeProgramare;
        public static PrivateFontCollection pfc;
        public static void Show<T>(ref T userControl) where T : UserControl
        {
            if (userControl == null || userControl.IsDisposed)
            {
                userControl = (T)Activator.CreateInstance(typeof(T));
            }
            panelRight.SuspendLayout();
            panelRight.Controls.Add(userControl);
            userControl.BringToFront();
            userControl.Show();
            panelRight.ResumeLayout(true);
        }
        public static void Hide<T>(ref T userControl) where T : UserControl
        {
            if (userControl == null || userControl.IsDisposed)
                return;
            userControl.Hide();
            panelRight.Controls.Remove(userControl);
            userControl.Dispose();
            userControl.BackgroundImage.Dispose();
            foreach (Control c in userControl.Controls)
            {
                c.BackgroundImage.Dispose();
            }
        }

       /* public static void initializeFont()//Components.pfc.Families[0]
        {
            pfc = new PrivateFontCollection();
            int fontLength = Resources.FONT.Length;
            byte[] fontdata = Resources.FONT;
            IntPtr data = Marshal.AllocCoTaskMem(fontLength);
            Marshal.Copy(fontdata, 0, data, fontLength);
            pfc.AddMemoryFont(data, fontLength);
        }*/
        static Components()
        {

        }
    }
}
