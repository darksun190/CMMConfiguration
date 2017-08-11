using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Office = Microsoft.Office.Core;

namespace CMMConfiguration
{
    partial class OverviewActionsPaneControl1 : UserControl
    {
        public OverviewActionsPaneControl1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Variable.Project_Name = textBox1.Text;
        }
    }
}
