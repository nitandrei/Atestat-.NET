﻿using System;
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
        /// <summary>
        /// Visuals
        /// </summary>
        public static MainForm mainForm;
        public static Panel panelLeft;
        public static Panel panelRight;
        public static MetodeDeProgramare metodeDeProgramare;
        public static Teorie teorie;
        public static DivideEtImpera divideEtImpera;
        public static Teste teste;
        /// <summary>
        /// Teste, formatul este "Nume_poze.extensie,numarul_variantei_corecte" EX: Poza.png,1
        /// </summary>
        public const int numberOfQuestions = 10;
        private const string localFolder = "Teste";
        private const string txtFile = "Intrebari.txt";
        public static string[] questions;
        private static string pathToFolder;
        /// <summary>
        /// Custom Fonts
        /// </summary>
        public static PrivateFontCollection pfc;

        public static void Show<T>(ref T userControl, bool cleanPanel) where T : UserControl
        {
            panelRight.SuspendLayout();
            if (cleanPanel == true)
                CleanPanel();
            if (userControl == null || userControl.IsDisposed)
            {
                userControl = (T)Activator.CreateInstance(typeof(T));
            }
            if (cleanPanel == true)
                CleanPanel();
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
        public static void CleanPanel()
        {
            int i = 0;
            foreach (Control c in Components.panelRight.Controls)
                i++;
            while (i > 0)
            {
                UserControl userControl = (UserControl)Components.panelRight.Controls[--i];
                Components.Hide(ref userControl);
            }
        }
        public static void initQuestions()
        {
            int line = 0;
            pathToFolder = Path.Combine(AppContext.BaseDirectory, localFolder);
            if(!Directory.Exists(pathToFolder))
            {
                MessageBox.Show("Fisierul " + Components.pathToFolder + " nu exista\n" +
                                "Aplicatia se va inchide!");
                Environment.Exit(0);
            }
            string pathToTxt = Path.Combine(pathToFolder, txtFile);
            if (!File.Exists(pathToTxt))
            {
                MessageBox.Show("Fisierul "+ Components.txtFile + " nu exista\n"+
                                "Aplicatia se va inchide!");
                Environment.Exit(0);
            }
            questions = File.ReadAllLines(pathToTxt);
            if(questions.Length < Components.numberOfQuestions)
            {
                MessageBox.Show("Nu sunt suficiente intrebari!\n"+
                                "Minimul este "+Components.numberOfQuestions+'\n'+
                                "Aplicatia se va inchide!");
                Environment.Exit(0);
            }
            foreach (string question in questions)
            {
                line++;
                string[] temp = question.Split(',');
                if (temp.Length != 2)
                {
                    MessageBox.Show("A aparut o problema la linia " + line +'\n'+
                                    "Numarul de argumente este nepotrivit\n"+
                                    "Aplicatia se va inchide!");
                    Environment.Exit(0);
                }
                if ( !File.Exists(Path.Combine(pathToFolder, temp[0])) )
                {
                    MessageBox.Show("A aparut o problema la linia " + line + '\n' +
                                    "Fisierul " + temp[0] + " nu exista\n" +
                                    "Aplicatia se va inchide!");
                    Environment.Exit(0);
                }
                int myInt;
                bool isNumerical = int.TryParse(temp[1], out myInt);
                if( !(isNumerical && 1 <= myInt && myInt <=4) )
                {
                    MessageBox.Show("A aparut o problema la linia " + line + '\n' +
                                    temp[1] + " nu este conform parametrilor\n" +
                                    "Aplicatia se va inchide!");
                    Environment.Exit(0);
                }
            }
        }
        public static void randomizeQuestions()
        {
            var rnd = new Random();
            questions = questions.OrderBy(question => rnd.Next()).ToArray();
        }

        //Add font to resources, then reference it here
        //USE: Components.pfc.Families[0]
        /* public static void initializeFont() //may be unsafe?
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
