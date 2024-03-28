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
    public partial class FrmCand : Form
    {
        public FrmCand()
        {
            InitializeComponent();
        }

        private void tabCandidatoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tabCandidatoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bD3WDataSet);

        }

        private void FrmCand_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD3WDataSet.TabVagas' table. You can move, or remove it, as needed.
            this.tabVagasTableAdapter.Fill(this.bD3WDataSet.TabVagas);
            // TODO: This line of code loads data into the 'bD3WDataSet.TabCandidato' table. You can move, or remove it, as needed.
            this.tabCandidatoTableAdapter.Fill(this.bD3WDataSet.TabCandidato);

        }

        private void FrmCand_KeyPress(object sender, KeyPressEventArgs e)
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
