using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Proj3W
{
    public partial class FrmVagas : Form
    {
        public FrmVagas()
        {
            InitializeComponent();
        }

        private void tabVagasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tabVagasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bD3WDataSet);

        }

        private void FrmVagas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD3WDataSet.TabCliempresa' table. You can move, or remove it, as needed.
            this.tabCliempresaTableAdapter.Fill(this.bD3WDataSet.TabCliempresa);
            // TODO: This line of code loads data into the 'bD3WDataSet.TabVagas' table. You can move, or remove it, as needed.
            this.tabVagasTableAdapter.Fill(this.bD3WDataSet.TabVagas);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close(); 
        }

        private void FrmVagas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)13)
                SendKeys.Send("{Tab}"); 
        }
    }
}
