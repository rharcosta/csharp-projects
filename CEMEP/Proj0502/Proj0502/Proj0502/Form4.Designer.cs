namespace Proj0502
{
    partial class FrmClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClientes));
            System.Windows.Forms.Label códCliLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label cPFLabel;
            System.Windows.Forms.Label dtNascLabel;
            System.Windows.Forms.Label sexoLabel;
            System.Windows.Forms.Label endereçoLabel;
            System.Windows.Forms.Label cepLabel;
            System.Windows.Forms.Label cidadeLabel;
            System.Windows.Forms.Label estadoLabel;
            System.Windows.Forms.Label telefoneLabel;
            this.button1 = new System.Windows.Forms.Button();
            this.bD0502DataSet = new Proj0502.BD0502DataSet();
            this.tabCliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabCliTableAdapter = new Proj0502.BD0502DataSetTableAdapters.TabCliTableAdapter();
            this.tableAdapterManager = new Proj0502.BD0502DataSetTableAdapters.TableAdapterManager();
            this.tabCliBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tabCliBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.códCliTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.cPFMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.dtNascDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.sexoTextBox = new System.Windows.Forms.TextBox();
            this.endereçoTextBox = new System.Windows.Forms.TextBox();
            this.cepMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cidadeTextBox = new System.Windows.Forms.TextBox();
            this.estadoComboBox = new System.Windows.Forms.ComboBox();
            this.telefoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            códCliLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            cPFLabel = new System.Windows.Forms.Label();
            dtNascLabel = new System.Windows.Forms.Label();
            sexoLabel = new System.Windows.Forms.Label();
            endereçoLabel = new System.Windows.Forms.Label();
            cepLabel = new System.Windows.Forms.Label();
            cidadeLabel = new System.Windows.Forms.Label();
            estadoLabel = new System.Windows.Forms.Label();
            telefoneLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bD0502DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabCliBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabCliBindingNavigator)).BeginInit();
            this.tabCliBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(405, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Fechar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // bD0502DataSet
            // 
            this.bD0502DataSet.DataSetName = "BD0502DataSet";
            this.bD0502DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabCliBindingSource
            // 
            this.tabCliBindingSource.DataMember = "TabCli";
            this.tabCliBindingSource.DataSource = this.bD0502DataSet;
            // 
            // tabCliTableAdapter
            // 
            this.tabCliTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TabCliTableAdapter = this.tabCliTableAdapter;
            this.tableAdapterManager.TabProdTableAdapter = null;
            this.tableAdapterManager.TabVendedorTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Proj0502.BD0502DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tabCliBindingNavigator
            // 
            this.tabCliBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tabCliBindingNavigator.BindingSource = this.tabCliBindingSource;
            this.tabCliBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tabCliBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tabCliBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tabCliBindingNavigatorSaveItem});
            this.tabCliBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tabCliBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tabCliBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tabCliBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tabCliBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tabCliBindingNavigator.Name = "tabCliBindingNavigator";
            this.tabCliBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tabCliBindingNavigator.Size = new System.Drawing.Size(500, 25);
            this.tabCliBindingNavigator.TabIndex = 1;
            this.tabCliBindingNavigator.Text = "bindingNavigator1";
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
            // tabCliBindingNavigatorSaveItem
            // 
            this.tabCliBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tabCliBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tabCliBindingNavigatorSaveItem.Image")));
            this.tabCliBindingNavigatorSaveItem.Name = "tabCliBindingNavigatorSaveItem";
            this.tabCliBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.tabCliBindingNavigatorSaveItem.Text = "Save Data";
            this.tabCliBindingNavigatorSaveItem.Click += new System.EventHandler(this.tabCliBindingNavigatorSaveItem_Click);
            // 
            // códCliLabel
            // 
            códCliLabel.AutoSize = true;
            códCliLabel.Location = new System.Drawing.Point(60, 75);
            códCliLabel.Name = "códCliLabel";
            códCliLabel.Size = new System.Drawing.Size(43, 13);
            códCliLabel.TabIndex = 2;
            códCliLabel.Text = "Código:";
            // 
            // códCliTextBox
            // 
            this.códCliTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabCliBindingSource, "CódCli", true));
            this.códCliTextBox.Location = new System.Drawing.Point(122, 72);
            this.códCliTextBox.Name = "códCliTextBox";
            this.códCliTextBox.Size = new System.Drawing.Size(200, 20);
            this.códCliTextBox.TabIndex = 3;
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(60, 101);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(38, 13);
            nomeLabel.TabIndex = 4;
            nomeLabel.Text = "Nome:";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabCliBindingSource, "Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(122, 98);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(200, 20);
            this.nomeTextBox.TabIndex = 5;
            // 
            // cPFLabel
            // 
            cPFLabel.AutoSize = true;
            cPFLabel.Location = new System.Drawing.Point(60, 127);
            cPFLabel.Name = "cPFLabel";
            cPFLabel.Size = new System.Drawing.Size(30, 13);
            cPFLabel.TabIndex = 6;
            cPFLabel.Text = "CPF:";
            // 
            // cPFMaskedTextBox
            // 
            this.cPFMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabCliBindingSource, "CPF", true));
            this.cPFMaskedTextBox.Location = new System.Drawing.Point(122, 124);
            this.cPFMaskedTextBox.Name = "cPFMaskedTextBox";
            this.cPFMaskedTextBox.Size = new System.Drawing.Size(200, 20);
            this.cPFMaskedTextBox.TabIndex = 7;
            // 
            // dtNascLabel
            // 
            dtNascLabel.AutoSize = true;
            dtNascLabel.Location = new System.Drawing.Point(60, 154);
            dtNascLabel.Name = "dtNascLabel";
            dtNascLabel.Size = new System.Drawing.Size(49, 13);
            dtNascLabel.TabIndex = 8;
            dtNascLabel.Text = "Dt Nasc:";
            // 
            // dtNascDateTimePicker
            // 
            this.dtNascDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tabCliBindingSource, "DtNasc", true));
            this.dtNascDateTimePicker.Location = new System.Drawing.Point(122, 150);
            this.dtNascDateTimePicker.Name = "dtNascDateTimePicker";
            this.dtNascDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dtNascDateTimePicker.TabIndex = 9;
            // 
            // sexoLabel
            // 
            sexoLabel.AutoSize = true;
            sexoLabel.Location = new System.Drawing.Point(60, 179);
            sexoLabel.Name = "sexoLabel";
            sexoLabel.Size = new System.Drawing.Size(34, 13);
            sexoLabel.TabIndex = 10;
            sexoLabel.Text = "Sexo:";
            // 
            // sexoTextBox
            // 
            this.sexoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabCliBindingSource, "Sexo", true));
            this.sexoTextBox.Location = new System.Drawing.Point(122, 176);
            this.sexoTextBox.Name = "sexoTextBox";
            this.sexoTextBox.Size = new System.Drawing.Size(200, 20);
            this.sexoTextBox.TabIndex = 11;
            // 
            // endereçoLabel
            // 
            endereçoLabel.AutoSize = true;
            endereçoLabel.Location = new System.Drawing.Point(60, 205);
            endereçoLabel.Name = "endereçoLabel";
            endereçoLabel.Size = new System.Drawing.Size(56, 13);
            endereçoLabel.TabIndex = 12;
            endereçoLabel.Text = "Endereço:";
            // 
            // endereçoTextBox
            // 
            this.endereçoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabCliBindingSource, "Endereço", true));
            this.endereçoTextBox.Location = new System.Drawing.Point(122, 202);
            this.endereçoTextBox.Name = "endereçoTextBox";
            this.endereçoTextBox.Size = new System.Drawing.Size(200, 20);
            this.endereçoTextBox.TabIndex = 13;
            // 
            // cepLabel
            // 
            cepLabel.AutoSize = true;
            cepLabel.Location = new System.Drawing.Point(60, 231);
            cepLabel.Name = "cepLabel";
            cepLabel.Size = new System.Drawing.Size(29, 13);
            cepLabel.TabIndex = 14;
            cepLabel.Text = "Cep:";
            // 
            // cepMaskedTextBox
            // 
            this.cepMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabCliBindingSource, "Cep", true));
            this.cepMaskedTextBox.Location = new System.Drawing.Point(122, 228);
            this.cepMaskedTextBox.Name = "cepMaskedTextBox";
            this.cepMaskedTextBox.Size = new System.Drawing.Size(200, 20);
            this.cepMaskedTextBox.TabIndex = 15;
            // 
            // cidadeLabel
            // 
            cidadeLabel.AutoSize = true;
            cidadeLabel.Location = new System.Drawing.Point(60, 257);
            cidadeLabel.Name = "cidadeLabel";
            cidadeLabel.Size = new System.Drawing.Size(43, 13);
            cidadeLabel.TabIndex = 16;
            cidadeLabel.Text = "Cidade:";
            // 
            // cidadeTextBox
            // 
            this.cidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabCliBindingSource, "Cidade", true));
            this.cidadeTextBox.Location = new System.Drawing.Point(122, 254);
            this.cidadeTextBox.Name = "cidadeTextBox";
            this.cidadeTextBox.Size = new System.Drawing.Size(200, 20);
            this.cidadeTextBox.TabIndex = 17;
            // 
            // estadoLabel
            // 
            estadoLabel.AutoSize = true;
            estadoLabel.Location = new System.Drawing.Point(60, 283);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new System.Drawing.Size(43, 13);
            estadoLabel.TabIndex = 18;
            estadoLabel.Text = "Estado:";
            // 
            // estadoComboBox
            // 
            this.estadoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabCliBindingSource, "Estado", true));
            this.estadoComboBox.FormattingEnabled = true;
            this.estadoComboBox.Location = new System.Drawing.Point(122, 280);
            this.estadoComboBox.Name = "estadoComboBox";
            this.estadoComboBox.Size = new System.Drawing.Size(200, 21);
            this.estadoComboBox.TabIndex = 19;
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.Location = new System.Drawing.Point(60, 310);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(52, 13);
            telefoneLabel.TabIndex = 20;
            telefoneLabel.Text = "Telefone:";
            // 
            // telefoneMaskedTextBox
            // 
            this.telefoneMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabCliBindingSource, "Telefone", true));
            this.telefoneMaskedTextBox.Location = new System.Drawing.Point(122, 307);
            this.telefoneMaskedTextBox.Name = "telefoneMaskedTextBox";
            this.telefoneMaskedTextBox.Size = new System.Drawing.Size(200, 20);
            this.telefoneMaskedTextBox.TabIndex = 21;
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 383);
            this.Controls.Add(códCliLabel);
            this.Controls.Add(this.códCliTextBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(cPFLabel);
            this.Controls.Add(this.cPFMaskedTextBox);
            this.Controls.Add(dtNascLabel);
            this.Controls.Add(this.dtNascDateTimePicker);
            this.Controls.Add(sexoLabel);
            this.Controls.Add(this.sexoTextBox);
            this.Controls.Add(endereçoLabel);
            this.Controls.Add(this.endereçoTextBox);
            this.Controls.Add(cepLabel);
            this.Controls.Add(this.cepMaskedTextBox);
            this.Controls.Add(cidadeLabel);
            this.Controls.Add(this.cidadeTextBox);
            this.Controls.Add(estadoLabel);
            this.Controls.Add(this.estadoComboBox);
            this.Controls.Add(telefoneLabel);
            this.Controls.Add(this.telefoneMaskedTextBox);
            this.Controls.Add(this.tabCliBindingNavigator);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.FrmClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bD0502DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabCliBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabCliBindingNavigator)).EndInit();
            this.tabCliBindingNavigator.ResumeLayout(false);
            this.tabCliBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private BD0502DataSet bD0502DataSet;
        private System.Windows.Forms.BindingSource tabCliBindingSource;
        private Proj0502.BD0502DataSetTableAdapters.TabCliTableAdapter tabCliTableAdapter;
        private Proj0502.BD0502DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tabCliBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tabCliBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox códCliTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.MaskedTextBox cPFMaskedTextBox;
        private System.Windows.Forms.DateTimePicker dtNascDateTimePicker;
        private System.Windows.Forms.TextBox sexoTextBox;
        private System.Windows.Forms.TextBox endereçoTextBox;
        private System.Windows.Forms.MaskedTextBox cepMaskedTextBox;
        private System.Windows.Forms.TextBox cidadeTextBox;
        private System.Windows.Forms.ComboBox estadoComboBox;
        private System.Windows.Forms.MaskedTextBox telefoneMaskedTextBox;
    }
}