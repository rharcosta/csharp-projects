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
    public partial class ConsultaVendas : Form
    {
        public ConsultaVendas()
        {
            InitializeComponent();
        }

        private void vendasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vendasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.industria_MetalurgicaDataSet);

        }

        private void Form23_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'industria_MetalurgicaDataSet.Vendas' table. You can move, or remove it, as needed.
            this.vendasTableAdapter.Fill(this.industria_MetalurgicaDataSet.Vendas);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.vendasTableAdapter.FillByVendas(this.industria_MetalurgicaDataSet.Vendas, Convert.ToInt16(textBox1.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
