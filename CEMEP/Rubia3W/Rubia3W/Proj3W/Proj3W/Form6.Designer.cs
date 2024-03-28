namespace Proj3W
{
    partial class FrmUsu
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
            System.Windows.Forms.Label codUsuarioLabel;
            System.Windows.Forms.Label nomeCompletoLabel;
            System.Windows.Forms.Label nomeUsuLabel;
            System.Windows.Forms.Label senhaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsu));
            this.bD3WDataSet = new Proj3W.BD3WDataSet();
            this.tabUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabUsuarioTableAdapter = new Proj3W.BD3WDataSetTableAdapters.TabUsuarioTableAdapter();
            this.tableAdapterManager = new Proj3W.BD3WDataSetTableAdapters.TableAdapterManager();
            this.tabUsuarioBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tabUsuarioBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.codUsuarioTextBox = new System.Windows.Forms.TextBox();
            this.nomeCompletoTextBox = new System.Windows.Forms.TextBox();
            this.nomeUsuTextBox = new System.Windows.Forms.TextBox();
            this.senhaMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            codUsuarioLabel = new System.Windows.Forms.Label();
            nomeCompletoLabel = new System.Windows.Forms.Label();
            nomeUsuLabel = new System.Windows.Forms.Label();
            senhaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bD3WDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabUsuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabUsuarioBindingNavigator)).BeginInit();
            this.tabUsuarioBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // codUsuarioLabel
            // 
            codUsuarioLabel.AutoSize = true;
            codUsuarioLabel.BackColor = System.Drawing.Color.Transparent;
            codUsuarioLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            codUsuarioLabel.ForeColor = System.Drawing.Color.White;
            codUsuarioLabel.Location = new System.Drawing.Point(12, 48);
            codUsuarioLabel.Name = "codUsuarioLabel";
            codUsuarioLabel.Size = new System.Drawing.Size(92, 25);
            codUsuarioLabel.TabIndex = 1;
            codUsuarioLabel.Text = "Código:";
            // 
            // nomeCompletoLabel
            // 
            nomeCompletoLabel.AutoSize = true;
            nomeCompletoLabel.BackColor = System.Drawing.Color.Transparent;
            nomeCompletoLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomeCompletoLabel.ForeColor = System.Drawing.Color.White;
            nomeCompletoLabel.Location = new System.Drawing.Point(12, 81);
            nomeCompletoLabel.Name = "nomeCompletoLabel";
            nomeCompletoLabel.Size = new System.Drawing.Size(187, 25);
            nomeCompletoLabel.TabIndex = 3;
            nomeCompletoLabel.Text = "Nome Completo:";
            // 
            // nomeUsuLabel
            // 
            nomeUsuLabel.AutoSize = true;
            nomeUsuLabel.BackColor = System.Drawing.Color.Transparent;
            nomeUsuLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomeUsuLabel.ForeColor = System.Drawing.Color.White;
            nomeUsuLabel.Location = new System.Drawing.Point(12, 117);
            nomeUsuLabel.Name = "nomeUsuLabel";
            nomeUsuLabel.Size = new System.Drawing.Size(98, 25);
            nomeUsuLabel.TabIndex = 5;
            nomeUsuLabel.Text = "Usuário:";
            // 
            // senhaLabel
            // 
            senhaLabel.AutoSize = true;
            senhaLabel.BackColor = System.Drawing.Color.Transparent;
            senhaLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            senhaLabel.ForeColor = System.Drawing.Color.White;
            senhaLabel.Location = new System.Drawing.Point(12, 151);
            senhaLabel.Name = "senhaLabel";
            senhaLabel.Size = new System.Drawing.Size(80, 25);
            senhaLabel.TabIndex = 7;
            senhaLabel.Text = "Senha:";
            // 
            // bD3WDataSet
            // 
            this.bD3WDataSet.DataSetName = "BD3WDataSet";
            this.bD3WDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabUsuarioBindingSource
            // 
            this.tabUsuarioBindingSource.DataMember = "TabUsuario";
            this.tabUsuarioBindingSource.DataSource = this.bD3WDataSet;
            // 
            // tabUsuarioTableAdapter
            // 
            this.tabUsuarioTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TabCandidatoTableAdapter = null;
            this.tableAdapterManager.TabCliempresaTableAdapter = null;
            this.tableAdapterManager.TabUsuarioTableAdapter = this.tabUsuarioTableAdapter;
            this.tableAdapterManager.TabVagasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Proj3W.BD3WDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tabUsuarioBindingNavigator
            // 
            this.tabUsuarioBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tabUsuarioBindingNavigator.BindingSource = this.tabUsuarioBindingSource;
            this.tabUsuarioBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tabUsuarioBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tabUsuarioBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tabUsuarioBindingNavigatorSaveItem});
            this.tabUsuarioBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tabUsuarioBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tabUsuarioBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tabUsuarioBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tabUsuarioBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tabUsuarioBindingNavigator.Name = "tabUsuarioBindingNavigator";
            this.tabUsuarioBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tabUsuarioBindingNavigator.Size = new System.Drawing.Size(388, 25);
            this.tabUsuarioBindingNavigator.TabIndex = 0;
            this.tabUsuarioBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorCountItem.ForeColor = System.Drawing.Color.Black;
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
            // tabUsuarioBindingNavigatorSaveItem
            // 
            this.tabUsuarioBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tabUsuarioBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tabUsuarioBindingNavigatorSaveItem.Image")));
            this.tabUsuarioBindingNavigatorSaveItem.Name = "tabUsuarioBindingNavigatorSaveItem";
            this.tabUsuarioBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tabUsuarioBindingNavigatorSaveItem.Text = "Save Data";
            this.tabUsuarioBindingNavigatorSaveItem.Click += new System.EventHandler(this.tabUsuarioBindingNavigatorSaveItem_Click);
            // 
            // codUsuarioTextBox
            // 
            this.codUsuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabUsuarioBindingSource, "CodUsuario", true));
            this.codUsuarioTextBox.Location = new System.Drawing.Point(216, 53);
            this.codUsuarioTextBox.Name = "codUsuarioTextBox";
            this.codUsuarioTextBox.ReadOnly = true;
            this.codUsuarioTextBox.Size = new System.Drawing.Size(160, 20);
            this.codUsuarioTextBox.TabIndex = 1;
            this.codUsuarioTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nomeCompletoTextBox
            // 
            this.nomeCompletoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabUsuarioBindingSource, "NomeCompleto", true));
            this.nomeCompletoTextBox.Location = new System.Drawing.Point(216, 86);
            this.nomeCompletoTextBox.Name = "nomeCompletoTextBox";
            this.nomeCompletoTextBox.Size = new System.Drawing.Size(160, 20);
            this.nomeCompletoTextBox.TabIndex = 2;
            this.nomeCompletoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nomeUsuTextBox
            // 
            this.nomeUsuTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabUsuarioBindingSource, "NomeUsu", true));
            this.nomeUsuTextBox.Location = new System.Drawing.Point(216, 122);
            this.nomeUsuTextBox.Name = "nomeUsuTextBox";
            this.nomeUsuTextBox.Size = new System.Drawing.Size(160, 20);
            this.nomeUsuTextBox.TabIndex = 3;
            this.nomeUsuTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // senhaMaskedTextBox
            // 
            this.senhaMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabUsuarioBindingSource, "Senha", true));
            this.senhaMaskedTextBox.Location = new System.Drawing.Point(216, 156);
            this.senhaMaskedTextBox.Name = "senhaMaskedTextBox";
            this.senhaMaskedTextBox.PasswordChar = '*';
            this.senhaMaskedTextBox.Size = new System.Drawing.Size(160, 20);
            this.senhaMaskedTextBox.TabIndex = 4;
            this.senhaMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Lucida Sans", 11.25F);
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(288, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 30);
            this.button1.TabIndex = 5;
            this.button1.Text = "&Fechar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.button1, "Fechar");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmUsu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(388, 245);
            this.Controls.Add(this.button1);
            this.Controls.Add(codUsuarioLabel);
            this.Controls.Add(this.codUsuarioTextBox);
            this.Controls.Add(nomeCompletoLabel);
            this.Controls.Add(this.nomeCompletoTextBox);
            this.Controls.Add(nomeUsuLabel);
            this.Controls.Add(this.nomeUsuTextBox);
            this.Controls.Add(senhaLabel);
            this.Controls.Add(this.senhaMaskedTextBox);
            this.Controls.Add(this.tabUsuarioBindingNavigator);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmUsu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Usuários";
            this.Load += new System.EventHandler(this.FrmUsu_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmUsu_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.bD3WDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabUsuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabUsuarioBindingNavigator)).EndInit();
            this.tabUsuarioBindingNavigator.ResumeLayout(false);
            this.tabUsuarioBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BD3WDataSet bD3WDataSet;
        private System.Windows.Forms.BindingSource tabUsuarioBindingSource;
        private Proj3W.BD3WDataSetTableAdapters.TabUsuarioTableAdapter tabUsuarioTableAdapter;
        private Proj3W.BD3WDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tabUsuarioBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tabUsuarioBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox codUsuarioTextBox;
        private System.Windows.Forms.TextBox nomeCompletoTextBox;
        private System.Windows.Forms.TextBox nomeUsuTextBox;
        private System.Windows.Forms.MaskedTextBox senhaMaskedTextBox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button1;
    }
}