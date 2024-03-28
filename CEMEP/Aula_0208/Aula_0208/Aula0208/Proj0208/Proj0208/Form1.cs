using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Proj0208
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n1, n2, result;
            n1= Convert.ToDouble(textBox1.Text);
            n2 = Convert.ToDouble(textBox2.Text);
            result = n1 + n2;
            textBox3.Text = Convert.ToString(result);
        }
    }
}
