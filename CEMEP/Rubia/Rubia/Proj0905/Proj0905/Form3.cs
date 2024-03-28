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
    public partial class FrmPrin : Form
    {
        public FrmPrin()
        {
            InitializeComponent();
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadUsuario Usuario = new FrmCadUsuario();
            Usuario.Show(); 
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "Aguardando resposta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
                MessageBox.Show("Retornando");
        }

        private void arquivoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "Aguardando resposta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
                MessageBox.Show("Retornando");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = System.DateTime.Now.ToLongTimeString();
            toolStripStatusLabel2.Text = System.DateTime.Now.ToLongDateString();
        }

        private void editoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadEditora Editora = new FrmCadEditora();
            Editora.Show(); 
        }

        private void livroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadLivro Livro = new FrmCadLivro();
            Livro.Show(); 
        }
    }
}
