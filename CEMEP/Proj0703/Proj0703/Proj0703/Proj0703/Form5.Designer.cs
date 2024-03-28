namespace Proj0703
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label codDisciplinaLabel;
            System.Windows.Forms.Label nomeDiscLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.bD0703DataSet = new Proj0703.BD0703DataSet();
            this.tabDisciplinaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabDisciplinaTableAdapter = new Proj0703.BD0703DataSetTableAdapters.TabDisciplinaTableAdapter();
            this.tableAdapterManager = new Proj0703.BD0703DataSetTableAdapters.TableAdapterManager();
            this.tabDisciplinaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tabDisciplinaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.codDisciplinaTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bD0703DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabProfBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabProfTableAdapter = new Proj0703.BD0703DataSetTableAdapters.TabProfTableAdapter();
            codDisciplinaLabel = new System.Windows.Forms.Label();
            nomeDiscLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bD0703DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabDisciplinaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabDisciplinaBindingNavigator)).BeginInit();
            this.tabDisciplinaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bD0703DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabProfBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // codDisciplinaLabel
            // 
            codDisciplinaLabel.AutoSize = true;
            codDisciplinaLabel.Location = new System.Drawing.Point(51, 105);
            codDisciplinaLabel.Name = "codDisciplinaLabel";
            codDisciplinaLabel.Size = new System.Drawing.Size(77, 13);
            codDisciplinaLabel.TabIndex = 1;
            codDisciplinaLabel.Text = "Cod Disciplina:";
            // 
            // nomeDiscLabel
            // 
            nomeDiscLabel.AutoSize = true;
            nomeDiscLabel.Location = new System.Drawing.Point(51, 131);
            nomeDiscLabel.Name = "nomeDiscLabel";
            nomeDiscLabel.Size = new System.Drawing.Size(62, 13);
            nomeDiscLabel.TabIndex = 3;
            nomeDiscLabel.Text = "Nome Disc:";
            // 
            // bD0703DataSet
            // 
            this.bD0703DataSet.DataSetName = "BD0703DataSet";
            this.bD0703DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabDisciplinaBindingSource
            // 
            this.tabDisciplinaBindingSource.DataMember = "TabDisciplina";
            this.tabDisciplinaBindingSource.DataSource = this.bD0703DataSet;
            // 
            // tabDisciplinaTableAdapter
            // 
            this.tabDisciplinaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TabAlunoTableAdapter = null;
            this.tableAdapterManager.TabDisciplinaTableAdapter = this.tabDisciplinaTableAdapter;
            this.tableAdapterManager.TabProfTableAdapter = null;
            this.tableAdapterManager.TabSalaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Proj0703.BD0703DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tabDisciplinaBindingNavigator
            // 
            this.tabDisciplinaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tabDisciplinaBindingNavigator.BindingSource = this.tabDisciplinaBindingSource;
            this.tabDisciplinaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tabDisciplinaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tabDisciplinaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tabDisciplinaBindingNavigatorSaveItem});
            this.tabDisciplinaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tabDisciplinaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tabDisciplinaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tabDisciplinaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tabDisciplinaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tabDisciplinaBindingNavigator.Name = "tabDisciplinaBindingNavigator";
            this.tabDisciplinaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tabDisciplinaBindingNavigator.Size = new System.Drawing.Size(292, 25);
            this.tabDisciplinaBindingNavigator.TabIndex = 0;
            this.tabDisciplinaBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tabDisciplinaBindingNavigatorSaveItem
            // 
            this.tabDisciplinaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tabDisciplinaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tabDisciplinaBindingNavigatorSaveItem.Image")));
            this.tabDisciplinaBindingNavigatorSaveItem.Name = "tabDisciplinaBindingNavigatorSaveItem";
            this.tabDisciplinaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tabDisciplinaBindingNavigatorSaveItem.Text = "Save Data";
            this.tabDisciplinaBindingNavigatorSaveItem.Click += new System.EventHandler(this.tabDisciplinaBindingNavigatorSaveItem_Click);
            // 
            // codDisciplinaTextBox
            // 
            this.codDisciplinaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabDisciplinaBindingSource, "CodDisciplina", true));
            this.codDisciplinaTextBox.Location = new System.Drawing.Point(134, 102);
            this.codDisciplinaTextBox.Name = "codDisciplinaTextBox";
            this.codDisciplinaTextBox.Size = new System.Drawing.Size(100, 20);
            this.codDisciplinaTextBox.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.tabProfBindingSource;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(134, 131);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.Text = "System.Data.DataViewManagerListItemTypeDescriptor";
            // 
            // bD0703DataSetBindingSource
            // 
            this.bD0703DataSetBindingSource.DataSource = this.bD0703DataSet;
            this.bD0703DataSetBindingSource.Position = 0;
            // 
            // tabProfBindingSource
            // 
            this.tabProfBindingSource.DataMember = "TabProf";
            this.tabProfBindingSource.DataSource = this.bD0703DataSetBindingSource;
            // 
            // tabProfTableAdapter
            // 
            this.tabProfTableAdapter.ClearBeforeFill = true;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(codDisciplinaLabel);
            this.Controls.Add(this.codDisciplinaTextBox);
            this.Controls.Add(nomeDiscLabel);
            this.Controls.Add(this.tabDisciplinaBindingNavigator);
            this.Name = "Form5";
            this.Text = "Disciplina";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bD0703DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabDisciplinaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabDisciplinaBindingNavigator)).EndInit();
            this.tabDisciplinaBindingNavigator.ResumeLayout(false);
            this.tabDisciplinaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bD0703DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabProfBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BD0703DataSet bD0703DataSet;
        private System.Windows.Forms.BindingSource tabDisciplinaBindingSource;
        private Proj0703.BD0703DataSetTableAdapters.TabDisciplinaTableAdapter tabDisciplinaTableAdapter;
        private Proj0703.BD0703DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tabDisciplinaBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tabDisciplinaBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox codDisciplinaTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource bD0703DataSetBindingSource;
        private System.Windows.Forms.BindingSource tabProfBindingSource;
        private Proj0703.BD0703DataSetTableAdapters.TabProfTableAdapter tabProfTableAdapter;
    }
}