namespace Proj0703
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            System.Windows.Forms.Label codSalaLabel;
            System.Windows.Forms.Label serieLabel;
            System.Windows.Forms.Label turmaLabel;
            System.Windows.Forms.Label periodoLabel;
            this.bD0703DataSet = new Proj0703.BD0703DataSet();
            this.tabSalaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabSalaTableAdapter = new Proj0703.BD0703DataSetTableAdapters.TabSalaTableAdapter();
            this.tableAdapterManager = new Proj0703.BD0703DataSetTableAdapters.TableAdapterManager();
            this.tabSalaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tabSalaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.codSalaTextBox = new System.Windows.Forms.TextBox();
            this.serieComboBox = new System.Windows.Forms.ComboBox();
            this.turmaComboBox = new System.Windows.Forms.ComboBox();
            this.periodoComboBox = new System.Windows.Forms.ComboBox();
            codSalaLabel = new System.Windows.Forms.Label();
            serieLabel = new System.Windows.Forms.Label();
            turmaLabel = new System.Windows.Forms.Label();
            periodoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bD0703DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabSalaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabSalaBindingNavigator)).BeginInit();
            this.tabSalaBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // bD0703DataSet
            // 
            this.bD0703DataSet.DataSetName = "BD0703DataSet";
            this.bD0703DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabSalaBindingSource
            // 
            this.tabSalaBindingSource.DataMember = "TabSala";
            this.tabSalaBindingSource.DataSource = this.bD0703DataSet;
            // 
            // tabSalaTableAdapter
            // 
            this.tabSalaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TabAlunoTableAdapter = null;
            this.tableAdapterManager.TabDisciplinaTableAdapter = null;
            this.tableAdapterManager.TabProfTableAdapter = null;
            this.tableAdapterManager.TabSalaTableAdapter = this.tabSalaTableAdapter;
            this.tableAdapterManager.UpdateOrder = Proj0703.BD0703DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tabSalaBindingNavigator
            // 
            this.tabSalaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tabSalaBindingNavigator.BindingSource = this.tabSalaBindingSource;
            this.tabSalaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tabSalaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tabSalaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tabSalaBindingNavigatorSaveItem});
            this.tabSalaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tabSalaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tabSalaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tabSalaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tabSalaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tabSalaBindingNavigator.Name = "tabSalaBindingNavigator";
            this.tabSalaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tabSalaBindingNavigator.Size = new System.Drawing.Size(292, 25);
            this.tabSalaBindingNavigator.TabIndex = 0;
            this.tabSalaBindingNavigator.Text = "bindingNavigator1";
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
            // tabSalaBindingNavigatorSaveItem
            // 
            this.tabSalaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tabSalaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tabSalaBindingNavigatorSaveItem.Image")));
            this.tabSalaBindingNavigatorSaveItem.Name = "tabSalaBindingNavigatorSaveItem";
            this.tabSalaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.tabSalaBindingNavigatorSaveItem.Text = "Save Data";
            this.tabSalaBindingNavigatorSaveItem.Click += new System.EventHandler(this.tabSalaBindingNavigatorSaveItem_Click);
            // 
            // codSalaLabel
            // 
            codSalaLabel.AutoSize = true;
            codSalaLabel.Location = new System.Drawing.Point(47, 90);
            codSalaLabel.Name = "codSalaLabel";
            codSalaLabel.Size = new System.Drawing.Size(53, 13);
            codSalaLabel.TabIndex = 1;
            codSalaLabel.Text = "Cod Sala:";
            // 
            // codSalaTextBox
            // 
            this.codSalaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabSalaBindingSource, "CodSala", true));
            this.codSalaTextBox.Location = new System.Drawing.Point(106, 87);
            this.codSalaTextBox.Name = "codSalaTextBox";
            this.codSalaTextBox.Size = new System.Drawing.Size(121, 20);
            this.codSalaTextBox.TabIndex = 2;
            // 
            // serieLabel
            // 
            serieLabel.AutoSize = true;
            serieLabel.Location = new System.Drawing.Point(47, 116);
            serieLabel.Name = "serieLabel";
            serieLabel.Size = new System.Drawing.Size(34, 13);
            serieLabel.TabIndex = 3;
            serieLabel.Text = "Serie:";
            // 
            // serieComboBox
            // 
            this.serieComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabSalaBindingSource, "Serie", true));
            this.serieComboBox.FormattingEnabled = true;
            this.serieComboBox.Location = new System.Drawing.Point(106, 113);
            this.serieComboBox.Name = "serieComboBox";
            this.serieComboBox.Size = new System.Drawing.Size(121, 21);
            this.serieComboBox.TabIndex = 4;
            // 
            // turmaLabel
            // 
            turmaLabel.AutoSize = true;
            turmaLabel.Location = new System.Drawing.Point(47, 143);
            turmaLabel.Name = "turmaLabel";
            turmaLabel.Size = new System.Drawing.Size(40, 13);
            turmaLabel.TabIndex = 5;
            turmaLabel.Text = "Turma:";
            // 
            // turmaComboBox
            // 
            this.turmaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabSalaBindingSource, "Turma", true));
            this.turmaComboBox.FormattingEnabled = true;
            this.turmaComboBox.Location = new System.Drawing.Point(106, 140);
            this.turmaComboBox.Name = "turmaComboBox";
            this.turmaComboBox.Size = new System.Drawing.Size(121, 21);
            this.turmaComboBox.TabIndex = 6;
            // 
            // periodoLabel
            // 
            periodoLabel.AutoSize = true;
            periodoLabel.Location = new System.Drawing.Point(47, 170);
            periodoLabel.Name = "periodoLabel";
            periodoLabel.Size = new System.Drawing.Size(46, 13);
            periodoLabel.TabIndex = 7;
            periodoLabel.Text = "Periodo:";
            // 
            // periodoComboBox
            // 
            this.periodoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabSalaBindingSource, "Periodo", true));
            this.periodoComboBox.FormattingEnabled = true;
            this.periodoComboBox.Location = new System.Drawing.Point(106, 167);
            this.periodoComboBox.Name = "periodoComboBox";
            this.periodoComboBox.Size = new System.Drawing.Size(121, 21);
            this.periodoComboBox.TabIndex = 8;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(codSalaLabel);
            this.Controls.Add(this.codSalaTextBox);
            this.Controls.Add(serieLabel);
            this.Controls.Add(this.serieComboBox);
            this.Controls.Add(turmaLabel);
            this.Controls.Add(this.turmaComboBox);
            this.Controls.Add(periodoLabel);
            this.Controls.Add(this.periodoComboBox);
            this.Controls.Add(this.tabSalaBindingNavigator);
            this.Name = "Form4";
            this.Text = "Sala";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bD0703DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabSalaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabSalaBindingNavigator)).EndInit();
            this.tabSalaBindingNavigator.ResumeLayout(false);
            this.tabSalaBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BD0703DataSet bD0703DataSet;
        private System.Windows.Forms.BindingSource tabSalaBindingSource;
        private Proj0703.BD0703DataSetTableAdapters.TabSalaTableAdapter tabSalaTableAdapter;
        private Proj0703.BD0703DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tabSalaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tabSalaBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox codSalaTextBox;
        private System.Windows.Forms.ComboBox serieComboBox;
        private System.Windows.Forms.ComboBox turmaComboBox;
        private System.Windows.Forms.ComboBox periodoComboBox;
    }
}