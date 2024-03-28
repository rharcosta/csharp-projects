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
    public partial class FrmProduto : Form
    {
        public FrmProduto()
        {
            InitializeComponent();
        }

        private void tabProdBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tabProdBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bD0502DataSet);

        }

        private void FrmProduto_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD0502DataSet.TabProd' table. You can move, or remove it, as needed.
            this.tabProdTableAdapter.Fill(this.bD0502DataSet.TabProd);

        }
    }
}
