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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void tabDisciplinaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tabDisciplinaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bD0703DataSet);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD0703DataSet.TabProf' table. You can move, or remove it, as needed.
            this.tabProfTableAdapter.Fill(this.bD0703DataSet.TabProf);
            // TODO: This line of code loads data into the 'bD0703DataSet.TabDisciplina' table. You can move, or remove it, as needed.
            this.tabDisciplinaTableAdapter.Fill(this.bD0703DataSet.TabDisciplina);

        }
    }
}
