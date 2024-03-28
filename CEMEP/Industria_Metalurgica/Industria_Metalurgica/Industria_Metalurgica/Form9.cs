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
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void clientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.industria_MetalurgicaDataSet);

        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'industria_MetalurgicaDataSet.Clientes' table. You can move, or remove it, as needed.
            this.clientesTableAdapter.Fill(this.industria_MetalurgicaDataSet.Clientes);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close(); 
        }
    }
}
