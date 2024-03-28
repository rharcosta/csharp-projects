using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TRAB
{
    public partial class Frmprin : Form
    {
        public Frmprin()
        {
            InitializeComponent();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmforne principal= new Frmforne();
            principal.Show(); 
            this.Visible= true; 
        }

        private void sobreOSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmsobre principal = new Frmsobre();
            principal.Show();
            this.Visible = true; 
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmlogin principal = new Frmlogin();
            principal.Show();
            this.Visible = false; 
           
        }

        private void caToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmcalend principal = new Frmcalend();
            principal.Show();
            this.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToLongDateString();
            toolStripStatusLabel2.Text = DateTime.Now.ToLongTimeString();  
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

        private void fornecedorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frmforne principal = new Frmforne();
            principal.Show();
            this.Visible = true; 
        }

        private void calendárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmcalend principal = new Frmcalend();
            principal.Show();
            this.Visible = true;
        }

        private void sobreOSistemaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frmsobre principal = new Frmsobre();
            principal.Show();
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

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frmlogin principal = new Frmlogin();
            principal.Show();
            this.Visible = false; 
        }

        private void arquivoToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
        toolStripStatusLabel3.Text = arquivoToolStripMenuItem.ToolTipText;   
        }

        private void sairToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
        toolStripStatusLabel3.Text = sairToolStripMenuItem.ToolTipText;
        }

        private void cadastroToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
        toolStripStatusLabel3.Text = cadastroToolStripMenuItem.ToolTipText;
        }

        private void fornecedorToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
        toolStripStatusLabel3.Text = fornecedorToolStripMenuItem.ToolTipText;
        }

        private void utilitáriosToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
        toolStripStatusLabel3.Text = utilitáriosToolStripMenuItem.ToolTipText;
        }

        private void caToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
        toolStripStatusLabel3.Text = caToolStripMenuItem.ToolTipText;
        }

        private void calculadoraToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
        toolStripStatusLabel3.Text = calculadoraToolStripMenuItem.ToolTipText;
        }

        private void windowsExplorerToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
        toolStripStatusLabel3.Text = windowsExplorerToolStripMenuItem.ToolTipText;
        }

        private void internetToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
        toolStripStatusLabel3.Text = internetToolStripMenuItem.ToolTipText;
        }

        private void editorDeTextoToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
        toolStripStatusLabel3.Text = editorDeTextoToolStripMenuItem.ToolTipText;
        }

        private void ajudaToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
        toolStripStatusLabel3.Text = ajudaToolStripMenuItem.ToolTipText;
        }

        private void sobreOSistemaToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
        toolStripStatusLabel3.Text = sobreOSistemaToolStripMenuItem.ToolTipText;
        }

        private void arquivoToolStripMenuItem1_MouseMove(object sender, MouseEventArgs e)
        {
        toolStripStatusLabel3.Text = arquivoToolStripMenuItem.ToolTipText;
        }

        private void sairToolStripMenuItem1_MouseMove(object sender, MouseEventArgs e)
        {
        toolStripStatusLabel3.Text = sairToolStripMenuItem.ToolTipText;
        }

        private void cadastroToolStripMenuItem1_MouseMove(object sender, MouseEventArgs e)
        {
        toolStripStatusLabel3.Text = cadastroToolStripMenuItem.ToolTipText;
        }

        private void fornecedorToolStripMenuItem1_MouseMove(object sender, MouseEventArgs e)
        {
        toolStripStatusLabel3.Text = fornecedorToolStripMenuItem.ToolTipText;
        }

        private void utilitáriosToolStripMenuItem1_MouseMove(object sender, MouseEventArgs e)
        {
        toolStripStatusLabel3.Text = utilitáriosToolStripMenuItem.ToolTipText;
        }

        private void calendárioToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
        toolStripStatusLabel3.Text = caToolStripMenuItem.ToolTipText;
        }

        private void calculadoraToolStripMenuItem1_MouseMove(object sender, MouseEventArgs e)
        {
        toolStripStatusLabel3.Text = calculadoraToolStripMenuItem.ToolTipText;
        }
        
        private void windowsExplorerToolStripMenuItem1_MouseMove(object sender, MouseEventArgs e)
        {
        toolStripStatusLabel3.Text = windowsExplorerToolStripMenuItem.ToolTipText;
        }

        private void internetToolStripMenuItem1_MouseMove(object sender, MouseEventArgs e)
        {
        toolStripStatusLabel3.Text = internetToolStripMenuItem.ToolTipText;
        }

        private void editorDeTextoToolStripMenuItem1_MouseMove(object sender, MouseEventArgs e)
        {
        toolStripStatusLabel3.Text = editorDeTextoToolStripMenuItem.ToolTipText;
        }

        private void ajudaToolStripMenuItem1_MouseMove(object sender, MouseEventArgs e)
        {
        toolStripStatusLabel3.Text = ajudaToolStripMenuItem.ToolTipText;
        }

        private void sobreOSistemaToolStripMenuItem1_MouseMove(object sender, MouseEventArgs e)
        {
        toolStripStatusLabel3.Text = sobreOSistemaToolStripMenuItem.ToolTipText;
        }

       
        
        
        
        
       

        
     
       

        

        
    }
}
