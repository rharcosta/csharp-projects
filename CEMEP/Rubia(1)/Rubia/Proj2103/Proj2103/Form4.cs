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
    public partial class FrmLoc : Form
    {
        public FrmLoc()
        {
            InitializeComponent();
        }

        private void tabLocacaoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tabLocacaoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bD2103DataSet);

        }

        private void FrmLoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD2103DataSet.TabFilme' table. You can move, or remove it, as needed.
            this.tabFilmeTableAdapter.Fill(this.bD2103DataSet.TabFilme);
            // TODO: This line of code loads data into the 'bD2103DataSet.TabCliente' table. You can move, or remove it, as needed.
            this.tabClienteTableAdapter.Fill(this.bD2103DataSet.TabCliente);
            // TODO: This line of code loads data into the 'bD2103DataSet.TabLocacao' table. You can move, or remove it, as needed.
            this.tabLocacaoTableAdapter.Fill(this.bD2103DataSet.TabLocacao);

        }

        private void FrmLoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)13)
                SendKeys.Send("{Tab}");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close(); 
        }
    }
}
