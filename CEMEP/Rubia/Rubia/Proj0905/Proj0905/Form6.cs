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
    public partial class FrmCadLivro : Form
    {
        public FrmCadLivro()
        {
            InitializeComponent();
        }

        private void cadLivroBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cadLivroBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bD0905DataSet);

        }

        private void FrmCadLivro_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD0905DataSet.CadEditora' table. You can move, or remove it, as needed.
            this.cadEditoraTableAdapter.Fill(this.bD0905DataSet.CadEditora);
            // TODO: This line of code loads data into the 'bD0905DataSet.CadLivro' table. You can move, or remove it, as needed.
            this.cadLivroTableAdapter.Fill(this.bD0905DataSet.CadLivro);

        }
    }
}
