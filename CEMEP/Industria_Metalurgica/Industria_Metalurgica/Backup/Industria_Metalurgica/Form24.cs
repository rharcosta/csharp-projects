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
    public partial class ConsultaFuncionarios : Form
    {
        public ConsultaFuncionarios()
        {
            InitializeComponent();
        }

        private void funcionáriosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.funcionáriosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.industria_MetalurgicaDataSet);

        }

        private void Form24_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'industria_MetalurgicaDataSet.Funcionários' table. You can move, or remove it, as needed.
            this.funcionáriosTableAdapter.Fill(this.industria_MetalurgicaDataSet.Funcionários);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.funcionáriosTableAdapter.FillByFunc(this.industria_MetalurgicaDataSet.Funcionários, textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
