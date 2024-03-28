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
    public partial class FrmPrin : Form
    {
        public FrmPrin()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = System.DateTime.Now.ToLongTimeString();
            toolStripStatusLabel3.Text = System.DateTime.Now.ToLongDateString();
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

        private void clienteEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEmp Empresa = new FrmEmp();
            Empresa.Show(); 
        }

        private void candidatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCand Candidato = new FrmCand();
            Candidato.Show(); 
        }

        private void vagasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVagas Vagas = new FrmVagas();
            Vagas.Show(); 
        }

        private void arquivoToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripStatusLabel1.Text = arquivoToolStripMenuItem.ToolTipText; 
        }

        private void cadastroToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripStatusLabel1.Text = cadastroToolStripMenuItem.ToolTipText;
        }

        private void ferramentasToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripStatusLabel1.Text = ferramentasToolStripMenuItem.ToolTipText;
        }

        private void ajudaToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripStatusLabel1.Text = ajudaToolStripMenuItem.ToolTipText;
        }

        private void sairToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripStatusLabel1.Text = sairToolStripMenuItem.ToolTipText;
        }

        private void clienteEmpresaToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripStatusLabel1.Text = clienteEmpresaToolStripMenuItem.ToolTipText;
        }

        private void candidatoToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripStatusLabel1.Text = candidatoToolStripMenuItem.ToolTipText;
        }

        private void vagasToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripStatusLabel1.Text = vagasToolStripMenuItem.ToolTipText;
        }

        private void calendárioToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripStatusLabel1.Text = calendárioToolStripMenuItem.ToolTipText;
        }

        private void calculadoraToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripStatusLabel1.Text = calculadoraToolStripMenuItem.ToolTipText;
        }

        private void windowsExplorerToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripStatusLabel1.Text = windowsExplorerToolStripMenuItem.ToolTipText;
        }

        private void iToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripStatusLabel1.Text = iToolStripMenuItem.ToolTipText;
        }

        private void editorDeTextoToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripStatusLabel1.Text = editorDeTextoToolStripMenuItem.ToolTipText;
        }

        private void sobreOSistemaToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripStatusLabel1.Text = sobreOSistemaToolStripMenuItem.ToolTipText;
        }

    }
}
