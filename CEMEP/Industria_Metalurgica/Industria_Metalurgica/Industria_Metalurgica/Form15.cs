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
    public partial class FrmVendas : Form
    {
        public FrmVendas()
        {
            InitializeComponent();
        }

        private void vendasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vendasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.industria_MetalurgicaDataSet);

        }

        private void FrmVendas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'industria_MetalurgicaDataSet.Vendas' table. You can move, or remove it, as needed.
            this.vendasTableAdapter.Fill(this.industria_MetalurgicaDataSet.Vendas);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close(); 
        }
    }
}
