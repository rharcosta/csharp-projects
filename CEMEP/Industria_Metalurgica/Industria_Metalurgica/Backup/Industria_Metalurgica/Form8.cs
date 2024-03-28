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
    public partial class FrmCompras : Form
    {
        public FrmCompras()
        {
            InitializeComponent();
        }

        private void comprasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.comprasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.industria_MetalurgicaDataSet);

        }

        private void FrmCompras_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'industria_MetalurgicaDataSet.Fornecedores' table. You can move, or remove it, as needed.
            this.fornecedoresTableAdapter.Fill(this.industria_MetalurgicaDataSet.Fornecedores);
            // TODO: This line of code loads data into the 'industria_MetalurgicaDataSet.Compras' table. You can move, or remove it, as needed.
            this.comprasTableAdapter.Fill(this.industria_MetalurgicaDataSet.Compras);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close(); 
        }

        private void FrmCompras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)13)
                SendKeys.Send("{Tab}");
        }
    }
}
