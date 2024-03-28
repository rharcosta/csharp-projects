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
    public partial class FrmPrinc : Form
    {
        public FrmPrinc()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "Aguardando resposta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                FrmLogin Usu = new FrmLogin();
                Usu.Show();
                this.Close();
            }
            else
                MessageBox.Show("Retornando");
        }

        private void calendárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCalendario Calendario = new FrmCalendario();
            Calendario.Show();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        private void windowsExplorerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Explorer.exe");
        }

        private void iToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("IExplore.exe");
        }

        private void editorDeTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("WinWord.exe");
        }

        private void sobreOSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSobre Sobre = new FrmSobre();
            Sobre.Show(); 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = System.DateTime.Now.ToLongTimeString();
            toolStripStatusLabel3.Text = System.DateTime.Now.ToLongDateString();
        }

        private void clienteEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmContas Contas = new FrmContas();
            Contas.Show(); 
        }

        private void candidatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCompras Compras = new FrmCompras();
            Compras.Show(); 
        }
    }
}
