using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atestat.NET
{
    public partial class Teste : UserControl
    {
        public Teste()
        {
            InitializeComponent();
            Components.initQuestions();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            foreach (string question in Components.questions)
                label1.Text += question + '\n';
            Components.randomizeQuestions();
        }
    }
}
