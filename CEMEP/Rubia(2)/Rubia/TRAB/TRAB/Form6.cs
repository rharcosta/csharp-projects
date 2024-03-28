using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TRAB
{
    public partial class Frmforne : Form
    {
        public Frmforne()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            maskedTextBox1.Clear();
            maskedTextBox2.Clear();
            comboBox1.Text="";
            maskedTextBox3.Clear();
            textBox1.Focus(); 
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close(); 
        }
    }
}
