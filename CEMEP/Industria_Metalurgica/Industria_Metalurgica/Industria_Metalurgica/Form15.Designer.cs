namespace Industria_Metalurgica
{
    partial class FrmVendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVendas));
            System.Windows.Forms.Label código_VendLabel;
            System.Windows.Forms.Label produto_VendLabel;
            System.Windows.Forms.Label cliente_VendLabel;
            System.Windows.Forms.Label quantidade_VendLabel;
            System.Windows.Forms.Label vendedor_VendLabel;
            System.Windows.Forms.Label data_VendLabel;
            System.Windows.Forms.Label nota_Fiscal_VendLabel;
            System.Windows.Forms.Label valor_VendLabel;
            this.industria_MetalurgicaDataSet = new Industria_Metalurgica.Industria_MetalurgicaDataSet();
            this.vendasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendasTableAdapter = new Industria_Metalurgica.Industria_MetalurgicaDataSetTableAdapters.VendasTableAdapter();
            this.tableAdapterManager = new Industria_Metalurgica.Industria_MetalurgicaDataSetTableAdapters.TableAdapterManager();
            this.vendasBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.vendasBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.código_VendTextBox = new System.Windows.Forms.TextBox();
            this.produto_VendTextBox = new System.Windows.Forms.TextBox();
            this.cliente_VendTextBox = new System.Windows.Forms.TextBox();
            this.quantidade_VendTextBox = new System.Windows.Forms.TextBox();
            this.vendedor_VendTextBox = new System.Windows.Forms.TextBox();
            this.data_VendDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nota_Fiscal_VendTextBox = new System.Windows.Forms.TextBox();
            this.valor_VendMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.button2 = new System.Windows.Forms.Button();
            código_VendLabel = new System.Windows.Forms.Label();
            produto_VendLabel = new System.Windows.Forms.Label();
            cliente_VendLabel = new System.Windows.Forms.Label();
            quantidade_VendLabel = new System.Windows.Forms.Label();
            vendedor_VendLabel = new System.Windows.Forms.Label();
            data_VendLabel = new System.Windows.Forms.Label();
            nota_Fiscal_VendLabel = new System.Windows.Forms.Label();
            valor_VendLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.industria_MetalurgicaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendasBindingNavigator)).BeginInit();
            this.vendasBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // industria_MetalurgicaDataSet
            // 
            this.industria_MetalurgicaDataSet.DataSetName = "Industria_MetalurgicaDataSet";
            this.industria_MetalurgicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vendasBindingSource
            // 
            this.vendasBindingSource.DataMember = "Vendas";
            this.vendasBindingSource.DataSource = this.industria_MetalurgicaDataSet;
            // 
            // vendasTableAdapter
            // 
            this.vendasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientesTableAdapter = null;
            this.tableAdapterManager.ComprasTableAdapter = null;
            this.tableAdapterManager.ContasTableAdapter = null;
            this.tableAdapterManager.FornecedoresTableAdapter = null;
            this.tableAdapterManager.FuncionáriosTableAdapter = null;
            this.tableAdapterManager.LoginTableAdapter = null;
            this.tableAdapterManager.Nota_fiscalTableAdapter = null;
            this.tableAdapterManager.ProdutosTableAdapter = null;
            this.tableAdapterManager.TransportadorasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Industria_Metalurgica.Industria_MetalurgicaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VendasTableAdapter = this.vendasTableAdapter;
            // 
            // vendasBindingNavigator
            // 
            this.vendasBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.vendasBindingNavigator.BindingSource = this.vendasBindingSource;
            this.vendasBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.vendasBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.vendasBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.vendasBindingNavigatorSaveItem});
            this.vendasBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.vendasBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.vendasBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.vendasBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.vendasBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.vendasBindingNavigator.Name = "vendasBindingNavigator";
            this.vendasBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.vendasBindingNavigator.Size = new System.Drawing.Size(423, 25);
            this.vendasBindingNavigator.TabIndex = 0;
            this.vendasBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // vendasBindingNavigatorSaveItem
            // 
            this.vendasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.vendasBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("vendasBindingNavigatorSaveItem.Image")));
            this.vendasBindingNavigatorSaveItem.Name = "vendasBindingNavigatorSaveItem";
            this.vendasBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.vendasBindingNavigatorSaveItem.Text = "Save Data";
            this.vendasBindingNavigatorSaveItem.Click += new System.EventHandler(this.vendasBindingNavigatorSaveItem_Click);
            // 
            // código_VendLabel
            // 
            código_VendLabel.AutoSize = true;
            código_VendLabel.BackColor = System.Drawing.Color.Transparent;
            código_VendLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            código_VendLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            código_VendLabel.Location = new System.Drawing.Point(26, 44);
            código_VendLabel.Name = "código_VendLabel";
            código_VendLabel.Size = new System.Drawing.Size(84, 30);
            código_VendLabel.TabIndex = 1;
            código_VendLabel.Text = "Código:";
            // 
            // código_VendTextBox
            // 
            this.código_VendTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendasBindingSource, "Código_Vend", true));
            this.código_VendTextBox.Location = new System.Drawing.Point(188, 52);
            this.código_VendTextBox.Name = "código_VendTextBox";
            this.código_VendTextBox.ReadOnly = true;
            this.código_VendTextBox.Size = new System.Drawing.Size(200, 20);
            this.código_VendTextBox.TabIndex = 2;
            this.código_VendTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // produto_VendLabel
            // 
            produto_VendLabel.AutoSize = true;
            produto_VendLabel.BackColor = System.Drawing.Color.Transparent;
            produto_VendLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            produto_VendLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            produto_VendLabel.Location = new System.Drawing.Point(26, 70);
            produto_VendLabel.Name = "produto_VendLabel";
            produto_VendLabel.Size = new System.Drawing.Size(92, 30);
            produto_VendLabel.TabIndex = 3;
            produto_VendLabel.Text = "Produto:";
            // 
            // produto_VendTextBox
            // 
            this.produto_VendTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendasBindingSource, "Produto_Vend", true));
            this.produto_VendTextBox.Location = new System.Drawing.Point(188, 78);
            this.produto_VendTextBox.Name = "produto_VendTextBox";
            this.produto_VendTextBox.Size = new System.Drawing.Size(200, 20);
            this.produto_VendTextBox.TabIndex = 4;
            this.produto_VendTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cliente_VendLabel
            // 
            cliente_VendLabel.AutoSize = true;
            cliente_VendLabel.BackColor = System.Drawing.Color.Transparent;
            cliente_VendLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            cliente_VendLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            cliente_VendLabel.Location = new System.Drawing.Point(26, 96);
            cliente_VendLabel.Name = "cliente_VendLabel";
            cliente_VendLabel.Size = new System.Drawing.Size(82, 30);
            cliente_VendLabel.TabIndex = 5;
            cliente_VendLabel.Text = "Cliente:";
            // 
            // cliente_VendTextBox
            // 
            this.cliente_VendTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendasBindingSource, "Cliente_Vend", true));
            this.cliente_VendTextBox.Location = new System.Drawing.Point(188, 104);
            this.cliente_VendTextBox.Name = "cliente_VendTextBox";
            this.cliente_VendTextBox.Size = new System.Drawing.Size(200, 20);
            this.cliente_VendTextBox.TabIndex = 6;
            this.cliente_VendTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // quantidade_VendLabel
            // 
            quantidade_VendLabel.AutoSize = true;
            quantidade_VendLabel.BackColor = System.Drawing.Color.Transparent;
            quantidade_VendLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            quantidade_VendLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            quantidade_VendLabel.Location = new System.Drawing.Point(26, 122);
            quantidade_VendLabel.Name = "quantidade_VendLabel";
            quantidade_VendLabel.Size = new System.Drawing.Size(127, 30);
            quantidade_VendLabel.TabIndex = 7;
            quantidade_VendLabel.Text = "Quantidade:";
            // 
            // quantidade_VendTextBox
            // 
            this.quantidade_VendTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendasBindingSource, "Quantidade_Vend", true));
            this.quantidade_VendTextBox.Location = new System.Drawing.Point(188, 130);
            this.quantidade_VendTextBox.Name = "quantidade_VendTextBox";
            this.quantidade_VendTextBox.Size = new System.Drawing.Size(200, 20);
            this.quantidade_VendTextBox.TabIndex = 8;
            this.quantidade_VendTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // vendedor_VendLabel
            // 
            vendedor_VendLabel.AutoSize = true;
            vendedor_VendLabel.BackColor = System.Drawing.Color.Transparent;
            vendedor_VendLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            vendedor_VendLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            vendedor_VendLabel.Location = new System.Drawing.Point(26, 148);
            vendedor_VendLabel.Name = "vendedor_VendLabel";
            vendedor_VendLabel.Size = new System.Drawing.Size(107, 30);
            vendedor_VendLabel.TabIndex = 9;
            vendedor_VendLabel.Text = "Vendedor:";
            // 
            // vendedor_VendTextBox
            // 
            this.vendedor_VendTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendasBindingSource, "Vendedor_Vend", true));
            this.vendedor_VendTextBox.Location = new System.Drawing.Point(188, 156);
            this.vendedor_VendTextBox.Name = "vendedor_VendTextBox";
            this.vendedor_VendTextBox.Size = new System.Drawing.Size(200, 20);
            this.vendedor_VendTextBox.TabIndex = 10;
            this.vendedor_VendTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // data_VendLabel
            // 
            data_VendLabel.AutoSize = true;
            data_VendLabel.BackColor = System.Drawing.Color.Transparent;
            data_VendLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            data_VendLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            data_VendLabel.Location = new System.Drawing.Point(26, 175);
            data_VendLabel.Name = "data_VendLabel";
            data_VendLabel.Size = new System.Drawing.Size(62, 30);
            data_VendLabel.TabIndex = 11;
            data_VendLabel.Text = "Data:";
            // 
            // data_VendDateTimePicker
            // 
            this.data_VendDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.vendasBindingSource, "Data_Vend", true));
            this.data_VendDateTimePicker.Location = new System.Drawing.Point(188, 182);
            this.data_VendDateTimePicker.Name = "data_VendDateTimePicker";
            this.data_VendDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.data_VendDateTimePicker.TabIndex = 12;
            // 
            // nota_Fiscal_VendLabel
            // 
            nota_Fiscal_VendLabel.AutoSize = true;
            nota_Fiscal_VendLabel.BackColor = System.Drawing.Color.Transparent;
            nota_Fiscal_VendLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            nota_Fiscal_VendLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            nota_Fiscal_VendLabel.Location = new System.Drawing.Point(26, 200);
            nota_Fiscal_VendLabel.Name = "nota_Fiscal_VendLabel";
            nota_Fiscal_VendLabel.Size = new System.Drawing.Size(120, 30);
            nota_Fiscal_VendLabel.TabIndex = 13;
            nota_Fiscal_VendLabel.Text = "Nota Fiscal:";
            // 
            // nota_Fiscal_VendTextBox
            // 
            this.nota_Fiscal_VendTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendasBindingSource, "Nota_Fiscal_Vend", true));
            this.nota_Fiscal_VendTextBox.Location = new System.Drawing.Point(188, 208);
            this.nota_Fiscal_VendTextBox.Name = "nota_Fiscal_VendTextBox";
            this.nota_Fiscal_VendTextBox.Size = new System.Drawing.Size(200, 20);
            this.nota_Fiscal_VendTextBox.TabIndex = 14;
            this.nota_Fiscal_VendTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // valor_VendLabel
            // 
            valor_VendLabel.AutoSize = true;
            valor_VendLabel.BackColor = System.Drawing.Color.Transparent;
            valor_VendLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            valor_VendLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            valor_VendLabel.Location = new System.Drawing.Point(26, 226);
            valor_VendLabel.Name = "valor_VendLabel";
            valor_VendLabel.Size = new System.Drawing.Size(64, 30);
            valor_VendLabel.TabIndex = 15;
            valor_VendLabel.Text = "Valor:";
            // 
            // valor_VendMaskedTextBox
            // 
            this.valor_VendMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendasBindingSource, "Valor_Vend", true));
            this.valor_VendMaskedTextBox.Location = new System.Drawing.Point(188, 234);
            this.valor_VendMaskedTextBox.Mask = "$";
            this.valor_VendMaskedTextBox.Name = "valor_VendMaskedTextBox";
            this.valor_VendMaskedTextBox.Size = new System.Drawing.Size(200, 20);
            this.valor_VendMaskedTextBox.TabIndex = 16;
            this.valor_VendMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Lucida Sans", 11.25F);
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(300, 271);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 30);
            this.button2.TabIndex = 45;
            this.button2.Text = "&Fechar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(423, 313);
            this.Controls.Add(this.button2);
            this.Controls.Add(código_VendLabel);
            this.Controls.Add(this.código_VendTextBox);
            this.Controls.Add(produto_VendLabel);
            this.Controls.Add(this.produto_VendTextBox);
            this.Controls.Add(cliente_VendLabel);
            this.Controls.Add(this.cliente_VendTextBox);
            this.Controls.Add(quantidade_VendLabel);
            this.Controls.Add(this.quantidade_VendTextBox);
            this.Controls.Add(vendedor_VendLabel);
            this.Controls.Add(this.vendedor_VendTextBox);
            this.Controls.Add(data_VendLabel);
            this.Controls.Add(this.data_VendDateTimePicker);
            this.Controls.Add(nota_Fiscal_VendLabel);
            this.Controls.Add(this.nota_Fiscal_VendTextBox);
            this.Controls.Add(valor_VendLabel);
            this.Controls.Add(this.valor_VendMaskedTextBox);
            this.Controls.Add(this.vendasBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendas";
            this.Load += new System.EventHandler(this.FrmVendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.industria_MetalurgicaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendasBindingNavigator)).EndInit();
            this.vendasBindingNavigator.ResumeLayout(false);
            this.vendasBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Industria_MetalurgicaDataSet industria_MetalurgicaDataSet;
        private System.Windows.Forms.BindingSource vendasBindingSource;
        private Industria_Metalurgica.Industria_MetalurgicaDataSetTableAdapters.VendasTableAdapter vendasTableAdapter;
        private Industria_Metalurgica.Industria_MetalurgicaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator vendasBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton vendasBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox código_VendTextBox;
        private System.Windows.Forms.TextBox produto_VendTextBox;
        private System.Windows.Forms.TextBox cliente_VendTextBox;
        private System.Windows.Forms.TextBox quantidade_VendTextBox;
        private System.Windows.Forms.TextBox vendedor_VendTextBox;
        private System.Windows.Forms.DateTimePicker data_VendDateTimePicker;
        private System.Windows.Forms.TextBox nota_Fiscal_VendTextBox;
        private System.Windows.Forms.MaskedTextBox valor_VendMaskedTextBox;
        private System.Windows.Forms.Button button2;
    }
}