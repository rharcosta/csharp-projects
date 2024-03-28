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
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void tabCliBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tabCliBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bD0502DataSet);

        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD0502DataSet.TabCli' table. You can move, or remove it, as needed.
            this.tabCliTableAdapter.Fill(this.bD0502DataSet.TabCli);

        }
    }
}
