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
    public partial class Frmsplash : Form
    {
        public Frmsplash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value == 25)
            {
                label3.Text = "Configurando Formulários..."; 
            }
            if (progressBar1.Value == 50)
            {
                label3.Text = "Atualizando Banco de Dados...";
            }
            if (progressBar1.Value == 75)
            {
                label3.Text = "Carregando Ferramentas...";
            }
            if (progressBar1.Value == 90)
            {
                label3.Text = "Abrindo o Sistema...";
            }
            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.Increment(5);
            }
            else
            {
                timer1.Enabled = false; 
                this.Visible = false; 
                Frmprin Frmprin = new Frmprin();
                Frmprin.Show(); 
             }
                







        }

        
    }
}
