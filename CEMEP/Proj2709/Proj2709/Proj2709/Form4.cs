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
    public partial class Formprod : Form
    {
        public Formprod()
        {
            InitializeComponent();
        }

        private void Formprod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                SendKeys.Send("{Tab}");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            comboBox1.Text = ""; 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Double Compra, Venda, Imposto; 
            Compra = Convert.ToDouble(textBox3.Text); 
           
            Venda = Compra * 1.3;
            textBox4.Text= Convert.ToString(Venda);
 
            if(comboBox1.Text == "Sudeste"){
                Imposto= Venda * 1.1;
                textBox5.Text = Convert.ToString(Imposto);
            }
            if(comboBox1.Text == "Nordeste"){
                Imposto = Venda * 1.2;
                textBox5.Text = Convert.ToString(Imposto);
            }
            if(comboBox1.Text == "Sul"){
                Imposto = Venda * 1.4;
                textBox5.Text = Convert.ToString(Imposto);
            }

            
             

        }
    }
}
