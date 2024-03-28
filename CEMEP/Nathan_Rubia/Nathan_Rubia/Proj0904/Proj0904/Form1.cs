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
    public partial class FrmPrin : Form
    {
        public FrmPrin()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Deseja sair?", "Aguardando resposta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
                MessageBox.Show("Retornando");
        }

        private void pacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPaciente Paciente = new FrmPaciente(); 
            Paciente.Show();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsulta Consulta = new FrmConsulta();
            Consulta.Show(); 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = System.DateTime.Now.ToLongTimeString();
            toolStripStatusLabel2.Text = System.DateTime.Now.ToLongDateString();
        }
    }
}
