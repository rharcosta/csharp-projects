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
    public partial class Frmlogin : Form
    {
        public Frmlogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "trab" && textBox2.Text == "0805")
            {
                    this.Visible = false;
                    Frmprin Principal = new Frmprin();
                    Principal.Show();

                }
                else{

                
                MessageBox.Show("Login inválido!!", "Atenção");
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();

               
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "Finalizando...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                Application.Exit();
            else
                MessageBox.Show("Retornando");
        }

        private void Frmlogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                SendKeys.Send("{Tab}");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                textBox2.UseSystemPasswordChar = false;

            else
                textBox2.UseSystemPasswordChar = true;
        }
    }
}