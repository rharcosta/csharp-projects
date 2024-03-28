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
    public partial class ConsultaFornecedores : Form
    {
        public ConsultaFornecedores()
        {
            InitializeComponent();
        }

        private void fornecedoresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.fornecedoresBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.industria_MetalurgicaDataSet);

        }

        private void Form19_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'industria_MetalurgicaDataSet.Fornecedores' table. You can move, or remove it, as needed.
            this.fornecedoresTableAdapter.Fill(this.industria_MetalurgicaDataSet.Fornecedores);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.fornecedoresTableAdapter.FillByFornecedores(this.industria_MetalurgicaDataSet.Fornecedores, Convert.ToInt16(textBox1.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
