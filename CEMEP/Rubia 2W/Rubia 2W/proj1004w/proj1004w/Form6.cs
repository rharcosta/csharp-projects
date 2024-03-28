using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace proj1004w
{
    public partial class Formvenda : Form
    {
        public Formvenda()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close(); 
        }

        private void Formvenda_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)13)
                SendKeys.Send("{Tab}");
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Formvenda_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Processando..."); 

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            numericUpDown1.Text = "";
            dateTimePicker1.Text  = "";  
            
        }

        
    }
}
