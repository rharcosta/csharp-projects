using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Proj0904
{
    public partial class FrmConsulta : Form
    {
        public FrmConsulta()
        {
            InitializeComponent();
        }

        private void consultaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.consultaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDProva0904DataSet);

        }

        private void FrmConsulta_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDProva0904DataSet.Paciente' table. You can move, or remove it, as needed.
            this.pacienteTableAdapter.Fill(this.bDProva0904DataSet.Paciente);
            // TODO: This line of code loads data into the 'bDProva0904DataSet.Consulta' table. You can move, or remove it, as needed.
            this.consultaTableAdapter.Fill(this.bDProva0904DataSet.Consulta);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close(); 
        }

        private void FrmConsulta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)13)
                SendKeys.Send("{Tab}");
        }
    }
}
