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
    public partial class FrmForn : Form
    {
        public FrmForn()
        {
            InitializeComponent();
        }

        private void fornecedoresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.fornecedoresBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.industria_MetalurgicaDataSet);

        }

        private void FrmForn_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'industria_MetalurgicaDataSet.Transportadoras' table. You can move, or remove it, as needed.
            this.transportadorasTableAdapter.Fill(this.industria_MetalurgicaDataSet.Transportadoras);
            // TODO: This line of code loads data into the 'industria_MetalurgicaDataSet.Fornecedores' table. You can move, or remove it, as needed.
            this.fornecedoresTableAdapter.Fill(this.industria_MetalurgicaDataSet.Fornecedores);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmForn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)13)
                SendKeys.Send("{Tab}");
        }
    }
}
