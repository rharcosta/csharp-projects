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
    public partial class FrmNota : Form
    {
        public FrmNota()
        {
            InitializeComponent();
        }

        private void nota_fiscalBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nota_fiscalBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.industria_MetalurgicaDataSet);

        }

        private void FrmNota_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'industria_MetalurgicaDataSet.Clientes' table. You can move, or remove it, as needed.
            this.clientesTableAdapter.Fill(this.industria_MetalurgicaDataSet.Clientes);
            // TODO: This line of code loads data into the 'industria_MetalurgicaDataSet.Produtos' table. You can move, or remove it, as needed.
            this.produtosTableAdapter.Fill(this.industria_MetalurgicaDataSet.Produtos);
            // TODO: This line of code loads data into the 'industria_MetalurgicaDataSet.Nota_fiscal' table. You can move, or remove it, as needed.
            this.nota_fiscalTableAdapter.Fill(this.industria_MetalurgicaDataSet.Nota_fiscal);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close(); 
        }

        private void FrmNota_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)13)
                SendKeys.Send("{Tab}");
        }
    }
}
