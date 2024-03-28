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
    public partial class ConsultaProdutos : Form
    {
        public ConsultaProdutos()
        {
            InitializeComponent();
        }

        private void produtosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.produtosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.industria_MetalurgicaDataSet);

        }

        private void ConsultaProdutos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'industria_MetalurgicaDataSet.Produtos' table. You can move, or remove it, as needed.
            this.produtosTableAdapter.Fill(this.industria_MetalurgicaDataSet.Produtos);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.produtosTableAdapter.FillByProdutos(this.industria_MetalurgicaDataSet.Produtos, Convert.ToInt16(textBox1.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
