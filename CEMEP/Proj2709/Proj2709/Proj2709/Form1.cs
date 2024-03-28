using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Formsplash : Form
    {
        public Formsplash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value == 25)
            {
                label1.Text = "Configurando Formulários...";
            }
            if (progressBar1.Value == 50)
            {
                label1.Text = "Atualizando Banco de Dados...";
            }
            if (progressBar1.Value == 75)
            {
                label1.Text = "Carregando Ferramentas...";
            }
            if (progressBar1.Value == 90)
            {
                label1.Text = "Abrindo o Sistema...";
            }
            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.Increment(5);
            }
            else
            {
                timer1.Enabled = false;
                this.Visible = false;
                Formprin Formprin = new Formprin();
                Formprin.Show();
            }
                

        }
    }
}
