using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Proj0905
{
    public partial class FrmSplash : Form
    {
        public FrmSplash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value = progressBar1.Value + 2;
                label1.Text = "Carregando..." + progressBar1.Value + "%";
            }

            else
            {

                timer1.Enabled = false;
                FrmLogin Login = new FrmLogin();
                Login.Show();
                this.Visible = false;
            } 

        }

        private void FrmSplash_Load(object sender, EventArgs e)
        {

        }
    }
}
