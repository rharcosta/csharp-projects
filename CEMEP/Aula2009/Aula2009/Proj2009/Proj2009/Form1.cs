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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btadicionar_Click(object sender, EventArgs e)
        {
            String nome = Txtnome.Text;
            Lstnome.Items.Add(nome);
            Txtnome.Clear();
            Txtnome.Focus();
        }

        private void Btsair_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void Btremove_Click(object sender, EventArgs e)
        {
            int valor = Lstnome.SelectedIndex;
            if (valor == -1)
            {
                MessageBox.Show("Para excluir um item da lista é necessário selecioná-lo primeiro"
                    , "Excluindo item da lista", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Txtnome.Focus();
            }
            else
            {
                Lstnome.Items.RemoveAt(valor);
            }

        }

        private void Btremovetudo_Click(object sender, EventArgs e)
        {
            if (Lstnome.Items.Count == 0)
            {
                MessageBox.Show("A lista está vazia! Adicione primeiro um item, para depois remove-lo",
                    "Excluindo item da lista", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Txtnome.Focus();
            }
            else
            {
                Lstnome.Items.Clear();
                Txtnome.Focus(); 
            }

        }

        private void Btcancela_Click(object sender, EventArgs e)
        {
            Txtnome.Clear();
            Txtnome.Focus();
        }
    }
}
