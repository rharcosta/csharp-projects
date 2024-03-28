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
    public partial class Frmprin : Form
    {
        public Frmprin()
        {
            InitializeComponent();
        }

        private void alunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmaluno Aluno = new Frmaluno();
            Aluno.Show();
            this.Visible = true;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "Finalizando...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Frmlogin Login = new Frmlogin();
                Login.Show();
                this.Visible = false;
            }
            else
                MessageBox.Show("Retornando");
            
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        private void windowsExplorerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Explorer.exe");
        }

        private void internetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("IExplore.exe");
        }

        private void editorDeTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Winword.exe");
        }

        private void calendárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmcalend Calendario = new Frmcalend();
            Calendario.Show();
            this.Visible = true;
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "Finalizando...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Frmlogin Login = new Frmlogin();
                Login.Show();
                this.Visible = false;
            }
            else
                MessageBox.Show("Retornando");
            
        }

        private void alunoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frmaluno Aluno = new Frmaluno();
            Aluno.Show();
            this.Visible = true;
        }

        private void calendárioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frmcalend Calendario = new Frmcalend();
            Calendario.Show();
            this.Visible = true;
        }

        private void calculadoraToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        private void windowsExplorerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Explorer.exe");
        }

        private void internetToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("IExplore.exe");
        }

        private void editorDeTextoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Winword.exe");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToLongDateString();
            toolStripStatusLabel2.Text = DateTime.Now.ToShortTimeString(); 
        }

        

       
    }
}
