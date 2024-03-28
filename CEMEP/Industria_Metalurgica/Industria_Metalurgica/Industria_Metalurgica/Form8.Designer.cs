namespace Industria_Metalurgica
{
    partial class FrmCompras
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
            System.Windows.Forms.Label código_CompLabel;
            System.Windows.Forms.Label produto_CompLabel;
            System.Windows.Forms.Label quantidade_CompLabel;
            System.Windows.Forms.Label fornecedor_CompLabel;
            System.Windows.Forms.Label data_CompLabel;
            System.Windows.Forms.Label valor_CompLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCompras));
            this.industria_MetalurgicaDataSet = new Industria_Metalurgica.Industria_MetalurgicaDataSet();
            this.comprasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comprasTableAdapter = new Industria_Metalurgica.Industria_MetalurgicaDataSetTableAdapters.ComprasTableAdapter();
            this.tableAdapterManager = new Industria_Metalurgica.Industria_MetalurgicaDataSetTableAdapters.TableAdapterManager();
            this.comprasBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.comprasBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.código_CompTextBox = new System.Windows.Forms.TextBox();
            this.produto_CompTextBox = new System.Windows.Forms.TextBox();
            this.quantidade_CompTextBox = new System.Windows.Forms.TextBox();
            this.fornecedor_CompTextBox = new System.Windows.Forms.TextBox();
            this.data_CompDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.valor_CompMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.button2 = new System.Windows.Forms.Button();
            código_CompLabel = new System.Windows.Forms.Label();
            produto_CompLabel = new System.Windows.Forms.Label();
            quantidade_CompLabel = new System.Windows.Forms.Label();
            fornecedor_CompLabel = new System.Windows.Forms.Label();
            data_CompLabel = new System.Windows.Forms.Label();
            valor_CompLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.industria_MetalurgicaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprasBindingNavigator)).BeginInit();
            this.comprasBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // código_CompLabel
            // 
            código_CompLabel.AutoSize = true;
            código_CompLabel.BackColor = System.Drawing.Color.Transparent;
            código_CompLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            código_CompLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            código_CompLabel.Location = new System.Drawing.Point(12, 72);
            código_CompLabel.Name = "código_CompLabel";
            código_CompLabel.Size = new System.Drawing.Size(84, 30);
            código_CompLabel.TabIndex = 1;
            código_CompLabel.Text = "Código:";
            // 
            // produto_CompLabel
            // 
            produto_CompLabel.AutoSize = true;
            produto_CompLabel.BackColor = System.Drawing.Color.Transparent;
            produto_CompLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            produto_CompLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            produto_CompLabel.Location = new System.Drawing.Point(12, 98);
            produto_CompLabel.Name = "produto_CompLabel";
            produto_CompLabel.Size = new System.Drawing.Size(92, 30);
            produto_CompLabel.TabIndex = 3;
            produto_CompLabel.Text = "Produto:";
            // 
            // quantidade_CompLabel
            // 
            quantidade_CompLabel.AutoSize = true;
            quantidade_CompLabel.BackColor = System.Drawing.Color.Transparent;
            quantidade_CompLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            quantidade_CompLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            quantidade_CompLabel.Location = new System.Drawing.Point(12, 124);
            quantidade_CompLabel.Name = "quantidade_CompLabel";
            quantidade_CompLabel.Size = new System.Drawing.Size(127, 30);
            quantidade_CompLabel.TabIndex = 5;
            quantidade_CompLabel.Text = "Quantidade:";
            // 
            // fornecedor_CompLabel
            // 
            fornecedor_CompLabel.AutoSize = true;
            fornecedor_CompLabel.BackColor = System.Drawing.Color.Transparent;
            fornecedor_CompLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            fornecedor_CompLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            fornecedor_CompLabel.Location = new System.Drawing.Point(12, 150);
            fornecedor_CompLabel.Name = "fornecedor_CompLabel";
            fornecedor_CompLabel.Size = new System.Drawing.Size(122, 30);
            fornecedor_CompLabel.TabIndex = 7;
            fornecedor_CompLabel.Text = "Fornecedor:";
            // 
            // data_CompLabel
            // 
            data_CompLabel.AutoSize = true;
            data_CompLabel.BackColor = System.Drawing.Color.Transparent;
            data_CompLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            data_CompLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            data_CompLabel.Location = new System.Drawing.Point(12, 177);
            data_CompLabel.Name = "data_CompLabel";
            data_CompLabel.Size = new System.Drawing.Size(62, 30);
            data_CompLabel.TabIndex = 9;
            data_CompLabel.Text = "Data:";
            // 
            // valor_CompLabel
            // 
            valor_CompLabel.AutoSize = true;
            valor_CompLabel.BackColor = System.Drawing.Color.Transparent;
            valor_CompLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            valor_CompLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            valor_CompLabel.Location = new System.Drawing.Point(12, 202);
            valor_CompLabel.Name = "valor_CompLabel";
            valor_CompLabel.Size = new System.Drawing.Size(64, 30);
            valor_CompLabel.TabIndex = 11;
            valor_CompLabel.Text = "Valor:";
            // 
            // industria_MetalurgicaDataSet
            // 
            this.industria_MetalurgicaDataSet.DataSetName = "Industria_MetalurgicaDataSet";
            this.industria_MetalurgicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comprasBindingSource
            // 
            this.comprasBindingSource.DataMember = "Compras";
            this.comprasBindingSource.DataSource = this.industria_MetalurgicaDataSet;
            // 
            // comprasTableAdapter
            // 
            this.comprasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientesTableAdapter = null;
            this.tableAdapterManager.ComprasTableAdapter = this.comprasTableAdapter;
            this.tableAdapterManager.ContasTableAdapter = null;
            this.tableAdapterManager.FornecedoresTableAdapter = null;
            this.tableAdapterManager.FuncionáriosTableAdapter = null;
            this.tableAdapterManager.LoginTableAdapter = null;
            this.tableAdapterManager.Nota_fiscalTableAdapter = null;
            this.tableAdapterManager.ProdutosTableAdapter = null;
            this.tableAdapterManager.TransportadorasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Industria_Metalurgica.Industria_MetalurgicaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VendasTableAdapter = null;
            // 
            // comprasBindingNavigator
            // 
            this.comprasBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.comprasBindingNavigator.BindingSource = this.comprasBindingSource;
            this.comprasBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.comprasBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.comprasBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.comprasBindingNavigatorSaveItem});
            this.comprasBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.comprasBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.comprasBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.comprasBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.comprasBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.comprasBindingNavigator.Name = "comprasBindingNavigator";
            this.comprasBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.comprasBindingNavigator.Size = new System.Drawing.Size(369, 25);
            this.comprasBindingNavigator.TabIndex = 0;
            this.comprasBindingNavigator.Text = "bindingNavigator1";
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
            // comprasBindingNavigatorSaveItem
            // 
            this.comprasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.comprasBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("comprasBindingNavigatorSaveItem.Image")));
            this.comprasBindingNavigatorSaveItem.Name = "comprasBindingNavigatorSaveItem";
            this.comprasBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.comprasBindingNavigatorSaveItem.Text = "Save Data";
            this.comprasBindingNavigatorSaveItem.Click += new System.EventHandler(this.comprasBindingNavigatorSaveItem_Click);
            // 
            // código_CompTextBox
            // 
            this.código_CompTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.comprasBindingSource, "Código_Comp", true));
            this.código_CompTextBox.Location = new System.Drawing.Point(157, 82);
            this.código_CompTextBox.Name = "código_CompTextBox";
            this.código_CompTextBox.ReadOnly = true;
            this.código_CompTextBox.Size = new System.Drawing.Size(200, 20);
            this.código_CompTextBox.TabIndex = 2;
            this.código_CompTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // produto_CompTextBox
            // 
            this.produto_CompTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.comprasBindingSource, "Produto_Comp", true));
            this.produto_CompTextBox.Location = new System.Drawing.Point(157, 108);
            this.produto_CompTextBox.Name = "produto_CompTextBox";
            this.produto_CompTextBox.Size = new System.Drawing.Size(200, 20);
            this.produto_CompTextBox.TabIndex = 4;
            this.produto_CompTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // quantidade_CompTextBox
            // 
            this.quantidade_CompTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.comprasBindingSource, "Quantidade_Comp", true));
            this.quantidade_CompTextBox.Location = new System.Drawing.Point(157, 134);
            this.quantidade_CompTextBox.Name = "quantidade_CompTextBox";
            this.quantidade_CompTextBox.Size = new System.Drawing.Size(200, 20);
            this.quantidade_CompTextBox.TabIndex = 6;
            this.quantidade_CompTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fornecedor_CompTextBox
            // 
            this.fornecedor_CompTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.comprasBindingSource, "Fornecedor_Comp", true));
            this.fornecedor_CompTextBox.Location = new System.Drawing.Point(157, 160);
            this.fornecedor_CompTextBox.Name = "fornecedor_CompTextBox";
            this.fornecedor_CompTextBox.Size = new System.Drawing.Size(200, 20);
            this.fornecedor_CompTextBox.TabIndex = 8;
            this.fornecedor_CompTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // data_CompDateTimePicker
            // 
            this.data_CompDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.comprasBindingSource, "Data_Comp", true));
            this.data_CompDateTimePicker.Location = new System.Drawing.Point(157, 186);
            this.data_CompDateTimePicker.Name = "data_CompDateTimePicker";
            this.data_CompDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.data_CompDateTimePicker.TabIndex = 10;
            // 
            // valor_CompMaskedTextBox
            // 
            this.valor_CompMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.comprasBindingSource, "Valor_Comp", true));
            this.valor_CompMaskedTextBox.Location = new System.Drawing.Point(157, 212);
            this.valor_CompMaskedTextBox.Mask = "$";
            this.valor_CompMaskedTextBox.Name = "valor_CompMaskedTextBox";
            this.valor_CompMaskedTextBox.Size = new System.Drawing.Size(200, 20);
            this.valor_CompMaskedTextBox.TabIndex = 12;
            this.valor_CompMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Lucida Sans", 11.25F);
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(269, 268);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 30);
            this.button2.TabIndex = 42;
            this.button2.Text = "&Fechar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(369, 310);
            this.Controls.Add(this.button2);
            this.Controls.Add(código_CompLabel);
            this.Controls.Add(this.código_CompTextBox);
            this.Controls.Add(produto_CompLabel);
            this.Controls.Add(this.produto_CompTextBox);
            this.Controls.Add(quantidade_CompLabel);
            this.Controls.Add(this.quantidade_CompTextBox);
            this.Controls.Add(fornecedor_CompLabel);
            this.Controls.Add(this.fornecedor_CompTextBox);
            this.Controls.Add(data_CompLabel);
            this.Controls.Add(this.data_CompDateTimePicker);
            this.Controls.Add(valor_CompLabel);
            this.Controls.Add(this.valor_CompMaskedTextBox);
            this.Controls.Add(this.comprasBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compras";
            this.Load += new System.EventHandler(this.FrmCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.industria_MetalurgicaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprasBindingNavigator)).EndInit();
            this.comprasBindingNavigator.ResumeLayout(false);
            this.comprasBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Industria_MetalurgicaDataSet industria_MetalurgicaDataSet;
        private System.Windows.Forms.BindingSource comprasBindingSource;
        private Industria_Metalurgica.Industria_MetalurgicaDataSetTableAdapters.ComprasTableAdapter comprasTableAdapter;
        private Industria_Metalurgica.Industria_MetalurgicaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator comprasBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton comprasBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox código_CompTextBox;
        private System.Windows.Forms.TextBox produto_CompTextBox;
        private System.Windows.Forms.TextBox quantidade_CompTextBox;
        private System.Windows.Forms.TextBox fornecedor_CompTextBox;
        private System.Windows.Forms.DateTimePicker data_CompDateTimePicker;
        private System.Windows.Forms.MaskedTextBox valor_CompMaskedTextBox;
        private System.Windows.Forms.Button button2;
    }
}