using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Atestat.NET.Properties;

namespace Atestat.NET
{
    public static class Components
    {
        public static MainForm mainForm;
        public static Panel panelLeft;
        public static Panel panelRight;
        public static MetodeDeProgramare metodeDeProgramare;

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
            userControl.Hide();
            panelRight.Controls.Remove(userControl);
            userControl.Dispose();
            userControl.BackgroundImage.Dispose();
            foreach (Control c in userControl.Controls)
            {
                c.BackgroundImage.Dispose();
            }
        }
        public static string Name(UserControl userControl)
        {
            return userControl.GetType().FullName;
        }
        static Components()
        {

        }
    }
}
