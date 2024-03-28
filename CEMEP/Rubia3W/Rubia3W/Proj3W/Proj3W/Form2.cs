using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Proj3W
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

        private void tabUsuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tabUsuarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bD3WDataSet);

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD3WDataSet.TabUsuario' table. You can move, or remove it, as needed.
            this.tabUsuarioTableAdapter.Fill(this.bD3WDataSet.TabUsuario);

        }

        private void button2_Click(object sender, EventArgs e)
        {

           int result = tabUsuarioTableAdapter.FillByUser(bD3WDataSet.TabUsuario, textBox1.Text, textBox2.Text); 
             
           if (result==1) //Registro encontrado
           {
            FrmPrin Principal  = new FrmPrin ();
            Principal.Show(); 
           }      
            
           else  //Registro não encontrado
           {
            MessageBox.Show("Usuário ou senha inválidos!!Digite novamente..."); 
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus ();
           }
         }

        private void FrmLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char) 13)
            SendKeys.Send ("{Tab}"); 

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmUsu Usuario = new FrmUsu();
            Usuario.Show(); 
        } 


     }
 }

