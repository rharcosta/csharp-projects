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
    public partial class Formprin : Form
    {
        public Formprin()
        {
            InitializeComponent();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formprod formprod = new Formprod();
            formprod.Show(); 
            
        }

        private void calendárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formcalend Calendario = new Formcalend();
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

        private void internetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("IExplore.exe");
        }

        private void editorDeTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Winword.exe");
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

        private void Formprin_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = System.DateTime.Now.ToLongTimeString();
            toolStripStatusLabel2.Text = System.DateTime.Now.ToLongDateString();
  
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        
    }
}
