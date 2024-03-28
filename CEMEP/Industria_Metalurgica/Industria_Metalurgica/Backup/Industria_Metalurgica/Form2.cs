using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Industria_Metalurgica
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "Aguardando resposta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
                MessageBox.Show("Retornando");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmUsu Usuario = new FrmUsu();
            Usuario.Show(); 
        }

        private void loginBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.loginBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.industria_MetalurgicaDataSet);

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'industria_MetalurgicaDataSet.Login' table. You can move, or remove it, as needed.
            this.loginTableAdapter.Fill(this.industria_MetalurgicaDataSet.Login);

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int result = loginTableAdapter.FillByUsuario(industria_MetalurgicaDataSet.Login, textBox1.Text, textBox2.Text);
            if (result == 1)
            {
                FrmPrinc Principal = new FrmPrinc();
                Principal.Show();
            }

            else
            {
                MessageBox.Show("Usuário ou senha inválidos!! Digite novamente...");
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }
        }

        private void FrmLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)13)
                SendKeys.Send("{Tab}"); 
        }



        
    }
}
