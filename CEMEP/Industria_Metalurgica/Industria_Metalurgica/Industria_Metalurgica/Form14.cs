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
    public partial class FrmTransp : Form
    {
        public FrmTransp()
        {
            InitializeComponent();
        }

        private void transportadorasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.transportadorasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.industria_MetalurgicaDataSet);

        }

        private void FrmTransp_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'industria_MetalurgicaDataSet.Transportadoras' table. You can move, or remove it, as needed.
            this.transportadorasTableAdapter.Fill(this.industria_MetalurgicaDataSet.Transportadoras);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close(); 
        }
    }
}
