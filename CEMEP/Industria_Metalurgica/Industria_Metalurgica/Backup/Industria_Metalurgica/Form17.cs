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
    public partial class ConsultaCompras : Form
    {
        public ConsultaCompras()
        {
            InitializeComponent();
        }

        private void comprasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.comprasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.industria_MetalurgicaDataSet);

        }

        private void Form17_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'industria_MetalurgicaDataSet.Compras' table. You can move, or remove it, as needed.
            this.comprasTableAdapter.Fill(this.industria_MetalurgicaDataSet.Compras);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.comprasTableAdapter.FillByCompras(this.industria_MetalurgicaDataSet.Compras, Convert.ToInt16(textBox1.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
