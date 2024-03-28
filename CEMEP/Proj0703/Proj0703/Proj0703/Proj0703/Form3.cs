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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void tabProfBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tabProfBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bD0703DataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD0703DataSet.TabProf' table. You can move, or remove it, as needed.
            this.tabProfTableAdapter.Fill(this.bD0703DataSet.TabProf);

        }
    }
}
