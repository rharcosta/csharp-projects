namespace Proj0905
{
    partial class FrmCadLivro
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
            System.Windows.Forms.Label códLivroLabel;
            System.Windows.Forms.Label títuloLabel;
            System.Windows.Forms.Label autorLabel;
            System.Windows.Forms.Label sinopseLabel;
            System.Windows.Forms.Label estiloLabel;
            System.Windows.Forms.Label editoraLabel;
            System.Windows.Forms.Label capaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadLivro));
            this.bD0905DataSet = new Proj0905.BD0905DataSet();
            this.cadLivroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cadLivroTableAdapter = new Proj0905.BD0905DataSetTableAdapters.CadLivroTableAdapter();
            this.tableAdapterManager = new Proj0905.BD0905DataSetTableAdapters.TableAdapterManager();
            this.cadEditoraTableAdapter = new Proj0905.BD0905DataSetTableAdapters.CadEditoraTableAdapter();
            this.cadLivroBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.cadLivroBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.códLivroTextBox = new System.Windows.Forms.TextBox();
            this.títuloTextBox = new System.Windows.Forms.TextBox();
            this.autorTextBox = new System.Windows.Forms.TextBox();
            this.sinopseTextBox = new System.Windows.Forms.TextBox();
            this.estiloComboBox = new System.Windows.Forms.ComboBox();
            this.editoraTextBox = new System.Windows.Forms.TextBox();
            this.capaPictureBox = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cadEditoraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD0905DataSetBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.bD0905DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD0905DataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bD0905DataSetBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            códLivroLabel = new System.Windows.Forms.Label();
            títuloLabel = new System.Windows.Forms.Label();
            autorLabel = new System.Windows.Forms.Label();
            sinopseLabel = new System.Windows.Forms.Label();
            estiloLabel = new System.Windows.Forms.Label();
            editoraLabel = new System.Windows.Forms.Label();
            capaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bD0905DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadLivroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadLivroBindingNavigator)).BeginInit();
            this.cadLivroBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.capaPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadEditoraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD0905DataSetBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD0905DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD0905DataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD0905DataSetBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // códLivroLabel
            // 
            códLivroLabel.AutoSize = true;
            códLivroLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            códLivroLabel.Location = new System.Drawing.Point(7, 63);
            códLivroLabel.Name = "códLivroLabel";
            códLivroLabel.Size = new System.Drawing.Size(67, 22);
            códLivroLabel.TabIndex = 1;
            códLivroLabel.Text = "Código: ";
            // 
            // títuloLabel
            // 
            títuloLabel.AutoSize = true;
            títuloLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            títuloLabel.Location = new System.Drawing.Point(7, 89);
            títuloLabel.Name = "títuloLabel";
            títuloLabel.Size = new System.Drawing.Size(53, 22);
            títuloLabel.TabIndex = 3;
            títuloLabel.Text = "Título:";
            // 
            // autorLabel
            // 
            autorLabel.AutoSize = true;
            autorLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            autorLabel.Location = new System.Drawing.Point(7, 115);
            autorLabel.Name = "autorLabel";
            autorLabel.Size = new System.Drawing.Size(52, 22);
            autorLabel.TabIndex = 5;
            autorLabel.Text = "Autor:";
            // 
            // sinopseLabel
            // 
            sinopseLabel.AutoSize = true;
            sinopseLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sinopseLabel.Location = new System.Drawing.Point(7, 141);
            sinopseLabel.Name = "sinopseLabel";
            sinopseLabel.Size = new System.Drawing.Size(66, 22);
            sinopseLabel.TabIndex = 7;
            sinopseLabel.Text = "Sinopse:";
            // 
            // estiloLabel
            // 
            estiloLabel.AutoSize = true;
            estiloLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            estiloLabel.Location = new System.Drawing.Point(7, 167);
            estiloLabel.Name = "estiloLabel";
            estiloLabel.Size = new System.Drawing.Size(51, 22);
            estiloLabel.TabIndex = 9;
            estiloLabel.Text = "Estilo:";
            // 
            // editoraLabel
            // 
            editoraLabel.AutoSize = true;
            editoraLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            editoraLabel.Location = new System.Drawing.Point(7, 194);
            editoraLabel.Name = "editoraLabel";
            editoraLabel.Size = new System.Drawing.Size(64, 22);
            editoraLabel.TabIndex = 11;
            editoraLabel.Text = "Editora:";
            // 
            // capaLabel
            // 
            capaLabel.AutoSize = true;
            capaLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            capaLabel.Location = new System.Drawing.Point(7, 217);
            capaLabel.Name = "capaLabel";
            capaLabel.Size = new System.Drawing.Size(50, 22);
            capaLabel.TabIndex = 13;
            capaLabel.Text = "Capa:";
            // 
            // bD0905DataSet
            // 
            this.bD0905DataSet.DataSetName = "BD0905DataSet";
            this.bD0905DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cadLivroBindingSource
            // 
            this.cadLivroBindingSource.DataMember = "CadLivro";
            this.cadLivroBindingSource.DataSource = this.bD0905DataSet;
            // 
            // cadLivroTableAdapter
            // 
            this.cadLivroTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CadEditoraTableAdapter = this.cadEditoraTableAdapter;
            this.tableAdapterManager.CadLivroTableAdapter = this.cadLivroTableAdapter;
            this.tableAdapterManager.TabUsuárioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Proj0905.BD0905DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cadEditoraTableAdapter
            // 
            this.cadEditoraTableAdapter.ClearBeforeFill = true;
            // 
            // cadLivroBindingNavigator
            // 
            this.cadLivroBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cadLivroBindingNavigator.BindingSource = this.cadLivroBindingSource;
            this.cadLivroBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cadLivroBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cadLivroBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.cadLivroBindingNavigatorSaveItem});
            this.cadLivroBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cadLivroBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cadLivroBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cadLivroBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cadLivroBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cadLivroBindingNavigator.Name = "cadLivroBindingNavigator";
            this.cadLivroBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cadLivroBindingNavigator.Size = new System.Drawing.Size(641, 25);
            this.cadLivroBindingNavigator.TabIndex = 0;
            this.cadLivroBindingNavigator.Text = "bindingNavigator1";
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
            // cadLivroBindingNavigatorSaveItem
            // 
            this.cadLivroBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cadLivroBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cadLivroBindingNavigatorSaveItem.Image")));
            this.cadLivroBindingNavigatorSaveItem.Name = "cadLivroBindingNavigatorSaveItem";
            this.cadLivroBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.cadLivroBindingNavigatorSaveItem.Text = "Save Data";
            this.cadLivroBindingNavigatorSaveItem.Click += new System.EventHandler(this.cadLivroBindingNavigatorSaveItem_Click);
            // 
            // códLivroTextBox
            // 
            this.códLivroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadLivroBindingSource, "CódLivro", true));
            this.códLivroTextBox.Location = new System.Drawing.Point(94, 63);
            this.códLivroTextBox.Name = "códLivroTextBox";
            this.códLivroTextBox.Size = new System.Drawing.Size(414, 20);
            this.códLivroTextBox.TabIndex = 2;
            // 
            // títuloTextBox
            // 
            this.títuloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadLivroBindingSource, "Título", true));
            this.títuloTextBox.Location = new System.Drawing.Point(94, 89);
            this.títuloTextBox.Name = "títuloTextBox";
            this.títuloTextBox.Size = new System.Drawing.Size(414, 20);
            this.títuloTextBox.TabIndex = 4;
            // 
            // autorTextBox
            // 
            this.autorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadLivroBindingSource, "Autor", true));
            this.autorTextBox.Location = new System.Drawing.Point(94, 115);
            this.autorTextBox.Name = "autorTextBox";
            this.autorTextBox.Size = new System.Drawing.Size(414, 20);
            this.autorTextBox.TabIndex = 6;
            // 
            // sinopseTextBox
            // 
            this.sinopseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadLivroBindingSource, "Sinopse", true));
            this.sinopseTextBox.Location = new System.Drawing.Point(94, 141);
            this.sinopseTextBox.Name = "sinopseTextBox";
            this.sinopseTextBox.Size = new System.Drawing.Size(414, 20);
            this.sinopseTextBox.TabIndex = 8;
            // 
            // estiloComboBox
            // 
            this.estiloComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadLivroBindingSource, "Estilo", true));
            this.estiloComboBox.FormattingEnabled = true;
            this.estiloComboBox.Location = new System.Drawing.Point(94, 167);
            this.estiloComboBox.Name = "estiloComboBox";
            this.estiloComboBox.Size = new System.Drawing.Size(414, 21);
            this.estiloComboBox.TabIndex = 10;
            // 
            // editoraTextBox
            // 
            this.editoraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadLivroBindingSource, "Editora", true));
            this.editoraTextBox.Location = new System.Drawing.Point(94, 194);
            this.editoraTextBox.Name = "editoraTextBox";
            this.editoraTextBox.Size = new System.Drawing.Size(414, 20);
            this.editoraTextBox.TabIndex = 12;
            // 
            // capaPictureBox
            // 
            this.capaPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.cadLivroBindingSource, "Capa", true));
            this.capaPictureBox.Location = new System.Drawing.Point(94, 220);
            this.capaPictureBox.Name = "capaPictureBox";
            this.capaPictureBox.Size = new System.Drawing.Size(414, 50);
            this.capaPictureBox.TabIndex = 14;
            this.capaPictureBox.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.cadEditoraBindingSource;
            this.comboBox1.DisplayMember = "Razão_Social";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(529, 194);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.ValueMember = "CódEditora";
            // 
            // cadEditoraBindingSource
            // 
            this.cadEditoraBindingSource.DataMember = "CadEditora";
            this.cadEditoraBindingSource.DataSource = this.bD0905DataSetBindingSource3;
            // 
            // bD0905DataSetBindingSource3
            // 
            this.bD0905DataSetBindingSource3.DataSource = this.bD0905DataSet;
            this.bD0905DataSetBindingSource3.Position = 0;
            // 
            // bD0905DataSetBindingSource
            // 
            this.bD0905DataSetBindingSource.DataSource = this.bD0905DataSet;
            this.bD0905DataSetBindingSource.Position = 0;
            // 
            // bD0905DataSetBindingSource1
            // 
            this.bD0905DataSetBindingSource1.DataSource = this.bD0905DataSet;
            this.bD0905DataSetBindingSource1.Position = 0;
            // 
            // bD0905DataSetBindingSource2
            // 
            this.bD0905DataSetBindingSource2.DataSource = this.bD0905DataSet;
            this.bD0905DataSetBindingSource2.Position = 0;
            // 
            // FrmCadLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 302);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(códLivroLabel);
            this.Controls.Add(this.códLivroTextBox);
            this.Controls.Add(títuloLabel);
            this.Controls.Add(this.títuloTextBox);
            this.Controls.Add(autorLabel);
            this.Controls.Add(this.autorTextBox);
            this.Controls.Add(sinopseLabel);
            this.Controls.Add(this.sinopseTextBox);
            this.Controls.Add(estiloLabel);
            this.Controls.Add(this.estiloComboBox);
            this.Controls.Add(editoraLabel);
            this.Controls.Add(this.editoraTextBox);
            this.Controls.Add(capaLabel);
            this.Controls.Add(this.capaPictureBox);
            this.Controls.Add(this.cadLivroBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadLivro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Livro";
            this.Load += new System.EventHandler(this.FrmCadLivro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bD0905DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadLivroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadLivroBindingNavigator)).EndInit();
            this.cadLivroBindingNavigator.ResumeLayout(false);
            this.cadLivroBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.capaPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadEditoraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD0905DataSetBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD0905DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD0905DataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD0905DataSetBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BD0905DataSet bD0905DataSet;
        private System.Windows.Forms.BindingSource cadLivroBindingSource;
        private Proj0905.BD0905DataSetTableAdapters.CadLivroTableAdapter cadLivroTableAdapter;
        private Proj0905.BD0905DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cadLivroBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton cadLivroBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox códLivroTextBox;
        private System.Windows.Forms.TextBox títuloTextBox;
        private System.Windows.Forms.TextBox autorTextBox;
        private System.Windows.Forms.TextBox sinopseTextBox;
        private System.Windows.Forms.ComboBox estiloComboBox;
        private System.Windows.Forms.TextBox editoraTextBox;
        private System.Windows.Forms.PictureBox capaPictureBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource bD0905DataSetBindingSource;
        private System.Windows.Forms.BindingSource bD0905DataSetBindingSource1;
        private System.Windows.Forms.BindingSource bD0905DataSetBindingSource2;
        private System.Windows.Forms.BindingSource bD0905DataSetBindingSource3;
        private Proj0905.BD0905DataSetTableAdapters.CadEditoraTableAdapter cadEditoraTableAdapter;
        private System.Windows.Forms.BindingSource cadEditoraBindingSource;

    }
}