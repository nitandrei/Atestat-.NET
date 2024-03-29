﻿using System;
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
    public partial class SirDeCaractere1 : UserControl
    {
        public SirDeCaractere1()
        {
            InitializeComponent();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            Components.Show(ref Components.sirDeCaractere2, false);
            Components.Hide(ref Components.sirDeCaractere1);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Components.Show(ref Components.teorie, false);
            Components.Hide(ref Components.sirDeCaractere1);
        }
    }
}
