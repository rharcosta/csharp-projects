using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace proj1004w
{
    public partial class frmprin : Form
    {
        public frmprin()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sobreOSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formsobre principal = new Formsobre();
            principal.Show();
            this.Visible = true;
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formcli principal = new Formcli();
            principal.Show();
            this.Visible = true;
        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formvenda principal = new Formvenda();
            principal.Show();
            this.Visible = true;
        }

        

    }
}
