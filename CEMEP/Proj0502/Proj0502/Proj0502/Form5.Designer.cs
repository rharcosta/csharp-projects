namespace Proj0502
{
    partial class FrmProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProduto));
            System.Windows.Forms.Label códProdLabel;
            System.Windows.Forms.Label descriçãoLabel;
            System.Windows.Forms.Label valorLabel;
            this.button1 = new System.Windows.Forms.Button();
            this.bD0502DataSet = new Proj0502.BD0502DataSet();
            this.tabProdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabProdTableAdapter = new Proj0502.BD0502DataSetTableAdapters.TabProdTableAdapter();
            this.tableAdapterManager = new Proj0502.BD0502DataSetTableAdapters.TableAdapterManager();
            this.tabProdBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tabProdBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.códProdTextBox = new System.Windows.Forms.TextBox();
            this.descriçãoTextBox = new System.Windows.Forms.TextBox();
            this.valorTextBox = new System.Windows.Forms.TextBox();
            códProdLabel = new System.Windows.Forms.Label();
            descriçãoLabel = new System.Windows.Forms.Label();
            valorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bD0502DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabProdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabProdBindingNavigator)).BeginInit();
            this.tabProdBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(360, 318);
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
            // tabProdBindingSource
            // 
            this.tabProdBindingSource.DataMember = "TabProd";
            this.tabProdBindingSource.DataSource = this.bD0502DataSet;
            // 
            // tabProdTableAdapter
            // 
            this.tabProdTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TabCliTableAdapter = null;
            this.tableAdapterManager.TabProdTableAdapter = this.tabProdTableAdapter;
            this.tableAdapterManager.TabVendedorTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Proj0502.BD0502DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tabProdBindingNavigator
            // 
            this.tabProdBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tabProdBindingNavigator.BindingSource = this.tabProdBindingSource;
            this.tabProdBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tabProdBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tabProdBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tabProdBindingNavigatorSaveItem});
            this.tabProdBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tabProdBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tabProdBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tabProdBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tabProdBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tabProdBindingNavigator.Name = "tabProdBindingNavigator";
            this.tabProdBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tabProdBindingNavigator.Size = new System.Drawing.Size(492, 25);
            this.tabProdBindingNavigator.TabIndex = 1;
            this.tabProdBindingNavigator.Text = "bindingNavigator1";
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
            // tabProdBindingNavigatorSaveItem
            // 
            this.tabProdBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tabProdBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tabProdBindingNavigatorSaveItem.Image")));
            this.tabProdBindingNavigatorSaveItem.Name = "tabProdBindingNavigatorSaveItem";
            this.tabProdBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.tabProdBindingNavigatorSaveItem.Text = "Save Data";
            this.tabProdBindingNavigatorSaveItem.Click += new System.EventHandler(this.tabProdBindingNavigatorSaveItem_Click);
            // 
            // códProdLabel
            // 
            códProdLabel.AutoSize = true;
            códProdLabel.Location = new System.Drawing.Point(61, 60);
            códProdLabel.Name = "códProdLabel";
            códProdLabel.Size = new System.Drawing.Size(54, 13);
            códProdLabel.TabIndex = 2;
            códProdLabel.Text = "Cód Prod:";
            // 
            // códProdTextBox
            // 
            this.códProdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabProdBindingSource, "CódProd", true));
            this.códProdTextBox.Location = new System.Drawing.Point(206, 53);
            this.códProdTextBox.Name = "códProdTextBox";
            this.códProdTextBox.Size = new System.Drawing.Size(100, 20);
            this.códProdTextBox.TabIndex = 3;
            // 
            // descriçãoLabel
            // 
            descriçãoLabel.AutoSize = true;
            descriçãoLabel.Location = new System.Drawing.Point(61, 86);
            descriçãoLabel.Name = "descriçãoLabel";
            descriçãoLabel.Size = new System.Drawing.Size(58, 13);
            descriçãoLabel.TabIndex = 4;
            descriçãoLabel.Text = "Descrição:";
            // 
            // descriçãoTextBox
            // 
            this.descriçãoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabProdBindingSource, "Descrição", true));
            this.descriçãoTextBox.Location = new System.Drawing.Point(206, 83);
            this.descriçãoTextBox.Name = "descriçãoTextBox";
            this.descriçãoTextBox.Size = new System.Drawing.Size(100, 20);
            this.descriçãoTextBox.TabIndex = 5;
            // 
            // valorLabel
            // 
            valorLabel.AutoSize = true;
            valorLabel.Location = new System.Drawing.Point(61, 112);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new System.Drawing.Size(34, 13);
            valorLabel.TabIndex = 6;
            valorLabel.Text = "Valor:";
            // 
            // valorTextBox
            // 
            this.valorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabProdBindingSource, "Valor", true));
            this.valorTextBox.Location = new System.Drawing.Point(206, 112);
            this.valorTextBox.Name = "valorTextBox";
            this.valorTextBox.Size = new System.Drawing.Size(100, 20);
            this.valorTextBox.TabIndex = 7;
            // 
            // FrmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 373);
            this.Controls.Add(códProdLabel);
            this.Controls.Add(this.códProdTextBox);
            this.Controls.Add(descriçãoLabel);
            this.Controls.Add(this.descriçãoTextBox);
            this.Controls.Add(valorLabel);
            this.Controls.Add(this.valorTextBox);
            this.Controls.Add(this.tabProdBindingNavigator);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produto";
            this.Load += new System.EventHandler(this.FrmProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bD0502DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabProdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabProdBindingNavigator)).EndInit();
            this.tabProdBindingNavigator.ResumeLayout(false);
            this.tabProdBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private BD0502DataSet bD0502DataSet;
        private System.Windows.Forms.BindingSource tabProdBindingSource;
        private Proj0502.BD0502DataSetTableAdapters.TabProdTableAdapter tabProdTableAdapter;
        private Proj0502.BD0502DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tabProdBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tabProdBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox códProdTextBox;
        private System.Windows.Forms.TextBox descriçãoTextBox;
        private System.Windows.Forms.TextBox valorTextBox;
    }
}