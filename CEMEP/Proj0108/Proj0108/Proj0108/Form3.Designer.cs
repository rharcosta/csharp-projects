namespace Proj0108
{
    partial class FrmLivro
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
            System.Windows.Forms.Label codLivroLabel;
            System.Windows.Forms.Label tituloLabel;
            System.Windows.Forms.Label codEditoraLabel;
            System.Windows.Forms.Label edicaoLabel;
            System.Windows.Forms.Label anoLabel;
            System.Windows.Forms.Label iSBNLabel;
            System.Windows.Forms.Label autorLabel;
            System.Windows.Forms.Label capaLabel;
            System.Windows.Forms.Label sinopseLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLivro));
            this.bancoDataSet = new Proj0108.BancoDataSet();
            this.tabLivroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabLivroTableAdapter = new Proj0108.BancoDataSetTableAdapters.TabLivroTableAdapter();
            this.tableAdapterManager = new Proj0108.BancoDataSetTableAdapters.TableAdapterManager();
            this.tabLivroBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tabLivroBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.codLivroTextBox = new System.Windows.Forms.TextBox();
            this.tituloTextBox = new System.Windows.Forms.TextBox();
            this.codEditoraTextBox = new System.Windows.Forms.TextBox();
            this.edicaoTextBox = new System.Windows.Forms.TextBox();
            this.anoTextBox = new System.Windows.Forms.TextBox();
            this.iSBNTextBox = new System.Windows.Forms.TextBox();
            this.autorTextBox = new System.Windows.Forms.TextBox();
            this.capaPictureBox = new System.Windows.Forms.PictureBox();
            this.sinopseTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bancoDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabEditoraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabEditoraTableAdapter = new Proj0108.BancoDataSetTableAdapters.TabEditoraTableAdapter();
            codLivroLabel = new System.Windows.Forms.Label();
            tituloLabel = new System.Windows.Forms.Label();
            codEditoraLabel = new System.Windows.Forms.Label();
            edicaoLabel = new System.Windows.Forms.Label();
            anoLabel = new System.Windows.Forms.Label();
            iSBNLabel = new System.Windows.Forms.Label();
            autorLabel = new System.Windows.Forms.Label();
            capaLabel = new System.Windows.Forms.Label();
            sinopseLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bancoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabLivroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabLivroBindingNavigator)).BeginInit();
            this.tabLivroBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.capaPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabEditoraBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // codLivroLabel
            // 
            codLivroLabel.AutoSize = true;
            codLivroLabel.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            codLivroLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            codLivroLabel.Location = new System.Drawing.Point(21, 45);
            codLivroLabel.Name = "codLivroLabel";
            codLivroLabel.Size = new System.Drawing.Size(75, 26);
            codLivroLabel.TabIndex = 1;
            codLivroLabel.Text = "Código:";
            // 
            // tituloLabel
            // 
            tituloLabel.AutoSize = true;
            tituloLabel.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tituloLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            tituloLabel.Location = new System.Drawing.Point(21, 71);
            tituloLabel.Name = "tituloLabel";
            tituloLabel.Size = new System.Drawing.Size(67, 26);
            tituloLabel.TabIndex = 3;
            tituloLabel.Text = "Título:";
            // 
            // codEditoraLabel
            // 
            codEditoraLabel.AutoSize = true;
            codEditoraLabel.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            codEditoraLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            codEditoraLabel.Location = new System.Drawing.Point(21, 97);
            codEditoraLabel.Name = "codEditoraLabel";
            codEditoraLabel.Size = new System.Drawing.Size(115, 26);
            codEditoraLabel.TabIndex = 5;
            codEditoraLabel.Text = "Cód Editora:";
            // 
            // edicaoLabel
            // 
            edicaoLabel.AutoSize = true;
            edicaoLabel.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            edicaoLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            edicaoLabel.Location = new System.Drawing.Point(21, 123);
            edicaoLabel.Name = "edicaoLabel";
            edicaoLabel.Size = new System.Drawing.Size(72, 26);
            edicaoLabel.TabIndex = 7;
            edicaoLabel.Text = "Edição:";
            // 
            // anoLabel
            // 
            anoLabel.AutoSize = true;
            anoLabel.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            anoLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            anoLabel.Location = new System.Drawing.Point(21, 149);
            anoLabel.Name = "anoLabel";
            anoLabel.Size = new System.Drawing.Size(53, 26);
            anoLabel.TabIndex = 9;
            anoLabel.Text = "Ano:";
            // 
            // iSBNLabel
            // 
            iSBNLabel.AutoSize = true;
            iSBNLabel.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iSBNLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            iSBNLabel.Location = new System.Drawing.Point(21, 175);
            iSBNLabel.Name = "iSBNLabel";
            iSBNLabel.Size = new System.Drawing.Size(63, 26);
            iSBNLabel.TabIndex = 11;
            iSBNLabel.Text = "ISBN:";
            // 
            // autorLabel
            // 
            autorLabel.AutoSize = true;
            autorLabel.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            autorLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            autorLabel.Location = new System.Drawing.Point(21, 201);
            autorLabel.Name = "autorLabel";
            autorLabel.Size = new System.Drawing.Size(65, 26);
            autorLabel.TabIndex = 13;
            autorLabel.Text = "Autor:";
            // 
            // capaLabel
            // 
            capaLabel.AutoSize = true;
            capaLabel.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            capaLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            capaLabel.Location = new System.Drawing.Point(21, 224);
            capaLabel.Name = "capaLabel";
            capaLabel.Size = new System.Drawing.Size(58, 26);
            capaLabel.TabIndex = 15;
            capaLabel.Text = "Capa:";
            // 
            // sinopseLabel
            // 
            sinopseLabel.AutoSize = true;
            sinopseLabel.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sinopseLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            sinopseLabel.Location = new System.Drawing.Point(21, 283);
            sinopseLabel.Name = "sinopseLabel";
            sinopseLabel.Size = new System.Drawing.Size(81, 26);
            sinopseLabel.TabIndex = 17;
            sinopseLabel.Text = "Sinopse:";
            // 
            // bancoDataSet
            // 
            this.bancoDataSet.DataSetName = "BancoDataSet";
            this.bancoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabLivroBindingSource
            // 
            this.tabLivroBindingSource.DataMember = "TabLivro";
            this.tabLivroBindingSource.DataSource = this.bancoDataSet;
            // 
            // tabLivroTableAdapter
            // 
            this.tabLivroTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TabEditoraTableAdapter = null;
            this.tableAdapterManager.TabLivroTableAdapter = this.tabLivroTableAdapter;
            this.tableAdapterManager.UpdateOrder = Proj0108.BancoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tabLivroBindingNavigator
            // 
            this.tabLivroBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tabLivroBindingNavigator.BindingSource = this.tabLivroBindingSource;
            this.tabLivroBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tabLivroBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tabLivroBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tabLivroBindingNavigatorSaveItem});
            this.tabLivroBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tabLivroBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tabLivroBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tabLivroBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tabLivroBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tabLivroBindingNavigator.Name = "tabLivroBindingNavigator";
            this.tabLivroBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tabLivroBindingNavigator.Size = new System.Drawing.Size(393, 25);
            this.tabLivroBindingNavigator.TabIndex = 0;
            this.tabLivroBindingNavigator.Text = "bindingNavigator1";
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
            // tabLivroBindingNavigatorSaveItem
            // 
            this.tabLivroBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tabLivroBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tabLivroBindingNavigatorSaveItem.Image")));
            this.tabLivroBindingNavigatorSaveItem.Name = "tabLivroBindingNavigatorSaveItem";
            this.tabLivroBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tabLivroBindingNavigatorSaveItem.Text = "Save Data";
            this.tabLivroBindingNavigatorSaveItem.Click += new System.EventHandler(this.tabLivroBindingNavigatorSaveItem_Click);
            // 
            // codLivroTextBox
            // 
            this.codLivroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabLivroBindingSource, "CodLivro", true));
            this.codLivroTextBox.Location = new System.Drawing.Point(153, 45);
            this.codLivroTextBox.Name = "codLivroTextBox";
            this.codLivroTextBox.Size = new System.Drawing.Size(100, 20);
            this.codLivroTextBox.TabIndex = 2;
            // 
            // tituloTextBox
            // 
            this.tituloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabLivroBindingSource, "Titulo", true));
            this.tituloTextBox.Location = new System.Drawing.Point(153, 71);
            this.tituloTextBox.Name = "tituloTextBox";
            this.tituloTextBox.Size = new System.Drawing.Size(100, 20);
            this.tituloTextBox.TabIndex = 4;
            // 
            // codEditoraTextBox
            // 
            this.codEditoraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabLivroBindingSource, "CodEditora", true));
            this.codEditoraTextBox.Location = new System.Drawing.Point(153, 97);
            this.codEditoraTextBox.Name = "codEditoraTextBox";
            this.codEditoraTextBox.Size = new System.Drawing.Size(100, 20);
            this.codEditoraTextBox.TabIndex = 6;
            // 
            // edicaoTextBox
            // 
            this.edicaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabLivroBindingSource, "Edicao", true));
            this.edicaoTextBox.Location = new System.Drawing.Point(153, 123);
            this.edicaoTextBox.Name = "edicaoTextBox";
            this.edicaoTextBox.Size = new System.Drawing.Size(100, 20);
            this.edicaoTextBox.TabIndex = 8;
            // 
            // anoTextBox
            // 
            this.anoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabLivroBindingSource, "Ano", true));
            this.anoTextBox.Location = new System.Drawing.Point(153, 149);
            this.anoTextBox.Name = "anoTextBox";
            this.anoTextBox.Size = new System.Drawing.Size(100, 20);
            this.anoTextBox.TabIndex = 10;
            // 
            // iSBNTextBox
            // 
            this.iSBNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabLivroBindingSource, "ISBN", true));
            this.iSBNTextBox.Location = new System.Drawing.Point(153, 175);
            this.iSBNTextBox.Name = "iSBNTextBox";
            this.iSBNTextBox.Size = new System.Drawing.Size(100, 20);
            this.iSBNTextBox.TabIndex = 12;
            // 
            // autorTextBox
            // 
            this.autorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabLivroBindingSource, "Autor", true));
            this.autorTextBox.Location = new System.Drawing.Point(153, 201);
            this.autorTextBox.Name = "autorTextBox";
            this.autorTextBox.Size = new System.Drawing.Size(100, 20);
            this.autorTextBox.TabIndex = 14;
            // 
            // capaPictureBox
            // 
            this.capaPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.tabLivroBindingSource, "Capa", true));
            this.capaPictureBox.Location = new System.Drawing.Point(153, 227);
            this.capaPictureBox.Name = "capaPictureBox";
            this.capaPictureBox.Size = new System.Drawing.Size(100, 50);
            this.capaPictureBox.TabIndex = 16;
            this.capaPictureBox.TabStop = false;
            // 
            // sinopseTextBox
            // 
            this.sinopseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabLivroBindingSource, "Sinopse", true));
            this.sinopseTextBox.Location = new System.Drawing.Point(153, 283);
            this.sinopseTextBox.Name = "sinopseTextBox";
            this.sinopseTextBox.Size = new System.Drawing.Size(100, 20);
            this.sinopseTextBox.TabIndex = 18;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.tabEditoraBindingSource;
            this.comboBox1.DisplayMember = "Nome";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(269, 97);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(111, 21);
            this.comboBox1.TabIndex = 19;
            this.comboBox1.ValueMember = "Nome";
            // 
            // bancoDataSetBindingSource1
            // 
            this.bancoDataSetBindingSource1.DataSource = this.bancoDataSet;
            this.bancoDataSetBindingSource1.Position = 0;
            // 
            // tabEditoraBindingSource
            // 
            this.tabEditoraBindingSource.DataMember = "TabEditora";
            this.tabEditoraBindingSource.DataSource = this.bancoDataSetBindingSource1;
            // 
            // tabEditoraTableAdapter
            // 
            this.tabEditoraTableAdapter.ClearBeforeFill = true;
            // 
            // FrmLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(393, 342);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(codLivroLabel);
            this.Controls.Add(this.codLivroTextBox);
            this.Controls.Add(tituloLabel);
            this.Controls.Add(this.tituloTextBox);
            this.Controls.Add(codEditoraLabel);
            this.Controls.Add(this.codEditoraTextBox);
            this.Controls.Add(edicaoLabel);
            this.Controls.Add(this.edicaoTextBox);
            this.Controls.Add(anoLabel);
            this.Controls.Add(this.anoTextBox);
            this.Controls.Add(iSBNLabel);
            this.Controls.Add(this.iSBNTextBox);
            this.Controls.Add(autorLabel);
            this.Controls.Add(this.autorTextBox);
            this.Controls.Add(capaLabel);
            this.Controls.Add(this.capaPictureBox);
            this.Controls.Add(sinopseLabel);
            this.Controls.Add(this.sinopseTextBox);
            this.Controls.Add(this.tabLivroBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLivro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Livro";
            this.Load += new System.EventHandler(this.FrmLivro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bancoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabLivroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabLivroBindingNavigator)).EndInit();
            this.tabLivroBindingNavigator.ResumeLayout(false);
            this.tabLivroBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.capaPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabEditoraBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BancoDataSet bancoDataSet;
        private System.Windows.Forms.BindingSource tabLivroBindingSource;
        private Proj0108.BancoDataSetTableAdapters.TabLivroTableAdapter tabLivroTableAdapter;
        private Proj0108.BancoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tabLivroBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tabLivroBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox codLivroTextBox;
        private System.Windows.Forms.TextBox tituloTextBox;
        private System.Windows.Forms.TextBox codEditoraTextBox;
        private System.Windows.Forms.TextBox edicaoTextBox;
        private System.Windows.Forms.TextBox anoTextBox;
        private System.Windows.Forms.TextBox iSBNTextBox;
        private System.Windows.Forms.TextBox autorTextBox;
        private System.Windows.Forms.PictureBox capaPictureBox;
        private System.Windows.Forms.TextBox sinopseTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource bancoDataSetBindingSource1;
        private System.Windows.Forms.BindingSource tabEditoraBindingSource;
        private Proj0108.BancoDataSetTableAdapters.TabEditoraTableAdapter tabEditoraTableAdapter;
    }
}