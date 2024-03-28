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
    public partial class Formcli : Form
    {
        public Formcli()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;  
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Close();
        }

        private void Formcli_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                SendKeys.Send("{Tab}");

        }

        private void Formcli_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Clear(); 
            maskedTextBox2.Clear();
            maskedTextBox3.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            comboBox1.Text = "";
            dateTimePicker1.Text = "";
              
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Processando..."); 
        }

        
        
    }
}
