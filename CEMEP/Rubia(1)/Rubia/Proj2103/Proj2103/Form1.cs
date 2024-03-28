using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Proj2103
{
    public partial class FrmPrin : Form
    {
        public FrmPrin()
        {
            InitializeComponent();
        }

        private void filmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFilme Filme = new FrmFilme();
            Filme.Show(); 
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCli Cliente = new FrmCli();
            Cliente.Show();
        }

        private void locaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLoc Locacao = new FrmLoc();
            Locacao.Show(); 
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = System.DateTime.Now.ToLongTimeString();
            toolStripStatusLabel2.Text = System.DateTime.Now.ToLongDateString();
        }
    }
}
