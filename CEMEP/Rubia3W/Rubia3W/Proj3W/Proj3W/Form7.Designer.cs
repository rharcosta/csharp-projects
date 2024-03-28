namespace Proj3W
{
    partial class FrmEmp
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
            System.Windows.Forms.Label codCliLabel;
            System.Windows.Forms.Label rSocialLabel;
            System.Windows.Forms.Label cNPJLabel;
            System.Windows.Forms.Label enderLabel;
            System.Windows.Forms.Label cidadeLabel;
            System.Windows.Forms.Label estadoLabel;
            System.Windows.Forms.Label cEPLabel;
            System.Windows.Forms.Label foneLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label contatoLabel;
            System.Windows.Forms.Label dataCadLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmp));
            this.tabCliempresaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tabCliempresaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.codCliTextBox = new System.Windows.Forms.TextBox();
            this.rSocialTextBox = new System.Windows.Forms.TextBox();
            this.cNPJMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.enderTextBox = new System.Windows.Forms.TextBox();
            this.cidadeTextBox = new System.Windows.Forms.TextBox();
            this.estadoComboBox = new System.Windows.Forms.ComboBox();
            this.cEPMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.foneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.contatoTextBox = new System.Windows.Forms.TextBox();
            this.dataCadDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabCliempresaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD3WDataSet = new Proj3W.BD3WDataSet();
            this.tabCliempresaTableAdapter = new Proj3W.BD3WDataSetTableAdapters.TabCliempresaTableAdapter();
            this.tableAdapterManager = new Proj3W.BD3WDataSetTableAdapters.TableAdapterManager();
            codCliLabel = new System.Windows.Forms.Label();
            rSocialLabel = new System.Windows.Forms.Label();
            cNPJLabel = new System.Windows.Forms.Label();
            enderLabel = new System.Windows.Forms.Label();
            cidadeLabel = new System.Windows.Forms.Label();
            estadoLabel = new System.Windows.Forms.Label();
            cEPLabel = new System.Windows.Forms.Label();
            foneLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            contatoLabel = new System.Windows.Forms.Label();
            dataCadLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tabCliempresaBindingNavigator)).BeginInit();
            this.tabCliempresaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabCliempresaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD3WDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // codCliLabel
            // 
            codCliLabel.AutoSize = true;
            codCliLabel.BackColor = System.Drawing.Color.Transparent;
            codCliLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F);
            codCliLabel.ForeColor = System.Drawing.Color.White;
            codCliLabel.Location = new System.Drawing.Point(20, 43);
            codCliLabel.Name = "codCliLabel";
            codCliLabel.Size = new System.Drawing.Size(92, 25);
            codCliLabel.TabIndex = 1;
            codCliLabel.Text = "Código:";
            // 
            // rSocialLabel
            // 
            rSocialLabel.AutoSize = true;
            rSocialLabel.BackColor = System.Drawing.Color.Transparent;
            rSocialLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F);
            rSocialLabel.ForeColor = System.Drawing.Color.White;
            rSocialLabel.Location = new System.Drawing.Point(20, 69);
            rSocialLabel.Name = "rSocialLabel";
            rSocialLabel.Size = new System.Drawing.Size(147, 25);
            rSocialLabel.TabIndex = 3;
            rSocialLabel.Text = "Razão Social:";
            // 
            // cNPJLabel
            // 
            cNPJLabel.AutoSize = true;
            cNPJLabel.BackColor = System.Drawing.Color.Transparent;
            cNPJLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F);
            cNPJLabel.ForeColor = System.Drawing.Color.White;
            cNPJLabel.Location = new System.Drawing.Point(20, 95);
            cNPJLabel.Name = "cNPJLabel";
            cNPJLabel.Size = new System.Drawing.Size(69, 25);
            cNPJLabel.TabIndex = 5;
            cNPJLabel.Text = "CNPJ:";
            // 
            // enderLabel
            // 
            enderLabel.AutoSize = true;
            enderLabel.BackColor = System.Drawing.Color.Transparent;
            enderLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F);
            enderLabel.ForeColor = System.Drawing.Color.White;
            enderLabel.Location = new System.Drawing.Point(20, 121);
            enderLabel.Name = "enderLabel";
            enderLabel.Size = new System.Drawing.Size(113, 25);
            enderLabel.TabIndex = 7;
            enderLabel.Text = "Endereço:";
            // 
            // cidadeLabel
            // 
            cidadeLabel.AutoSize = true;
            cidadeLabel.BackColor = System.Drawing.Color.Transparent;
            cidadeLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F);
            cidadeLabel.ForeColor = System.Drawing.Color.White;
            cidadeLabel.Location = new System.Drawing.Point(20, 147);
            cidadeLabel.Name = "cidadeLabel";
            cidadeLabel.Size = new System.Drawing.Size(90, 25);
            cidadeLabel.TabIndex = 9;
            cidadeLabel.Text = "Cidade:";
            // 
            // estadoLabel
            // 
            estadoLabel.AutoSize = true;
            estadoLabel.BackColor = System.Drawing.Color.Transparent;
            estadoLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F);
            estadoLabel.ForeColor = System.Drawing.Color.White;
            estadoLabel.Location = new System.Drawing.Point(20, 173);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new System.Drawing.Size(87, 25);
            estadoLabel.TabIndex = 11;
            estadoLabel.Text = "Estado:";
            // 
            // cEPLabel
            // 
            cEPLabel.AutoSize = true;
            cEPLabel.BackColor = System.Drawing.Color.Transparent;
            cEPLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F);
            cEPLabel.ForeColor = System.Drawing.Color.White;
            cEPLabel.Location = new System.Drawing.Point(20, 200);
            cEPLabel.Name = "cEPLabel";
            cEPLabel.Size = new System.Drawing.Size(57, 25);
            cEPLabel.TabIndex = 13;
            cEPLabel.Text = "CEP:";
            // 
            // foneLabel
            // 
            foneLabel.AutoSize = true;
            foneLabel.BackColor = System.Drawing.Color.Transparent;
            foneLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F);
            foneLabel.ForeColor = System.Drawing.Color.White;
            foneLabel.Location = new System.Drawing.Point(20, 226);
            foneLabel.Name = "foneLabel";
            foneLabel.Size = new System.Drawing.Size(108, 25);
            foneLabel.TabIndex = 15;
            foneLabel.Text = "Telefone:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.BackColor = System.Drawing.Color.Transparent;
            emailLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F);
            emailLabel.ForeColor = System.Drawing.Color.White;
            emailLabel.Location = new System.Drawing.Point(20, 252);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(74, 25);
            emailLabel.TabIndex = 17;
            emailLabel.Text = "Email:";
            // 
            // contatoLabel
            // 
            contatoLabel.AutoSize = true;
            contatoLabel.BackColor = System.Drawing.Color.Transparent;
            contatoLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F);
            contatoLabel.ForeColor = System.Drawing.Color.White;
            contatoLabel.Location = new System.Drawing.Point(20, 278);
            contatoLabel.Name = "contatoLabel";
            contatoLabel.Size = new System.Drawing.Size(101, 25);
            contatoLabel.TabIndex = 19;
            contatoLabel.Text = "Contato:";
            // 
            // dataCadLabel
            // 
            dataCadLabel.AutoSize = true;
            dataCadLabel.BackColor = System.Drawing.Color.Transparent;
            dataCadLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F);
            dataCadLabel.ForeColor = System.Drawing.Color.White;
            dataCadLabel.Location = new System.Drawing.Point(20, 305);
            dataCadLabel.Name = "dataCadLabel";
            dataCadLabel.Size = new System.Drawing.Size(199, 25);
            dataCadLabel.TabIndex = 21;
            dataCadLabel.Text = "Data de Cadastro:";
            // 
            // tabCliempresaBindingNavigator
            // 
            this.tabCliempresaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tabCliempresaBindingNavigator.BindingSource = this.tabCliempresaBindingSource;
            this.tabCliempresaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tabCliempresaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tabCliempresaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tabCliempresaBindingNavigatorSaveItem});
            this.tabCliempresaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tabCliempresaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tabCliempresaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tabCliempresaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tabCliempresaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tabCliempresaBindingNavigator.Name = "tabCliempresaBindingNavigator";
            this.tabCliempresaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tabCliempresaBindingNavigator.Size = new System.Drawing.Size(484, 25);
            this.tabCliempresaBindingNavigator.TabIndex = 0;
            this.tabCliempresaBindingNavigator.Text = "bindingNavigator1";
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
            // tabCliempresaBindingNavigatorSaveItem
            // 
            this.tabCliempresaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tabCliempresaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tabCliempresaBindingNavigatorSaveItem.Image")));
            this.tabCliempresaBindingNavigatorSaveItem.Name = "tabCliempresaBindingNavigatorSaveItem";
            this.tabCliempresaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tabCliempresaBindingNavigatorSaveItem.Text = "Save Data";
            this.tabCliempresaBindingNavigatorSaveItem.Click += new System.EventHandler(this.tabCliempresaBindingNavigatorSaveItem_Click);
            // 
            // codCliTextBox
            // 
            this.codCliTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabCliempresaBindingSource, "CodCli", true));
            this.codCliTextBox.Location = new System.Drawing.Point(225, 48);
            this.codCliTextBox.Name = "codCliTextBox";
            this.codCliTextBox.ReadOnly = true;
            this.codCliTextBox.Size = new System.Drawing.Size(233, 20);
            this.codCliTextBox.TabIndex = 1;
            this.codCliTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rSocialTextBox
            // 
            this.rSocialTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabCliempresaBindingSource, "RSocial", true));
            this.rSocialTextBox.Location = new System.Drawing.Point(225, 74);
            this.rSocialTextBox.Name = "rSocialTextBox";
            this.rSocialTextBox.Size = new System.Drawing.Size(233, 20);
            this.rSocialTextBox.TabIndex = 2;
            this.rSocialTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cNPJMaskedTextBox
            // 
            this.cNPJMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabCliempresaBindingSource, "CNPJ", true));
            this.cNPJMaskedTextBox.Location = new System.Drawing.Point(225, 100);
            this.cNPJMaskedTextBox.Mask = "000,000,000,00";
            this.cNPJMaskedTextBox.Name = "cNPJMaskedTextBox";
            this.cNPJMaskedTextBox.Size = new System.Drawing.Size(233, 20);
            this.cNPJMaskedTextBox.TabIndex = 3;
            this.cNPJMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // enderTextBox
            // 
            this.enderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabCliempresaBindingSource, "Ender", true));
            this.enderTextBox.Location = new System.Drawing.Point(225, 126);
            this.enderTextBox.Name = "enderTextBox";
            this.enderTextBox.Size = new System.Drawing.Size(233, 20);
            this.enderTextBox.TabIndex = 4;
            this.enderTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cidadeTextBox
            // 
            this.cidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabCliempresaBindingSource, "Cidade", true));
            this.cidadeTextBox.Location = new System.Drawing.Point(225, 152);
            this.cidadeTextBox.Name = "cidadeTextBox";
            this.cidadeTextBox.Size = new System.Drawing.Size(233, 20);
            this.cidadeTextBox.TabIndex = 5;
            this.cidadeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // estadoComboBox
            // 
            this.estadoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabCliempresaBindingSource, "Estado", true));
            this.estadoComboBox.FormattingEnabled = true;
            this.estadoComboBox.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BH",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.estadoComboBox.Location = new System.Drawing.Point(225, 178);
            this.estadoComboBox.Name = "estadoComboBox";
            this.estadoComboBox.Size = new System.Drawing.Size(233, 21);
            this.estadoComboBox.TabIndex = 6;
            // 
            // cEPMaskedTextBox
            // 
            this.cEPMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabCliempresaBindingSource, "CEP", true));
            this.cEPMaskedTextBox.Location = new System.Drawing.Point(225, 205);
            this.cEPMaskedTextBox.Name = "cEPMaskedTextBox";
            this.cEPMaskedTextBox.Size = new System.Drawing.Size(233, 20);
            this.cEPMaskedTextBox.TabIndex = 7;
            this.cEPMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // foneMaskedTextBox
            // 
            this.foneMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabCliempresaBindingSource, "Fone", true));
            this.foneMaskedTextBox.Location = new System.Drawing.Point(225, 231);
            this.foneMaskedTextBox.Mask = "(00)0000-0000";
            this.foneMaskedTextBox.Name = "foneMaskedTextBox";
            this.foneMaskedTextBox.Size = new System.Drawing.Size(233, 20);
            this.foneMaskedTextBox.TabIndex = 8;
            this.foneMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabCliempresaBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(225, 257);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(233, 20);
            this.emailTextBox.TabIndex = 9;
            this.emailTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // contatoTextBox
            // 
            this.contatoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabCliempresaBindingSource, "Contato", true));
            this.contatoTextBox.Location = new System.Drawing.Point(225, 283);
            this.contatoTextBox.Name = "contatoTextBox";
            this.contatoTextBox.Size = new System.Drawing.Size(233, 20);
            this.contatoTextBox.TabIndex = 10;
            this.contatoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataCadDateTimePicker
            // 
            this.dataCadDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tabCliempresaBindingSource, "DataCad", true));
            this.dataCadDateTimePicker.Location = new System.Drawing.Point(225, 309);
            this.dataCadDateTimePicker.Name = "dataCadDateTimePicker";
            this.dataCadDateTimePicker.Size = new System.Drawing.Size(233, 20);
            this.dataCadDateTimePicker.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Lucida Sans", 11.25F);
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(370, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 30);
            this.button1.TabIndex = 23;
            this.button1.Text = "&Fechar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.button1, "Fechar");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabCliempresaBindingSource
            // 
            this.tabCliempresaBindingSource.DataMember = "TabCliempresa";
            this.tabCliempresaBindingSource.DataSource = this.bD3WDataSet;
            // 
            // bD3WDataSet
            // 
            this.bD3WDataSet.DataSetName = "BD3WDataSet";
            this.bD3WDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabCliempresaTableAdapter
            // 
            this.tabCliempresaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TabCandidatoTableAdapter = null;
            this.tableAdapterManager.TabCliempresaTableAdapter = this.tabCliempresaTableAdapter;
            this.tableAdapterManager.TabUsuarioTableAdapter = null;
            this.tableAdapterManager.TabVagasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Proj3W.BD3WDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FrmEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(484, 408);
            this.Controls.Add(this.button1);
            this.Controls.Add(codCliLabel);
            this.Controls.Add(this.codCliTextBox);
            this.Controls.Add(rSocialLabel);
            this.Controls.Add(this.rSocialTextBox);
            this.Controls.Add(cNPJLabel);
            this.Controls.Add(this.cNPJMaskedTextBox);
            this.Controls.Add(enderLabel);
            this.Controls.Add(this.enderTextBox);
            this.Controls.Add(cidadeLabel);
            this.Controls.Add(this.cidadeTextBox);
            this.Controls.Add(estadoLabel);
            this.Controls.Add(this.estadoComboBox);
            this.Controls.Add(cEPLabel);
            this.Controls.Add(this.cEPMaskedTextBox);
            this.Controls.Add(foneLabel);
            this.Controls.Add(this.foneMaskedTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(contatoLabel);
            this.Controls.Add(this.contatoTextBox);
            this.Controls.Add(dataCadLabel);
            this.Controls.Add(this.dataCadDateTimePicker);
            this.Controls.Add(this.tabCliempresaBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEmp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Empresas";
            this.Load += new System.EventHandler(this.FrmEmp_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmEmp_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.tabCliempresaBindingNavigator)).EndInit();
            this.tabCliempresaBindingNavigator.ResumeLayout(false);
            this.tabCliempresaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabCliempresaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD3WDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BD3WDataSet bD3WDataSet;
        private System.Windows.Forms.BindingSource tabCliempresaBindingSource;
        private Proj3W.BD3WDataSetTableAdapters.TabCliempresaTableAdapter tabCliempresaTableAdapter;
        private Proj3W.BD3WDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tabCliempresaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tabCliempresaBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox codCliTextBox;
        private System.Windows.Forms.TextBox rSocialTextBox;
        private System.Windows.Forms.MaskedTextBox cNPJMaskedTextBox;
        private System.Windows.Forms.TextBox enderTextBox;
        private System.Windows.Forms.TextBox cidadeTextBox;
        private System.Windows.Forms.ComboBox estadoComboBox;
        private System.Windows.Forms.MaskedTextBox cEPMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox foneMaskedTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox contatoTextBox;
        private System.Windows.Forms.DateTimePicker dataCadDateTimePicker;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}