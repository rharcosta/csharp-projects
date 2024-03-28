namespace Proj3W
{
    partial class FrmCand
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
            System.Windows.Forms.Label codCandLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label vagaLabel;
            System.Windows.Forms.Label cPFLabel;
            System.Windows.Forms.Label rGLabel;
            System.Windows.Forms.Label sexoLabel;
            System.Windows.Forms.Label dataNascLabel;
            System.Windows.Forms.Label enderLabel;
            System.Windows.Forms.Label cidadeLabel;
            System.Windows.Forms.Label estadoLabel;
            System.Windows.Forms.Label cEPLabel;
            System.Windows.Forms.Label foneLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label profisLabel;
            System.Windows.Forms.Label dtCadLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCand));
            this.bD3WDataSet = new Proj3W.BD3WDataSet();
            this.tabCandidatoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabCandidatoTableAdapter = new Proj3W.BD3WDataSetTableAdapters.TabCandidatoTableAdapter();
            this.tableAdapterManager = new Proj3W.BD3WDataSetTableAdapters.TableAdapterManager();
            this.tabCandidatoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tabCandidatoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.codCandTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.vagaTextBox = new System.Windows.Forms.TextBox();
            this.cPFMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.rGMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.sexoComboBox = new System.Windows.Forms.ComboBox();
            this.dataNascDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.enderTextBox = new System.Windows.Forms.TextBox();
            this.cidadeTextBox = new System.Windows.Forms.TextBox();
            this.estadoComboBox = new System.Windows.Forms.ComboBox();
            this.cEPTextBox = new System.Windows.Forms.TextBox();
            this.foneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.profisTextBox = new System.Windows.Forms.TextBox();
            this.dtCadDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabVagasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabVagasTableAdapter = new Proj3W.BD3WDataSetTableAdapters.TabVagasTableAdapter();
            codCandLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            vagaLabel = new System.Windows.Forms.Label();
            cPFLabel = new System.Windows.Forms.Label();
            rGLabel = new System.Windows.Forms.Label();
            sexoLabel = new System.Windows.Forms.Label();
            dataNascLabel = new System.Windows.Forms.Label();
            enderLabel = new System.Windows.Forms.Label();
            cidadeLabel = new System.Windows.Forms.Label();
            estadoLabel = new System.Windows.Forms.Label();
            cEPLabel = new System.Windows.Forms.Label();
            foneLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            profisLabel = new System.Windows.Forms.Label();
            dtCadLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bD3WDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabCandidatoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabCandidatoBindingNavigator)).BeginInit();
            this.tabCandidatoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabVagasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // codCandLabel
            // 
            codCandLabel.AutoSize = true;
            codCandLabel.BackColor = System.Drawing.Color.Transparent;
            codCandLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F);
            codCandLabel.ForeColor = System.Drawing.Color.White;
            codCandLabel.Location = new System.Drawing.Point(23, 48);
            codCandLabel.Name = "codCandLabel";
            codCandLabel.Size = new System.Drawing.Size(92, 25);
            codCandLabel.TabIndex = 1;
            codCandLabel.Text = "Código:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.BackColor = System.Drawing.Color.Transparent;
            nomeLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F);
            nomeLabel.ForeColor = System.Drawing.Color.White;
            nomeLabel.Location = new System.Drawing.Point(23, 74);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(80, 25);
            nomeLabel.TabIndex = 3;
            nomeLabel.Text = "Nome:";
            // 
            // vagaLabel
            // 
            vagaLabel.AutoSize = true;
            vagaLabel.BackColor = System.Drawing.Color.Transparent;
            vagaLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F);
            vagaLabel.ForeColor = System.Drawing.Color.White;
            vagaLabel.Location = new System.Drawing.Point(23, 100);
            vagaLabel.Name = "vagaLabel";
            vagaLabel.Size = new System.Drawing.Size(70, 25);
            vagaLabel.TabIndex = 5;
            vagaLabel.Text = "Vaga:";
            // 
            // cPFLabel
            // 
            cPFLabel.AutoSize = true;
            cPFLabel.BackColor = System.Drawing.Color.Transparent;
            cPFLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F);
            cPFLabel.ForeColor = System.Drawing.Color.White;
            cPFLabel.Location = new System.Drawing.Point(23, 126);
            cPFLabel.Name = "cPFLabel";
            cPFLabel.Size = new System.Drawing.Size(57, 25);
            cPFLabel.TabIndex = 7;
            cPFLabel.Text = "CPF:";
            // 
            // rGLabel
            // 
            rGLabel.AutoSize = true;
            rGLabel.BackColor = System.Drawing.Color.Transparent;
            rGLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F);
            rGLabel.ForeColor = System.Drawing.Color.White;
            rGLabel.Location = new System.Drawing.Point(23, 152);
            rGLabel.Name = "rGLabel";
            rGLabel.Size = new System.Drawing.Size(47, 25);
            rGLabel.TabIndex = 9;
            rGLabel.Text = "RG:";
            // 
            // sexoLabel
            // 
            sexoLabel.AutoSize = true;
            sexoLabel.BackColor = System.Drawing.Color.Transparent;
            sexoLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F);
            sexoLabel.ForeColor = System.Drawing.Color.White;
            sexoLabel.Location = new System.Drawing.Point(23, 178);
            sexoLabel.Name = "sexoLabel";
            sexoLabel.Size = new System.Drawing.Size(68, 25);
            sexoLabel.TabIndex = 11;
            sexoLabel.Text = "Sexo:";
            // 
            // dataNascLabel
            // 
            dataNascLabel.AutoSize = true;
            dataNascLabel.BackColor = System.Drawing.Color.Transparent;
            dataNascLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F);
            dataNascLabel.ForeColor = System.Drawing.Color.White;
            dataNascLabel.Location = new System.Drawing.Point(23, 206);
            dataNascLabel.Name = "dataNascLabel";
            dataNascLabel.Size = new System.Drawing.Size(228, 25);
            dataNascLabel.TabIndex = 13;
            dataNascLabel.Text = "Data de Nascimento:";
            // 
            // enderLabel
            // 
            enderLabel.AutoSize = true;
            enderLabel.BackColor = System.Drawing.Color.Transparent;
            enderLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F);
            enderLabel.ForeColor = System.Drawing.Color.White;
            enderLabel.Location = new System.Drawing.Point(23, 231);
            enderLabel.Name = "enderLabel";
            enderLabel.Size = new System.Drawing.Size(113, 25);
            enderLabel.TabIndex = 15;
            enderLabel.Text = "Endereço:";
            // 
            // cidadeLabel
            // 
            cidadeLabel.AutoSize = true;
            cidadeLabel.BackColor = System.Drawing.Color.Transparent;
            cidadeLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F);
            cidadeLabel.ForeColor = System.Drawing.Color.White;
            cidadeLabel.Location = new System.Drawing.Point(23, 257);
            cidadeLabel.Name = "cidadeLabel";
            cidadeLabel.Size = new System.Drawing.Size(90, 25);
            cidadeLabel.TabIndex = 17;
            cidadeLabel.Text = "Cidade:";
            // 
            // estadoLabel
            // 
            estadoLabel.AutoSize = true;
            estadoLabel.BackColor = System.Drawing.Color.Transparent;
            estadoLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F);
            estadoLabel.ForeColor = System.Drawing.Color.White;
            estadoLabel.Location = new System.Drawing.Point(23, 283);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new System.Drawing.Size(87, 25);
            estadoLabel.TabIndex = 19;
            estadoLabel.Text = "Estado:";
            // 
            // cEPLabel
            // 
            cEPLabel.AutoSize = true;
            cEPLabel.BackColor = System.Drawing.Color.Transparent;
            cEPLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F);
            cEPLabel.ForeColor = System.Drawing.Color.White;
            cEPLabel.Location = new System.Drawing.Point(23, 310);
            cEPLabel.Name = "cEPLabel";
            cEPLabel.Size = new System.Drawing.Size(57, 25);
            cEPLabel.TabIndex = 21;
            cEPLabel.Text = "CEP:";
            // 
            // foneLabel
            // 
            foneLabel.AutoSize = true;
            foneLabel.BackColor = System.Drawing.Color.Transparent;
            foneLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F);
            foneLabel.ForeColor = System.Drawing.Color.White;
            foneLabel.Location = new System.Drawing.Point(23, 336);
            foneLabel.Name = "foneLabel";
            foneLabel.Size = new System.Drawing.Size(108, 25);
            foneLabel.TabIndex = 23;
            foneLabel.Text = "Telefone:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.BackColor = System.Drawing.Color.Transparent;
            emailLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F);
            emailLabel.ForeColor = System.Drawing.Color.White;
            emailLabel.Location = new System.Drawing.Point(23, 362);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(74, 25);
            emailLabel.TabIndex = 25;
            emailLabel.Text = "Email:";
            // 
            // profisLabel
            // 
            profisLabel.AutoSize = true;
            profisLabel.BackColor = System.Drawing.Color.Transparent;
            profisLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F);
            profisLabel.ForeColor = System.Drawing.Color.White;
            profisLabel.Location = new System.Drawing.Point(23, 388);
            profisLabel.Name = "profisLabel";
            profisLabel.Size = new System.Drawing.Size(114, 25);
            profisLabel.TabIndex = 27;
            profisLabel.Text = "Profissão:";
            // 
            // dtCadLabel
            // 
            dtCadLabel.AutoSize = true;
            dtCadLabel.BackColor = System.Drawing.Color.Transparent;
            dtCadLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F);
            dtCadLabel.ForeColor = System.Drawing.Color.White;
            dtCadLabel.Location = new System.Drawing.Point(23, 415);
            dtCadLabel.Name = "dtCadLabel";
            dtCadLabel.Size = new System.Drawing.Size(167, 25);
            dtCadLabel.TabIndex = 29;
            dtCadLabel.Text = "Data Cadastro:";
            // 
            // bD3WDataSet
            // 
            this.bD3WDataSet.DataSetName = "BD3WDataSet";
            this.bD3WDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabCandidatoBindingSource
            // 
            this.tabCandidatoBindingSource.DataMember = "TabCandidato";
            this.tabCandidatoBindingSource.DataSource = this.bD3WDataSet;
            // 
            // tabCandidatoTableAdapter
            // 
            this.tabCandidatoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TabCandidatoTableAdapter = this.tabCandidatoTableAdapter;
            this.tableAdapterManager.TabCliempresaTableAdapter = null;
            this.tableAdapterManager.TabUsuarioTableAdapter = null;
            this.tableAdapterManager.TabVagasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Proj3W.BD3WDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tabCandidatoBindingNavigator
            // 
            this.tabCandidatoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tabCandidatoBindingNavigator.BindingSource = this.tabCandidatoBindingSource;
            this.tabCandidatoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tabCandidatoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tabCandidatoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tabCandidatoBindingNavigatorSaveItem});
            this.tabCandidatoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tabCandidatoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tabCandidatoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tabCandidatoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tabCandidatoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tabCandidatoBindingNavigator.Name = "tabCandidatoBindingNavigator";
            this.tabCandidatoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tabCandidatoBindingNavigator.Size = new System.Drawing.Size(624, 25);
            this.tabCandidatoBindingNavigator.TabIndex = 0;
            this.tabCandidatoBindingNavigator.Text = "bindingNavigator1";
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
            // tabCandidatoBindingNavigatorSaveItem
            // 
            this.tabCandidatoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tabCandidatoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tabCandidatoBindingNavigatorSaveItem.Image")));
            this.tabCandidatoBindingNavigatorSaveItem.Name = "tabCandidatoBindingNavigatorSaveItem";
            this.tabCandidatoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tabCandidatoBindingNavigatorSaveItem.Text = "Save Data";
            this.tabCandidatoBindingNavigatorSaveItem.Click += new System.EventHandler(this.tabCandidatoBindingNavigatorSaveItem_Click);
            // 
            // codCandTextBox
            // 
            this.codCandTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabCandidatoBindingSource, "CodCand", true));
            this.codCandTextBox.Location = new System.Drawing.Point(258, 54);
            this.codCandTextBox.Name = "codCandTextBox";
            this.codCandTextBox.ReadOnly = true;
            this.codCandTextBox.Size = new System.Drawing.Size(200, 20);
            this.codCandTextBox.TabIndex = 1;
            this.codCandTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabCandidatoBindingSource, "Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(258, 80);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(200, 20);
            this.nomeTextBox.TabIndex = 2;
            this.nomeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // vagaTextBox
            // 
            this.vagaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabCandidatoBindingSource, "Vaga", true));
            this.vagaTextBox.Location = new System.Drawing.Point(258, 106);
            this.vagaTextBox.Name = "vagaTextBox";
            this.vagaTextBox.Size = new System.Drawing.Size(200, 20);
            this.vagaTextBox.TabIndex = 3;
            this.vagaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cPFMaskedTextBox
            // 
            this.cPFMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabCandidatoBindingSource, "CPF", true));
            this.cPFMaskedTextBox.Location = new System.Drawing.Point(258, 132);
            this.cPFMaskedTextBox.Mask = "000,000,000-00";
            this.cPFMaskedTextBox.Name = "cPFMaskedTextBox";
            this.cPFMaskedTextBox.Size = new System.Drawing.Size(200, 20);
            this.cPFMaskedTextBox.TabIndex = 4;
            this.cPFMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rGMaskedTextBox
            // 
            this.rGMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabCandidatoBindingSource, "RG", true));
            this.rGMaskedTextBox.Location = new System.Drawing.Point(258, 158);
            this.rGMaskedTextBox.Mask = "00,000,000-0";
            this.rGMaskedTextBox.Name = "rGMaskedTextBox";
            this.rGMaskedTextBox.Size = new System.Drawing.Size(200, 20);
            this.rGMaskedTextBox.TabIndex = 5;
            this.rGMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sexoComboBox
            // 
            this.sexoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabCandidatoBindingSource, "Sexo", true));
            this.sexoComboBox.FormattingEnabled = true;
            this.sexoComboBox.Items.AddRange(new object[] {
            "Feminino",
            "Maculino",
            "Outro"});
            this.sexoComboBox.Location = new System.Drawing.Point(258, 184);
            this.sexoComboBox.Name = "sexoComboBox";
            this.sexoComboBox.Size = new System.Drawing.Size(200, 21);
            this.sexoComboBox.TabIndex = 6;
            // 
            // dataNascDateTimePicker
            // 
            this.dataNascDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tabCandidatoBindingSource, "DataNasc", true));
            this.dataNascDateTimePicker.Location = new System.Drawing.Point(258, 211);
            this.dataNascDateTimePicker.Name = "dataNascDateTimePicker";
            this.dataNascDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dataNascDateTimePicker.TabIndex = 7;
            // 
            // enderTextBox
            // 
            this.enderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabCandidatoBindingSource, "Ender", true));
            this.enderTextBox.Location = new System.Drawing.Point(258, 237);
            this.enderTextBox.Name = "enderTextBox";
            this.enderTextBox.Size = new System.Drawing.Size(200, 20);
            this.enderTextBox.TabIndex = 8;
            this.enderTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cidadeTextBox
            // 
            this.cidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabCandidatoBindingSource, "Cidade", true));
            this.cidadeTextBox.Location = new System.Drawing.Point(258, 263);
            this.cidadeTextBox.Name = "cidadeTextBox";
            this.cidadeTextBox.Size = new System.Drawing.Size(200, 20);
            this.cidadeTextBox.TabIndex = 9;
            this.cidadeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // estadoComboBox
            // 
            this.estadoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabCandidatoBindingSource, "Estado", true));
            this.estadoComboBox.FormattingEnabled = true;
            this.estadoComboBox.Items.AddRange(new object[] {
            "",
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
            this.estadoComboBox.Location = new System.Drawing.Point(258, 289);
            this.estadoComboBox.Name = "estadoComboBox";
            this.estadoComboBox.Size = new System.Drawing.Size(200, 21);
            this.estadoComboBox.TabIndex = 10;
            // 
            // cEPTextBox
            // 
            this.cEPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabCandidatoBindingSource, "CEP", true));
            this.cEPTextBox.Location = new System.Drawing.Point(258, 316);
            this.cEPTextBox.Name = "cEPTextBox";
            this.cEPTextBox.Size = new System.Drawing.Size(200, 20);
            this.cEPTextBox.TabIndex = 11;
            this.cEPTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // foneMaskedTextBox
            // 
            this.foneMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabCandidatoBindingSource, "Fone", true));
            this.foneMaskedTextBox.Location = new System.Drawing.Point(258, 342);
            this.foneMaskedTextBox.Mask = "(00)0000-0000";
            this.foneMaskedTextBox.Name = "foneMaskedTextBox";
            this.foneMaskedTextBox.Size = new System.Drawing.Size(200, 20);
            this.foneMaskedTextBox.TabIndex = 12;
            this.foneMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabCandidatoBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(258, 368);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(200, 20);
            this.emailTextBox.TabIndex = 13;
            this.emailTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // profisTextBox
            // 
            this.profisTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabCandidatoBindingSource, "Profis", true));
            this.profisTextBox.Location = new System.Drawing.Point(258, 394);
            this.profisTextBox.Name = "profisTextBox";
            this.profisTextBox.Size = new System.Drawing.Size(200, 20);
            this.profisTextBox.TabIndex = 14;
            this.profisTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtCadDateTimePicker
            // 
            this.dtCadDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tabCandidatoBindingSource, "DtCad", true));
            this.dtCadDateTimePicker.Location = new System.Drawing.Point(258, 420);
            this.dtCadDateTimePicker.Name = "dtCadDateTimePicker";
            this.dtCadDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dtCadDateTimePicker.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Lucida Sans", 11.25F);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(370, 478);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 30);
            this.button1.TabIndex = 16;
            this.button1.Text = "&Fechar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.button1, "Fechar");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.tabVagasBindingSource;
            this.comboBox1.DisplayMember = "CodVaga";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(464, 104);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 30;
            this.comboBox1.ValueMember = "CodVaga";
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
            // FrmCand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(624, 520);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(codCandLabel);
            this.Controls.Add(this.codCandTextBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(vagaLabel);
            this.Controls.Add(this.vagaTextBox);
            this.Controls.Add(cPFLabel);
            this.Controls.Add(this.cPFMaskedTextBox);
            this.Controls.Add(rGLabel);
            this.Controls.Add(this.rGMaskedTextBox);
            this.Controls.Add(sexoLabel);
            this.Controls.Add(this.sexoComboBox);
            this.Controls.Add(dataNascLabel);
            this.Controls.Add(this.dataNascDateTimePicker);
            this.Controls.Add(enderLabel);
            this.Controls.Add(this.enderTextBox);
            this.Controls.Add(cidadeLabel);
            this.Controls.Add(this.cidadeTextBox);
            this.Controls.Add(estadoLabel);
            this.Controls.Add(this.estadoComboBox);
            this.Controls.Add(cEPLabel);
            this.Controls.Add(this.cEPTextBox);
            this.Controls.Add(foneLabel);
            this.Controls.Add(this.foneMaskedTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(profisLabel);
            this.Controls.Add(this.profisTextBox);
            this.Controls.Add(dtCadLabel);
            this.Controls.Add(this.dtCadDateTimePicker);
            this.Controls.Add(this.tabCandidatoBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCand";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Candidatos";
            this.Load += new System.EventHandler(this.FrmCand_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmCand_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.bD3WDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabCandidatoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabCandidatoBindingNavigator)).EndInit();
            this.tabCandidatoBindingNavigator.ResumeLayout(false);
            this.tabCandidatoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabVagasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BD3WDataSet bD3WDataSet;
        private System.Windows.Forms.BindingSource tabCandidatoBindingSource;
        private Proj3W.BD3WDataSetTableAdapters.TabCandidatoTableAdapter tabCandidatoTableAdapter;
        private Proj3W.BD3WDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tabCandidatoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tabCandidatoBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox codCandTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox vagaTextBox;
        private System.Windows.Forms.MaskedTextBox cPFMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox rGMaskedTextBox;
        private System.Windows.Forms.ComboBox sexoComboBox;
        private System.Windows.Forms.DateTimePicker dataNascDateTimePicker;
        private System.Windows.Forms.TextBox enderTextBox;
        private System.Windows.Forms.TextBox cidadeTextBox;
        private System.Windows.Forms.ComboBox estadoComboBox;
        private System.Windows.Forms.TextBox cEPTextBox;
        private System.Windows.Forms.MaskedTextBox foneMaskedTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox profisTextBox;
        private System.Windows.Forms.DateTimePicker dtCadDateTimePicker;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource tabVagasBindingSource;
        private Proj3W.BD3WDataSetTableAdapters.TabVagasTableAdapter tabVagasTableAdapter;
    }
}