namespace Proj2103
{
    partial class FrmCli
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
            System.Windows.Forms.Label codClienteLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label cPFLabel;
            System.Windows.Forms.Label rGLabel;
            System.Windows.Forms.Label sexoLabel;
            System.Windows.Forms.Label dataCadLabel;
            System.Windows.Forms.Label enderLabel;
            System.Windows.Forms.Label cidadeLabel;
            System.Windows.Forms.Label estadoLabel;
            System.Windows.Forms.Label foneLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCli));
            this.tabClienteBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.tabClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.tabClienteBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.button1 = new System.Windows.Forms.Button();
            this.tabClienteTableAdapter = new Proj2103.BD2103DataSetTableAdapters.TabClienteTableAdapter();
            this.tableAdapterManager = new Proj2103.BD2103DataSetTableAdapters.TableAdapterManager();
            this.codClienteTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.cPFMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.rGMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.sexoComboBox = new System.Windows.Forms.ComboBox();
            this.dataCadMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.enderTextBox = new System.Windows.Forms.TextBox();
            this.cidadeTextBox = new System.Windows.Forms.TextBox();
            this.estadoComboBox = new System.Windows.Forms.ComboBox();
            this.foneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            codClienteLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            cPFLabel = new System.Windows.Forms.Label();
            rGLabel = new System.Windows.Forms.Label();
            sexoLabel = new System.Windows.Forms.Label();
            dataCadLabel = new System.Windows.Forms.Label();
            enderLabel = new System.Windows.Forms.Label();
            cidadeLabel = new System.Windows.Forms.Label();
            estadoLabel = new System.Windows.Forms.Label();
            foneLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tabClienteBindingNavigator)).BeginInit();
            this.tabClienteBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD2103DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // codClienteLabel
            // 
            codClienteLabel.AutoSize = true;
            codClienteLabel.BackColor = System.Drawing.Color.Transparent;
            codClienteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            codClienteLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            codClienteLabel.Location = new System.Drawing.Point(80, 79);
            codClienteLabel.Name = "codClienteLabel";
            codClienteLabel.Size = new System.Drawing.Size(55, 16);
            codClienteLabel.TabIndex = 21;
            codClienteLabel.Text = "Código:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.BackColor = System.Drawing.Color.Transparent;
            nomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomeLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            nomeLabel.Location = new System.Drawing.Point(80, 105);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(48, 16);
            nomeLabel.TabIndex = 23;
            nomeLabel.Text = "Nome:";
            // 
            // cPFLabel
            // 
            cPFLabel.AutoSize = true;
            cPFLabel.BackColor = System.Drawing.Color.Transparent;
            cPFLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cPFLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            cPFLabel.Location = new System.Drawing.Point(80, 131);
            cPFLabel.Name = "cPFLabel";
            cPFLabel.Size = new System.Drawing.Size(37, 16);
            cPFLabel.TabIndex = 25;
            cPFLabel.Text = "CPF:";
            // 
            // rGLabel
            // 
            rGLabel.AutoSize = true;
            rGLabel.BackColor = System.Drawing.Color.Transparent;
            rGLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            rGLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            rGLabel.Location = new System.Drawing.Point(80, 157);
            rGLabel.Name = "rGLabel";
            rGLabel.Size = new System.Drawing.Size(31, 16);
            rGLabel.TabIndex = 27;
            rGLabel.Text = "RG:";
            // 
            // sexoLabel
            // 
            sexoLabel.AutoSize = true;
            sexoLabel.BackColor = System.Drawing.Color.Transparent;
            sexoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sexoLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            sexoLabel.Location = new System.Drawing.Point(80, 183);
            sexoLabel.Name = "sexoLabel";
            sexoLabel.Size = new System.Drawing.Size(42, 16);
            sexoLabel.TabIndex = 29;
            sexoLabel.Text = "Sexo:";
            // 
            // dataCadLabel
            // 
            dataCadLabel.AutoSize = true;
            dataCadLabel.BackColor = System.Drawing.Color.Transparent;
            dataCadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataCadLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataCadLabel.Location = new System.Drawing.Point(80, 210);
            dataCadLabel.Name = "dataCadLabel";
            dataCadLabel.Size = new System.Drawing.Size(68, 16);
            dataCadLabel.TabIndex = 31;
            dataCadLabel.Text = "Data Cad:";
            // 
            // enderLabel
            // 
            enderLabel.AutoSize = true;
            enderLabel.BackColor = System.Drawing.Color.Transparent;
            enderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            enderLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            enderLabel.Location = new System.Drawing.Point(80, 236);
            enderLabel.Name = "enderLabel";
            enderLabel.Size = new System.Drawing.Size(70, 16);
            enderLabel.TabIndex = 33;
            enderLabel.Text = "Endereço:";
            // 
            // cidadeLabel
            // 
            cidadeLabel.AutoSize = true;
            cidadeLabel.BackColor = System.Drawing.Color.Transparent;
            cidadeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cidadeLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            cidadeLabel.Location = new System.Drawing.Point(80, 262);
            cidadeLabel.Name = "cidadeLabel";
            cidadeLabel.Size = new System.Drawing.Size(55, 16);
            cidadeLabel.TabIndex = 35;
            cidadeLabel.Text = "Cidade:";
            // 
            // estadoLabel
            // 
            estadoLabel.AutoSize = true;
            estadoLabel.BackColor = System.Drawing.Color.Transparent;
            estadoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            estadoLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            estadoLabel.Location = new System.Drawing.Point(80, 288);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new System.Drawing.Size(54, 16);
            estadoLabel.TabIndex = 37;
            estadoLabel.Text = "Estado:";
            // 
            // foneLabel
            // 
            foneLabel.AutoSize = true;
            foneLabel.BackColor = System.Drawing.Color.Transparent;
            foneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            foneLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            foneLabel.Location = new System.Drawing.Point(80, 315);
            foneLabel.Name = "foneLabel";
            foneLabel.Size = new System.Drawing.Size(42, 16);
            foneLabel.TabIndex = 39;
            foneLabel.Text = "Fone:";
            // 
            // tabClienteBindingNavigator
            // 
            this.tabClienteBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tabClienteBindingNavigator.BindingSource = this.tabClienteBindingSource;
            this.tabClienteBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tabClienteBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tabClienteBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tabClienteBindingNavigatorSaveItem});
            this.tabClienteBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tabClienteBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tabClienteBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tabClienteBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tabClienteBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tabClienteBindingNavigator.Name = "tabClienteBindingNavigator";
            this.tabClienteBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tabClienteBindingNavigator.Size = new System.Drawing.Size(386, 25);
            this.tabClienteBindingNavigator.TabIndex = 0;
            this.tabClienteBindingNavigator.Text = "bindingNavigator1";
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
            // tabClienteBindingSource
            // 
            this.tabClienteBindingSource.DataMember = "TabCliente";
            this.tabClienteBindingSource.DataSource = this.bD2103DataSet;
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
            // tabClienteBindingNavigatorSaveItem
            // 
            this.tabClienteBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tabClienteBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tabClienteBindingNavigatorSaveItem.Image")));
            this.tabClienteBindingNavigatorSaveItem.Name = "tabClienteBindingNavigatorSaveItem";
            this.tabClienteBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tabClienteBindingNavigatorSaveItem.Text = "Save Data";
            this.tabClienteBindingNavigatorSaveItem.Click += new System.EventHandler(this.tabClienteBindingNavigatorSaveItem_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(187, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "&Fechar";
            this.toolTip1.SetToolTip(this.button1, "Fechar");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabClienteTableAdapter
            // 
            this.tabClienteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TabClienteTableAdapter = this.tabClienteTableAdapter;
            this.tableAdapterManager.TabFilmeTableAdapter = null;
            this.tableAdapterManager.TabLocacaoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Proj2103.BD2103DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // codClienteTextBox
            // 
            this.codClienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabClienteBindingSource, "CodCliente", true));
            this.codClienteTextBox.Location = new System.Drawing.Point(178, 75);
            this.codClienteTextBox.Name = "codClienteTextBox";
            this.codClienteTextBox.Size = new System.Drawing.Size(121, 20);
            this.codClienteTextBox.TabIndex = 22;
            this.codClienteTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabClienteBindingSource, "Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(178, 101);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(121, 20);
            this.nomeTextBox.TabIndex = 24;
            this.nomeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cPFMaskedTextBox
            // 
            this.cPFMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabClienteBindingSource, "CPF", true));
            this.cPFMaskedTextBox.Location = new System.Drawing.Point(178, 127);
            this.cPFMaskedTextBox.Mask = "000.000.000-00";
            this.cPFMaskedTextBox.Name = "cPFMaskedTextBox";
            this.cPFMaskedTextBox.Size = new System.Drawing.Size(121, 20);
            this.cPFMaskedTextBox.TabIndex = 26;
            this.cPFMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rGMaskedTextBox
            // 
            this.rGMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabClienteBindingSource, "RG", true));
            this.rGMaskedTextBox.Location = new System.Drawing.Point(178, 153);
            this.rGMaskedTextBox.Mask = "00.000.000-00";
            this.rGMaskedTextBox.Name = "rGMaskedTextBox";
            this.rGMaskedTextBox.Size = new System.Drawing.Size(121, 20);
            this.rGMaskedTextBox.TabIndex = 28;
            this.rGMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sexoComboBox
            // 
            this.sexoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabClienteBindingSource, "Sexo", true));
            this.sexoComboBox.FormattingEnabled = true;
            this.sexoComboBox.Items.AddRange(new object[] {
            "Feminino",
            "Masculino"});
            this.sexoComboBox.Location = new System.Drawing.Point(178, 179);
            this.sexoComboBox.Name = "sexoComboBox";
            this.sexoComboBox.Size = new System.Drawing.Size(121, 21);
            this.sexoComboBox.TabIndex = 30;
            // 
            // dataCadMaskedTextBox
            // 
            this.dataCadMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabClienteBindingSource, "DataCad", true));
            this.dataCadMaskedTextBox.Location = new System.Drawing.Point(178, 206);
            this.dataCadMaskedTextBox.Mask = "00/00/0000";
            this.dataCadMaskedTextBox.Name = "dataCadMaskedTextBox";
            this.dataCadMaskedTextBox.Size = new System.Drawing.Size(121, 20);
            this.dataCadMaskedTextBox.TabIndex = 32;
            this.dataCadMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dataCadMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // enderTextBox
            // 
            this.enderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabClienteBindingSource, "Ender", true));
            this.enderTextBox.Location = new System.Drawing.Point(178, 232);
            this.enderTextBox.Name = "enderTextBox";
            this.enderTextBox.Size = new System.Drawing.Size(121, 20);
            this.enderTextBox.TabIndex = 34;
            this.enderTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cidadeTextBox
            // 
            this.cidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabClienteBindingSource, "Cidade", true));
            this.cidadeTextBox.Location = new System.Drawing.Point(178, 258);
            this.cidadeTextBox.Name = "cidadeTextBox";
            this.cidadeTextBox.Size = new System.Drawing.Size(121, 20);
            this.cidadeTextBox.TabIndex = 36;
            this.cidadeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // estadoComboBox
            // 
            this.estadoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabClienteBindingSource, "Estado", true));
            this.estadoComboBox.FormattingEnabled = true;
            this.estadoComboBox.Items.AddRange(new object[] {
            "Acre",
            "Alagoas",
            "Amapá",
            "Amazonas",
            "Bahia",
            "Ceará",
            "Distrito Federal",
            "Espírito Santo",
            "Goiás",
            "Maranhão",
            "Mato Grosso",
            "Mato Grosso do Sul",
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
            "Santa Catarina",
            "São Paulo",
            "Sergipe",
            "Tocantins"});
            this.estadoComboBox.Location = new System.Drawing.Point(178, 284);
            this.estadoComboBox.Name = "estadoComboBox";
            this.estadoComboBox.Size = new System.Drawing.Size(121, 21);
            this.estadoComboBox.TabIndex = 38;
            // 
            // foneMaskedTextBox
            // 
            this.foneMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabClienteBindingSource, "Fone", true));
            this.foneMaskedTextBox.Location = new System.Drawing.Point(178, 311);
            this.foneMaskedTextBox.Mask = "(00) 0000-0000";
            this.foneMaskedTextBox.Name = "foneMaskedTextBox";
            this.foneMaskedTextBox.Size = new System.Drawing.Size(121, 20);
            this.foneMaskedTextBox.TabIndex = 40;
            this.foneMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FrmCli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(386, 417);
            this.Controls.Add(codClienteLabel);
            this.Controls.Add(this.codClienteTextBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(cPFLabel);
            this.Controls.Add(this.cPFMaskedTextBox);
            this.Controls.Add(rGLabel);
            this.Controls.Add(this.rGMaskedTextBox);
            this.Controls.Add(sexoLabel);
            this.Controls.Add(this.sexoComboBox);
            this.Controls.Add(dataCadLabel);
            this.Controls.Add(this.dataCadMaskedTextBox);
            this.Controls.Add(enderLabel);
            this.Controls.Add(this.enderTextBox);
            this.Controls.Add(cidadeLabel);
            this.Controls.Add(this.cidadeTextBox);
            this.Controls.Add(estadoLabel);
            this.Controls.Add(this.estadoComboBox);
            this.Controls.Add(foneLabel);
            this.Controls.Add(this.foneMaskedTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabClienteBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Clientes";
            this.Load += new System.EventHandler(this.FrmCli_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmCli_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.tabClienteBindingNavigator)).EndInit();
            this.tabClienteBindingNavigator.ResumeLayout(false);
            this.tabClienteBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD2103DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BD2103DataSet bD2103DataSet;
        private System.Windows.Forms.BindingSource tabClienteBindingSource;
        private Proj2103.BD2103DataSetTableAdapters.TabClienteTableAdapter tabClienteTableAdapter;
        private Proj2103.BD2103DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tabClienteBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tabClienteBindingNavigatorSaveItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox codClienteTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.MaskedTextBox cPFMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox rGMaskedTextBox;
        private System.Windows.Forms.ComboBox sexoComboBox;
        private System.Windows.Forms.MaskedTextBox dataCadMaskedTextBox;
        private System.Windows.Forms.TextBox enderTextBox;
        private System.Windows.Forms.TextBox cidadeTextBox;
        private System.Windows.Forms.ComboBox estadoComboBox;
        private System.Windows.Forms.MaskedTextBox foneMaskedTextBox;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}