using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Proj02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sal, imp; 
            sal = Convert.ToDouble(textBox3.Text);

            imp = sal * 0.15;
            textBox7.Text = Convert.ToString(imp);    
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double salariobruto, sal, ndp, valetransporte, valerefeicao, salarioliquido, imp;
            sal = Convert.ToDouble(textBox3.Text);
            ndp = Convert.ToDouble(textBox4.Text);
            valerefeicao = Convert.ToDouble(textBox5.Text);
            valetransporte = Convert.ToDouble(textBox6.Text);
            imp = Convert.ToDouble(textBox7.Text);   
          
            salariobruto= sal + (ndp * 50) + valerefeicao + valetransporte;
            textBox8.Text= Convert.ToString(salariobruto);  

            salarioliquido = salariobruto - imp;
            textBox9.Text = Convert.ToString(salarioliquido); 
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                SendKeys.Send("{tab}");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
        }

        
    }
}
