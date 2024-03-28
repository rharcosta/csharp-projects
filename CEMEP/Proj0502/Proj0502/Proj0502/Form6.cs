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
    public partial class FrmVendedor : Form
    {
        public FrmVendedor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close(); 
        }

        private void tabVendedorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tabVendedorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bD0502DataSet);

        }

        private void FrmVendedor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD0502DataSet.TabVendedor' table. You can move, or remove it, as needed.
            this.tabVendedorTableAdapter.Fill(this.bD0502DataSet.TabVendedor);

        }
    }
}
