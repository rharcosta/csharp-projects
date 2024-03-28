namespace Proj3W
{
    partial class FrmVagas
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
            System.Windows.Forms.Label codVagaLabel;
            System.Windows.Forms.Label empresaLabel;
            System.Windows.Forms.Label salarioLabel;
            System.Windows.Forms.Label cHLabel;
            System.Windows.Forms.Label dataSolicitacaoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVagas));
            this.button1 = new System.Windows.Forms.Button();
            this.bD3WDataSet = new Proj3W.BD3WDataSet();
            this.tabVagasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabVagasTableAdapter = new Proj3W.BD3WDataSetTableAdapters.TabVagasTableAdapter();
            this.tableAdapterManager = new Proj3W.BD3WDataSetTableAdapters.TableAdapterManager();
            this.tabVagasBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tabVagasBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.codVagaTextBox = new System.Windows.Forms.TextBox();
            this.empresaTextBox = new System.Windows.Forms.TextBox();
            this.salarioTextBox = new System.Windows.Forms.TextBox();
            this.cHComboBox = new System.Windows.Forms.ComboBox();
            this.dataSolicitacaoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bD3WDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabCliempresaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabCliempresaTableAdapter = new Proj3W.BD3WDataSetTableAdapters.TabCliempresaTableAdapter();
            codVagaLabel = new System.Windows.Forms.Label();
            empresaLabel = new System.Windows.Forms.Label();
            salarioLabel = new System.Windows.Forms.Label();
            cHLabel = new System.Windows.Forms.Label();
            dataSolicitacaoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bD3WDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabVagasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabVagasBindingNavigator)).BeginInit();
            this.tabVagasBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bD3WDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabCliempresaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // codVagaLabel
            // 
            codVagaLabel.AutoSize = true;
            codVagaLabel.BackColor = System.Drawing.Color.Transparent;
            codVagaLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F);
            codVagaLabel.ForeColor = System.Drawing.Color.White;
            codVagaLabel.Location = new System.Drawing.Point(23, 55);
            codVagaLabel.Name = "codVagaLabel";
            codVagaLabel.Size = new System.Drawing.Size(92, 25);
            codVagaLabel.TabIndex = 33;
            codVagaLabel.Text = "Código:";
            // 
            // empresaLabel
            // 
            empresaLabel.AutoSize = true;
            empresaLabel.BackColor = System.Drawing.Color.Transparent;
            empresaLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F);
            empresaLabel.ForeColor = System.Drawing.Color.White;
            empresaLabel.Location = new System.Drawing.Point(23, 81);
            empresaLabel.Name = "empresaLabel";
            empresaLabel.Size = new System.Drawing.Size(107, 25);
            empresaLabel.TabIndex = 35;
            empresaLabel.Text = "Empresa:";
            // 
            // salarioLabel
            // 
            salarioLabel.AutoSize = true;
            salarioLabel.BackColor = System.Drawing.Color.Transparent;
            salarioLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F);
            salarioLabel.ForeColor = System.Drawing.Color.White;
            salarioLabel.Location = new System.Drawing.Point(23, 107);
            salarioLabel.Name = "salarioLabel";
            salarioLabel.Size = new System.Drawing.Size(88, 25);
            salarioLabel.TabIndex = 37;
            salarioLabel.Text = "Salário:";
            // 
            // cHLabel
            // 
            cHLabel.AutoSize = true;
            cHLabel.BackColor = System.Drawing.Color.Transparent;
            cHLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F);
            cHLabel.ForeColor = System.Drawing.Color.White;
            cHLabel.Location = new System.Drawing.Point(23, 133);
            cHLabel.Name = "cHLabel";
            cHLabel.Size = new System.Drawing.Size(163, 25);
            cHLabel.TabIndex = 39;
            cHLabel.Text = "Carga Horária:";
            // 
            // dataSolicitacaoLabel
            // 
            dataSolicitacaoLabel.AutoSize = true;
            dataSolicitacaoLabel.BackColor = System.Drawing.Color.Transparent;
            dataSolicitacaoLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F);
            dataSolicitacaoLabel.ForeColor = System.Drawing.Color.White;
            dataSolicitacaoLabel.Location = new System.Drawing.Point(23, 161);
            dataSolicitacaoLabel.Name = "dataSolicitacaoLabel";
            dataSolicitacaoLabel.Size = new System.Drawing.Size(183, 25);
            dataSolicitacaoLabel.TabIndex = 41;
            dataSolicitacaoLabel.Text = "Data Solicitação:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Lucida Sans", 11.25F);
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(341, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 30);
            this.button1.TabIndex = 6;
            this.button1.Text = "&Fechar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.button1, "Fechar");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bD3WDataSet
            // 
            this.bD3WDataSet.DataSetName = "BD3WDataSet";
            this.bD3WDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabVagasBindingSource
            // 
            this.tabVagasBindingSource.DataMember = "TabVagas";
            this.tabVagasBindingSource.DataSource = this.bD3WDataSet;
            // 
            // tabVagasTableAdapter
            // 
            this.tabVagasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TabCandidatoTableAdapter = null;
            this.tableAdapterManager.TabCliempresaTableAdapter = null;
            this.tableAdapterManager.TabUsuarioTableAdapter = null;
            this.tableAdapterManager.TabVagasTableAdapter = this.tabVagasTableAdapter;
            this.tableAdapterManager.UpdateOrder = Proj3W.BD3WDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tabVagasBindingNavigator
            // 
            this.tabVagasBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tabVagasBindingNavigator.BindingSource = this.tabVagasBindingSource;
            this.tabVagasBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tabVagasBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tabVagasBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tabVagasBindingNavigatorSaveItem});
            this.tabVagasBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tabVagasBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tabVagasBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tabVagasBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tabVagasBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tabVagasBindingNavigator.Name = "tabVagasBindingNavigator";
            this.tabVagasBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tabVagasBindingNavigator.Size = new System.Drawing.Size(574, 25);
            this.tabVagasBindingNavigator.TabIndex = 33;
            this.tabVagasBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
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
            // tabVagasBindingNavigatorSaveItem
            // 
            this.tabVagasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tabVagasBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tabVagasBindingNavigatorSaveItem.Image")));
            this.tabVagasBindingNavigatorSaveItem.Name = "tabVagasBindingNavigatorSaveItem";
            this.tabVagasBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tabVagasBindingNavigatorSaveItem.Text = "Save Data";
            this.tabVagasBindingNavigatorSaveItem.Click += new System.EventHandler(this.tabVagasBindingNavigatorSaveItem_Click);
            // 
            // codVagaTextBox
            // 
            this.codVagaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabVagasBindingSource, "CodVaga", true));
            this.codVagaTextBox.Location = new System.Drawing.Point(229, 61);
            this.codVagaTextBox.Name = "codVagaTextBox";
            this.codVagaTextBox.ReadOnly = true;
            this.codVagaTextBox.Size = new System.Drawing.Size(200, 20);
            this.codVagaTextBox.TabIndex = 1;
            this.codVagaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // empresaTextBox
            // 
            this.empresaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabVagasBindingSource, "Empresa", true));
            this.empresaTextBox.Location = new System.Drawing.Point(229, 87);
            this.empresaTextBox.Name = "empresaTextBox";
            this.empresaTextBox.Size = new System.Drawing.Size(200, 20);
            this.empresaTextBox.TabIndex = 2;
            this.empresaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // salarioTextBox
            // 
            this.salarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabVagasBindingSource, "Salario", true));
            this.salarioTextBox.Location = new System.Drawing.Point(229, 113);
            this.salarioTextBox.Name = "salarioTextBox";
            this.salarioTextBox.Size = new System.Drawing.Size(200, 20);
            this.salarioTextBox.TabIndex = 3;
            this.salarioTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cHComboBox
            // 
            this.cHComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabVagasBindingSource, "CH", true));
            this.cHComboBox.FormattingEnabled = true;
            this.cHComboBox.Items.AddRange(new object[] {
            "30 horas",
            "36 horas",
            "40 horas",
            "44 horas",
            ""});
            this.cHComboBox.Location = new System.Drawing.Point(229, 139);
            this.cHComboBox.Name = "cHComboBox";
            this.cHComboBox.Size = new System.Drawing.Size(200, 21);
            this.cHComboBox.TabIndex = 4;
            // 
            // dataSolicitacaoDateTimePicker
            // 
            this.dataSolicitacaoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tabVagasBindingSource, "DataSolicitacao", true));
            this.dataSolicitacaoDateTimePicker.Location = new System.Drawing.Point(229, 166);
            this.dataSolicitacaoDateTimePicker.Name = "dataSolicitacaoDateTimePicker";
            this.dataSolicitacaoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dataSolicitacaoDateTimePicker.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.tabCliempresaBindingSource;
            this.comboBox1.DisplayMember = "CodCli";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(435, 86);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 42;
            this.comboBox1.ValueMember = "CodCli";
            // 
            // bD3WDataSetBindingSource
            // 
            this.bD3WDataSetBindingSource.DataSource = this.bD3WDataSet;
            this.bD3WDataSetBindingSource.Position = 0;
            // 
            // tabCliempresaBindingSource
            // 
            this.tabCliempresaBindingSource.DataMember = "TabCliempresa";
            this.tabCliempresaBindingSource.DataSource = this.bD3WDataSetBindingSource;
            // 
            // tabCliempresaTableAdapter
            // 
            this.tabCliempresaTableAdapter.ClearBeforeFill = true;
            // 
            // FrmVagas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(574, 257);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(codVagaLabel);
            this.Controls.Add(this.codVagaTextBox);
            this.Controls.Add(empresaLabel);
            this.Controls.Add(this.empresaTextBox);
            this.Controls.Add(salarioLabel);
            this.Controls.Add(this.salarioTextBox);
            this.Controls.Add(cHLabel);
            this.Controls.Add(this.cHComboBox);
            this.Controls.Add(dataSolicitacaoLabel);
            this.Controls.Add(this.dataSolicitacaoDateTimePicker);
            this.Controls.Add(this.tabVagasBindingNavigator);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmVagas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Vagas";
            this.Load += new System.EventHandler(this.FrmVagas_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmVagas_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.bD3WDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabVagasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabVagasBindingNavigator)).EndInit();
            this.tabVagasBindingNavigator.ResumeLayout(false);
            this.tabVagasBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bD3WDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabCliempresaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private BD3WDataSet bD3WDataSet;
        private System.Windows.Forms.BindingSource tabVagasBindingSource;
        private Proj3W.BD3WDataSetTableAdapters.TabVagasTableAdapter tabVagasTableAdapter;
        private Proj3W.BD3WDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tabVagasBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tabVagasBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox codVagaTextBox;
        private System.Windows.Forms.TextBox empresaTextBox;
        private System.Windows.Forms.TextBox salarioTextBox;
        private System.Windows.Forms.ComboBox cHComboBox;
        private System.Windows.Forms.DateTimePicker dataSolicitacaoDateTimePicker;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource bD3WDataSetBindingSource;
        private System.Windows.Forms.BindingSource tabCliempresaBindingSource;
        private Proj3W.BD3WDataSetTableAdapters.TabCliempresaTableAdapter tabCliempresaTableAdapter;
    }
}