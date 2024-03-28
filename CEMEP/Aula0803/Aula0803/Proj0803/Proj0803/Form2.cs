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
    public partial class Frmlogin : Form
    {
        public Frmlogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair do sistema?", "Finalizando...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Retornando ao sistema");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "2W" && textBox2.Text == "1234")
            {
                Frmprin principal= new Frmprin();
                principal.Show();
            }
            else
            {
                MessageBox.Show("Senha ou usuário inválido");
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Frmlogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                SendKeys.Send("{tab}");
        }

       

 
    }
}
