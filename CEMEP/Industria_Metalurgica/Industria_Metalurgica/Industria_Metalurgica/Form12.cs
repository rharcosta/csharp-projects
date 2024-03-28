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
    public partial class FrmNota : Form
    {
        public FrmNota()
        {
            InitializeComponent();
        }

        private void nota_fiscalBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nota_fiscalBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.industria_MetalurgicaDataSet);

        }

        private void FrmNota_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'industria_MetalurgicaDataSet.Nota_fiscal' table. You can move, or remove it, as needed.
            this.nota_fiscalTableAdapter.Fill(this.industria_MetalurgicaDataSet.Nota_fiscal);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close(); 
        }
    }
}
