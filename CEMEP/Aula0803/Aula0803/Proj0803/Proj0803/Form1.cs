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
    public partial class frmsplash : Form
    {
        public frmsplash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
         if(progressBar1.Value<100)
         { 
             progressBar1.Value=progressBar1.Value+2;
             label4.Text="Carregando..."+progressBar1.Value+"%";
         }
         else 
         {
             timer1.Enabled = false; //
           Frmlogin login= new Frmlogin(); //Criando form login
           login.Show(); //Chamando o form
           this.Visible=false; //Deixando o splash invisível

         }

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

    }
}
