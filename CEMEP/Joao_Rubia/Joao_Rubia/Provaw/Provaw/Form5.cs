using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Frmaluno : Form
    {
        public Frmaluno()
        {
            InitializeComponent();
        }

        private void Frmaluno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                SendKeys.Send("{Tab}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            maskedTextBox1.Clear();
            maskedTextBox2.Clear();
            maskedTextBox3.Clear();
            maskedTextBox4.Clear();
            comboBox1.Text = "";
            radioButton1.Text = "";
            radioButton2.Text = "";
            radioButton3.Text = "";
            textBox1.Focus(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close(); 
        }

       
    }
}
