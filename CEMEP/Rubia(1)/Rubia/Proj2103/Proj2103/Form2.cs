using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Proj2103
{
    public partial class FrmFilme : Form
    {
        public FrmFilme()
        {
            InitializeComponent();
        }

        private void tabFilmeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tabFilmeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bD2103DataSet);

        }

        private void FrmFilme_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD2103DataSet.TabFilme' table. You can move, or remove it, as needed.
            this.tabFilmeTableAdapter.Fill(this.bD2103DataSet.TabFilme);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close(); 

        }

        private void FrmFilme_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)13)
                SendKeys.Send("{Tab}");
        }

        
    }
}
