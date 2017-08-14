using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMMConfiguration
{
    public partial class DiscountRate : UserControl
    {
        public DiscountRate()
        {
            InitializeComponent();
        }
        public double DiscountValue
        {
            get
            {
                double v = double.Parse(textBox1.Text);
                return v / 100.0;
            }
        }
        [Category("SunXin")]
        public string TextValue
        {
            set
            {
                textBox1.Text = value;
            }
            get
            {
                return textBox1.Text;
            }
        }
    }
}
