﻿using System;
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
            if (progressBar1.Value < 100)
            {
                progressBar1.Value = progressBar1.Value + 2;
                label2.Text = "Carregando " + progressBar1.Value + "%";
            }
            else
            {
                timer1.Enabled = false; 
                Frmvenda Cadastro= new Frmvenda(); 
                Cadastro.Show();     
                this.Visible= false;
            } 

        }

        private void Frmsplash_Load(object sender, EventArgs e)
        {

        }

         

    }
}
