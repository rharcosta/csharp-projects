using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Proj0703
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void tabSalaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tabSalaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bD0703DataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD0703DataSet.TabSala' table. You can move, or remove it, as needed.
            this.tabSalaTableAdapter.Fill(this.bD0703DataSet.TabSala);

        }
    }
}
