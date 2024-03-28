namespace Proj0108
{
    partial class FrmEditora
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
            System.Windows.Forms.Label codEditoraLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label enderecoLabel;
            System.Windows.Forms.Label cidadeLabel;
            System.Windows.Forms.Label ufLabel;
            System.Windows.Forms.Label telefoneLabel;
            System.Windows.Forms.Label cNPJLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditora));
            this.bancoDataSet = new Proj0108.BancoDataSet();
            this.tabEditoraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabEditoraTableAdapter = new Proj0108.BancoDataSetTableAdapters.TabEditoraTableAdapter();
            this.tableAdapterManager = new Proj0108.BancoDataSetTableAdapters.TableAdapterManager();
            this.tabEditoraBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tabEditoraBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.codEditoraTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.enderecoTextBox = new System.Windows.Forms.TextBox();
            this.cidadeTextBox = new System.Windows.Forms.TextBox();
            this.ufComboBox = new System.Windows.Forms.ComboBox();
            this.telefoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cNPJMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            codEditoraLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            enderecoLabel = new System.Windows.Forms.Label();
            cidadeLabel = new System.Windows.Forms.Label();
            ufLabel = new System.Windows.Forms.Label();
            telefoneLabel = new System.Windows.Forms.Label();
            cNPJLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bancoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabEditoraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabEditoraBindingNavigator)).BeginInit();
            this.tabEditoraBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // codEditoraLabel
            // 
            codEditoraLabel.AutoSize = true;
            codEditoraLabel.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            codEditoraLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            codEditoraLabel.Location = new System.Drawing.Point(12, 70);
            codEditoraLabel.Name = "codEditoraLabel";
            codEditoraLabel.Size = new System.Drawing.Size(75, 26);
            codEditoraLabel.TabIndex = 1;
            codEditoraLabel.Text = "Código:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomeLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            nomeLabel.Location = new System.Drawing.Point(12, 96);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(69, 26);
            nomeLabel.TabIndex = 3;
            nomeLabel.Text = "Nome:";
            // 
            // enderecoLabel
            // 
            enderecoLabel.AutoSize = true;
            enderecoLabel.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            enderecoLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            enderecoLabel.Location = new System.Drawing.Point(12, 122);
            enderecoLabel.Name = "enderecoLabel";
            enderecoLabel.Size = new System.Drawing.Size(94, 26);
            enderecoLabel.TabIndex = 5;
            enderecoLabel.Text = "Endereço:";
            // 
            // cidadeLabel
            // 
            cidadeLabel.AutoSize = true;
            cidadeLabel.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cidadeLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            cidadeLabel.Location = new System.Drawing.Point(12, 148);
            cidadeLabel.Name = "cidadeLabel";
            cidadeLabel.Size = new System.Drawing.Size(74, 26);
            cidadeLabel.TabIndex = 7;
            cidadeLabel.Text = "Cidade:";
            // 
            // ufLabel
            // 
            ufLabel.AutoSize = true;
            ufLabel.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ufLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            ufLabel.Location = new System.Drawing.Point(12, 174);
            ufLabel.Name = "ufLabel";
            ufLabel.Size = new System.Drawing.Size(39, 26);
            ufLabel.TabIndex = 9;
            ufLabel.Text = "Uf:";
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            telefoneLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            telefoneLabel.Location = new System.Drawing.Point(12, 201);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(88, 26);
            telefoneLabel.TabIndex = 11;
            telefoneLabel.Text = "Telefone:";
            // 
            // cNPJLabel
            // 
            cNPJLabel.AutoSize = true;
            cNPJLabel.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cNPJLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            cNPJLabel.Location = new System.Drawing.Point(12, 227);
            cNPJLabel.Name = "cNPJLabel";
            cNPJLabel.Size = new System.Drawing.Size(64, 26);
            cNPJLabel.TabIndex = 13;
            cNPJLabel.Text = "CNPJ:";
            // 
            // bancoDataSet
            // 
            this.bancoDataSet.DataSetName = "BancoDataSet";
            this.bancoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabEditoraBindingSource
            // 
            this.tabEditoraBindingSource.DataMember = "TabEditora";
            this.tabEditoraBindingSource.DataSource = this.bancoDataSet;
            // 
            // tabEditoraTableAdapter
            // 
            this.tabEditoraTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TabEditoraTableAdapter = this.tabEditoraTableAdapter;
            this.tableAdapterManager.TabLivroTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Proj0108.BancoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tabEditoraBindingNavigator
            // 
            this.tabEditoraBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tabEditoraBindingNavigator.BindingSource = this.tabEditoraBindingSource;
            this.tabEditoraBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tabEditoraBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tabEditoraBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tabEditoraBindingNavigatorSaveItem});
            this.tabEditoraBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tabEditoraBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tabEditoraBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tabEditoraBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tabEditoraBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tabEditoraBindingNavigator.Name = "tabEditoraBindingNavigator";
            this.tabEditoraBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tabEditoraBindingNavigator.Size = new System.Drawing.Size(294, 25);
            this.tabEditoraBindingNavigator.TabIndex = 0;
            this.tabEditoraBindingNavigator.Text = "bindingNavigator1";
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
            // tabEditoraBindingNavigatorSaveItem
            // 
            this.tabEditoraBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tabEditoraBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tabEditoraBindingNavigatorSaveItem.Image")));
            this.tabEditoraBindingNavigatorSaveItem.Name = "tabEditoraBindingNavigatorSaveItem";
            this.tabEditoraBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tabEditoraBindingNavigatorSaveItem.Text = "Save Data";
            this.tabEditoraBindingNavigatorSaveItem.Click += new System.EventHandler(this.tabEditoraBindingNavigatorSaveItem_Click);
            // 
            // codEditoraTextBox
            // 
            this.codEditoraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabEditoraBindingSource, "CodEditora", true));
            this.codEditoraTextBox.Location = new System.Drawing.Point(152, 76);
            this.codEditoraTextBox.Name = "codEditoraTextBox";
            this.codEditoraTextBox.Size = new System.Drawing.Size(121, 20);
            this.codEditoraTextBox.TabIndex = 2;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabEditoraBindingSource, "Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(152, 102);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(121, 20);
            this.nomeTextBox.TabIndex = 4;
            // 
            // enderecoTextBox
            // 
            this.enderecoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabEditoraBindingSource, "Endereco", true));
            this.enderecoTextBox.Location = new System.Drawing.Point(152, 128);
            this.enderecoTextBox.Name = "enderecoTextBox";
            this.enderecoTextBox.Size = new System.Drawing.Size(121, 20);
            this.enderecoTextBox.TabIndex = 6;
            // 
            // cidadeTextBox
            // 
            this.cidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabEditoraBindingSource, "Cidade", true));
            this.cidadeTextBox.Location = new System.Drawing.Point(152, 154);
            this.cidadeTextBox.Name = "cidadeTextBox";
            this.cidadeTextBox.Size = new System.Drawing.Size(121, 20);
            this.cidadeTextBox.TabIndex = 8;
            // 
            // ufComboBox
            // 
            this.ufComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabEditoraBindingSource, "Uf", true));
            this.ufComboBox.FormattingEnabled = true;
            this.ufComboBox.Items.AddRange(new object[] {
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
            this.ufComboBox.Location = new System.Drawing.Point(152, 180);
            this.ufComboBox.Name = "ufComboBox";
            this.ufComboBox.Size = new System.Drawing.Size(121, 21);
            this.ufComboBox.TabIndex = 10;
            // 
            // telefoneMaskedTextBox
            // 
            this.telefoneMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabEditoraBindingSource, "Telefone", true));
            this.telefoneMaskedTextBox.Location = new System.Drawing.Point(152, 207);
            this.telefoneMaskedTextBox.Name = "telefoneMaskedTextBox";
            this.telefoneMaskedTextBox.Size = new System.Drawing.Size(121, 20);
            this.telefoneMaskedTextBox.TabIndex = 12;
            // 
            // cNPJMaskedTextBox
            // 
            this.cNPJMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabEditoraBindingSource, "CNPJ", true));
            this.cNPJMaskedTextBox.Location = new System.Drawing.Point(152, 233);
            this.cNPJMaskedTextBox.Name = "cNPJMaskedTextBox";
            this.cNPJMaskedTextBox.Size = new System.Drawing.Size(121, 20);
            this.cNPJMaskedTextBox.TabIndex = 14;
            // 
            // FrmEditora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(294, 332);
            this.Controls.Add(codEditoraLabel);
            this.Controls.Add(this.codEditoraTextBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(enderecoLabel);
            this.Controls.Add(this.enderecoTextBox);
            this.Controls.Add(cidadeLabel);
            this.Controls.Add(this.cidadeTextBox);
            this.Controls.Add(ufLabel);
            this.Controls.Add(this.ufComboBox);
            this.Controls.Add(telefoneLabel);
            this.Controls.Add(this.telefoneMaskedTextBox);
            this.Controls.Add(cNPJLabel);
            this.Controls.Add(this.cNPJMaskedTextBox);
            this.Controls.Add(this.tabEditoraBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEditora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Editora";
            this.Load += new System.EventHandler(this.FrmEditora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bancoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabEditoraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabEditoraBindingNavigator)).EndInit();
            this.tabEditoraBindingNavigator.ResumeLayout(false);
            this.tabEditoraBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BancoDataSet bancoDataSet;
        private System.Windows.Forms.BindingSource tabEditoraBindingSource;
        private Proj0108.BancoDataSetTableAdapters.TabEditoraTableAdapter tabEditoraTableAdapter;
        private Proj0108.BancoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tabEditoraBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tabEditoraBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox codEditoraTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox enderecoTextBox;
        private System.Windows.Forms.TextBox cidadeTextBox;
        private System.Windows.Forms.ComboBox ufComboBox;
        private System.Windows.Forms.MaskedTextBox telefoneMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox cNPJMaskedTextBox;
    }
}