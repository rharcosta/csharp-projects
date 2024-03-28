using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Proj0108
{
    public partial class FrmLivro : Form
    {
        public FrmLivro()
        {
            InitializeComponent();
        }

        private void tabLivroBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tabLivroBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bancoDataSet);

        }

        private void FrmLivro_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bancoDataSet.TabEditora' table. You can move, or remove it, as needed.
            this.tabEditoraTableAdapter.Fill(this.bancoDataSet.TabEditora);
            // TODO: This line of code loads data into the 'bancoDataSet.TabLivro' table. You can move, or remove it, as needed.
            this.tabLivroTableAdapter.Fill(this.bancoDataSet.TabLivro);

        }
    }
}
