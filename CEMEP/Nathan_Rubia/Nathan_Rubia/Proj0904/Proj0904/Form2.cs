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
    public partial class FrmPaciente : Form
    {
        public FrmPaciente()
        {
            InitializeComponent();
        }

        private void pacienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pacienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDProva0904DataSet);

        }

        private void FrmPaciente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDProva0904DataSet.Paciente' table. You can move, or remove it, as needed.
            this.pacienteTableAdapter.Fill(this.bDProva0904DataSet.Paciente);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close(); 
        }

        private void FrmPaciente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)13)
                SendKeys.Send("{Tab}");
        }
    }
}
