namespace Proj2103
{
    partial class FrmLoc
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
            System.Windows.Forms.Label codLocacaoLabel;
            System.Windows.Forms.Label clienteLabel;
            System.Windows.Forms.Label filmeLabel;
            System.Windows.Forms.Label dataRetiradaLabel;
            System.Windows.Forms.Label dataDevolucaoLabel;
            System.Windows.Forms.Label qtdDeDiasLabel;
            System.Windows.Forms.Label valorLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLoc));
            this.tabLocacaoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.tabLocacaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD2103DataSet = new Proj2103.BD2103DataSet();
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
            this.tabLocacaoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.codLocacaoTextBox = new System.Windows.Forms.TextBox();
            this.dataRetiradaMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.dataDevolucaoMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.qtdDeDiasTextBox = new System.Windows.Forms.TextBox();
            this.valorTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabLocacaoTableAdapter = new Proj2103.BD2103DataSetTableAdapters.TabLocacaoTableAdapter();
            this.tableAdapterManager = new Proj2103.BD2103DataSetTableAdapters.TableAdapterManager();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.clienteComboBox = new System.Windows.Forms.ComboBox();
            this.tabClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filmeComboBox = new System.Windows.Forms.ComboBox();
            this.tabFilmeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabClienteTableAdapter = new Proj2103.BD2103DataSetTableAdapters.TabClienteTableAdapter();
            this.tabFilmeTableAdapter = new Proj2103.BD2103DataSetTableAdapters.TabFilmeTableAdapter();
            codLocacaoLabel = new System.Windows.Forms.Label();
            clienteLabel = new System.Windows.Forms.Label();
            filmeLabel = new System.Windows.Forms.Label();
            dataRetiradaLabel = new System.Windows.Forms.Label();
            dataDevolucaoLabel = new System.Windows.Forms.Label();
            qtdDeDiasLabel = new System.Windows.Forms.Label();
            valorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tabLocacaoBindingNavigator)).BeginInit();
            this.tabLocacaoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabLocacaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD2103DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabFilmeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // codLocacaoLabel
            // 
            codLocacaoLabel.AutoSize = true;
            codLocacaoLabel.BackColor = System.Drawing.Color.Transparent;
            codLocacaoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            codLocacaoLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            codLocacaoLabel.Location = new System.Drawing.Point(17, 55);
            codLocacaoLabel.Name = "codLocacaoLabel";
            codLocacaoLabel.Size = new System.Drawing.Size(55, 16);
            codLocacaoLabel.TabIndex = 1;
            codLocacaoLabel.Text = "Código:";
            // 
            // clienteLabel
            // 
            clienteLabel.AutoSize = true;
            clienteLabel.BackColor = System.Drawing.Color.Transparent;
            clienteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            clienteLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            clienteLabel.Location = new System.Drawing.Point(17, 81);
            clienteLabel.Name = "clienteLabel";
            clienteLabel.Size = new System.Drawing.Size(52, 16);
            clienteLabel.TabIndex = 3;
            clienteLabel.Text = "Cliente:";
            // 
            // filmeLabel
            // 
            filmeLabel.AutoSize = true;
            filmeLabel.BackColor = System.Drawing.Color.Transparent;
            filmeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            filmeLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            filmeLabel.Location = new System.Drawing.Point(17, 107);
            filmeLabel.Name = "filmeLabel";
            filmeLabel.Size = new System.Drawing.Size(44, 16);
            filmeLabel.TabIndex = 5;
            filmeLabel.Text = "Filme:";
            // 
            // dataRetiradaLabel
            // 
            dataRetiradaLabel.AutoSize = true;
            dataRetiradaLabel.BackColor = System.Drawing.Color.Transparent;
            dataRetiradaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataRetiradaLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataRetiradaLabel.Location = new System.Drawing.Point(17, 133);
            dataRetiradaLabel.Name = "dataRetiradaLabel";
            dataRetiradaLabel.Size = new System.Drawing.Size(95, 16);
            dataRetiradaLabel.TabIndex = 7;
            dataRetiradaLabel.Text = "Data Retirada:";
            // 
            // dataDevolucaoLabel
            // 
            dataDevolucaoLabel.AutoSize = true;
            dataDevolucaoLabel.BackColor = System.Drawing.Color.Transparent;
            dataDevolucaoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataDevolucaoLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataDevolucaoLabel.Location = new System.Drawing.Point(17, 159);
            dataDevolucaoLabel.Name = "dataDevolucaoLabel";
            dataDevolucaoLabel.Size = new System.Drawing.Size(109, 16);
            dataDevolucaoLabel.TabIndex = 9;
            dataDevolucaoLabel.Text = "Data Devolução:";
            // 
            // qtdDeDiasLabel
            // 
            qtdDeDiasLabel.AutoSize = true;
            qtdDeDiasLabel.BackColor = System.Drawing.Color.Transparent;
            qtdDeDiasLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            qtdDeDiasLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            qtdDeDiasLabel.Location = new System.Drawing.Point(17, 185);
            qtdDeDiasLabel.Name = "qtdDeDiasLabel";
            qtdDeDiasLabel.Size = new System.Drawing.Size(82, 16);
            qtdDeDiasLabel.TabIndex = 11;
            qtdDeDiasLabel.Text = "Qtd de Dias:";
            // 
            // valorLabel
            // 
            valorLabel.AutoSize = true;
            valorLabel.BackColor = System.Drawing.Color.Transparent;
            valorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            valorLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            valorLabel.Location = new System.Drawing.Point(17, 211);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new System.Drawing.Size(43, 16);
            valorLabel.TabIndex = 13;
            valorLabel.Text = "Valor:";
            // 
            // tabLocacaoBindingNavigator
            // 
            this.tabLocacaoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tabLocacaoBindingNavigator.BindingSource = this.tabLocacaoBindingSource;
            this.tabLocacaoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tabLocacaoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tabLocacaoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tabLocacaoBindingNavigatorSaveItem});
            this.tabLocacaoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tabLocacaoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tabLocacaoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tabLocacaoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tabLocacaoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tabLocacaoBindingNavigator.Name = "tabLocacaoBindingNavigator";
            this.tabLocacaoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tabLocacaoBindingNavigator.Size = new System.Drawing.Size(317, 25);
            this.tabLocacaoBindingNavigator.TabIndex = 0;
            this.tabLocacaoBindingNavigator.Text = "bindingNavigator1";
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
            // tabLocacaoBindingSource
            // 
            this.tabLocacaoBindingSource.DataMember = "TabLocacao";
            this.tabLocacaoBindingSource.DataSource = this.bD2103DataSet;
            // 
            // bD2103DataSet
            // 
            this.bD2103DataSet.DataSetName = "BD2103DataSet";
            this.bD2103DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tabLocacaoBindingNavigatorSaveItem
            // 
            this.tabLocacaoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tabLocacaoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tabLocacaoBindingNavigatorSaveItem.Image")));
            this.tabLocacaoBindingNavigatorSaveItem.Name = "tabLocacaoBindingNavigatorSaveItem";
            this.tabLocacaoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tabLocacaoBindingNavigatorSaveItem.Text = "Save Data";
            this.tabLocacaoBindingNavigatorSaveItem.Click += new System.EventHandler(this.tabLocacaoBindingNavigatorSaveItem_Click);
            // 
            // codLocacaoTextBox
            // 
            this.codLocacaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabLocacaoBindingSource, "CodLocacao", true));
            this.codLocacaoTextBox.Location = new System.Drawing.Point(132, 51);
            this.codLocacaoTextBox.Name = "codLocacaoTextBox";
            this.codLocacaoTextBox.Size = new System.Drawing.Size(100, 20);
            this.codLocacaoTextBox.TabIndex = 2;
            this.codLocacaoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataRetiradaMaskedTextBox
            // 
            this.dataRetiradaMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabLocacaoBindingSource, "DataRetirada", true));
            this.dataRetiradaMaskedTextBox.Location = new System.Drawing.Point(132, 129);
            this.dataRetiradaMaskedTextBox.Mask = "00/00/0000";
            this.dataRetiradaMaskedTextBox.Name = "dataRetiradaMaskedTextBox";
            this.dataRetiradaMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.dataRetiradaMaskedTextBox.TabIndex = 8;
            this.dataRetiradaMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dataRetiradaMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // dataDevolucaoMaskedTextBox
            // 
            this.dataDevolucaoMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabLocacaoBindingSource, "DataDevolucao", true));
            this.dataDevolucaoMaskedTextBox.Location = new System.Drawing.Point(132, 155);
            this.dataDevolucaoMaskedTextBox.Mask = "00/00/0000";
            this.dataDevolucaoMaskedTextBox.Name = "dataDevolucaoMaskedTextBox";
            this.dataDevolucaoMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.dataDevolucaoMaskedTextBox.TabIndex = 10;
            this.dataDevolucaoMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dataDevolucaoMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // qtdDeDiasTextBox
            // 
            this.qtdDeDiasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabLocacaoBindingSource, "QtdDeDias", true));
            this.qtdDeDiasTextBox.Location = new System.Drawing.Point(132, 181);
            this.qtdDeDiasTextBox.Name = "qtdDeDiasTextBox";
            this.qtdDeDiasTextBox.Size = new System.Drawing.Size(100, 20);
            this.qtdDeDiasTextBox.TabIndex = 12;
            this.qtdDeDiasTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // valorTextBox
            // 
            this.valorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabLocacaoBindingSource, "Valor", true));
            this.valorTextBox.Location = new System.Drawing.Point(132, 207);
            this.valorTextBox.Name = "valorTextBox";
            this.valorTextBox.Size = new System.Drawing.Size(100, 20);
            this.valorTextBox.TabIndex = 14;
            this.valorTextBox.Text = "R$";
            this.valorTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(157, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "&Fechar";
            this.toolTip1.SetToolTip(this.button1, "Fechar");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabLocacaoTableAdapter
            // 
            this.tabLocacaoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TabClienteTableAdapter = null;
            this.tableAdapterManager.TabFilmeTableAdapter = null;
            this.tableAdapterManager.TabLocacaoTableAdapter = this.tabLocacaoTableAdapter;
            this.tableAdapterManager.UpdateOrder = Proj2103.BD2103DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // clienteComboBox
            // 
            this.clienteComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabLocacaoBindingSource, "Cliente", true));
            this.clienteComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tabLocacaoBindingSource, "Cliente", true));
            this.clienteComboBox.DataSource = this.tabClienteBindingSource;
            this.clienteComboBox.DisplayMember = "CodCliente";
            this.clienteComboBox.FormattingEnabled = true;
            this.clienteComboBox.Location = new System.Drawing.Point(132, 77);
            this.clienteComboBox.Name = "clienteComboBox";
            this.clienteComboBox.Size = new System.Drawing.Size(100, 21);
            this.clienteComboBox.TabIndex = 23;
            this.clienteComboBox.ValueMember = "CodCliente";
            // 
            // tabClienteBindingSource
            // 
            this.tabClienteBindingSource.DataMember = "TabCliente";
            this.tabClienteBindingSource.DataSource = this.bD2103DataSet;
            // 
            // filmeComboBox
            // 
            this.filmeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabLocacaoBindingSource, "Filme", true));
            this.filmeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tabLocacaoBindingSource, "Filme", true));
            this.filmeComboBox.DataSource = this.tabFilmeBindingSource;
            this.filmeComboBox.DisplayMember = "CodFilme";
            this.filmeComboBox.FormattingEnabled = true;
            this.filmeComboBox.Location = new System.Drawing.Point(132, 104);
            this.filmeComboBox.Name = "filmeComboBox";
            this.filmeComboBox.Size = new System.Drawing.Size(100, 21);
            this.filmeComboBox.TabIndex = 24;
            this.filmeComboBox.ValueMember = "CodFilme";
            // 
            // tabFilmeBindingSource
            // 
            this.tabFilmeBindingSource.DataMember = "TabFilme";
            this.tabFilmeBindingSource.DataSource = this.bD2103DataSet;
            // 
            // tabClienteTableAdapter
            // 
            this.tabClienteTableAdapter.ClearBeforeFill = true;
            // 
            // tabFilmeTableAdapter
            // 
            this.tabFilmeTableAdapter.ClearBeforeFill = true;
            // 
            // FrmLoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(317, 295);
            this.Controls.Add(this.filmeComboBox);
            this.Controls.Add(this.clienteComboBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(codLocacaoLabel);
            this.Controls.Add(this.codLocacaoTextBox);
            this.Controls.Add(clienteLabel);
            this.Controls.Add(filmeLabel);
            this.Controls.Add(dataRetiradaLabel);
            this.Controls.Add(this.dataRetiradaMaskedTextBox);
            this.Controls.Add(dataDevolucaoLabel);
            this.Controls.Add(this.dataDevolucaoMaskedTextBox);
            this.Controls.Add(qtdDeDiasLabel);
            this.Controls.Add(this.qtdDeDiasTextBox);
            this.Controls.Add(valorLabel);
            this.Controls.Add(this.valorTextBox);
            this.Controls.Add(this.tabLocacaoBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Locação";
            this.Load += new System.EventHandler(this.FrmLoc_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmLoc_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.tabLocacaoBindingNavigator)).EndInit();
            this.tabLocacaoBindingNavigator.ResumeLayout(false);
            this.tabLocacaoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabLocacaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD2103DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabFilmeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BD2103DataSet bD2103DataSet;
        private System.Windows.Forms.BindingSource tabLocacaoBindingSource;
        private Proj2103.BD2103DataSetTableAdapters.TabLocacaoTableAdapter tabLocacaoTableAdapter;
        private Proj2103.BD2103DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tabLocacaoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tabLocacaoBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox codLocacaoTextBox;
        private System.Windows.Forms.MaskedTextBox dataRetiradaMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox dataDevolucaoMaskedTextBox;
        private System.Windows.Forms.TextBox qtdDeDiasTextBox;
        private System.Windows.Forms.TextBox valorTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox clienteComboBox;
        private System.Windows.Forms.ComboBox filmeComboBox;
        private System.Windows.Forms.BindingSource tabClienteBindingSource;
        private Proj2103.BD2103DataSetTableAdapters.TabClienteTableAdapter tabClienteTableAdapter;
        private System.Windows.Forms.BindingSource tabFilmeBindingSource;
        private Proj2103.BD2103DataSetTableAdapters.TabFilmeTableAdapter tabFilmeTableAdapter;
    }
}