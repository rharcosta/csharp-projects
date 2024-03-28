using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Proj0905
{
    public partial class FrmCadEditora : Form
    {
        public FrmCadEditora()
        {
            InitializeComponent();
        }

        private void cadEditoraBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cadEditoraBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bD0905DataSet);

        }

        private void FrmCadEditora_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD0905DataSet.CadEditora' table. You can move, or remove it, as needed.
            this.cadEditoraTableAdapter.Fill(this.bD0905DataSet.CadEditora);

        }
    }
}
