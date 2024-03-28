namespace Proj0703
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            System.Windows.Forms.Label codProfLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label disciplinaLabel;
            this.bD0703DataSet = new Proj0703.BD0703DataSet();
            this.tabProfBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabProfTableAdapter = new Proj0703.BD0703DataSetTableAdapters.TabProfTableAdapter();
            this.tableAdapterManager = new Proj0703.BD0703DataSetTableAdapters.TableAdapterManager();
            this.tabProfBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.tabProfBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.codProfTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.disciplinaTextBox = new System.Windows.Forms.TextBox();
            codProfLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            disciplinaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bD0703DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabProfBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabProfBindingNavigator)).BeginInit();
            this.tabProfBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // bD0703DataSet
            // 
            this.bD0703DataSet.DataSetName = "BD0703DataSet";
            this.bD0703DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabProfBindingSource
            // 
            this.tabProfBindingSource.DataMember = "TabProf";
            this.tabProfBindingSource.DataSource = this.bD0703DataSet;
            // 
            // tabProfTableAdapter
            // 
            this.tabProfTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TabAlunoTableAdapter = null;
            this.tableAdapterManager.TabDisciplinaTableAdapter = null;
            this.tableAdapterManager.TabProfTableAdapter = this.tabProfTableAdapter;
            this.tableAdapterManager.TabSalaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Proj0703.BD0703DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tabProfBindingNavigator
            // 
            this.tabProfBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tabProfBindingNavigator.BindingSource = this.tabProfBindingSource;
            this.tabProfBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tabProfBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tabProfBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tabProfBindingNavigatorSaveItem});
            this.tabProfBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tabProfBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tabProfBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tabProfBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tabProfBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tabProfBindingNavigator.Name = "tabProfBindingNavigator";
            this.tabProfBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tabProfBindingNavigator.Size = new System.Drawing.Size(292, 25);
            this.tabProfBindingNavigator.TabIndex = 0;
            this.tabProfBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 13);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // tabProfBindingNavigatorSaveItem
            // 
            this.tabProfBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tabProfBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tabProfBindingNavigatorSaveItem.Image")));
            this.tabProfBindingNavigatorSaveItem.Name = "tabProfBindingNavigatorSaveItem";
            this.tabProfBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.tabProfBindingNavigatorSaveItem.Text = "Save Data";
            this.tabProfBindingNavigatorSaveItem.Click += new System.EventHandler(this.tabProfBindingNavigatorSaveItem_Click);
            // 
            // codProfLabel
            // 
            codProfLabel.AutoSize = true;
            codProfLabel.Location = new System.Drawing.Point(64, 105);
            codProfLabel.Name = "codProfLabel";
            codProfLabel.Size = new System.Drawing.Size(51, 13);
            codProfLabel.TabIndex = 1;
            codProfLabel.Text = "Cod Prof:";
            // 
            // codProfTextBox
            // 
            this.codProfTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabProfBindingSource, "CodProf", true));
            this.codProfTextBox.Location = new System.Drawing.Point(125, 102);
            this.codProfTextBox.Name = "codProfTextBox";
            this.codProfTextBox.Size = new System.Drawing.Size(100, 20);
            this.codProfTextBox.TabIndex = 2;
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(64, 131);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(38, 13);
            nomeLabel.TabIndex = 3;
            nomeLabel.Text = "Nome:";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabProfBindingSource, "Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(125, 128);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(100, 20);
            this.nomeTextBox.TabIndex = 4;
            // 
            // disciplinaLabel
            // 
            disciplinaLabel.AutoSize = true;
            disciplinaLabel.Location = new System.Drawing.Point(64, 157);
            disciplinaLabel.Name = "disciplinaLabel";
            disciplinaLabel.Size = new System.Drawing.Size(55, 13);
            disciplinaLabel.TabIndex = 5;
            disciplinaLabel.Text = "Disciplina:";
            // 
            // disciplinaTextBox
            // 
            this.disciplinaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabProfBindingSource, "Disciplina", true));
            this.disciplinaTextBox.Location = new System.Drawing.Point(125, 154);
            this.disciplinaTextBox.Name = "disciplinaTextBox";
            this.disciplinaTextBox.Size = new System.Drawing.Size(100, 20);
            this.disciplinaTextBox.TabIndex = 6;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(codProfLabel);
            this.Controls.Add(this.codProfTextBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(disciplinaLabel);
            this.Controls.Add(this.disciplinaTextBox);
            this.Controls.Add(this.tabProfBindingNavigator);
            this.Name = "Form3";
            this.Text = "Professor";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bD0703DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabProfBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabProfBindingNavigator)).EndInit();
            this.tabProfBindingNavigator.ResumeLayout(false);
            this.tabProfBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BD0703DataSet bD0703DataSet;
        private System.Windows.Forms.BindingSource tabProfBindingSource;
        private Proj0703.BD0703DataSetTableAdapters.TabProfTableAdapter tabProfTableAdapter;
        private Proj0703.BD0703DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tabProfBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tabProfBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox codProfTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox disciplinaTextBox;
    }
}