using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Industria_Metalurgica
{
    public partial class FrmFunc : Form
    {
        public FrmFunc()
        {
            InitializeComponent();
        }

        private void funcionáriosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.funcionáriosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.industria_MetalurgicaDataSet);

        }

        private void FrmFunc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'industria_MetalurgicaDataSet.Funcionários' table. You can move, or remove it, as needed.
            this.funcionáriosTableAdapter.Fill(this.industria_MetalurgicaDataSet.Funcionários);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close(); 
        }

        private void FrmFunc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)13)
                SendKeys.Send("{Tab}");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog Carregar = new OpenFileDialog();
         if (Carregar.ShowDialog() == DialogResult.OK)
        {
          Bitmap Bit = new Bitmap (Carregar.FileName);
          Carregar.DefaultExt = "*.JPG";
          Carregar.Filter = "Imagem (*.JPG) | *.JPG";
          capaPictureBox.Image = Bit; 
        }

        }
    }
}
