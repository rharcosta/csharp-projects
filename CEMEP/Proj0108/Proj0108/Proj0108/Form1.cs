using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Proj0108
{
    public partial class FrmPrin : Form
    {
        public FrmPrin()
        {
            InitializeComponent();
        }

        private void editoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEditora Editora = new FrmEditora();
            Editora.Show(); 
        }

        private void livroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLivro Livro = new FrmLivro();
            Livro.Show(); 
        }
    }
}
