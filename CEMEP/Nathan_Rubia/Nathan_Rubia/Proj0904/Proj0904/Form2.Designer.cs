namespace Proj0904
{
    partial class FrmPaciente
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
            System.Windows.Forms.Label códPacienteLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label cPFLabel;
            System.Windows.Forms.Label rGLabel;
            System.Windows.Forms.Label sexoLabel;
            System.Windows.Forms.Label dtcadLabel;
            System.Windows.Forms.Label enderLabel;
            System.Windows.Forms.Label cidadeLabel;
            System.Windows.Forms.Label estadoLabel;
            System.Windows.Forms.Label foneLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPaciente));
            this.bDProva0904DataSet = new Proj0904.BDProva0904DataSet();
            this.pacienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pacienteTableAdapter = new Proj0904.BDProva0904DataSetTableAdapters.PacienteTableAdapter();
            this.tableAdapterManager = new Proj0904.BDProva0904DataSetTableAdapters.TableAdapterManager();
            this.pacienteBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.pacienteBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.códPacienteTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.cPFMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.rGMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.sexoComboBox = new System.Windows.Forms.ComboBox();
            this.dtcadDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.enderTextBox = new System.Windows.Forms.TextBox();
            this.cidadeTextBox = new System.Windows.Forms.TextBox();
            this.estadoComboBox = new System.Windows.Forms.ComboBox();
            this.foneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            códPacienteLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            cPFLabel = new System.Windows.Forms.Label();
            rGLabel = new System.Windows.Forms.Label();
            sexoLabel = new System.Windows.Forms.Label();
            dtcadLabel = new System.Windows.Forms.Label();
            enderLabel = new System.Windows.Forms.Label();
            cidadeLabel = new System.Windows.Forms.Label();
            estadoLabel = new System.Windows.Forms.Label();
            foneLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bDProva0904DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingNavigator)).BeginInit();
            this.pacienteBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // códPacienteLabel
            // 
            códPacienteLabel.AutoSize = true;
            códPacienteLabel.BackColor = System.Drawing.Color.Transparent;
            códPacienteLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            códPacienteLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            códPacienteLabel.Location = new System.Drawing.Point(21, 59);
            códPacienteLabel.Name = "códPacienteLabel";
            códPacienteLabel.Size = new System.Drawing.Size(63, 22);
            códPacienteLabel.TabIndex = 1;
            códPacienteLabel.Text = "Código:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.BackColor = System.Drawing.Color.Transparent;
            nomeLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomeLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            nomeLabel.Location = new System.Drawing.Point(21, 85);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(56, 22);
            nomeLabel.TabIndex = 3;
            nomeLabel.Text = "Nome:";
            // 
            // cPFLabel
            // 
            cPFLabel.AutoSize = true;
            cPFLabel.BackColor = System.Drawing.Color.Transparent;
            cPFLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cPFLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            cPFLabel.Location = new System.Drawing.Point(21, 111);
            cPFLabel.Name = "cPFLabel";
            cPFLabel.Size = new System.Drawing.Size(44, 22);
            cPFLabel.TabIndex = 5;
            cPFLabel.Text = "CPF:";
            // 
            // rGLabel
            // 
            rGLabel.AutoSize = true;
            rGLabel.BackColor = System.Drawing.Color.Transparent;
            rGLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            rGLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            rGLabel.Location = new System.Drawing.Point(21, 137);
            rGLabel.Name = "rGLabel";
            rGLabel.Size = new System.Drawing.Size(36, 22);
            rGLabel.TabIndex = 7;
            rGLabel.Text = "RG:";
            // 
            // sexoLabel
            // 
            sexoLabel.AutoSize = true;
            sexoLabel.BackColor = System.Drawing.Color.Transparent;
            sexoLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sexoLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            sexoLabel.Location = new System.Drawing.Point(21, 163);
            sexoLabel.Name = "sexoLabel";
            sexoLabel.Size = new System.Drawing.Size(46, 22);
            sexoLabel.TabIndex = 9;
            sexoLabel.Text = "Sexo:";
            // 
            // dtcadLabel
            // 
            dtcadLabel.AutoSize = true;
            dtcadLabel.BackColor = System.Drawing.Color.Transparent;
            dtcadLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dtcadLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dtcadLabel.Location = new System.Drawing.Point(21, 191);
            dtcadLabel.Name = "dtcadLabel";
            dtcadLabel.Size = new System.Drawing.Size(108, 22);
            dtcadLabel.TabIndex = 11;
            dtcadLabel.Text = "Data cadastro:";
            // 
            // enderLabel
            // 
            enderLabel.AutoSize = true;
            enderLabel.BackColor = System.Drawing.Color.Transparent;
            enderLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            enderLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            enderLabel.Location = new System.Drawing.Point(21, 216);
            enderLabel.Name = "enderLabel";
            enderLabel.Size = new System.Drawing.Size(77, 22);
            enderLabel.TabIndex = 13;
            enderLabel.Text = "Endereço:";
            // 
            // cidadeLabel
            // 
            cidadeLabel.AutoSize = true;
            cidadeLabel.BackColor = System.Drawing.Color.Transparent;
            cidadeLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cidadeLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            cidadeLabel.Location = new System.Drawing.Point(21, 242);
            cidadeLabel.Name = "cidadeLabel";
            cidadeLabel.Size = new System.Drawing.Size(62, 22);
            cidadeLabel.TabIndex = 15;
            cidadeLabel.Text = "Cidade:";
            // 
            // estadoLabel
            // 
            estadoLabel.AutoSize = true;
            estadoLabel.BackColor = System.Drawing.Color.Transparent;
            estadoLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            estadoLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            estadoLabel.Location = new System.Drawing.Point(21, 268);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new System.Drawing.Size(60, 22);
            estadoLabel.TabIndex = 17;
            estadoLabel.Text = "Estado:";
            // 
            // foneLabel
            // 
            foneLabel.AutoSize = true;
            foneLabel.BackColor = System.Drawing.Color.Transparent;
            foneLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            foneLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            foneLabel.Location = new System.Drawing.Point(21, 295);
            foneLabel.Name = "foneLabel";
            foneLabel.Size = new System.Drawing.Size(69, 22);
            foneLabel.TabIndex = 19;
            foneLabel.Text = "Telefone:";
            // 
            // bDProva0904DataSet
            // 
            this.bDProva0904DataSet.DataSetName = "BDProva0904DataSet";
            this.bDProva0904DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pacienteBindingSource
            // 
            this.pacienteBindingSource.DataMember = "Paciente";
            this.pacienteBindingSource.DataSource = this.bDProva0904DataSet;
            // 
            // pacienteTableAdapter
            // 
            this.pacienteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ConsultaTableAdapter = null;
            this.tableAdapterManager.PacienteTableAdapter = this.pacienteTableAdapter;
            this.tableAdapterManager.UpdateOrder = Proj0904.BDProva0904DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pacienteBindingNavigator
            // 
            this.pacienteBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pacienteBindingNavigator.BindingSource = this.pacienteBindingSource;
            this.pacienteBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pacienteBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pacienteBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.pacienteBindingNavigatorSaveItem});
            this.pacienteBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pacienteBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pacienteBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pacienteBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pacienteBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pacienteBindingNavigator.Name = "pacienteBindingNavigator";
            this.pacienteBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pacienteBindingNavigator.Size = new System.Drawing.Size(421, 25);
            this.pacienteBindingNavigator.TabIndex = 0;
            this.pacienteBindingNavigator.Text = "bindingNavigator1";
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
            // pacienteBindingNavigatorSaveItem
            // 
            this.pacienteBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pacienteBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pacienteBindingNavigatorSaveItem.Image")));
            this.pacienteBindingNavigatorSaveItem.Name = "pacienteBindingNavigatorSaveItem";
            this.pacienteBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.pacienteBindingNavigatorSaveItem.Text = "Save Data";
            this.pacienteBindingNavigatorSaveItem.Click += new System.EventHandler(this.pacienteBindingNavigatorSaveItem_Click);
            // 
            // códPacienteTextBox
            // 
            this.códPacienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "CódPaciente", true));
            this.códPacienteTextBox.Location = new System.Drawing.Point(132, 59);
            this.códPacienteTextBox.Name = "códPacienteTextBox";
            this.códPacienteTextBox.Size = new System.Drawing.Size(200, 20);
            this.códPacienteTextBox.TabIndex = 2;
            this.códPacienteTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(132, 85);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(200, 20);
            this.nomeTextBox.TabIndex = 4;
            this.nomeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cPFMaskedTextBox
            // 
            this.cPFMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "CPF", true));
            this.cPFMaskedTextBox.Location = new System.Drawing.Point(132, 111);
            this.cPFMaskedTextBox.Mask = "000.000.000-00";
            this.cPFMaskedTextBox.Name = "cPFMaskedTextBox";
            this.cPFMaskedTextBox.Size = new System.Drawing.Size(200, 20);
            this.cPFMaskedTextBox.TabIndex = 6;
            this.cPFMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rGMaskedTextBox
            // 
            this.rGMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "RG", true));
            this.rGMaskedTextBox.Location = new System.Drawing.Point(132, 137);
            this.rGMaskedTextBox.Mask = "00.000.000-0";
            this.rGMaskedTextBox.Name = "rGMaskedTextBox";
            this.rGMaskedTextBox.Size = new System.Drawing.Size(200, 20);
            this.rGMaskedTextBox.TabIndex = 8;
            this.rGMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sexoComboBox
            // 
            this.sexoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "Sexo", true));
            this.sexoComboBox.Items.AddRange(new object[] {
            "Feminino",
            "Masculino"});
            this.sexoComboBox.Location = new System.Drawing.Point(132, 163);
            this.sexoComboBox.Name = "sexoComboBox";
            this.sexoComboBox.Size = new System.Drawing.Size(200, 21);
            this.sexoComboBox.TabIndex = 10;
            // 
            // dtcadDateTimePicker
            // 
            this.dtcadDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pacienteBindingSource, "Dtcad", true));
            this.dtcadDateTimePicker.Location = new System.Drawing.Point(132, 190);
            this.dtcadDateTimePicker.Name = "dtcadDateTimePicker";
            this.dtcadDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dtcadDateTimePicker.TabIndex = 12;
            // 
            // enderTextBox
            // 
            this.enderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "Ender", true));
            this.enderTextBox.Location = new System.Drawing.Point(132, 216);
            this.enderTextBox.Name = "enderTextBox";
            this.enderTextBox.Size = new System.Drawing.Size(200, 20);
            this.enderTextBox.TabIndex = 14;
            this.enderTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cidadeTextBox
            // 
            this.cidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "Cidade", true));
            this.cidadeTextBox.Location = new System.Drawing.Point(132, 242);
            this.cidadeTextBox.Name = "cidadeTextBox";
            this.cidadeTextBox.Size = new System.Drawing.Size(200, 20);
            this.cidadeTextBox.TabIndex = 16;
            this.cidadeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // estadoComboBox
            // 
            this.estadoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "Estado", true));
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
            this.estadoComboBox.Location = new System.Drawing.Point(132, 268);
            this.estadoComboBox.Name = "estadoComboBox";
            this.estadoComboBox.Size = new System.Drawing.Size(200, 21);
            this.estadoComboBox.TabIndex = 18;
            // 
            // foneMaskedTextBox
            // 
            this.foneMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "Fone", true));
            this.foneMaskedTextBox.Location = new System.Drawing.Point(132, 295);
            this.foneMaskedTextBox.Mask = "(99) 0000-0000";
            this.foneMaskedTextBox.Name = "foneMaskedTextBox";
            this.foneMaskedTextBox.Size = new System.Drawing.Size(200, 20);
            this.foneMaskedTextBox.TabIndex = 20;
            this.foneMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(350, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 28);
            this.button1.TabIndex = 21;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.button1, "Fechar");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(421, 356);
            this.Controls.Add(this.button1);
            this.Controls.Add(códPacienteLabel);
            this.Controls.Add(this.códPacienteTextBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(cPFLabel);
            this.Controls.Add(this.cPFMaskedTextBox);
            this.Controls.Add(rGLabel);
            this.Controls.Add(this.rGMaskedTextBox);
            this.Controls.Add(sexoLabel);
            this.Controls.Add(this.sexoComboBox);
            this.Controls.Add(dtcadLabel);
            this.Controls.Add(this.dtcadDateTimePicker);
            this.Controls.Add(enderLabel);
            this.Controls.Add(this.enderTextBox);
            this.Controls.Add(cidadeLabel);
            this.Controls.Add(this.cidadeTextBox);
            this.Controls.Add(estadoLabel);
            this.Controls.Add(this.estadoComboBox);
            this.Controls.Add(foneLabel);
            this.Controls.Add(this.foneMaskedTextBox);
            this.Controls.Add(this.pacienteBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Paciente";
            this.Load += new System.EventHandler(this.FrmPaciente_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmPaciente_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.bDProva0904DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingNavigator)).EndInit();
            this.pacienteBindingNavigator.ResumeLayout(false);
            this.pacienteBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BDProva0904DataSet bDProva0904DataSet;
        private System.Windows.Forms.BindingSource pacienteBindingSource;
        private Proj0904.BDProva0904DataSetTableAdapters.PacienteTableAdapter pacienteTableAdapter;
        private Proj0904.BDProva0904DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pacienteBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton pacienteBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox códPacienteTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.MaskedTextBox cPFMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox rGMaskedTextBox;
        private System.Windows.Forms.ComboBox sexoComboBox;
        private System.Windows.Forms.DateTimePicker dtcadDateTimePicker;
        private System.Windows.Forms.TextBox enderTextBox;
        private System.Windows.Forms.TextBox cidadeTextBox;
        private System.Windows.Forms.ComboBox estadoComboBox;
        private System.Windows.Forms.MaskedTextBox foneMaskedTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}