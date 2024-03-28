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
    public partial class FrmUsu : Form
    {
        public FrmUsu()
        {
            InitializeComponent();
        }

        private void tabUsuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tabUsuarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bD3WDataSet);

        }

        private void FrmUsu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD3WDataSet.TabUsuario' table. You can move, or remove it, as needed.
            this.tabUsuarioTableAdapter.Fill(this.bD3WDataSet.TabUsuario);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close(); 
        }

        private void FrmUsu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)13)
                SendKeys.Send("{Tab}"); 
        }
    }
}
