using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Proj0502
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "Aula") && (textBox2.Text == "0502")){
                FrmPrin Principal = new FrmPrin(); 
                Principal.Show();
                Close(); 
            }
                else 
                MessageBox.Show("Usuário ou senha inválidos"); 
            

        }
    }
}
