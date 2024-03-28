using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Proj2103
{
    public partial class FrmCli : Form
    {
        public FrmCli()
        {
            InitializeComponent();
        }

        private void tabClienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tabClienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bD2103DataSet);

        }

        private void FrmCli_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD2103DataSet.TabCliente' table. You can move, or remove it, as needed.
            this.tabClienteTableAdapter.Fill(this.bD2103DataSet.TabCliente);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close(); 
        }

        private void FrmCli_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)13)
            SendKeys.Send("{Tab}"); 
           

        }
    }
}
