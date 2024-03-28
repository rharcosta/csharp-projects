using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Proj0905
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close(); 
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmCadUsuario Usuario = new FrmCadUsuario();
            Usuario.Show(); 
        }

        private void cadEditoraBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cadEditoraBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bD0905DataSet);

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD0905DataSet.CadEditora' table. You can move, or remove it, as needed.
            this.cadEditoraTableAdapter.Fill(this.bD0905DataSet.CadEditora);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int result = FrmCadUsuarioTableAdapter.FillbyUsuario(BD0905DataSet.FrmCadUsuario, textBox1.Text, textBox2.Text);
            if (result == 1) //Registro encontrado
            {
                FrmPrin Principal = new FrmPrin();
                Principal.Show();
            }
            else //Registro não encontrado
            {
                MessageBox.Show("Usuário ou senha inválidos!! Digite novamente...");
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }
        }
    }
}
