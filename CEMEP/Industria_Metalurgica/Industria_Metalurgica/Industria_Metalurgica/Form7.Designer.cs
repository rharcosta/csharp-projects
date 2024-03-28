namespace Industria_Metalurgica
{
    partial class FrmContas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmContas));
            System.Windows.Forms.Label código_ContLabel;
            System.Windows.Forms.Label códigoForn_ContLabel;
            System.Windows.Forms.Label produto_ContLabel;
            System.Windows.Forms.Label data_ContLabel;
            System.Windows.Forms.Label responsável_ContLabel;
            System.Windows.Forms.Label hora_ContLabel;
            System.Windows.Forms.Label valor_ContLabel;
            System.Windows.Forms.Label tipoPagamento_ContLabel;
            System.Windows.Forms.Label valorJuros_ContLabel;
            this.contasBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.contasBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.código_ContTextBox = new System.Windows.Forms.TextBox();
            this.códigoForn_ContTextBox = new System.Windows.Forms.TextBox();
            this.produto_ContTextBox = new System.Windows.Forms.TextBox();
            this.data_ContDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.responsável_ContTextBox = new System.Windows.Forms.TextBox();
            this.hora_ContDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.valor_ContMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.tipoPagamento_ContComboBox = new System.Windows.Forms.ComboBox();
            this.valorJuros_ContMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.contasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.industria_MetalurgicaDataSet = new Industria_Metalurgica.Industria_MetalurgicaDataSet();
            this.contasTableAdapter = new Industria_Metalurgica.Industria_MetalurgicaDataSetTableAdapters.ContasTableAdapter();
            this.tableAdapterManager = new Industria_Metalurgica.Industria_MetalurgicaDataSetTableAdapters.TableAdapterManager();
            this.button2 = new System.Windows.Forms.Button();
            código_ContLabel = new System.Windows.Forms.Label();
            códigoForn_ContLabel = new System.Windows.Forms.Label();
            produto_ContLabel = new System.Windows.Forms.Label();
            data_ContLabel = new System.Windows.Forms.Label();
            responsável_ContLabel = new System.Windows.Forms.Label();
            hora_ContLabel = new System.Windows.Forms.Label();
            valor_ContLabel = new System.Windows.Forms.Label();
            tipoPagamento_ContLabel = new System.Windows.Forms.Label();
            valorJuros_ContLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.contasBindingNavigator)).BeginInit();
            this.contasBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.industria_MetalurgicaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // contasBindingNavigator
            // 
            this.contasBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.contasBindingNavigator.BindingSource = this.contasBindingSource;
            this.contasBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.contasBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.contasBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.contasBindingNavigatorSaveItem});
            this.contasBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.contasBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.contasBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.contasBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.contasBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.contasBindingNavigator.Name = "contasBindingNavigator";
            this.contasBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.contasBindingNavigator.Size = new System.Drawing.Size(488, 25);
            this.contasBindingNavigator.TabIndex = 0;
            this.contasBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
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
            // contasBindingNavigatorSaveItem
            // 
            this.contasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.contasBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("contasBindingNavigatorSaveItem.Image")));
            this.contasBindingNavigatorSaveItem.Name = "contasBindingNavigatorSaveItem";
            this.contasBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.contasBindingNavigatorSaveItem.Text = "Save Data";
            this.contasBindingNavigatorSaveItem.Click += new System.EventHandler(this.contasBindingNavigatorSaveItem_Click_1);
            // 
            // código_ContLabel
            // 
            código_ContLabel.AutoSize = true;
            código_ContLabel.BackColor = System.Drawing.Color.Transparent;
            código_ContLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            código_ContLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            código_ContLabel.Location = new System.Drawing.Point(23, 71);
            código_ContLabel.Name = "código_ContLabel";
            código_ContLabel.Size = new System.Drawing.Size(84, 30);
            código_ContLabel.TabIndex = 1;
            código_ContLabel.Text = "Código:";
            // 
            // código_ContTextBox
            // 
            this.código_ContTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contasBindingSource, "Código_Cont", true));
            this.código_ContTextBox.Location = new System.Drawing.Point(232, 71);
            this.código_ContTextBox.Name = "código_ContTextBox";
            this.código_ContTextBox.ReadOnly = true;
            this.código_ContTextBox.Size = new System.Drawing.Size(200, 20);
            this.código_ContTextBox.TabIndex = 2;
            this.código_ContTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // códigoForn_ContLabel
            // 
            códigoForn_ContLabel.AutoSize = true;
            códigoForn_ContLabel.BackColor = System.Drawing.Color.Transparent;
            códigoForn_ContLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            códigoForn_ContLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            códigoForn_ContLabel.Location = new System.Drawing.Point(23, 97);
            códigoForn_ContLabel.Name = "códigoForn_ContLabel";
            códigoForn_ContLabel.Size = new System.Drawing.Size(194, 30);
            códigoForn_ContLabel.TabIndex = 3;
            códigoForn_ContLabel.Text = "Código Fornecedor:";
            // 
            // códigoForn_ContTextBox
            // 
            this.códigoForn_ContTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contasBindingSource, "CódigoForn_Cont", true));
            this.códigoForn_ContTextBox.Location = new System.Drawing.Point(232, 97);
            this.códigoForn_ContTextBox.Name = "códigoForn_ContTextBox";
            this.códigoForn_ContTextBox.Size = new System.Drawing.Size(200, 20);
            this.códigoForn_ContTextBox.TabIndex = 4;
            this.códigoForn_ContTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // produto_ContLabel
            // 
            produto_ContLabel.AutoSize = true;
            produto_ContLabel.BackColor = System.Drawing.Color.Transparent;
            produto_ContLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            produto_ContLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            produto_ContLabel.Location = new System.Drawing.Point(23, 123);
            produto_ContLabel.Name = "produto_ContLabel";
            produto_ContLabel.Size = new System.Drawing.Size(92, 30);
            produto_ContLabel.TabIndex = 5;
            produto_ContLabel.Text = "Produto:";
            // 
            // produto_ContTextBox
            // 
            this.produto_ContTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contasBindingSource, "Produto_Cont", true));
            this.produto_ContTextBox.Location = new System.Drawing.Point(232, 123);
            this.produto_ContTextBox.Name = "produto_ContTextBox";
            this.produto_ContTextBox.Size = new System.Drawing.Size(200, 20);
            this.produto_ContTextBox.TabIndex = 6;
            this.produto_ContTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // data_ContLabel
            // 
            data_ContLabel.AutoSize = true;
            data_ContLabel.BackColor = System.Drawing.Color.Transparent;
            data_ContLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            data_ContLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            data_ContLabel.Location = new System.Drawing.Point(23, 150);
            data_ContLabel.Name = "data_ContLabel";
            data_ContLabel.Size = new System.Drawing.Size(62, 30);
            data_ContLabel.TabIndex = 7;
            data_ContLabel.Text = "Data:";
            // 
            // data_ContDateTimePicker
            // 
            this.data_ContDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.contasBindingSource, "Data_Cont", true));
            this.data_ContDateTimePicker.Location = new System.Drawing.Point(232, 149);
            this.data_ContDateTimePicker.Name = "data_ContDateTimePicker";
            this.data_ContDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.data_ContDateTimePicker.TabIndex = 8;
            // 
            // responsável_ContLabel
            // 
            responsável_ContLabel.AutoSize = true;
            responsável_ContLabel.BackColor = System.Drawing.Color.Transparent;
            responsável_ContLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            responsável_ContLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            responsável_ContLabel.Location = new System.Drawing.Point(23, 175);
            responsável_ContLabel.Name = "responsável_ContLabel";
            responsável_ContLabel.Size = new System.Drawing.Size(132, 30);
            responsável_ContLabel.TabIndex = 9;
            responsável_ContLabel.Text = "Responsável:";
            // 
            // responsável_ContTextBox
            // 
            this.responsável_ContTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contasBindingSource, "Responsável_Cont", true));
            this.responsável_ContTextBox.Location = new System.Drawing.Point(232, 175);
            this.responsável_ContTextBox.Name = "responsável_ContTextBox";
            this.responsável_ContTextBox.Size = new System.Drawing.Size(200, 20);
            this.responsável_ContTextBox.TabIndex = 10;
            this.responsável_ContTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // hora_ContLabel
            // 
            hora_ContLabel.AutoSize = true;
            hora_ContLabel.BackColor = System.Drawing.Color.Transparent;
            hora_ContLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            hora_ContLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            hora_ContLabel.Location = new System.Drawing.Point(23, 202);
            hora_ContLabel.Name = "hora_ContLabel";
            hora_ContLabel.Size = new System.Drawing.Size(63, 30);
            hora_ContLabel.TabIndex = 11;
            hora_ContLabel.Text = "Hora:";
            // 
            // hora_ContDateTimePicker
            // 
            this.hora_ContDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.contasBindingSource, "Hora_Cont", true));
            this.hora_ContDateTimePicker.Location = new System.Drawing.Point(232, 201);
            this.hora_ContDateTimePicker.Name = "hora_ContDateTimePicker";
            this.hora_ContDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.hora_ContDateTimePicker.TabIndex = 12;
            // 
            // valor_ContLabel
            // 
            valor_ContLabel.AutoSize = true;
            valor_ContLabel.BackColor = System.Drawing.Color.Transparent;
            valor_ContLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            valor_ContLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            valor_ContLabel.Location = new System.Drawing.Point(23, 227);
            valor_ContLabel.Name = "valor_ContLabel";
            valor_ContLabel.Size = new System.Drawing.Size(64, 30);
            valor_ContLabel.TabIndex = 13;
            valor_ContLabel.Text = "Valor:";
            // 
            // valor_ContMaskedTextBox
            // 
            this.valor_ContMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contasBindingSource, "Valor_Cont", true));
            this.valor_ContMaskedTextBox.Location = new System.Drawing.Point(232, 227);
            this.valor_ContMaskedTextBox.Name = "valor_ContMaskedTextBox";
            this.valor_ContMaskedTextBox.Size = new System.Drawing.Size(200, 20);
            this.valor_ContMaskedTextBox.TabIndex = 14;
            this.valor_ContMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tipoPagamento_ContLabel
            // 
            tipoPagamento_ContLabel.AutoSize = true;
            tipoPagamento_ContLabel.BackColor = System.Drawing.Color.Transparent;
            tipoPagamento_ContLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            tipoPagamento_ContLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            tipoPagamento_ContLabel.Location = new System.Drawing.Point(23, 253);
            tipoPagamento_ContLabel.Name = "tipoPagamento_ContLabel";
            tipoPagamento_ContLabel.Size = new System.Drawing.Size(169, 30);
            tipoPagamento_ContLabel.TabIndex = 15;
            tipoPagamento_ContLabel.Text = "Tipo Pagamento:";
            // 
            // tipoPagamento_ContComboBox
            // 
            this.tipoPagamento_ContComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contasBindingSource, "TipoPagamento_Cont", true));
            this.tipoPagamento_ContComboBox.FormattingEnabled = true;
            this.tipoPagamento_ContComboBox.Items.AddRange(new object[] {
            "Á Vista ",
            "Crédito",
            "Debito"});
            this.tipoPagamento_ContComboBox.Location = new System.Drawing.Point(232, 253);
            this.tipoPagamento_ContComboBox.Name = "tipoPagamento_ContComboBox";
            this.tipoPagamento_ContComboBox.Size = new System.Drawing.Size(200, 21);
            this.tipoPagamento_ContComboBox.TabIndex = 16;
            // 
            // valorJuros_ContLabel
            // 
            valorJuros_ContLabel.AutoSize = true;
            valorJuros_ContLabel.BackColor = System.Drawing.Color.Transparent;
            valorJuros_ContLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            valorJuros_ContLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            valorJuros_ContLabel.Location = new System.Drawing.Point(23, 280);
            valorJuros_ContLabel.Name = "valorJuros_ContLabel";
            valorJuros_ContLabel.Size = new System.Drawing.Size(118, 30);
            valorJuros_ContLabel.TabIndex = 17;
            valorJuros_ContLabel.Text = "Valor Juros:";
            // 
            // valorJuros_ContMaskedTextBox
            // 
            this.valorJuros_ContMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contasBindingSource, "ValorJuros_Cont", true));
            this.valorJuros_ContMaskedTextBox.Location = new System.Drawing.Point(232, 280);
            this.valorJuros_ContMaskedTextBox.Mask = "$";
            this.valorJuros_ContMaskedTextBox.Name = "valorJuros_ContMaskedTextBox";
            this.valorJuros_ContMaskedTextBox.Size = new System.Drawing.Size(200, 20);
            this.valorJuros_ContMaskedTextBox.TabIndex = 18;
            this.valorJuros_ContMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // contasBindingSource
            // 
            this.contasBindingSource.DataMember = "Contas";
            this.contasBindingSource.DataSource = this.industria_MetalurgicaDataSet;
            // 
            // industria_MetalurgicaDataSet
            // 
            this.industria_MetalurgicaDataSet.DataSetName = "Industria_MetalurgicaDataSet";
            this.industria_MetalurgicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contasTableAdapter
            // 
            this.contasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientesTableAdapter = null;
            this.tableAdapterManager.ComprasTableAdapter = null;
            this.tableAdapterManager.ContasTableAdapter = this.contasTableAdapter;
            this.tableAdapterManager.FornecedoresTableAdapter = null;
            this.tableAdapterManager.FuncionáriosTableAdapter = null;
            this.tableAdapterManager.LoginTableAdapter = null;
            this.tableAdapterManager.Nota_fiscalTableAdapter = null;
            this.tableAdapterManager.ProdutosTableAdapter = null;
            this.tableAdapterManager.TransportadorasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Industria_Metalurgica.Industria_MetalurgicaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VendasTableAdapter = null;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Lucida Sans", 11.25F);
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(344, 325);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 30);
            this.button2.TabIndex = 43;
            this.button2.Text = "&Fechar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmContas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(488, 367);
            this.Controls.Add(this.button2);
            this.Controls.Add(código_ContLabel);
            this.Controls.Add(this.código_ContTextBox);
            this.Controls.Add(códigoForn_ContLabel);
            this.Controls.Add(this.códigoForn_ContTextBox);
            this.Controls.Add(produto_ContLabel);
            this.Controls.Add(this.produto_ContTextBox);
            this.Controls.Add(data_ContLabel);
            this.Controls.Add(this.data_ContDateTimePicker);
            this.Controls.Add(responsável_ContLabel);
            this.Controls.Add(this.responsável_ContTextBox);
            this.Controls.Add(hora_ContLabel);
            this.Controls.Add(this.hora_ContDateTimePicker);
            this.Controls.Add(valor_ContLabel);
            this.Controls.Add(this.valor_ContMaskedTextBox);
            this.Controls.Add(tipoPagamento_ContLabel);
            this.Controls.Add(this.tipoPagamento_ContComboBox);
            this.Controls.Add(valorJuros_ContLabel);
            this.Controls.Add(this.valorJuros_ContMaskedTextBox);
            this.Controls.Add(this.contasBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmContas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contas";
            this.Load += new System.EventHandler(this.FrmContas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contasBindingNavigator)).EndInit();
            this.contasBindingNavigator.ResumeLayout(false);
            this.contasBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.industria_MetalurgicaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Industria_MetalurgicaDataSet industria_MetalurgicaDataSet;
        private System.Windows.Forms.BindingSource contasBindingSource;
        private Industria_Metalurgica.Industria_MetalurgicaDataSetTableAdapters.ContasTableAdapter contasTableAdapter;
        private Industria_Metalurgica.Industria_MetalurgicaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator contasBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton contasBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox código_ContTextBox;
        private System.Windows.Forms.TextBox códigoForn_ContTextBox;
        private System.Windows.Forms.TextBox produto_ContTextBox;
        private System.Windows.Forms.DateTimePicker data_ContDateTimePicker;
        private System.Windows.Forms.TextBox responsável_ContTextBox;
        private System.Windows.Forms.DateTimePicker hora_ContDateTimePicker;
        private System.Windows.Forms.MaskedTextBox valor_ContMaskedTextBox;
        private System.Windows.Forms.ComboBox tipoPagamento_ContComboBox;
        private System.Windows.Forms.MaskedTextBox valorJuros_ContMaskedTextBox;
        private System.Windows.Forms.Button button2;

    }
}