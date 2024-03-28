namespace Industria_Metalurgica
{
    partial class FrmForn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmForn));
            System.Windows.Forms.Label código_FornLabel;
            System.Windows.Forms.Label códigoTransp_FornLabel;
            System.Windows.Forms.Label cNPJ_FornLabel;
            System.Windows.Forms.Label razaoSocial_FornLabel;
            System.Windows.Forms.Label nomeEmp_FornLabel;
            System.Windows.Forms.Label responsavel_FornLabel;
            System.Windows.Forms.Label departamento_FornLabel;
            System.Windows.Forms.Label cid_FornLabel;
            System.Windows.Forms.Label est_FornLabel;
            System.Windows.Forms.Label cep_FornLabel;
            System.Windows.Forms.Label rua_FornLabel;
            System.Windows.Forms.Label n_FornLabel;
            System.Windows.Forms.Label bairro_FornLabel;
            System.Windows.Forms.Label complemento_FornLabel;
            System.Windows.Forms.Label tel_FornLabel;
            System.Windows.Forms.Label cel_FornLabel;
            System.Windows.Forms.Label email_FornLabel;
            this.industria_MetalurgicaDataSet = new Industria_Metalurgica.Industria_MetalurgicaDataSet();
            this.fornecedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fornecedoresTableAdapter = new Industria_Metalurgica.Industria_MetalurgicaDataSetTableAdapters.FornecedoresTableAdapter();
            this.tableAdapterManager = new Industria_Metalurgica.Industria_MetalurgicaDataSetTableAdapters.TableAdapterManager();
            this.fornecedoresBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.fornecedoresBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.código_FornTextBox = new System.Windows.Forms.TextBox();
            this.códigoTransp_FornTextBox = new System.Windows.Forms.TextBox();
            this.cNPJ_FornMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.razaoSocial_FornTextBox = new System.Windows.Forms.TextBox();
            this.nomeEmp_FornTextBox = new System.Windows.Forms.TextBox();
            this.responsavel_FornTextBox = new System.Windows.Forms.TextBox();
            this.departamento_FornComboBox = new System.Windows.Forms.ComboBox();
            this.cid_FornTextBox = new System.Windows.Forms.TextBox();
            this.est_FornComboBox = new System.Windows.Forms.ComboBox();
            this.cep_FornMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.rua_FornTextBox = new System.Windows.Forms.TextBox();
            this.n_FornTextBox = new System.Windows.Forms.TextBox();
            this.bairro_FornTextBox = new System.Windows.Forms.TextBox();
            this.complemento_FornTextBox = new System.Windows.Forms.TextBox();
            this.tel_FornMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cel_FornMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.email_FornTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            código_FornLabel = new System.Windows.Forms.Label();
            códigoTransp_FornLabel = new System.Windows.Forms.Label();
            cNPJ_FornLabel = new System.Windows.Forms.Label();
            razaoSocial_FornLabel = new System.Windows.Forms.Label();
            nomeEmp_FornLabel = new System.Windows.Forms.Label();
            responsavel_FornLabel = new System.Windows.Forms.Label();
            departamento_FornLabel = new System.Windows.Forms.Label();
            cid_FornLabel = new System.Windows.Forms.Label();
            est_FornLabel = new System.Windows.Forms.Label();
            cep_FornLabel = new System.Windows.Forms.Label();
            rua_FornLabel = new System.Windows.Forms.Label();
            n_FornLabel = new System.Windows.Forms.Label();
            bairro_FornLabel = new System.Windows.Forms.Label();
            complemento_FornLabel = new System.Windows.Forms.Label();
            tel_FornLabel = new System.Windows.Forms.Label();
            cel_FornLabel = new System.Windows.Forms.Label();
            email_FornLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.industria_MetalurgicaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingNavigator)).BeginInit();
            this.fornecedoresBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // industria_MetalurgicaDataSet
            // 
            this.industria_MetalurgicaDataSet.DataSetName = "Industria_MetalurgicaDataSet";
            this.industria_MetalurgicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fornecedoresBindingSource
            // 
            this.fornecedoresBindingSource.DataMember = "Fornecedores";
            this.fornecedoresBindingSource.DataSource = this.industria_MetalurgicaDataSet;
            // 
            // fornecedoresTableAdapter
            // 
            this.fornecedoresTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientesTableAdapter = null;
            this.tableAdapterManager.ComprasTableAdapter = null;
            this.tableAdapterManager.ContasTableAdapter = null;
            this.tableAdapterManager.FornecedoresTableAdapter = this.fornecedoresTableAdapter;
            this.tableAdapterManager.FuncionáriosTableAdapter = null;
            this.tableAdapterManager.LoginTableAdapter = null;
            this.tableAdapterManager.Nota_fiscalTableAdapter = null;
            this.tableAdapterManager.ProdutosTableAdapter = null;
            this.tableAdapterManager.TransportadorasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Industria_Metalurgica.Industria_MetalurgicaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VendasTableAdapter = null;
            // 
            // fornecedoresBindingNavigator
            // 
            this.fornecedoresBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.fornecedoresBindingNavigator.BindingSource = this.fornecedoresBindingSource;
            this.fornecedoresBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.fornecedoresBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.fornecedoresBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.fornecedoresBindingNavigatorSaveItem});
            this.fornecedoresBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.fornecedoresBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.fornecedoresBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.fornecedoresBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.fornecedoresBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.fornecedoresBindingNavigator.Name = "fornecedoresBindingNavigator";
            this.fornecedoresBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.fornecedoresBindingNavigator.Size = new System.Drawing.Size(396, 25);
            this.fornecedoresBindingNavigator.TabIndex = 0;
            this.fornecedoresBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // fornecedoresBindingNavigatorSaveItem
            // 
            this.fornecedoresBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fornecedoresBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("fornecedoresBindingNavigatorSaveItem.Image")));
            this.fornecedoresBindingNavigatorSaveItem.Name = "fornecedoresBindingNavigatorSaveItem";
            this.fornecedoresBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.fornecedoresBindingNavigatorSaveItem.Text = "Save Data";
            this.fornecedoresBindingNavigatorSaveItem.Click += new System.EventHandler(this.fornecedoresBindingNavigatorSaveItem_Click);
            // 
            // código_FornLabel
            // 
            código_FornLabel.AutoSize = true;
            código_FornLabel.BackColor = System.Drawing.Color.Transparent;
            código_FornLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            código_FornLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            código_FornLabel.Location = new System.Drawing.Point(23, 66);
            código_FornLabel.Name = "código_FornLabel";
            código_FornLabel.Size = new System.Drawing.Size(84, 30);
            código_FornLabel.TabIndex = 1;
            código_FornLabel.Text = "Código:";
            // 
            // código_FornTextBox
            // 
            this.código_FornTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedoresBindingSource, "Código_Forn", true));
            this.código_FornTextBox.Location = new System.Drawing.Point(253, 74);
            this.código_FornTextBox.Name = "código_FornTextBox";
            this.código_FornTextBox.Size = new System.Drawing.Size(121, 20);
            this.código_FornTextBox.TabIndex = 2;
            this.código_FornTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // códigoTransp_FornLabel
            // 
            códigoTransp_FornLabel.AutoSize = true;
            códigoTransp_FornLabel.BackColor = System.Drawing.Color.Transparent;
            códigoTransp_FornLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            códigoTransp_FornLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            códigoTransp_FornLabel.Location = new System.Drawing.Point(23, 92);
            códigoTransp_FornLabel.Name = "códigoTransp_FornLabel";
            códigoTransp_FornLabel.Size = new System.Drawing.Size(229, 30);
            códigoTransp_FornLabel.TabIndex = 3;
            códigoTransp_FornLabel.Text = "Código Transportadora:";
            // 
            // códigoTransp_FornTextBox
            // 
            this.códigoTransp_FornTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedoresBindingSource, "CódigoTransp_Forn", true));
            this.códigoTransp_FornTextBox.Location = new System.Drawing.Point(253, 100);
            this.códigoTransp_FornTextBox.Name = "códigoTransp_FornTextBox";
            this.códigoTransp_FornTextBox.Size = new System.Drawing.Size(121, 20);
            this.códigoTransp_FornTextBox.TabIndex = 4;
            this.códigoTransp_FornTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cNPJ_FornLabel
            // 
            cNPJ_FornLabel.AutoSize = true;
            cNPJ_FornLabel.BackColor = System.Drawing.Color.Transparent;
            cNPJ_FornLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            cNPJ_FornLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            cNPJ_FornLabel.Location = new System.Drawing.Point(23, 118);
            cNPJ_FornLabel.Name = "cNPJ_FornLabel";
            cNPJ_FornLabel.Size = new System.Drawing.Size(66, 30);
            cNPJ_FornLabel.TabIndex = 5;
            cNPJ_FornLabel.Text = "CNPJ:";
            // 
            // cNPJ_FornMaskedTextBox
            // 
            this.cNPJ_FornMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedoresBindingSource, "CNPJ_Forn", true));
            this.cNPJ_FornMaskedTextBox.Location = new System.Drawing.Point(253, 126);
            this.cNPJ_FornMaskedTextBox.Mask = "00,000,000/0000-00 ";
            this.cNPJ_FornMaskedTextBox.Name = "cNPJ_FornMaskedTextBox";
            this.cNPJ_FornMaskedTextBox.Size = new System.Drawing.Size(121, 20);
            this.cNPJ_FornMaskedTextBox.TabIndex = 6;
            this.cNPJ_FornMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // razaoSocial_FornLabel
            // 
            razaoSocial_FornLabel.AutoSize = true;
            razaoSocial_FornLabel.BackColor = System.Drawing.Color.Transparent;
            razaoSocial_FornLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            razaoSocial_FornLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            razaoSocial_FornLabel.Location = new System.Drawing.Point(23, 144);
            razaoSocial_FornLabel.Name = "razaoSocial_FornLabel";
            razaoSocial_FornLabel.Size = new System.Drawing.Size(135, 30);
            razaoSocial_FornLabel.TabIndex = 7;
            razaoSocial_FornLabel.Text = "Razão Social:";
            // 
            // razaoSocial_FornTextBox
            // 
            this.razaoSocial_FornTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedoresBindingSource, "RazaoSocial_Forn", true));
            this.razaoSocial_FornTextBox.Location = new System.Drawing.Point(253, 152);
            this.razaoSocial_FornTextBox.Name = "razaoSocial_FornTextBox";
            this.razaoSocial_FornTextBox.Size = new System.Drawing.Size(121, 20);
            this.razaoSocial_FornTextBox.TabIndex = 8;
            this.razaoSocial_FornTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nomeEmp_FornLabel
            // 
            nomeEmp_FornLabel.AutoSize = true;
            nomeEmp_FornLabel.BackColor = System.Drawing.Color.Transparent;
            nomeEmp_FornLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            nomeEmp_FornLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            nomeEmp_FornLabel.Location = new System.Drawing.Point(23, 170);
            nomeEmp_FornLabel.Name = "nomeEmp_FornLabel";
            nomeEmp_FornLabel.Size = new System.Drawing.Size(160, 30);
            nomeEmp_FornLabel.TabIndex = 9;
            nomeEmp_FornLabel.Text = "Nome Empresa:";
            // 
            // nomeEmp_FornTextBox
            // 
            this.nomeEmp_FornTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedoresBindingSource, "NomeEmp_Forn", true));
            this.nomeEmp_FornTextBox.Location = new System.Drawing.Point(253, 178);
            this.nomeEmp_FornTextBox.Name = "nomeEmp_FornTextBox";
            this.nomeEmp_FornTextBox.Size = new System.Drawing.Size(121, 20);
            this.nomeEmp_FornTextBox.TabIndex = 10;
            this.nomeEmp_FornTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // responsavel_FornLabel
            // 
            responsavel_FornLabel.AutoSize = true;
            responsavel_FornLabel.BackColor = System.Drawing.Color.Transparent;
            responsavel_FornLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            responsavel_FornLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            responsavel_FornLabel.Location = new System.Drawing.Point(23, 196);
            responsavel_FornLabel.Name = "responsavel_FornLabel";
            responsavel_FornLabel.Size = new System.Drawing.Size(132, 30);
            responsavel_FornLabel.TabIndex = 11;
            responsavel_FornLabel.Text = "Responsável:";
            // 
            // responsavel_FornTextBox
            // 
            this.responsavel_FornTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedoresBindingSource, "Responsavel_Forn", true));
            this.responsavel_FornTextBox.Location = new System.Drawing.Point(253, 204);
            this.responsavel_FornTextBox.Name = "responsavel_FornTextBox";
            this.responsavel_FornTextBox.Size = new System.Drawing.Size(121, 20);
            this.responsavel_FornTextBox.TabIndex = 12;
            this.responsavel_FornTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // departamento_FornLabel
            // 
            departamento_FornLabel.AutoSize = true;
            departamento_FornLabel.BackColor = System.Drawing.Color.Transparent;
            departamento_FornLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            departamento_FornLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            departamento_FornLabel.Location = new System.Drawing.Point(23, 222);
            departamento_FornLabel.Name = "departamento_FornLabel";
            departamento_FornLabel.Size = new System.Drawing.Size(152, 30);
            departamento_FornLabel.TabIndex = 13;
            departamento_FornLabel.Text = "Departamento:";
            // 
            // departamento_FornComboBox
            // 
            this.departamento_FornComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedoresBindingSource, "Departamento_Forn", true));
            this.departamento_FornComboBox.FormattingEnabled = true;
            this.departamento_FornComboBox.Location = new System.Drawing.Point(253, 230);
            this.departamento_FornComboBox.Name = "departamento_FornComboBox";
            this.departamento_FornComboBox.Size = new System.Drawing.Size(121, 21);
            this.departamento_FornComboBox.TabIndex = 14;
            // 
            // cid_FornLabel
            // 
            cid_FornLabel.AutoSize = true;
            cid_FornLabel.BackColor = System.Drawing.Color.Transparent;
            cid_FornLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            cid_FornLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            cid_FornLabel.Location = new System.Drawing.Point(23, 249);
            cid_FornLabel.Name = "cid_FornLabel";
            cid_FornLabel.Size = new System.Drawing.Size(82, 30);
            cid_FornLabel.TabIndex = 15;
            cid_FornLabel.Text = "Cidade:";
            // 
            // cid_FornTextBox
            // 
            this.cid_FornTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedoresBindingSource, "Cid_Forn", true));
            this.cid_FornTextBox.Location = new System.Drawing.Point(253, 257);
            this.cid_FornTextBox.Name = "cid_FornTextBox";
            this.cid_FornTextBox.Size = new System.Drawing.Size(121, 20);
            this.cid_FornTextBox.TabIndex = 16;
            this.cid_FornTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // est_FornLabel
            // 
            est_FornLabel.AutoSize = true;
            est_FornLabel.BackColor = System.Drawing.Color.Transparent;
            est_FornLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            est_FornLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            est_FornLabel.Location = new System.Drawing.Point(23, 275);
            est_FornLabel.Name = "est_FornLabel";
            est_FornLabel.Size = new System.Drawing.Size(80, 30);
            est_FornLabel.TabIndex = 17;
            est_FornLabel.Text = "Estado:";
            // 
            // est_FornComboBox
            // 
            this.est_FornComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedoresBindingSource, "Est_Forn", true));
            this.est_FornComboBox.FormattingEnabled = true;
            this.est_FornComboBox.Items.AddRange(new object[] {
            "Acre",
            "Alagoas",
            "Amapá",
            "Amazonas",
            "Bahia",
            "Ceará",
            "Distrito Federal",
            "Espírito Santos",
            "Goiás",
            "Maranhão",
            "Mato Grosso",
            "Mato Grosso do Sul\t",
            "Minas Gerais",
            "Pará",
            "Paraíba",
            "Paraná",
            "Pernambuco",
            "Piauí",
            "Rio de Janeiro",
            "Rio Grande do Norte",
            "Rio Grande do Sul",
            "Rondônia",
            "Roraima",
            "Santa Catarina\t\t",
            "São Paulo",
            "Sergipe",
            "Tocantins",
            ""});
            this.est_FornComboBox.Location = new System.Drawing.Point(253, 283);
            this.est_FornComboBox.Name = "est_FornComboBox";
            this.est_FornComboBox.Size = new System.Drawing.Size(121, 21);
            this.est_FornComboBox.TabIndex = 18;
            // 
            // cep_FornLabel
            // 
            cep_FornLabel.AutoSize = true;
            cep_FornLabel.BackColor = System.Drawing.Color.Transparent;
            cep_FornLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            cep_FornLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            cep_FornLabel.Location = new System.Drawing.Point(23, 302);
            cep_FornLabel.Name = "cep_FornLabel";
            cep_FornLabel.Size = new System.Drawing.Size(54, 30);
            cep_FornLabel.TabIndex = 19;
            cep_FornLabel.Text = "CEP:";
            // 
            // cep_FornMaskedTextBox
            // 
            this.cep_FornMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedoresBindingSource, "Cep_Forn", true));
            this.cep_FornMaskedTextBox.Location = new System.Drawing.Point(253, 310);
            this.cep_FornMaskedTextBox.Mask = "00,000-000";
            this.cep_FornMaskedTextBox.Name = "cep_FornMaskedTextBox";
            this.cep_FornMaskedTextBox.Size = new System.Drawing.Size(121, 20);
            this.cep_FornMaskedTextBox.TabIndex = 20;
            this.cep_FornMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rua_FornLabel
            // 
            rua_FornLabel.AutoSize = true;
            rua_FornLabel.BackColor = System.Drawing.Color.Transparent;
            rua_FornLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            rua_FornLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            rua_FornLabel.Location = new System.Drawing.Point(23, 328);
            rua_FornLabel.Name = "rua_FornLabel";
            rua_FornLabel.Size = new System.Drawing.Size(54, 30);
            rua_FornLabel.TabIndex = 21;
            rua_FornLabel.Text = "Rua:";
            // 
            // rua_FornTextBox
            // 
            this.rua_FornTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedoresBindingSource, "Rua_Forn", true));
            this.rua_FornTextBox.Location = new System.Drawing.Point(253, 336);
            this.rua_FornTextBox.Name = "rua_FornTextBox";
            this.rua_FornTextBox.Size = new System.Drawing.Size(121, 20);
            this.rua_FornTextBox.TabIndex = 22;
            this.rua_FornTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // n_FornLabel
            // 
            n_FornLabel.AutoSize = true;
            n_FornLabel.BackColor = System.Drawing.Color.Transparent;
            n_FornLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            n_FornLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            n_FornLabel.Location = new System.Drawing.Point(23, 354);
            n_FornLabel.Name = "n_FornLabel";
            n_FornLabel.Size = new System.Drawing.Size(34, 30);
            n_FornLabel.TabIndex = 23;
            n_FornLabel.Text = "N:";
            // 
            // n_FornTextBox
            // 
            this.n_FornTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedoresBindingSource, "N_Forn", true));
            this.n_FornTextBox.Location = new System.Drawing.Point(253, 362);
            this.n_FornTextBox.Name = "n_FornTextBox";
            this.n_FornTextBox.Size = new System.Drawing.Size(121, 20);
            this.n_FornTextBox.TabIndex = 24;
            this.n_FornTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bairro_FornLabel
            // 
            bairro_FornLabel.AutoSize = true;
            bairro_FornLabel.BackColor = System.Drawing.Color.Transparent;
            bairro_FornLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            bairro_FornLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            bairro_FornLabel.Location = new System.Drawing.Point(23, 380);
            bairro_FornLabel.Name = "bairro_FornLabel";
            bairro_FornLabel.Size = new System.Drawing.Size(72, 30);
            bairro_FornLabel.TabIndex = 25;
            bairro_FornLabel.Text = "Bairro:";
            // 
            // bairro_FornTextBox
            // 
            this.bairro_FornTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedoresBindingSource, "Bairro_Forn", true));
            this.bairro_FornTextBox.Location = new System.Drawing.Point(253, 388);
            this.bairro_FornTextBox.Name = "bairro_FornTextBox";
            this.bairro_FornTextBox.Size = new System.Drawing.Size(121, 20);
            this.bairro_FornTextBox.TabIndex = 26;
            this.bairro_FornTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // complemento_FornLabel
            // 
            complemento_FornLabel.AutoSize = true;
            complemento_FornLabel.BackColor = System.Drawing.Color.Transparent;
            complemento_FornLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            complemento_FornLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            complemento_FornLabel.Location = new System.Drawing.Point(23, 406);
            complemento_FornLabel.Name = "complemento_FornLabel";
            complemento_FornLabel.Size = new System.Drawing.Size(149, 30);
            complemento_FornLabel.TabIndex = 27;
            complemento_FornLabel.Text = "Complemento:";
            // 
            // complemento_FornTextBox
            // 
            this.complemento_FornTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedoresBindingSource, "Complemento_Forn", true));
            this.complemento_FornTextBox.Location = new System.Drawing.Point(253, 414);
            this.complemento_FornTextBox.Name = "complemento_FornTextBox";
            this.complemento_FornTextBox.Size = new System.Drawing.Size(121, 20);
            this.complemento_FornTextBox.TabIndex = 28;
            this.complemento_FornTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tel_FornLabel
            // 
            tel_FornLabel.AutoSize = true;
            tel_FornLabel.BackColor = System.Drawing.Color.Transparent;
            tel_FornLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            tel_FornLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            tel_FornLabel.Location = new System.Drawing.Point(23, 432);
            tel_FornLabel.Name = "tel_FornLabel";
            tel_FornLabel.Size = new System.Drawing.Size(96, 30);
            tel_FornLabel.TabIndex = 29;
            tel_FornLabel.Text = "Telefone:";
            // 
            // tel_FornMaskedTextBox
            // 
            this.tel_FornMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedoresBindingSource, "Tel_Forn", true));
            this.tel_FornMaskedTextBox.Location = new System.Drawing.Point(253, 440);
            this.tel_FornMaskedTextBox.Mask = "(99) 0000-0000";
            this.tel_FornMaskedTextBox.Name = "tel_FornMaskedTextBox";
            this.tel_FornMaskedTextBox.Size = new System.Drawing.Size(121, 20);
            this.tel_FornMaskedTextBox.TabIndex = 30;
            this.tel_FornMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cel_FornLabel
            // 
            cel_FornLabel.AutoSize = true;
            cel_FornLabel.BackColor = System.Drawing.Color.Transparent;
            cel_FornLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            cel_FornLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            cel_FornLabel.Location = new System.Drawing.Point(23, 458);
            cel_FornLabel.Name = "cel_FornLabel";
            cel_FornLabel.Size = new System.Drawing.Size(82, 30);
            cel_FornLabel.TabIndex = 31;
            cel_FornLabel.Text = "Celular:";
            // 
            // cel_FornMaskedTextBox
            // 
            this.cel_FornMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedoresBindingSource, "Cel_Forn", true));
            this.cel_FornMaskedTextBox.Location = new System.Drawing.Point(253, 466);
            this.cel_FornMaskedTextBox.Mask = "(99) 00000-0000";
            this.cel_FornMaskedTextBox.Name = "cel_FornMaskedTextBox";
            this.cel_FornMaskedTextBox.Size = new System.Drawing.Size(121, 20);
            this.cel_FornMaskedTextBox.TabIndex = 32;
            this.cel_FornMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // email_FornLabel
            // 
            email_FornLabel.AutoSize = true;
            email_FornLabel.BackColor = System.Drawing.Color.Transparent;
            email_FornLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            email_FornLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            email_FornLabel.Location = new System.Drawing.Point(23, 484);
            email_FornLabel.Name = "email_FornLabel";
            email_FornLabel.Size = new System.Drawing.Size(68, 30);
            email_FornLabel.TabIndex = 33;
            email_FornLabel.Text = "Email:";
            // 
            // email_FornTextBox
            // 
            this.email_FornTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedoresBindingSource, "Email_Forn", true));
            this.email_FornTextBox.Location = new System.Drawing.Point(253, 492);
            this.email_FornTextBox.Name = "email_FornTextBox";
            this.email_FornTextBox.Size = new System.Drawing.Size(121, 20);
            this.email_FornTextBox.TabIndex = 34;
            this.email_FornTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Lucida Sans", 11.25F);
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(286, 540);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 30);
            this.button2.TabIndex = 42;
            this.button2.Text = "&Fechar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmForn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(396, 573);
            this.Controls.Add(this.button2);
            this.Controls.Add(código_FornLabel);
            this.Controls.Add(this.código_FornTextBox);
            this.Controls.Add(códigoTransp_FornLabel);
            this.Controls.Add(this.códigoTransp_FornTextBox);
            this.Controls.Add(cNPJ_FornLabel);
            this.Controls.Add(this.cNPJ_FornMaskedTextBox);
            this.Controls.Add(razaoSocial_FornLabel);
            this.Controls.Add(this.razaoSocial_FornTextBox);
            this.Controls.Add(nomeEmp_FornLabel);
            this.Controls.Add(this.nomeEmp_FornTextBox);
            this.Controls.Add(responsavel_FornLabel);
            this.Controls.Add(this.responsavel_FornTextBox);
            this.Controls.Add(departamento_FornLabel);
            this.Controls.Add(this.departamento_FornComboBox);
            this.Controls.Add(cid_FornLabel);
            this.Controls.Add(this.cid_FornTextBox);
            this.Controls.Add(est_FornLabel);
            this.Controls.Add(this.est_FornComboBox);
            this.Controls.Add(cep_FornLabel);
            this.Controls.Add(this.cep_FornMaskedTextBox);
            this.Controls.Add(rua_FornLabel);
            this.Controls.Add(this.rua_FornTextBox);
            this.Controls.Add(n_FornLabel);
            this.Controls.Add(this.n_FornTextBox);
            this.Controls.Add(bairro_FornLabel);
            this.Controls.Add(this.bairro_FornTextBox);
            this.Controls.Add(complemento_FornLabel);
            this.Controls.Add(this.complemento_FornTextBox);
            this.Controls.Add(tel_FornLabel);
            this.Controls.Add(this.tel_FornMaskedTextBox);
            this.Controls.Add(cel_FornLabel);
            this.Controls.Add(this.cel_FornMaskedTextBox);
            this.Controls.Add(email_FornLabel);
            this.Controls.Add(this.email_FornTextBox);
            this.Controls.Add(this.fornecedoresBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmForn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fornecedores";
            this.Load += new System.EventHandler(this.FrmForn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.industria_MetalurgicaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingNavigator)).EndInit();
            this.fornecedoresBindingNavigator.ResumeLayout(false);
            this.fornecedoresBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Industria_MetalurgicaDataSet industria_MetalurgicaDataSet;
        private System.Windows.Forms.BindingSource fornecedoresBindingSource;
        private Industria_Metalurgica.Industria_MetalurgicaDataSetTableAdapters.FornecedoresTableAdapter fornecedoresTableAdapter;
        private Industria_Metalurgica.Industria_MetalurgicaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator fornecedoresBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton fornecedoresBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox código_FornTextBox;
        private System.Windows.Forms.TextBox códigoTransp_FornTextBox;
        private System.Windows.Forms.MaskedTextBox cNPJ_FornMaskedTextBox;
        private System.Windows.Forms.TextBox razaoSocial_FornTextBox;
        private System.Windows.Forms.TextBox nomeEmp_FornTextBox;
        private System.Windows.Forms.TextBox responsavel_FornTextBox;
        private System.Windows.Forms.ComboBox departamento_FornComboBox;
        private System.Windows.Forms.TextBox cid_FornTextBox;
        private System.Windows.Forms.ComboBox est_FornComboBox;
        private System.Windows.Forms.MaskedTextBox cep_FornMaskedTextBox;
        private System.Windows.Forms.TextBox rua_FornTextBox;
        private System.Windows.Forms.TextBox n_FornTextBox;
        private System.Windows.Forms.TextBox bairro_FornTextBox;
        private System.Windows.Forms.TextBox complemento_FornTextBox;
        private System.Windows.Forms.MaskedTextBox tel_FornMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox cel_FornMaskedTextBox;
        private System.Windows.Forms.TextBox email_FornTextBox;
        private System.Windows.Forms.Button button2;
    }
}