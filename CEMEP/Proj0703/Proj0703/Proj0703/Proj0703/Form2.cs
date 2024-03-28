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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void tabAlunoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tabAlunoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bD0703DataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD0703DataSet.TabAluno' table. You can move, or remove it, as needed.
            this.tabAlunoTableAdapter.Fill(this.bD0703DataSet.TabAluno);

        }
    }
}
