namespace Industria_Metalurgica
{
    partial class FrmProdutos
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
            System.Windows.Forms.Label código_ProdLabel;
            System.Windows.Forms.Label códigoForn_ProdLabel;
            System.Windows.Forms.Label produto_ProdLabel;
            System.Windows.Forms.Label descrição_ProdLabel;
            System.Windows.Forms.Label fabricação_ProdLabel;
            System.Windows.Forms.Label validade_ProdLabel;
            System.Windows.Forms.Label unidade_ProdLabel;
            System.Windows.Forms.Label cat_ProdLabel;
            System.Windows.Forms.Label forn_ProdLabel;
            System.Windows.Forms.Label valor_ProdLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProdutos));
            this.industria_MetalurgicaDataSet = new Industria_Metalurgica.Industria_MetalurgicaDataSet();
            this.produtosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtosTableAdapter = new Industria_Metalurgica.Industria_MetalurgicaDataSetTableAdapters.ProdutosTableAdapter();
            this.tableAdapterManager = new Industria_Metalurgica.Industria_MetalurgicaDataSetTableAdapters.TableAdapterManager();
            this.produtosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.produtosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.código_ProdTextBox = new System.Windows.Forms.TextBox();
            this.códigoForn_ProdTextBox = new System.Windows.Forms.TextBox();
            this.produto_ProdTextBox = new System.Windows.Forms.TextBox();
            this.descrição_ProdTextBox = new System.Windows.Forms.TextBox();
            this.fabricação_ProdDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.validade_ProdDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.unidade_ProdTextBox = new System.Windows.Forms.TextBox();
            this.cat_ProdComboBox = new System.Windows.Forms.ComboBox();
            this.forn_ProdTextBox = new System.Windows.Forms.TextBox();
            this.valor_ProdMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.button2 = new System.Windows.Forms.Button();
            código_ProdLabel = new System.Windows.Forms.Label();
            códigoForn_ProdLabel = new System.Windows.Forms.Label();
            produto_ProdLabel = new System.Windows.Forms.Label();
            descrição_ProdLabel = new System.Windows.Forms.Label();
            fabricação_ProdLabel = new System.Windows.Forms.Label();
            validade_ProdLabel = new System.Windows.Forms.Label();
            unidade_ProdLabel = new System.Windows.Forms.Label();
            cat_ProdLabel = new System.Windows.Forms.Label();
            forn_ProdLabel = new System.Windows.Forms.Label();
            valor_ProdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.industria_MetalurgicaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingNavigator)).BeginInit();
            this.produtosBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // código_ProdLabel
            // 
            código_ProdLabel.AutoSize = true;
            código_ProdLabel.BackColor = System.Drawing.Color.Transparent;
            código_ProdLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            código_ProdLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            código_ProdLabel.Location = new System.Drawing.Point(30, 63);
            código_ProdLabel.Name = "código_ProdLabel";
            código_ProdLabel.Size = new System.Drawing.Size(84, 30);
            código_ProdLabel.TabIndex = 1;
            código_ProdLabel.Text = "Código:";
            // 
            // códigoForn_ProdLabel
            // 
            códigoForn_ProdLabel.AutoSize = true;
            códigoForn_ProdLabel.BackColor = System.Drawing.Color.Transparent;
            códigoForn_ProdLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            códigoForn_ProdLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            códigoForn_ProdLabel.Location = new System.Drawing.Point(30, 89);
            códigoForn_ProdLabel.Name = "códigoForn_ProdLabel";
            códigoForn_ProdLabel.Size = new System.Drawing.Size(194, 30);
            códigoForn_ProdLabel.TabIndex = 3;
            códigoForn_ProdLabel.Text = "Código Fornecedor:";
            // 
            // produto_ProdLabel
            // 
            produto_ProdLabel.AutoSize = true;
            produto_ProdLabel.BackColor = System.Drawing.Color.Transparent;
            produto_ProdLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            produto_ProdLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            produto_ProdLabel.Location = new System.Drawing.Point(30, 115);
            produto_ProdLabel.Name = "produto_ProdLabel";
            produto_ProdLabel.Size = new System.Drawing.Size(92, 30);
            produto_ProdLabel.TabIndex = 5;
            produto_ProdLabel.Text = "Produto:";
            // 
            // descrição_ProdLabel
            // 
            descrição_ProdLabel.AutoSize = true;
            descrição_ProdLabel.BackColor = System.Drawing.Color.Transparent;
            descrição_ProdLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            descrição_ProdLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            descrição_ProdLabel.Location = new System.Drawing.Point(30, 141);
            descrição_ProdLabel.Name = "descrição_ProdLabel";
            descrição_ProdLabel.Size = new System.Drawing.Size(108, 30);
            descrição_ProdLabel.TabIndex = 7;
            descrição_ProdLabel.Text = "Descrição:";
            // 
            // fabricação_ProdLabel
            // 
            fabricação_ProdLabel.AutoSize = true;
            fabricação_ProdLabel.BackColor = System.Drawing.Color.Transparent;
            fabricação_ProdLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            fabricação_ProdLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            fabricação_ProdLabel.Location = new System.Drawing.Point(30, 168);
            fabricação_ProdLabel.Name = "fabricação_ProdLabel";
            fabricação_ProdLabel.Size = new System.Drawing.Size(116, 30);
            fabricação_ProdLabel.TabIndex = 9;
            fabricação_ProdLabel.Text = "Fabricação:";
            // 
            // validade_ProdLabel
            // 
            validade_ProdLabel.AutoSize = true;
            validade_ProdLabel.BackColor = System.Drawing.Color.Transparent;
            validade_ProdLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            validade_ProdLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            validade_ProdLabel.Location = new System.Drawing.Point(30, 194);
            validade_ProdLabel.Name = "validade_ProdLabel";
            validade_ProdLabel.Size = new System.Drawing.Size(96, 30);
            validade_ProdLabel.TabIndex = 11;
            validade_ProdLabel.Text = "Validade:";
            // 
            // unidade_ProdLabel
            // 
            unidade_ProdLabel.AutoSize = true;
            unidade_ProdLabel.BackColor = System.Drawing.Color.Transparent;
            unidade_ProdLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            unidade_ProdLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            unidade_ProdLabel.Location = new System.Drawing.Point(30, 219);
            unidade_ProdLabel.Name = "unidade_ProdLabel";
            unidade_ProdLabel.Size = new System.Drawing.Size(95, 30);
            unidade_ProdLabel.TabIndex = 13;
            unidade_ProdLabel.Text = "Unidade:";
            // 
            // cat_ProdLabel
            // 
            cat_ProdLabel.AutoSize = true;
            cat_ProdLabel.BackColor = System.Drawing.Color.Transparent;
            cat_ProdLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            cat_ProdLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            cat_ProdLabel.Location = new System.Drawing.Point(30, 245);
            cat_ProdLabel.Name = "cat_ProdLabel";
            cat_ProdLabel.Size = new System.Drawing.Size(107, 30);
            cat_ProdLabel.TabIndex = 15;
            cat_ProdLabel.Text = "Categoria:";
            // 
            // forn_ProdLabel
            // 
            forn_ProdLabel.AutoSize = true;
            forn_ProdLabel.BackColor = System.Drawing.Color.Transparent;
            forn_ProdLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            forn_ProdLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            forn_ProdLabel.Location = new System.Drawing.Point(30, 272);
            forn_ProdLabel.Name = "forn_ProdLabel";
            forn_ProdLabel.Size = new System.Drawing.Size(122, 30);
            forn_ProdLabel.TabIndex = 17;
            forn_ProdLabel.Text = "Fornecedor:";
            // 
            // valor_ProdLabel
            // 
            valor_ProdLabel.AutoSize = true;
            valor_ProdLabel.BackColor = System.Drawing.Color.Transparent;
            valor_ProdLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            valor_ProdLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            valor_ProdLabel.Location = new System.Drawing.Point(30, 298);
            valor_ProdLabel.Name = "valor_ProdLabel";
            valor_ProdLabel.Size = new System.Drawing.Size(64, 30);
            valor_ProdLabel.TabIndex = 19;
            valor_ProdLabel.Text = "Valor:";
            // 
            // industria_MetalurgicaDataSet
            // 
            this.industria_MetalurgicaDataSet.DataSetName = "Industria_MetalurgicaDataSet";
            this.industria_MetalurgicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produtosBindingSource
            // 
            this.produtosBindingSource.DataMember = "Produtos";
            this.produtosBindingSource.DataSource = this.industria_MetalurgicaDataSet;
            // 
            // produtosTableAdapter
            // 
            this.produtosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientesTableAdapter = null;
            this.tableAdapterManager.ComprasTableAdapter = null;
            this.tableAdapterManager.ContasTableAdapter = null;
            this.tableAdapterManager.FornecedoresTableAdapter = null;
            this.tableAdapterManager.FuncionáriosTableAdapter = null;
            this.tableAdapterManager.LoginTableAdapter = null;
            this.tableAdapterManager.Nota_fiscalTableAdapter = null;
            this.tableAdapterManager.ProdutosTableAdapter = this.produtosTableAdapter;
            this.tableAdapterManager.TransportadorasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Industria_Metalurgica.Industria_MetalurgicaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VendasTableAdapter = null;
            // 
            // produtosBindingNavigator
            // 
            this.produtosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.produtosBindingNavigator.BindingSource = this.produtosBindingSource;
            this.produtosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.produtosBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.produtosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.produtosBindingNavigatorSaveItem});
            this.produtosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.produtosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.produtosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.produtosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.produtosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.produtosBindingNavigator.Name = "produtosBindingNavigator";
            this.produtosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.produtosBindingNavigator.Size = new System.Drawing.Size(484, 25);
            this.produtosBindingNavigator.TabIndex = 0;
            this.produtosBindingNavigator.Text = "bindingNavigator1";
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
            // produtosBindingNavigatorSaveItem
            // 
            this.produtosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.produtosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("produtosBindingNavigatorSaveItem.Image")));
            this.produtosBindingNavigatorSaveItem.Name = "produtosBindingNavigatorSaveItem";
            this.produtosBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.produtosBindingNavigatorSaveItem.Text = "Save Data";
            this.produtosBindingNavigatorSaveItem.Click += new System.EventHandler(this.produtosBindingNavigatorSaveItem_Click);
            // 
            // código_ProdTextBox
            // 
            this.código_ProdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtosBindingSource, "Código_Prod", true));
            this.código_ProdTextBox.Location = new System.Drawing.Point(241, 63);
            this.código_ProdTextBox.Name = "código_ProdTextBox";
            this.código_ProdTextBox.ReadOnly = true;
            this.código_ProdTextBox.Size = new System.Drawing.Size(200, 20);
            this.código_ProdTextBox.TabIndex = 2;
            this.código_ProdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // códigoForn_ProdTextBox
            // 
            this.códigoForn_ProdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtosBindingSource, "CódigoForn_Prod", true));
            this.códigoForn_ProdTextBox.Location = new System.Drawing.Point(241, 89);
            this.códigoForn_ProdTextBox.Name = "códigoForn_ProdTextBox";
            this.códigoForn_ProdTextBox.Size = new System.Drawing.Size(200, 20);
            this.códigoForn_ProdTextBox.TabIndex = 4;
            this.códigoForn_ProdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // produto_ProdTextBox
            // 
            this.produto_ProdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtosBindingSource, "Produto_Prod", true));
            this.produto_ProdTextBox.Location = new System.Drawing.Point(241, 115);
            this.produto_ProdTextBox.Name = "produto_ProdTextBox";
            this.produto_ProdTextBox.Size = new System.Drawing.Size(200, 20);
            this.produto_ProdTextBox.TabIndex = 6;
            this.produto_ProdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // descrição_ProdTextBox
            // 
            this.descrição_ProdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtosBindingSource, "Descrição_Prod", true));
            this.descrição_ProdTextBox.Location = new System.Drawing.Point(241, 141);
            this.descrição_ProdTextBox.Name = "descrição_ProdTextBox";
            this.descrição_ProdTextBox.Size = new System.Drawing.Size(200, 20);
            this.descrição_ProdTextBox.TabIndex = 8;
            this.descrição_ProdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fabricação_ProdDateTimePicker
            // 
            this.fabricação_ProdDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.produtosBindingSource, "Fabricação_Prod", true));
            this.fabricação_ProdDateTimePicker.Location = new System.Drawing.Point(241, 167);
            this.fabricação_ProdDateTimePicker.Name = "fabricação_ProdDateTimePicker";
            this.fabricação_ProdDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fabricação_ProdDateTimePicker.TabIndex = 10;
            // 
            // validade_ProdDateTimePicker
            // 
            this.validade_ProdDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.produtosBindingSource, "Validade_Prod", true));
            this.validade_ProdDateTimePicker.Location = new System.Drawing.Point(241, 193);
            this.validade_ProdDateTimePicker.Name = "validade_ProdDateTimePicker";
            this.validade_ProdDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.validade_ProdDateTimePicker.TabIndex = 12;
            // 
            // unidade_ProdTextBox
            // 
            this.unidade_ProdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtosBindingSource, "Unidade_Prod", true));
            this.unidade_ProdTextBox.Location = new System.Drawing.Point(241, 219);
            this.unidade_ProdTextBox.Name = "unidade_ProdTextBox";
            this.unidade_ProdTextBox.Size = new System.Drawing.Size(200, 20);
            this.unidade_ProdTextBox.TabIndex = 14;
            this.unidade_ProdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cat_ProdComboBox
            // 
            this.cat_ProdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtosBindingSource, "Cat_Prod", true));
            this.cat_ProdComboBox.FormattingEnabled = true;
            this.cat_ProdComboBox.Location = new System.Drawing.Point(241, 245);
            this.cat_ProdComboBox.Name = "cat_ProdComboBox";
            this.cat_ProdComboBox.Size = new System.Drawing.Size(200, 21);
            this.cat_ProdComboBox.TabIndex = 16;
            // 
            // forn_ProdTextBox
            // 
            this.forn_ProdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtosBindingSource, "Forn_Prod", true));
            this.forn_ProdTextBox.Location = new System.Drawing.Point(241, 272);
            this.forn_ProdTextBox.Name = "forn_ProdTextBox";
            this.forn_ProdTextBox.Size = new System.Drawing.Size(200, 20);
            this.forn_ProdTextBox.TabIndex = 18;
            this.forn_ProdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // valor_ProdMaskedTextBox
            // 
            this.valor_ProdMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtosBindingSource, "Valor_Prod", true));
            this.valor_ProdMaskedTextBox.Location = new System.Drawing.Point(241, 298);
            this.valor_ProdMaskedTextBox.Mask = "$";
            this.valor_ProdMaskedTextBox.Name = "valor_ProdMaskedTextBox";
            this.valor_ProdMaskedTextBox.Size = new System.Drawing.Size(200, 20);
            this.valor_ProdMaskedTextBox.TabIndex = 20;
            this.valor_ProdMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Lucida Sans", 11.25F);
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(353, 342);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 30);
            this.button2.TabIndex = 44;
            this.button2.Text = "&Fechar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(484, 384);
            this.Controls.Add(this.button2);
            this.Controls.Add(código_ProdLabel);
            this.Controls.Add(this.código_ProdTextBox);
            this.Controls.Add(códigoForn_ProdLabel);
            this.Controls.Add(this.códigoForn_ProdTextBox);
            this.Controls.Add(produto_ProdLabel);
            this.Controls.Add(this.produto_ProdTextBox);
            this.Controls.Add(descrição_ProdLabel);
            this.Controls.Add(this.descrição_ProdTextBox);
            this.Controls.Add(fabricação_ProdLabel);
            this.Controls.Add(this.fabricação_ProdDateTimePicker);
            this.Controls.Add(validade_ProdLabel);
            this.Controls.Add(this.validade_ProdDateTimePicker);
            this.Controls.Add(unidade_ProdLabel);
            this.Controls.Add(this.unidade_ProdTextBox);
            this.Controls.Add(cat_ProdLabel);
            this.Controls.Add(this.cat_ProdComboBox);
            this.Controls.Add(forn_ProdLabel);
            this.Controls.Add(this.forn_ProdTextBox);
            this.Controls.Add(valor_ProdLabel);
            this.Controls.Add(this.valor_ProdMaskedTextBox);
            this.Controls.Add(this.produtosBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produtos";
            this.Load += new System.EventHandler(this.FrmProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.industria_MetalurgicaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingNavigator)).EndInit();
            this.produtosBindingNavigator.ResumeLayout(false);
            this.produtosBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Industria_MetalurgicaDataSet industria_MetalurgicaDataSet;
        private System.Windows.Forms.BindingSource produtosBindingSource;
        private Industria_Metalurgica.Industria_MetalurgicaDataSetTableAdapters.ProdutosTableAdapter produtosTableAdapter;
        private Industria_Metalurgica.Industria_MetalurgicaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator produtosBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton produtosBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox código_ProdTextBox;
        private System.Windows.Forms.TextBox códigoForn_ProdTextBox;
        private System.Windows.Forms.TextBox produto_ProdTextBox;
        private System.Windows.Forms.TextBox descrição_ProdTextBox;
        private System.Windows.Forms.DateTimePicker fabricação_ProdDateTimePicker;
        private System.Windows.Forms.DateTimePicker validade_ProdDateTimePicker;
        private System.Windows.Forms.TextBox unidade_ProdTextBox;
        private System.Windows.Forms.ComboBox cat_ProdComboBox;
        private System.Windows.Forms.TextBox forn_ProdTextBox;
        private System.Windows.Forms.MaskedTextBox valor_ProdMaskedTextBox;
        private System.Windows.Forms.Button button2;
    }
}