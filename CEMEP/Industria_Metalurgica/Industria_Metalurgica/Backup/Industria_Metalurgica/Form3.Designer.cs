namespace Industria_Metalurgica
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
            System.Windows.Forms.Label código_LoginLabel;
            System.Windows.Forms.Label nome_LoginLabel;
            System.Windows.Forms.Label usuário_LoginLabel;
            System.Windows.Forms.Label senha_LoginLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsu));
            this.industria_MetalurgicaDataSet = new Industria_Metalurgica.Industria_MetalurgicaDataSet();
            this.loginBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loginTableAdapter = new Industria_Metalurgica.Industria_MetalurgicaDataSetTableAdapters.LoginTableAdapter();
            this.tableAdapterManager = new Industria_Metalurgica.Industria_MetalurgicaDataSetTableAdapters.TableAdapterManager();
            this.loginBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.loginBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.código_LoginTextBox = new System.Windows.Forms.TextBox();
            this.nome_LoginTextBox = new System.Windows.Forms.TextBox();
            this.usuário_LoginTextBox = new System.Windows.Forms.TextBox();
            this.senha_LoginTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            código_LoginLabel = new System.Windows.Forms.Label();
            nome_LoginLabel = new System.Windows.Forms.Label();
            usuário_LoginLabel = new System.Windows.Forms.Label();
            senha_LoginLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.industria_MetalurgicaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingNavigator)).BeginInit();
            this.loginBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // código_LoginLabel
            // 
            código_LoginLabel.AutoSize = true;
            código_LoginLabel.BackColor = System.Drawing.Color.Transparent;
            código_LoginLabel.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            código_LoginLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            código_LoginLabel.Location = new System.Drawing.Point(23, 54);
            código_LoginLabel.Name = "código_LoginLabel";
            código_LoginLabel.Size = new System.Drawing.Size(96, 32);
            código_LoginLabel.TabIndex = 1;
            código_LoginLabel.Text = "Código:";
            // 
            // nome_LoginLabel
            // 
            nome_LoginLabel.AutoSize = true;
            nome_LoginLabel.BackColor = System.Drawing.Color.Transparent;
            nome_LoginLabel.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nome_LoginLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            nome_LoginLabel.Location = new System.Drawing.Point(23, 80);
            nome_LoginLabel.Name = "nome_LoginLabel";
            nome_LoginLabel.Size = new System.Drawing.Size(86, 32);
            nome_LoginLabel.TabIndex = 3;
            nome_LoginLabel.Text = "Nome:";
            // 
            // usuário_LoginLabel
            // 
            usuário_LoginLabel.AutoSize = true;
            usuário_LoginLabel.BackColor = System.Drawing.Color.Transparent;
            usuário_LoginLabel.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            usuário_LoginLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            usuário_LoginLabel.Location = new System.Drawing.Point(23, 106);
            usuário_LoginLabel.Name = "usuário_LoginLabel";
            usuário_LoginLabel.Size = new System.Drawing.Size(104, 32);
            usuário_LoginLabel.TabIndex = 5;
            usuário_LoginLabel.Text = "Usuário:";
            // 
            // senha_LoginLabel
            // 
            senha_LoginLabel.AutoSize = true;
            senha_LoginLabel.BackColor = System.Drawing.Color.Transparent;
            senha_LoginLabel.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            senha_LoginLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            senha_LoginLabel.Location = new System.Drawing.Point(23, 132);
            senha_LoginLabel.Name = "senha_LoginLabel";
            senha_LoginLabel.Size = new System.Drawing.Size(86, 32);
            senha_LoginLabel.TabIndex = 7;
            senha_LoginLabel.Text = "Senha:";
            // 
            // industria_MetalurgicaDataSet
            // 
            this.industria_MetalurgicaDataSet.DataSetName = "Industria_MetalurgicaDataSet";
            this.industria_MetalurgicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loginBindingSource
            // 
            this.loginBindingSource.DataMember = "Login";
            this.loginBindingSource.DataSource = this.industria_MetalurgicaDataSet;
            // 
            // loginTableAdapter
            // 
            this.loginTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientesTableAdapter = null;
            this.tableAdapterManager.ComprasTableAdapter = null;
            this.tableAdapterManager.ContasTableAdapter = null;
            this.tableAdapterManager.FornecedoresTableAdapter = null;
            this.tableAdapterManager.FuncionáriosTableAdapter = null;
            this.tableAdapterManager.LoginTableAdapter = this.loginTableAdapter;
            this.tableAdapterManager.Nota_fiscalTableAdapter = null;
            this.tableAdapterManager.ProdutosTableAdapter = null;
            this.tableAdapterManager.TransportadorasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Industria_Metalurgica.Industria_MetalurgicaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VendasTableAdapter = null;
            // 
            // loginBindingNavigator
            // 
            this.loginBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.loginBindingNavigator.BindingSource = this.loginBindingSource;
            this.loginBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.loginBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.loginBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.loginBindingNavigatorSaveItem});
            this.loginBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.loginBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.loginBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.loginBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.loginBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.loginBindingNavigator.Name = "loginBindingNavigator";
            this.loginBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.loginBindingNavigator.Size = new System.Drawing.Size(284, 25);
            this.loginBindingNavigator.TabIndex = 0;
            this.loginBindingNavigator.Text = "bindingNavigator1";
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
            // loginBindingNavigatorSaveItem
            // 
            this.loginBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.loginBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("loginBindingNavigatorSaveItem.Image")));
            this.loginBindingNavigatorSaveItem.Name = "loginBindingNavigatorSaveItem";
            this.loginBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.loginBindingNavigatorSaveItem.Text = "Save Data";
            this.loginBindingNavigatorSaveItem.Click += new System.EventHandler(this.loginBindingNavigatorSaveItem_Click);
            // 
            // código_LoginTextBox
            // 
            this.código_LoginTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loginBindingSource, "Código_Login", true));
            this.código_LoginTextBox.Location = new System.Drawing.Point(151, 65);
            this.código_LoginTextBox.Name = "código_LoginTextBox";
            this.código_LoginTextBox.Size = new System.Drawing.Size(121, 20);
            this.código_LoginTextBox.TabIndex = 2;
            // 
            // nome_LoginTextBox
            // 
            this.nome_LoginTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loginBindingSource, "Nome_Login", true));
            this.nome_LoginTextBox.Location = new System.Drawing.Point(151, 92);
            this.nome_LoginTextBox.Name = "nome_LoginTextBox";
            this.nome_LoginTextBox.Size = new System.Drawing.Size(121, 20);
            this.nome_LoginTextBox.TabIndex = 4;
            // 
            // usuário_LoginTextBox
            // 
            this.usuário_LoginTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loginBindingSource, "Usuário_Login", true));
            this.usuário_LoginTextBox.Location = new System.Drawing.Point(151, 117);
            this.usuário_LoginTextBox.Name = "usuário_LoginTextBox";
            this.usuário_LoginTextBox.Size = new System.Drawing.Size(121, 20);
            this.usuário_LoginTextBox.TabIndex = 6;
            // 
            // senha_LoginTextBox
            // 
            this.senha_LoginTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loginBindingSource, "Senha_Login", true));
            this.senha_LoginTextBox.Location = new System.Drawing.Point(151, 143);
            this.senha_LoginTextBox.Name = "senha_LoginTextBox";
            this.senha_LoginTextBox.PasswordChar = '*';
            this.senha_LoginTextBox.Size = new System.Drawing.Size(121, 20);
            this.senha_LoginTextBox.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Lucida Sans", 11.25F);
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(184, 219);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 30);
            this.button2.TabIndex = 40;
            this.button2.Text = "&Fechar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.button2, "Fechar");
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button2_KeyPress);
            // 
            // FrmUsu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button2);
            this.Controls.Add(código_LoginLabel);
            this.Controls.Add(this.código_LoginTextBox);
            this.Controls.Add(nome_LoginLabel);
            this.Controls.Add(this.nome_LoginTextBox);
            this.Controls.Add(usuário_LoginLabel);
            this.Controls.Add(this.usuário_LoginTextBox);
            this.Controls.Add(senha_LoginLabel);
            this.Controls.Add(this.senha_LoginTextBox);
            this.Controls.Add(this.loginBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmUsu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuário";
            this.Load += new System.EventHandler(this.FrmUsu_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmUsu_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.industria_MetalurgicaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingNavigator)).EndInit();
            this.loginBindingNavigator.ResumeLayout(false);
            this.loginBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Industria_MetalurgicaDataSet industria_MetalurgicaDataSet;
        private System.Windows.Forms.BindingSource loginBindingSource;
        private Industria_Metalurgica.Industria_MetalurgicaDataSetTableAdapters.LoginTableAdapter loginTableAdapter;
        private Industria_Metalurgica.Industria_MetalurgicaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator loginBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton loginBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox código_LoginTextBox;
        private System.Windows.Forms.TextBox nome_LoginTextBox;
        private System.Windows.Forms.TextBox usuário_LoginTextBox;
        private System.Windows.Forms.TextBox senha_LoginTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}