namespace Industria_Metalurgica
{
    partial class FrmNota
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
            System.Windows.Forms.Label código_NotaLabel;
            System.Windows.Forms.Label código_ProdLabel;
            System.Windows.Forms.Label códCli_NotaLabel;
            System.Windows.Forms.Label rgFun_NotaLabel;
            System.Windows.Forms.Label datEm_NotaLabel;
            System.Windows.Forms.Label prodDes_NotaLabel;
            System.Windows.Forms.Label qntProd_NotaLabel;
            System.Windows.Forms.Label formaPag_NotaLabel;
            System.Windows.Forms.Label valor_NotaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNota));
            this.industria_MetalurgicaDataSet = new Industria_Metalurgica.Industria_MetalurgicaDataSet();
            this.nota_fiscalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nota_fiscalTableAdapter = new Industria_Metalurgica.Industria_MetalurgicaDataSetTableAdapters.Nota_fiscalTableAdapter();
            this.tableAdapterManager = new Industria_Metalurgica.Industria_MetalurgicaDataSetTableAdapters.TableAdapterManager();
            this.nota_fiscalBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.nota_fiscalBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.código_NotaTextBox = new System.Windows.Forms.TextBox();
            this.código_ProdTextBox = new System.Windows.Forms.TextBox();
            this.códCli_NotaTextBox = new System.Windows.Forms.TextBox();
            this.rgFun_NotaMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.datEm_NotaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.prodDes_NotaTextBox = new System.Windows.Forms.TextBox();
            this.qntProd_NotaTextBox = new System.Windows.Forms.TextBox();
            this.formaPag_NotaComboBox = new System.Windows.Forms.ComboBox();
            this.valor_NotaMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.button2 = new System.Windows.Forms.Button();
            código_NotaLabel = new System.Windows.Forms.Label();
            código_ProdLabel = new System.Windows.Forms.Label();
            códCli_NotaLabel = new System.Windows.Forms.Label();
            rgFun_NotaLabel = new System.Windows.Forms.Label();
            datEm_NotaLabel = new System.Windows.Forms.Label();
            prodDes_NotaLabel = new System.Windows.Forms.Label();
            qntProd_NotaLabel = new System.Windows.Forms.Label();
            formaPag_NotaLabel = new System.Windows.Forms.Label();
            valor_NotaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.industria_MetalurgicaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nota_fiscalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nota_fiscalBindingNavigator)).BeginInit();
            this.nota_fiscalBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // código_NotaLabel
            // 
            código_NotaLabel.AutoSize = true;
            código_NotaLabel.BackColor = System.Drawing.Color.Transparent;
            código_NotaLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            código_NotaLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            código_NotaLabel.Location = new System.Drawing.Point(23, 53);
            código_NotaLabel.Name = "código_NotaLabel";
            código_NotaLabel.Size = new System.Drawing.Size(84, 30);
            código_NotaLabel.TabIndex = 1;
            código_NotaLabel.Text = "Código:";
            // 
            // código_ProdLabel
            // 
            código_ProdLabel.AutoSize = true;
            código_ProdLabel.BackColor = System.Drawing.Color.Transparent;
            código_ProdLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            código_ProdLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            código_ProdLabel.Location = new System.Drawing.Point(23, 79);
            código_ProdLabel.Name = "código_ProdLabel";
            código_ProdLabel.Size = new System.Drawing.Size(164, 30);
            código_ProdLabel.TabIndex = 3;
            código_ProdLabel.Text = "Código Produto:";
            // 
            // códCli_NotaLabel
            // 
            códCli_NotaLabel.AutoSize = true;
            códCli_NotaLabel.BackColor = System.Drawing.Color.Transparent;
            códCli_NotaLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            códCli_NotaLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            códCli_NotaLabel.Location = new System.Drawing.Point(23, 105);
            códCli_NotaLabel.Name = "códCli_NotaLabel";
            códCli_NotaLabel.Size = new System.Drawing.Size(154, 30);
            códCli_NotaLabel.TabIndex = 5;
            códCli_NotaLabel.Text = "Código Cliente:";
            // 
            // rgFun_NotaLabel
            // 
            rgFun_NotaLabel.AutoSize = true;
            rgFun_NotaLabel.BackColor = System.Drawing.Color.Transparent;
            rgFun_NotaLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            rgFun_NotaLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            rgFun_NotaLabel.Location = new System.Drawing.Point(23, 131);
            rgFun_NotaLabel.Name = "rgFun_NotaLabel";
            rgFun_NotaLabel.Size = new System.Drawing.Size(159, 30);
            rgFun_NotaLabel.TabIndex = 7;
            rgFun_NotaLabel.Text = "RG Funcionário:";
            // 
            // datEm_NotaLabel
            // 
            datEm_NotaLabel.AutoSize = true;
            datEm_NotaLabel.BackColor = System.Drawing.Color.Transparent;
            datEm_NotaLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            datEm_NotaLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            datEm_NotaLabel.Location = new System.Drawing.Point(23, 158);
            datEm_NotaLabel.Name = "datEm_NotaLabel";
            datEm_NotaLabel.Size = new System.Drawing.Size(143, 30);
            datEm_NotaLabel.TabIndex = 9;
            datEm_NotaLabel.Text = "Data Emissão:";
            // 
            // prodDes_NotaLabel
            // 
            prodDes_NotaLabel.AutoSize = true;
            prodDes_NotaLabel.BackColor = System.Drawing.Color.Transparent;
            prodDes_NotaLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            prodDes_NotaLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            prodDes_NotaLabel.Location = new System.Drawing.Point(23, 183);
            prodDes_NotaLabel.Name = "prodDes_NotaLabel";
            prodDes_NotaLabel.Size = new System.Drawing.Size(92, 30);
            prodDes_NotaLabel.TabIndex = 11;
            prodDes_NotaLabel.Text = "Produto:";
            // 
            // qntProd_NotaLabel
            // 
            qntProd_NotaLabel.AutoSize = true;
            qntProd_NotaLabel.BackColor = System.Drawing.Color.Transparent;
            qntProd_NotaLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            qntProd_NotaLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            qntProd_NotaLabel.Location = new System.Drawing.Point(23, 209);
            qntProd_NotaLabel.Name = "qntProd_NotaLabel";
            qntProd_NotaLabel.Size = new System.Drawing.Size(127, 30);
            qntProd_NotaLabel.TabIndex = 13;
            qntProd_NotaLabel.Text = "Quantidade:";
            // 
            // formaPag_NotaLabel
            // 
            formaPag_NotaLabel.AutoSize = true;
            formaPag_NotaLabel.BackColor = System.Drawing.Color.Transparent;
            formaPag_NotaLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            formaPag_NotaLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            formaPag_NotaLabel.Location = new System.Drawing.Point(23, 235);
            formaPag_NotaLabel.Name = "formaPag_NotaLabel";
            formaPag_NotaLabel.Size = new System.Drawing.Size(187, 30);
            formaPag_NotaLabel.TabIndex = 15;
            formaPag_NotaLabel.Text = "Forma Pagamento:";
            // 
            // valor_NotaLabel
            // 
            valor_NotaLabel.AutoSize = true;
            valor_NotaLabel.BackColor = System.Drawing.Color.Transparent;
            valor_NotaLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            valor_NotaLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            valor_NotaLabel.Location = new System.Drawing.Point(23, 262);
            valor_NotaLabel.Name = "valor_NotaLabel";
            valor_NotaLabel.Size = new System.Drawing.Size(64, 30);
            valor_NotaLabel.TabIndex = 17;
            valor_NotaLabel.Text = "Valor:";
            // 
            // industria_MetalurgicaDataSet
            // 
            this.industria_MetalurgicaDataSet.DataSetName = "Industria_MetalurgicaDataSet";
            this.industria_MetalurgicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nota_fiscalBindingSource
            // 
            this.nota_fiscalBindingSource.DataMember = "Nota fiscal";
            this.nota_fiscalBindingSource.DataSource = this.industria_MetalurgicaDataSet;
            // 
            // nota_fiscalTableAdapter
            // 
            this.nota_fiscalTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.Nota_fiscalTableAdapter = this.nota_fiscalTableAdapter;
            this.tableAdapterManager.ProdutosTableAdapter = null;
            this.tableAdapterManager.TransportadorasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Industria_Metalurgica.Industria_MetalurgicaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VendasTableAdapter = null;
            // 
            // nota_fiscalBindingNavigator
            // 
            this.nota_fiscalBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.nota_fiscalBindingNavigator.BindingSource = this.nota_fiscalBindingSource;
            this.nota_fiscalBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.nota_fiscalBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.nota_fiscalBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.nota_fiscalBindingNavigatorSaveItem});
            this.nota_fiscalBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.nota_fiscalBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.nota_fiscalBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.nota_fiscalBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.nota_fiscalBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.nota_fiscalBindingNavigator.Name = "nota_fiscalBindingNavigator";
            this.nota_fiscalBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.nota_fiscalBindingNavigator.Size = new System.Drawing.Size(435, 25);
            this.nota_fiscalBindingNavigator.TabIndex = 0;
            this.nota_fiscalBindingNavigator.Text = "bindingNavigator1";
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
            // nota_fiscalBindingNavigatorSaveItem
            // 
            this.nota_fiscalBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.nota_fiscalBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("nota_fiscalBindingNavigatorSaveItem.Image")));
            this.nota_fiscalBindingNavigatorSaveItem.Name = "nota_fiscalBindingNavigatorSaveItem";
            this.nota_fiscalBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.nota_fiscalBindingNavigatorSaveItem.Text = "Save Data";
            this.nota_fiscalBindingNavigatorSaveItem.Click += new System.EventHandler(this.nota_fiscalBindingNavigatorSaveItem_Click);
            // 
            // código_NotaTextBox
            // 
            this.código_NotaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nota_fiscalBindingSource, "Código_Nota", true));
            this.código_NotaTextBox.Location = new System.Drawing.Point(208, 63);
            this.código_NotaTextBox.Name = "código_NotaTextBox";
            this.código_NotaTextBox.ReadOnly = true;
            this.código_NotaTextBox.Size = new System.Drawing.Size(200, 20);
            this.código_NotaTextBox.TabIndex = 2;
            this.código_NotaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // código_ProdTextBox
            // 
            this.código_ProdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nota_fiscalBindingSource, "Código_Prod", true));
            this.código_ProdTextBox.Location = new System.Drawing.Point(208, 89);
            this.código_ProdTextBox.Name = "código_ProdTextBox";
            this.código_ProdTextBox.Size = new System.Drawing.Size(200, 20);
            this.código_ProdTextBox.TabIndex = 4;
            this.código_ProdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // códCli_NotaTextBox
            // 
            this.códCli_NotaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nota_fiscalBindingSource, "CódCli_Nota", true));
            this.códCli_NotaTextBox.Location = new System.Drawing.Point(208, 115);
            this.códCli_NotaTextBox.Name = "códCli_NotaTextBox";
            this.códCli_NotaTextBox.Size = new System.Drawing.Size(200, 20);
            this.códCli_NotaTextBox.TabIndex = 6;
            this.códCli_NotaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rgFun_NotaMaskedTextBox
            // 
            this.rgFun_NotaMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nota_fiscalBindingSource, "RgFun_Nota", true));
            this.rgFun_NotaMaskedTextBox.Location = new System.Drawing.Point(208, 141);
            this.rgFun_NotaMaskedTextBox.Mask = "00,000,0000-0";
            this.rgFun_NotaMaskedTextBox.Name = "rgFun_NotaMaskedTextBox";
            this.rgFun_NotaMaskedTextBox.Size = new System.Drawing.Size(200, 20);
            this.rgFun_NotaMaskedTextBox.TabIndex = 8;
            this.rgFun_NotaMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // datEm_NotaDateTimePicker
            // 
            this.datEm_NotaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.nota_fiscalBindingSource, "DatEm_Nota", true));
            this.datEm_NotaDateTimePicker.Location = new System.Drawing.Point(208, 167);
            this.datEm_NotaDateTimePicker.Name = "datEm_NotaDateTimePicker";
            this.datEm_NotaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.datEm_NotaDateTimePicker.TabIndex = 10;
            // 
            // prodDes_NotaTextBox
            // 
            this.prodDes_NotaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nota_fiscalBindingSource, "ProdDes_Nota", true));
            this.prodDes_NotaTextBox.Location = new System.Drawing.Point(208, 193);
            this.prodDes_NotaTextBox.Name = "prodDes_NotaTextBox";
            this.prodDes_NotaTextBox.Size = new System.Drawing.Size(200, 20);
            this.prodDes_NotaTextBox.TabIndex = 12;
            this.prodDes_NotaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // qntProd_NotaTextBox
            // 
            this.qntProd_NotaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nota_fiscalBindingSource, "QntProd_Nota", true));
            this.qntProd_NotaTextBox.Location = new System.Drawing.Point(208, 219);
            this.qntProd_NotaTextBox.Name = "qntProd_NotaTextBox";
            this.qntProd_NotaTextBox.Size = new System.Drawing.Size(200, 20);
            this.qntProd_NotaTextBox.TabIndex = 14;
            this.qntProd_NotaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // formaPag_NotaComboBox
            // 
            this.formaPag_NotaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nota_fiscalBindingSource, "FormaPag_Nota", true));
            this.formaPag_NotaComboBox.FormattingEnabled = true;
            this.formaPag_NotaComboBox.Items.AddRange(new object[] {
            "Á Vista",
            "Crédito",
            "Débito"});
            this.formaPag_NotaComboBox.Location = new System.Drawing.Point(208, 245);
            this.formaPag_NotaComboBox.Name = "formaPag_NotaComboBox";
            this.formaPag_NotaComboBox.Size = new System.Drawing.Size(200, 21);
            this.formaPag_NotaComboBox.TabIndex = 16;
            // 
            // valor_NotaMaskedTextBox
            // 
            this.valor_NotaMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nota_fiscalBindingSource, "Valor_Nota", true));
            this.valor_NotaMaskedTextBox.Location = new System.Drawing.Point(208, 272);
            this.valor_NotaMaskedTextBox.Mask = "$";
            this.valor_NotaMaskedTextBox.Name = "valor_NotaMaskedTextBox";
            this.valor_NotaMaskedTextBox.Size = new System.Drawing.Size(200, 20);
            this.valor_NotaMaskedTextBox.TabIndex = 18;
            this.valor_NotaMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Lucida Sans", 11.25F);
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(320, 315);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 30);
            this.button2.TabIndex = 43;
            this.button2.Text = "&Fechar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(435, 357);
            this.Controls.Add(this.button2);
            this.Controls.Add(código_NotaLabel);
            this.Controls.Add(this.código_NotaTextBox);
            this.Controls.Add(código_ProdLabel);
            this.Controls.Add(this.código_ProdTextBox);
            this.Controls.Add(códCli_NotaLabel);
            this.Controls.Add(this.códCli_NotaTextBox);
            this.Controls.Add(rgFun_NotaLabel);
            this.Controls.Add(this.rgFun_NotaMaskedTextBox);
            this.Controls.Add(datEm_NotaLabel);
            this.Controls.Add(this.datEm_NotaDateTimePicker);
            this.Controls.Add(prodDes_NotaLabel);
            this.Controls.Add(this.prodDes_NotaTextBox);
            this.Controls.Add(qntProd_NotaLabel);
            this.Controls.Add(this.qntProd_NotaTextBox);
            this.Controls.Add(formaPag_NotaLabel);
            this.Controls.Add(this.formaPag_NotaComboBox);
            this.Controls.Add(valor_NotaLabel);
            this.Controls.Add(this.valor_NotaMaskedTextBox);
            this.Controls.Add(this.nota_fiscalBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNota";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nota Fiscal";
            this.Load += new System.EventHandler(this.FrmNota_Load);
            ((System.ComponentModel.ISupportInitialize)(this.industria_MetalurgicaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nota_fiscalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nota_fiscalBindingNavigator)).EndInit();
            this.nota_fiscalBindingNavigator.ResumeLayout(false);
            this.nota_fiscalBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Industria_MetalurgicaDataSet industria_MetalurgicaDataSet;
        private System.Windows.Forms.BindingSource nota_fiscalBindingSource;
        private Industria_Metalurgica.Industria_MetalurgicaDataSetTableAdapters.Nota_fiscalTableAdapter nota_fiscalTableAdapter;
        private Industria_Metalurgica.Industria_MetalurgicaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator nota_fiscalBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton nota_fiscalBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox código_NotaTextBox;
        private System.Windows.Forms.TextBox código_ProdTextBox;
        private System.Windows.Forms.TextBox códCli_NotaTextBox;
        private System.Windows.Forms.MaskedTextBox rgFun_NotaMaskedTextBox;
        private System.Windows.Forms.DateTimePicker datEm_NotaDateTimePicker;
        private System.Windows.Forms.TextBox prodDes_NotaTextBox;
        private System.Windows.Forms.TextBox qntProd_NotaTextBox;
        private System.Windows.Forms.ComboBox formaPag_NotaComboBox;
        private System.Windows.Forms.MaskedTextBox valor_NotaMaskedTextBox;
        private System.Windows.Forms.Button button2;
    }
}