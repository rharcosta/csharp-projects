using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Proj3W
{
    public partial class FrmEmp : Form
    {
        public FrmEmp()
        {
            InitializeComponent();
        }

        private void tabCliempresaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

            this.Validate();
            this.tabCliempresaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bD3WDataSet);

        }

        private void FrmEmp_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD3WDataSet.TabCliempresa' table. You can move, or remove it, as needed.
            this.tabCliempresaTableAdapter.Fill(this.bD3WDataSet.TabCliempresa);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close(); 
        }

        private void FrmEmp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)13)
                SendKeys.Send("{Tab}"); 
        }
    }
}
