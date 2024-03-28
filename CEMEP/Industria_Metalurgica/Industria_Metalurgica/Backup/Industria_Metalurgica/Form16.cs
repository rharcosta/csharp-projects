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
    public partial class ConsultaContas : Form
    {
        public ConsultaContas()
        {
            InitializeComponent();
        }

        private void contasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.contasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.industria_MetalurgicaDataSet);

        }

        private void Form16_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'industria_MetalurgicaDataSet.Contas' table. You can move, or remove it, as needed.
            this.contasTableAdapter.Fill(this.industria_MetalurgicaDataSet.Contas);

        }

     
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.contasTableAdapter.FillByConta(this.industria_MetalurgicaDataSet.Contas, Convert.ToInt16 (textBox1.Text));

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
