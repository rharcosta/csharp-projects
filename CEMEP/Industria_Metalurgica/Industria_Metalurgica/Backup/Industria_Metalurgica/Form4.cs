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

        private void Contas_Click(object sender, EventArgs e)
        {
            FrmContas Contas = new FrmContas();
            Contas.Show();
        }
   
        private void Clientes_Click(object sender, EventArgs e)
        {
            FrmClientes Clientes = new FrmClientes();
            Clientes.Show(); 
        }

        private void Funcionarios_Click(object sender, EventArgs e)
        {
            FrmFunc Funcionarios = new FrmFunc();
            Funcionarios.Show(); 
        }

        private void NotaFiscal_Click(object sender, EventArgs e)
        {
            FrmNota Nota = new FrmNota();
            Nota.Show();
        }

        private void Produtos_Click(object sender, EventArgs e)
        {
            FrmProdutos Produtos = new FrmProdutos();
            Produtos.Show(); 
        }

        private void Transportadoras_Click(object sender, EventArgs e)
        {
            FrmTransp Transportadora = new FrmTransp();
            Transportadora.Show(); 
        }

        private void Vendas_Click(object sender, EventArgs e)
        {
            FrmVendas Vendas = new FrmVendas();
            Vendas.Show();
        }

        private void Compras_Click_1(object sender, EventArgs e)
        {
            FrmCompras Compras = new FrmCompras();
            Compras.Show(); 
        }

        private void Fornecedores_Click_1(object sender, EventArgs e)
        {
            FrmForn Fornecedores = new FrmForn();
            Fornecedores.Show(); 
        }

        private void contasToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ConsultaContas ConsuContas = new ConsultaContas();
            ConsuContas.Show();
        }

        private void comprasToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ConsultaCompras ConsuCompras = new ConsultaCompras();
            ConsuCompras.Show(); 
        }

        private void clientesToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ConsultaClientes ConsuClientes = new ConsultaClientes();
            ConsuClientes.Show(); 
        }

        private void fornecedoresToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ConsultaFornecedores ConsuFornecedores = new ConsultaFornecedores();
            ConsuFornecedores.Show(); 
        }

        private void notaFiscalToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ConsultaNota ConsuNota = new ConsultaNota();
            ConsuNota.Show(); 
        }

        private void produtosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ConsultaProdutos ConsuProdutos = new ConsultaProdutos();
            ConsuProdutos.Show(); 
        }

        private void transportadorasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultaTransportadora ConsuTransportadora = new ConsultaTransportadora();
            ConsuTransportadora.Show(); 
        }

        private void vendasToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ConsultaVendas ConsuVendas = new ConsultaVendas();
            ConsuVendas.Show();
        }

        private void funcionáriosToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ConsultaFuncionarios ConsuFunc = new ConsultaFuncionarios();
            ConsuFunc.Show(); 
        }

     
      
        
    }

       
}
