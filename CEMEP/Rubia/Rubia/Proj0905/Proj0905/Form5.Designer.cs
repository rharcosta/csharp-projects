namespace Proj0905
{
    partial class FrmCadEditora
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
            System.Windows.Forms.Label códEditoraLabel;
            System.Windows.Forms.Label razão_SocialLabel;
            System.Windows.Forms.Label cNPJLabel;
            System.Windows.Forms.Label cidadeLabel;
            System.Windows.Forms.Label estadoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadEditora));
            this.bD0905DataSet = new Proj0905.BD0905DataSet();
            this.cadEditoraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cadEditoraTableAdapter = new Proj0905.BD0905DataSetTableAdapters.CadEditoraTableAdapter();
            this.tableAdapterManager = new Proj0905.BD0905DataSetTableAdapters.TableAdapterManager();
            this.cadEditoraBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.cadEditoraBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.códEditoraTextBox = new System.Windows.Forms.TextBox();
            this.razão_SocialTextBox = new System.Windows.Forms.TextBox();
            this.cNPJMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cidadeTextBox = new System.Windows.Forms.TextBox();
            this.estadoComboBox = new System.Windows.Forms.ComboBox();
            códEditoraLabel = new System.Windows.Forms.Label();
            razão_SocialLabel = new System.Windows.Forms.Label();
            cNPJLabel = new System.Windows.Forms.Label();
            cidadeLabel = new System.Windows.Forms.Label();
            estadoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bD0905DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadEditoraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadEditoraBindingNavigator)).BeginInit();
            this.cadEditoraBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // códEditoraLabel
            // 
            códEditoraLabel.AutoSize = true;
            códEditoraLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            códEditoraLabel.Location = new System.Drawing.Point(27, 60);
            códEditoraLabel.Name = "códEditoraLabel";
            códEditoraLabel.Size = new System.Drawing.Size(63, 22);
            códEditoraLabel.TabIndex = 1;
            códEditoraLabel.Text = "Código:";
            // 
            // razão_SocialLabel
            // 
            razão_SocialLabel.AutoSize = true;
            razão_SocialLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            razão_SocialLabel.Location = new System.Drawing.Point(27, 86);
            razão_SocialLabel.Name = "razão_SocialLabel";
            razão_SocialLabel.Size = new System.Drawing.Size(100, 22);
            razão_SocialLabel.TabIndex = 3;
            razão_SocialLabel.Text = "Razão Social:";
            // 
            // cNPJLabel
            // 
            cNPJLabel.AutoSize = true;
            cNPJLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cNPJLabel.Location = new System.Drawing.Point(27, 112);
            cNPJLabel.Name = "cNPJLabel";
            cNPJLabel.Size = new System.Drawing.Size(53, 22);
            cNPJLabel.TabIndex = 5;
            cNPJLabel.Text = "CNPJ:";
            // 
            // cidadeLabel
            // 
            cidadeLabel.AutoSize = true;
            cidadeLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cidadeLabel.Location = new System.Drawing.Point(27, 138);
            cidadeLabel.Name = "cidadeLabel";
            cidadeLabel.Size = new System.Drawing.Size(62, 22);
            cidadeLabel.TabIndex = 7;
            cidadeLabel.Text = "Cidade:";
            // 
            // estadoLabel
            // 
            estadoLabel.AutoSize = true;
            estadoLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            estadoLabel.Location = new System.Drawing.Point(27, 164);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new System.Drawing.Size(60, 22);
            estadoLabel.TabIndex = 9;
            estadoLabel.Text = "Estado:";
            // 
            // bD0905DataSet
            // 
            this.bD0905DataSet.DataSetName = "BD0905DataSet";
            this.bD0905DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cadEditoraBindingSource
            // 
            this.cadEditoraBindingSource.DataMember = "CadEditora";
            this.cadEditoraBindingSource.DataSource = this.bD0905DataSet;
            // 
            // cadEditoraTableAdapter
            // 
            this.cadEditoraTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CadEditoraTableAdapter = this.cadEditoraTableAdapter;
            this.tableAdapterManager.CadLivroTableAdapter = null;
            this.tableAdapterManager.TabUsuárioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Proj0905.BD0905DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cadEditoraBindingNavigator
            // 
            this.cadEditoraBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cadEditoraBindingNavigator.BindingSource = this.cadEditoraBindingSource;
            this.cadEditoraBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cadEditoraBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cadEditoraBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.cadEditoraBindingNavigatorSaveItem});
            this.cadEditoraBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cadEditoraBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cadEditoraBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cadEditoraBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cadEditoraBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cadEditoraBindingNavigator.Name = "cadEditoraBindingNavigator";
            this.cadEditoraBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cadEditoraBindingNavigator.Size = new System.Drawing.Size(558, 25);
            this.cadEditoraBindingNavigator.TabIndex = 0;
            this.cadEditoraBindingNavigator.Text = "bindingNavigator1";
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
            // cadEditoraBindingNavigatorSaveItem
            // 
            this.cadEditoraBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cadEditoraBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cadEditoraBindingNavigatorSaveItem.Image")));
            this.cadEditoraBindingNavigatorSaveItem.Name = "cadEditoraBindingNavigatorSaveItem";
            this.cadEditoraBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.cadEditoraBindingNavigatorSaveItem.Text = "Save Data";
            this.cadEditoraBindingNavigatorSaveItem.Click += new System.EventHandler(this.cadEditoraBindingNavigatorSaveItem_Click);
            // 
            // códEditoraTextBox
            // 
            this.códEditoraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadEditoraBindingSource, "CódEditora", true));
            this.códEditoraTextBox.Location = new System.Drawing.Point(152, 63);
            this.códEditoraTextBox.Name = "códEditoraTextBox";
            this.códEditoraTextBox.Size = new System.Drawing.Size(318, 20);
            this.códEditoraTextBox.TabIndex = 2;
            // 
            // razão_SocialTextBox
            // 
            this.razão_SocialTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadEditoraBindingSource, "Razão_Social", true));
            this.razão_SocialTextBox.Location = new System.Drawing.Point(152, 89);
            this.razão_SocialTextBox.Name = "razão_SocialTextBox";
            this.razão_SocialTextBox.Size = new System.Drawing.Size(318, 20);
            this.razão_SocialTextBox.TabIndex = 4;
            // 
            // cNPJMaskedTextBox
            // 
            this.cNPJMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadEditoraBindingSource, "CNPJ", true));
            this.cNPJMaskedTextBox.Location = new System.Drawing.Point(152, 115);
            this.cNPJMaskedTextBox.Name = "cNPJMaskedTextBox";
            this.cNPJMaskedTextBox.Size = new System.Drawing.Size(318, 20);
            this.cNPJMaskedTextBox.TabIndex = 6;
            // 
            // cidadeTextBox
            // 
            this.cidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadEditoraBindingSource, "Cidade", true));
            this.cidadeTextBox.Location = new System.Drawing.Point(152, 141);
            this.cidadeTextBox.Name = "cidadeTextBox";
            this.cidadeTextBox.Size = new System.Drawing.Size(318, 20);
            this.cidadeTextBox.TabIndex = 8;
            // 
            // estadoComboBox
            // 
            this.estadoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadEditoraBindingSource, "Estado", true));
            this.estadoComboBox.FormattingEnabled = true;
            this.estadoComboBox.Items.AddRange(new object[] {
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
            "Tocantins"});
            this.estadoComboBox.Location = new System.Drawing.Point(152, 167);
            this.estadoComboBox.Name = "estadoComboBox";
            this.estadoComboBox.Size = new System.Drawing.Size(318, 21);
            this.estadoComboBox.TabIndex = 10;
            // 
            // FrmCadEditora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 230);
            this.Controls.Add(códEditoraLabel);
            this.Controls.Add(this.códEditoraTextBox);
            this.Controls.Add(razão_SocialLabel);
            this.Controls.Add(this.razão_SocialTextBox);
            this.Controls.Add(cNPJLabel);
            this.Controls.Add(this.cNPJMaskedTextBox);
            this.Controls.Add(cidadeLabel);
            this.Controls.Add(this.cidadeTextBox);
            this.Controls.Add(estadoLabel);
            this.Controls.Add(this.estadoComboBox);
            this.Controls.Add(this.cadEditoraBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadEditora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Editora";
            this.Load += new System.EventHandler(this.FrmCadEditora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bD0905DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadEditoraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadEditoraBindingNavigator)).EndInit();
            this.cadEditoraBindingNavigator.ResumeLayout(false);
            this.cadEditoraBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BD0905DataSet bD0905DataSet;
        private System.Windows.Forms.BindingSource cadEditoraBindingSource;
        private Proj0905.BD0905DataSetTableAdapters.CadEditoraTableAdapter cadEditoraTableAdapter;
        private Proj0905.BD0905DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cadEditoraBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton cadEditoraBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox códEditoraTextBox;
        private System.Windows.Forms.TextBox razão_SocialTextBox;
        private System.Windows.Forms.MaskedTextBox cNPJMaskedTextBox;
        private System.Windows.Forms.TextBox cidadeTextBox;
        private System.Windows.Forms.ComboBox estadoComboBox;
    }
}