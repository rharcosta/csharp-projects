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
    public partial class Frmvenda : Form
    {
        double Qtd, Valor, Total, Vista, Parcelas, Prazo, Juros;
        public Frmvenda()
        {
            InitializeComponent();
        }
   

        private void Frmvenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                SendKeys.Send("{Tab}");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Clear(); 
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox6.Visible=false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            textBox9.Visible = false;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            button3.Visible = false;
            label7.Visible = false;
            label8.Visible = false; 
            label9.Visible = false;
            label10.Visible = false;
            groupBox1.Visible = false;
            maskedTextBox1.Focus();


        }

        private void button4_Click(object sender, EventArgs e)
        {

            Qtd = Convert.ToDouble(textBox3.Text);
            Valor = Convert.ToDouble(textBox4.Text);
            
 
            Total = Qtd * Valor;
            textBox5.Text = "R$ " + Convert.ToString(Total);
            groupBox1.Visible = true; 

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair?","",MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                Application.Exit();
            else
                MessageBox.Show("Retornando");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Qtd = Convert.ToDouble(textBox3.Text);
            Valor = Convert.ToDouble(textBox4.Text);
            Parcelas = Convert.ToDouble(textBox6.Text);

            Total = Qtd * Valor;
           
            if ((Parcelas >= 1) && (Parcelas <= 3))
            {
                MessageBox.Show("Em até 3 vezes sem juros");
                Prazo = Total / Parcelas;
                label8.Visible = true; 
                label10.Visible = true; 
                textBox7.Visible = true;
                textBox9.Visible = true;
                textBox7.Text = "R$ " +Convert.ToString(Prazo);
                textBox9.Text = "R$ " +Convert.ToString(Total); 
            }

            if ((Parcelas >= 4) && (Parcelas <= 6))
            {
                MessageBox.Show("Em até 6 vezes com juros de 5%");
                Prazo = Total / Parcelas;
                Juros = Total * 1.05;
                label8.Visible = true;
                label10.Visible = true;
                textBox7.Visible = true;
                textBox9.Visible = true;
                textBox7.Text = "R$ "+Convert.ToString(Prazo);
                textBox9.Text = "R$ "+Convert.ToString(Juros); 
            }
            if ((Parcelas < 1) || (Parcelas > 6))
            {
                MessageBox.Show("Parcelamento não autorizado");
                textBox6.Clear();
                textBox6.Focus();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           

            Total = Qtd * Valor;
         
            if (radioButton1.Checked == true)
            {
                MessageBox.Show("A vista recebe 10% de desconto");
                Vista = Total * 0.9;
                textBox8.Text = "R$ " + Convert.ToString(Vista);
                label9.Visible = true;
                textBox8.Visible = true;
            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                MessageBox.Show("Informe o número de parcelas");
                label7.Visible = true;
                textBox6.Visible = true;
                textBox6.Focus();
                button3.Visible = true;
            }
        }

        private void Frmvenda_Load(object sender, EventArgs e)
        {

        }

    

       
    }
}
