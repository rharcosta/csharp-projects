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
    public partial class FrmCadUsuario : Form
    {
        public FrmCadUsuario()
        {
            InitializeComponent();
        }

        private void tabUsuárioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tabUsuárioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bD0905DataSet);

        }

        private void FrmCadUsuario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD0905DataSet.TabUsuário' table. You can move, or remove it, as needed.
            this.tabUsuárioTableAdapter.Fill(this.bD0905DataSet.TabUsuário);

        }
    }
}
