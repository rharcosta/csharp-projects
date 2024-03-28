namespace Proj0905
{
    partial class FrmCadUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadUsuario));
            System.Windows.Forms.Label códUsuárioLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label cPFLabel;
            System.Windows.Forms.Label nome_UsuárioLabel;
            System.Windows.Forms.Label senhaLabel;
            this.bD0905DataSet = new Proj0905.BD0905DataSet();
            this.tabUsuárioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabUsuárioTableAdapter = new Proj0905.BD0905DataSetTableAdapters.TabUsuárioTableAdapter();
            this.tableAdapterManager = new Proj0905.BD0905DataSetTableAdapters.TableAdapterManager();
            this.tabUsuárioBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tabUsuárioBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.códUsuárioTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.cPFMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.nome_UsuárioTextBox = new System.Windows.Forms.TextBox();
            this.senhaMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            códUsuárioLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            cPFLabel = new System.Windows.Forms.Label();
            nome_UsuárioLabel = new System.Windows.Forms.Label();
            senhaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bD0905DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabUsuárioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabUsuárioBindingNavigator)).BeginInit();
            this.tabUsuárioBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // bD0905DataSet
            // 
            this.bD0905DataSet.DataSetName = "BD0905DataSet";
            this.bD0905DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabUsuárioBindingSource
            // 
            this.tabUsuárioBindingSource.DataMember = "TabUsuário";
            this.tabUsuárioBindingSource.DataSource = this.bD0905DataSet;
            // 
            // tabUsuárioTableAdapter
            // 
            this.tabUsuárioTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CadEditoraTableAdapter = null;
            this.tableAdapterManager.CadLivroTableAdapter = null;
            this.tableAdapterManager.TabUsuárioTableAdapter = this.tabUsuárioTableAdapter;
            this.tableAdapterManager.UpdateOrder = Proj0905.BD0905DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tabUsuárioBindingNavigator
            // 
            this.tabUsuárioBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tabUsuárioBindingNavigator.BindingSource = this.tabUsuárioBindingSource;
            this.tabUsuárioBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tabUsuárioBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tabUsuárioBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tabUsuárioBindingNavigatorSaveItem});
            this.tabUsuárioBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tabUsuárioBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tabUsuárioBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tabUsuárioBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tabUsuárioBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tabUsuárioBindingNavigator.Name = "tabUsuárioBindingNavigator";
            this.tabUsuárioBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tabUsuárioBindingNavigator.Size = new System.Drawing.Size(267, 25);
            this.tabUsuárioBindingNavigator.TabIndex = 0;
            this.tabUsuárioBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 13);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // tabUsuárioBindingNavigatorSaveItem
            // 
            this.tabUsuárioBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tabUsuárioBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tabUsuárioBindingNavigatorSaveItem.Image")));
            this.tabUsuárioBindingNavigatorSaveItem.Name = "tabUsuárioBindingNavigatorSaveItem";
            this.tabUsuárioBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.tabUsuárioBindingNavigatorSaveItem.Text = "Save Data";
            this.tabUsuárioBindingNavigatorSaveItem.Click += new System.EventHandler(this.tabUsuárioBindingNavigatorSaveItem_Click);
            // 
            // códUsuárioLabel
            // 
            códUsuárioLabel.AutoSize = true;
            códUsuárioLabel.Location = new System.Drawing.Point(12, 44);
            códUsuárioLabel.Name = "códUsuárioLabel";
            códUsuárioLabel.Size = new System.Drawing.Size(68, 13);
            códUsuárioLabel.TabIndex = 1;
            códUsuárioLabel.Text = "Cód Usuário:";
            // 
            // códUsuárioTextBox
            // 
            this.códUsuárioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabUsuárioBindingSource, "CódUsuário", true));
            this.códUsuárioTextBox.Location = new System.Drawing.Point(95, 41);
            this.códUsuárioTextBox.Name = "códUsuárioTextBox";
            this.códUsuárioTextBox.Size = new System.Drawing.Size(100, 20);
            this.códUsuárioTextBox.TabIndex = 2;
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(12, 70);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(38, 13);
            nomeLabel.TabIndex = 3;
            nomeLabel.Text = "Nome:";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabUsuárioBindingSource, "Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(95, 67);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(100, 20);
            this.nomeTextBox.TabIndex = 4;
            // 
            // cPFLabel
            // 
            cPFLabel.AutoSize = true;
            cPFLabel.Location = new System.Drawing.Point(12, 96);
            cPFLabel.Name = "cPFLabel";
            cPFLabel.Size = new System.Drawing.Size(30, 13);
            cPFLabel.TabIndex = 5;
            cPFLabel.Text = "CPF:";
            // 
            // cPFMaskedTextBox
            // 
            this.cPFMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabUsuárioBindingSource, "CPF", true));
            this.cPFMaskedTextBox.Location = new System.Drawing.Point(95, 93);
            this.cPFMaskedTextBox.Name = "cPFMaskedTextBox";
            this.cPFMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.cPFMaskedTextBox.TabIndex = 6;
            // 
            // nome_UsuárioLabel
            // 
            nome_UsuárioLabel.AutoSize = true;
            nome_UsuárioLabel.Location = new System.Drawing.Point(12, 122);
            nome_UsuárioLabel.Name = "nome_UsuárioLabel";
            nome_UsuárioLabel.Size = new System.Drawing.Size(77, 13);
            nome_UsuárioLabel.TabIndex = 7;
            nome_UsuárioLabel.Text = "Nome Usuário:";
            // 
            // nome_UsuárioTextBox
            // 
            this.nome_UsuárioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabUsuárioBindingSource, "Nome_Usuário", true));
            this.nome_UsuárioTextBox.Location = new System.Drawing.Point(95, 119);
            this.nome_UsuárioTextBox.Name = "nome_UsuárioTextBox";
            this.nome_UsuárioTextBox.Size = new System.Drawing.Size(100, 20);
            this.nome_UsuárioTextBox.TabIndex = 8;
            // 
            // senhaLabel
            // 
            senhaLabel.AutoSize = true;
            senhaLabel.Location = new System.Drawing.Point(12, 148);
            senhaLabel.Name = "senhaLabel";
            senhaLabel.Size = new System.Drawing.Size(41, 13);
            senhaLabel.TabIndex = 9;
            senhaLabel.Text = "Senha:";
            // 
            // senhaMaskedTextBox
            // 
            this.senhaMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabUsuárioBindingSource, "Senha", true));
            this.senhaMaskedTextBox.Location = new System.Drawing.Point(95, 145);
            this.senhaMaskedTextBox.Name = "senhaMaskedTextBox";
            this.senhaMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.senhaMaskedTextBox.TabIndex = 10;
            // 
            // FrmCadUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 201);
            this.Controls.Add(códUsuárioLabel);
            this.Controls.Add(this.códUsuárioTextBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(cPFLabel);
            this.Controls.Add(this.cPFMaskedTextBox);
            this.Controls.Add(nome_UsuárioLabel);
            this.Controls.Add(this.nome_UsuárioTextBox);
            this.Controls.Add(senhaLabel);
            this.Controls.Add(this.senhaMaskedTextBox);
            this.Controls.Add(this.tabUsuárioBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Usuário";
            this.Load += new System.EventHandler(this.FrmCadUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bD0905DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabUsuárioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabUsuárioBindingNavigator)).EndInit();
            this.tabUsuárioBindingNavigator.ResumeLayout(false);
            this.tabUsuárioBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BD0905DataSet bD0905DataSet;
        private System.Windows.Forms.BindingSource tabUsuárioBindingSource;
        private Proj0905.BD0905DataSetTableAdapters.TabUsuárioTableAdapter tabUsuárioTableAdapter;
        private Proj0905.BD0905DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tabUsuárioBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tabUsuárioBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox códUsuárioTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.MaskedTextBox cPFMaskedTextBox;
        private System.Windows.Forms.TextBox nome_UsuárioTextBox;
        private System.Windows.Forms.MaskedTextBox senhaMaskedTextBox;

    }
}