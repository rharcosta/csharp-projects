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
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "trabw" && textBox2.Text == "1004")
            {
                this.Visible = false;
                frmprin principal = new frmprin();
                principal.Show();
                
            }
            else
            {
                MessageBox.Show("Senha ou usuário inválido", "Error");
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair do sistema?", "Finalizando...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                Application.Exit();
            else
                MessageBox.Show("Retornando ao sistema"); 
        }

        private void frmlogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                SendKeys.Send("{tab}");
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
