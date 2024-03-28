using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Proj0502
{
    public partial class FrmPrin : Form
    {
        public FrmPrin()
        {
            InitializeComponent();
        }

        private void FrmPrin_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = System.DateTime.Now.ToLongTimeString();
            toolStripStatusLabel2.Text = System.DateTime.Now.ToLongDateString();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close(); 
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClientes Clientes = new FrmClientes();
            Clientes.Show(); 
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProduto Produto = new FrmProduto(); 
            Produto.Show(); 
        }

        private void vendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVendedor Vendedor = new FrmVendedor(); 
            Vendedor.Show(); 
        }

        
    }
}
