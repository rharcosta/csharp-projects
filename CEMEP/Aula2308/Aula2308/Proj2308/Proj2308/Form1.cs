using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Proj2308
{
    public partial class Frmped : Form
    {
        public Frmped()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
 

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Quantidade1=0, Quantidade2=0, Quantidade3=0, TotalPar, Taxa, Total;
            Quantidade1 = Convert.ToDouble (textBox1.Text);
            Quantidade2 = Convert.ToDouble (textBox2.Text);
            Quantidade3 = Convert.ToDouble (textBox3.Text);
             

            if (checkBox1.Checked == true)
            {               
                TotalPar = Quantidade1 * 4.50;
                textBox5.Text = Convert.ToString(TotalPar);
                
            }
            if (checkBox2.Checked == true)
            {
                TotalPar = Quantidade2 * 12;
                textBox5.Text = Convert.ToString(TotalPar);
               
            }

            if (checkBox3.Checked == true)
            { 
                TotalPar = Quantidade3 * 20;
                textBox5.Text = Convert.ToString(TotalPar); 
               
            }

            TotalPar = Convert.ToDouble(textBox5.Text); 
            Taxa = (TotalPar * 10)/100;
            textBox6.Text = Convert.ToString(Taxa);
            textBox6.Text = String.Format("R$" + Taxa);
            Total = Taxa+TotalPar;
            textBox7.Text = Convert.ToString(Total); 
            textBox7.Text= String.Format("R$"+Total);
        }

        private void Frmped_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                SendKeys.Send("{tab}");
        }

        private void Frmped_Activated(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            
        }

        
    }

}
