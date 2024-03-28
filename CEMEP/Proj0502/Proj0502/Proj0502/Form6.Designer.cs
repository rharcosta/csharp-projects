namespace Proj0502
{
    partial class FrmVendedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVendedor));
            System.Windows.Forms.Label códVendedorLabel;
            System.Windows.Forms.Label nomeVendLabel;
            System.Windows.Forms.Label dtAdmLabel;
            System.Windows.Forms.Label salarioLabel;
            this.button1 = new System.Windows.Forms.Button();
            this.bD0502DataSet = new Proj0502.BD0502DataSet();
            this.tabVendedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabVendedorTableAdapter = new Proj0502.BD0502DataSetTableAdapters.TabVendedorTableAdapter();
            this.tableAdapterManager = new Proj0502.BD0502DataSetTableAdapters.TableAdapterManager();
            this.tabVendedorBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tabVendedorBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.códVendedorTextBox = new System.Windows.Forms.TextBox();
            this.nomeVendTextBox = new System.Windows.Forms.TextBox();
            this.dtAdmDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.salarioTextBox = new System.Windows.Forms.TextBox();
            códVendedorLabel = new System.Windows.Forms.Label();
            nomeVendLabel = new System.Windows.Forms.Label();
            dtAdmLabel = new System.Windows.Forms.Label();
            salarioLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bD0502DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabVendedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabVendedorBindingNavigator)).BeginInit();
            this.tabVendedorBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(368, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Fechar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bD0502DataSet
            // 
            this.bD0502DataSet.DataSetName = "BD0502DataSet";
            this.bD0502DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabVendedorBindingSource
            // 
            this.tabVendedorBindingSource.DataMember = "TabVendedor";
            this.tabVendedorBindingSource.DataSource = this.bD0502DataSet;
            // 
            // tabVendedorTableAdapter
            // 
            this.tabVendedorTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TabCliTableAdapter = null;
            this.tableAdapterManager.TabProdTableAdapter = null;
            this.tableAdapterManager.TabVendedorTableAdapter = this.tabVendedorTableAdapter;
            this.tableAdapterManager.UpdateOrder = Proj0502.BD0502DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tabVendedorBindingNavigator
            // 
            this.tabVendedorBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tabVendedorBindingNavigator.BindingSource = this.tabVendedorBindingSource;
            this.tabVendedorBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tabVendedorBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tabVendedorBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tabVendedorBindingNavigatorSaveItem});
            this.tabVendedorBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tabVendedorBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tabVendedorBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tabVendedorBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tabVendedorBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tabVendedorBindingNavigator.Name = "tabVendedorBindingNavigator";
            this.tabVendedorBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tabVendedorBindingNavigator.Size = new System.Drawing.Size(492, 25);
            this.tabVendedorBindingNavigator.TabIndex = 1;
            this.tabVendedorBindingNavigator.Text = "bindingNavigator1";
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
            // tabVendedorBindingNavigatorSaveItem
            // 
            this.tabVendedorBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tabVendedorBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tabVendedorBindingNavigatorSaveItem.Image")));
            this.tabVendedorBindingNavigatorSaveItem.Name = "tabVendedorBindingNavigatorSaveItem";
            this.tabVendedorBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.tabVendedorBindingNavigatorSaveItem.Text = "Save Data";
            this.tabVendedorBindingNavigatorSaveItem.Click += new System.EventHandler(this.tabVendedorBindingNavigatorSaveItem_Click);
            // 
            // códVendedorLabel
            // 
            códVendedorLabel.AutoSize = true;
            códVendedorLabel.Location = new System.Drawing.Point(61, 126);
            códVendedorLabel.Name = "códVendedorLabel";
            códVendedorLabel.Size = new System.Drawing.Size(43, 13);
            códVendedorLabel.TabIndex = 2;
            códVendedorLabel.Text = "Código:";
            // 
            // códVendedorTextBox
            // 
            this.códVendedorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabVendedorBindingSource, "CódVendedor", true));
            this.códVendedorTextBox.Location = new System.Drawing.Point(145, 123);
            this.códVendedorTextBox.Name = "códVendedorTextBox";
            this.códVendedorTextBox.Size = new System.Drawing.Size(259, 20);
            this.códVendedorTextBox.TabIndex = 3;
            // 
            // nomeVendLabel
            // 
            nomeVendLabel.AutoSize = true;
            nomeVendLabel.Location = new System.Drawing.Point(61, 152);
            nomeVendLabel.Name = "nomeVendLabel";
            nomeVendLabel.Size = new System.Drawing.Size(38, 13);
            nomeVendLabel.TabIndex = 4;
            nomeVendLabel.Text = "Nome:";
            // 
            // nomeVendTextBox
            // 
            this.nomeVendTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabVendedorBindingSource, "NomeVend", true));
            this.nomeVendTextBox.Location = new System.Drawing.Point(145, 149);
            this.nomeVendTextBox.Name = "nomeVendTextBox";
            this.nomeVendTextBox.Size = new System.Drawing.Size(259, 20);
            this.nomeVendTextBox.TabIndex = 5;
            // 
            // dtAdmLabel
            // 
            dtAdmLabel.AutoSize = true;
            dtAdmLabel.Location = new System.Drawing.Point(61, 179);
            dtAdmLabel.Name = "dtAdmLabel";
            dtAdmLabel.Size = new System.Drawing.Size(45, 13);
            dtAdmLabel.TabIndex = 6;
            dtAdmLabel.Text = "Dt Adm:";
            // 
            // dtAdmDateTimePicker
            // 
            this.dtAdmDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tabVendedorBindingSource, "DtAdm", true));
            this.dtAdmDateTimePicker.Location = new System.Drawing.Point(145, 175);
            this.dtAdmDateTimePicker.Name = "dtAdmDateTimePicker";
            this.dtAdmDateTimePicker.Size = new System.Drawing.Size(259, 20);
            this.dtAdmDateTimePicker.TabIndex = 7;
            // 
            // salarioLabel
            // 
            salarioLabel.AutoSize = true;
            salarioLabel.Location = new System.Drawing.Point(61, 204);
            salarioLabel.Name = "salarioLabel";
            salarioLabel.Size = new System.Drawing.Size(42, 13);
            salarioLabel.TabIndex = 8;
            salarioLabel.Text = "Salario:";
            // 
            // salarioTextBox
            // 
            this.salarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabVendedorBindingSource, "Salario", true));
            this.salarioTextBox.Location = new System.Drawing.Point(145, 201);
            this.salarioTextBox.Name = "salarioTextBox";
            this.salarioTextBox.Size = new System.Drawing.Size(259, 20);
            this.salarioTextBox.TabIndex = 9;
            // 
            // FrmVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 373);
            this.Controls.Add(códVendedorLabel);
            this.Controls.Add(this.códVendedorTextBox);
            this.Controls.Add(nomeVendLabel);
            this.Controls.Add(this.nomeVendTextBox);
            this.Controls.Add(dtAdmLabel);
            this.Controls.Add(this.dtAdmDateTimePicker);
            this.Controls.Add(salarioLabel);
            this.Controls.Add(this.salarioTextBox);
            this.Controls.Add(this.tabVendedorBindingNavigator);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmVendedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendedor";
            this.Load += new System.EventHandler(this.FrmVendedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bD0502DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabVendedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabVendedorBindingNavigator)).EndInit();
            this.tabVendedorBindingNavigator.ResumeLayout(false);
            this.tabVendedorBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private BD0502DataSet bD0502DataSet;
        private System.Windows.Forms.BindingSource tabVendedorBindingSource;
        private Proj0502.BD0502DataSetTableAdapters.TabVendedorTableAdapter tabVendedorTableAdapter;
        private Proj0502.BD0502DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tabVendedorBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tabVendedorBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox códVendedorTextBox;
        private System.Windows.Forms.TextBox nomeVendTextBox;
        private System.Windows.Forms.DateTimePicker dtAdmDateTimePicker;
        private System.Windows.Forms.TextBox salarioTextBox;
    }
}