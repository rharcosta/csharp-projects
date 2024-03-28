namespace Proj2103
{
    partial class FrmFilme
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
            System.Windows.Forms.Label codFilmeLabel;
            System.Windows.Forms.Label tituloLabel;
            System.Windows.Forms.Label diretorLabel;
            System.Windows.Forms.Label duracaoLabel;
            System.Windows.Forms.Label sinopseLabel;
            System.Windows.Forms.Label estiloLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFilme));
            this.tabFilmeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.tabFilmeBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.tabFilmeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.button1 = new System.Windows.Forms.Button();
            this.codFilmeTextBox = new System.Windows.Forms.TextBox();
            this.tituloTextBox = new System.Windows.Forms.TextBox();
            this.diretorTextBox = new System.Windows.Forms.TextBox();
            this.duracaoTextBox = new System.Windows.Forms.TextBox();
            this.sinopseTextBox = new System.Windows.Forms.TextBox();
            this.estiloComboBox = new System.Windows.Forms.ComboBox();
            this.tabFilmeTableAdapter = new Proj2103.BD2103DataSetTableAdapters.TabFilmeTableAdapter();
            this.tableAdapterManager = new Proj2103.BD2103DataSetTableAdapters.TableAdapterManager();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            codFilmeLabel = new System.Windows.Forms.Label();
            tituloLabel = new System.Windows.Forms.Label();
            diretorLabel = new System.Windows.Forms.Label();
            duracaoLabel = new System.Windows.Forms.Label();
            sinopseLabel = new System.Windows.Forms.Label();
            estiloLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tabFilmeBindingNavigator)).BeginInit();
            this.tabFilmeBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabFilmeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD2103DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // codFilmeLabel
            // 
            codFilmeLabel.AutoSize = true;
            codFilmeLabel.BackColor = System.Drawing.Color.Transparent;
            codFilmeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            codFilmeLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            codFilmeLabel.Location = new System.Drawing.Point(56, 57);
            codFilmeLabel.Name = "codFilmeLabel";
            codFilmeLabel.Size = new System.Drawing.Size(55, 16);
            codFilmeLabel.TabIndex = 13;
            codFilmeLabel.Text = "Código:";
            // 
            // tituloLabel
            // 
            tituloLabel.AutoSize = true;
            tituloLabel.BackColor = System.Drawing.Color.Transparent;
            tituloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tituloLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            tituloLabel.Location = new System.Drawing.Point(56, 83);
            tituloLabel.Name = "tituloLabel";
            tituloLabel.Size = new System.Drawing.Size(44, 16);
            tituloLabel.TabIndex = 15;
            tituloLabel.Text = "Titulo:";
            // 
            // diretorLabel
            // 
            diretorLabel.AutoSize = true;
            diretorLabel.BackColor = System.Drawing.Color.Transparent;
            diretorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            diretorLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            diretorLabel.Location = new System.Drawing.Point(56, 109);
            diretorLabel.Name = "diretorLabel";
            diretorLabel.Size = new System.Drawing.Size(51, 16);
            diretorLabel.TabIndex = 17;
            diretorLabel.Text = "Diretor:";
            // 
            // duracaoLabel
            // 
            duracaoLabel.AutoSize = true;
            duracaoLabel.BackColor = System.Drawing.Color.Transparent;
            duracaoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            duracaoLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            duracaoLabel.Location = new System.Drawing.Point(56, 135);
            duracaoLabel.Name = "duracaoLabel";
            duracaoLabel.Size = new System.Drawing.Size(63, 16);
            duracaoLabel.TabIndex = 19;
            duracaoLabel.Text = "Duração:";
            // 
            // sinopseLabel
            // 
            sinopseLabel.AutoSize = true;
            sinopseLabel.BackColor = System.Drawing.Color.Transparent;
            sinopseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sinopseLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            sinopseLabel.Location = new System.Drawing.Point(56, 161);
            sinopseLabel.Name = "sinopseLabel";
            sinopseLabel.Size = new System.Drawing.Size(61, 16);
            sinopseLabel.TabIndex = 21;
            sinopseLabel.Text = "Sinopse:";
            // 
            // estiloLabel
            // 
            estiloLabel.AutoSize = true;
            estiloLabel.BackColor = System.Drawing.Color.Transparent;
            estiloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            estiloLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            estiloLabel.Location = new System.Drawing.Point(56, 226);
            estiloLabel.Name = "estiloLabel";
            estiloLabel.Size = new System.Drawing.Size(44, 16);
            estiloLabel.TabIndex = 23;
            estiloLabel.Text = "Estilo:";
            // 
            // tabFilmeBindingNavigator
            // 
            this.tabFilmeBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tabFilmeBindingNavigator.BindingSource = this.tabFilmeBindingSource;
            this.tabFilmeBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tabFilmeBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tabFilmeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tabFilmeBindingNavigatorSaveItem});
            this.tabFilmeBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tabFilmeBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tabFilmeBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tabFilmeBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tabFilmeBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tabFilmeBindingNavigator.Name = "tabFilmeBindingNavigator";
            this.tabFilmeBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tabFilmeBindingNavigator.Size = new System.Drawing.Size(284, 25);
            this.tabFilmeBindingNavigator.TabIndex = 0;
            this.tabFilmeBindingNavigator.Text = "bindingNavigator1";
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
            // tabFilmeBindingSource
            // 
            this.tabFilmeBindingSource.DataMember = "TabFilme";
            this.tabFilmeBindingSource.DataSource = this.bD2103DataSet;
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
            // tabFilmeBindingNavigatorSaveItem
            // 
            this.tabFilmeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tabFilmeBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tabFilmeBindingNavigatorSaveItem.Image")));
            this.tabFilmeBindingNavigatorSaveItem.Name = "tabFilmeBindingNavigatorSaveItem";
            this.tabFilmeBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tabFilmeBindingNavigatorSaveItem.Text = "Save Data";
            this.tabFilmeBindingNavigatorSaveItem.Click += new System.EventHandler(this.tabFilmeBindingNavigatorSaveItem_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(197, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "&Fechar";
            this.toolTip1.SetToolTip(this.button1, "Fechar");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // codFilmeTextBox
            // 
            this.codFilmeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabFilmeBindingSource, "CodFilme", true));
            this.codFilmeTextBox.Location = new System.Drawing.Point(118, 54);
            this.codFilmeTextBox.Name = "codFilmeTextBox";
            this.codFilmeTextBox.Size = new System.Drawing.Size(121, 20);
            this.codFilmeTextBox.TabIndex = 14;
            this.codFilmeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tituloTextBox
            // 
            this.tituloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabFilmeBindingSource, "Titulo", true));
            this.tituloTextBox.Location = new System.Drawing.Point(118, 80);
            this.tituloTextBox.Name = "tituloTextBox";
            this.tituloTextBox.Size = new System.Drawing.Size(121, 20);
            this.tituloTextBox.TabIndex = 16;
            this.tituloTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // diretorTextBox
            // 
            this.diretorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabFilmeBindingSource, "Diretor", true));
            this.diretorTextBox.Location = new System.Drawing.Point(118, 106);
            this.diretorTextBox.Name = "diretorTextBox";
            this.diretorTextBox.Size = new System.Drawing.Size(121, 20);
            this.diretorTextBox.TabIndex = 18;
            this.diretorTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // duracaoTextBox
            // 
            this.duracaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabFilmeBindingSource, "Duracao", true));
            this.duracaoTextBox.Location = new System.Drawing.Point(118, 132);
            this.duracaoTextBox.Name = "duracaoTextBox";
            this.duracaoTextBox.Size = new System.Drawing.Size(121, 20);
            this.duracaoTextBox.TabIndex = 20;
            this.duracaoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sinopseTextBox
            // 
            this.sinopseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabFilmeBindingSource, "Sinopse", true));
            this.sinopseTextBox.Location = new System.Drawing.Point(118, 161);
            this.sinopseTextBox.Multiline = true;
            this.sinopseTextBox.Name = "sinopseTextBox";
            this.sinopseTextBox.Size = new System.Drawing.Size(121, 45);
            this.sinopseTextBox.TabIndex = 22;
            this.sinopseTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // estiloComboBox
            // 
            this.estiloComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabFilmeBindingSource, "Estilo", true));
            this.estiloComboBox.FormattingEnabled = true;
            this.estiloComboBox.Items.AddRange(new object[] {
            "Ação",
            "Comédia",
            "Drama",
            "Infantil ",
            "Policial",
            "Romance",
            "Suspense",
            "Terror"});
            this.estiloComboBox.Location = new System.Drawing.Point(118, 221);
            this.estiloComboBox.Name = "estiloComboBox";
            this.estiloComboBox.Size = new System.Drawing.Size(121, 21);
            this.estiloComboBox.TabIndex = 24;
            // 
            // tabFilmeTableAdapter
            // 
            this.tabFilmeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TabClienteTableAdapter = null;
            this.tableAdapterManager.TabFilmeTableAdapter = this.tabFilmeTableAdapter;
            this.tableAdapterManager.TabLocacaoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Proj2103.BD2103DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FrmFilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(284, 295);
            this.Controls.Add(codFilmeLabel);
            this.Controls.Add(this.codFilmeTextBox);
            this.Controls.Add(tituloLabel);
            this.Controls.Add(this.tituloTextBox);
            this.Controls.Add(diretorLabel);
            this.Controls.Add(this.diretorTextBox);
            this.Controls.Add(duracaoLabel);
            this.Controls.Add(this.duracaoTextBox);
            this.Controls.Add(sinopseLabel);
            this.Controls.Add(this.sinopseTextBox);
            this.Controls.Add(estiloLabel);
            this.Controls.Add(this.estiloComboBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabFilmeBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFilme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Filme";
            this.Load += new System.EventHandler(this.FrmFilme_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmFilme_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.tabFilmeBindingNavigator)).EndInit();
            this.tabFilmeBindingNavigator.ResumeLayout(false);
            this.tabFilmeBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabFilmeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD2103DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BD2103DataSet bD2103DataSet;
        private System.Windows.Forms.BindingSource tabFilmeBindingSource;
        private Proj2103.BD2103DataSetTableAdapters.TabFilmeTableAdapter tabFilmeTableAdapter;
        private Proj2103.BD2103DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tabFilmeBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tabFilmeBindingNavigatorSaveItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox codFilmeTextBox;
        private System.Windows.Forms.TextBox tituloTextBox;
        private System.Windows.Forms.TextBox diretorTextBox;
        private System.Windows.Forms.TextBox duracaoTextBox;
        private System.Windows.Forms.TextBox sinopseTextBox;
        private System.Windows.Forms.ComboBox estiloComboBox;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}