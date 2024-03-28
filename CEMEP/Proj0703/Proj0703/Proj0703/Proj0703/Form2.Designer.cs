namespace Proj0703
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            System.Windows.Forms.Label codAlunoLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label sexoLabel;
            System.Windows.Forms.Label cPFLabel;
            System.Windows.Forms.Label dtNascLabel;
            System.Windows.Forms.Label enterLabel;
            System.Windows.Forms.Label cidadeLabel;
            System.Windows.Forms.Label ufLabel;
            System.Windows.Forms.Label foneLabel;
            System.Windows.Forms.Label salaLabel;
            this.bD0703DataSet = new Proj0703.BD0703DataSet();
            this.tabAlunoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabAlunoTableAdapter = new Proj0703.BD0703DataSetTableAdapters.TabAlunoTableAdapter();
            this.tableAdapterManager = new Proj0703.BD0703DataSetTableAdapters.TableAdapterManager();
            this.tabAlunoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tabAlunoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.codAlunoTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.sexoTextBox = new System.Windows.Forms.TextBox();
            this.cPFMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.dtNascDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.enterTextBox = new System.Windows.Forms.TextBox();
            this.cidadeTextBox = new System.Windows.Forms.TextBox();
            this.ufTextBox = new System.Windows.Forms.TextBox();
            this.foneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.salaTextBox = new System.Windows.Forms.TextBox();
            codAlunoLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            sexoLabel = new System.Windows.Forms.Label();
            cPFLabel = new System.Windows.Forms.Label();
            dtNascLabel = new System.Windows.Forms.Label();
            enterLabel = new System.Windows.Forms.Label();
            cidadeLabel = new System.Windows.Forms.Label();
            ufLabel = new System.Windows.Forms.Label();
            foneLabel = new System.Windows.Forms.Label();
            salaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bD0703DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabAlunoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabAlunoBindingNavigator)).BeginInit();
            this.tabAlunoBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // bD0703DataSet
            // 
            this.bD0703DataSet.DataSetName = "BD0703DataSet";
            this.bD0703DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabAlunoBindingSource
            // 
            this.tabAlunoBindingSource.DataMember = "TabAluno";
            this.tabAlunoBindingSource.DataSource = this.bD0703DataSet;
            // 
            // tabAlunoTableAdapter
            // 
            this.tabAlunoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TabAlunoTableAdapter = this.tabAlunoTableAdapter;
            this.tableAdapterManager.TabDisciplinaTableAdapter = null;
            this.tableAdapterManager.TabProfTableAdapter = null;
            this.tableAdapterManager.TabSalaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Proj0703.BD0703DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tabAlunoBindingNavigator
            // 
            this.tabAlunoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tabAlunoBindingNavigator.BindingSource = this.tabAlunoBindingSource;
            this.tabAlunoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tabAlunoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tabAlunoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tabAlunoBindingNavigatorSaveItem});
            this.tabAlunoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tabAlunoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tabAlunoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tabAlunoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tabAlunoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tabAlunoBindingNavigator.Name = "tabAlunoBindingNavigator";
            this.tabAlunoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tabAlunoBindingNavigator.Size = new System.Drawing.Size(358, 25);
            this.tabAlunoBindingNavigator.TabIndex = 0;
            this.tabAlunoBindingNavigator.Text = "bindingNavigator1";
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
            // tabAlunoBindingNavigatorSaveItem
            // 
            this.tabAlunoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tabAlunoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tabAlunoBindingNavigatorSaveItem.Image")));
            this.tabAlunoBindingNavigatorSaveItem.Name = "tabAlunoBindingNavigatorSaveItem";
            this.tabAlunoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.tabAlunoBindingNavigatorSaveItem.Text = "Save Data";
            this.tabAlunoBindingNavigatorSaveItem.Click += new System.EventHandler(this.tabAlunoBindingNavigatorSaveItem_Click);
            // 
            // codAlunoLabel
            // 
            codAlunoLabel.AutoSize = true;
            codAlunoLabel.Location = new System.Drawing.Point(50, 63);
            codAlunoLabel.Name = "codAlunoLabel";
            codAlunoLabel.Size = new System.Drawing.Size(59, 13);
            codAlunoLabel.TabIndex = 1;
            codAlunoLabel.Text = "Cod Aluno:";
            // 
            // codAlunoTextBox
            // 
            this.codAlunoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabAlunoBindingSource, "CodAluno", true));
            this.codAlunoTextBox.Location = new System.Drawing.Point(115, 60);
            this.codAlunoTextBox.Name = "codAlunoTextBox";
            this.codAlunoTextBox.Size = new System.Drawing.Size(200, 20);
            this.codAlunoTextBox.TabIndex = 2;
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(50, 89);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(38, 13);
            nomeLabel.TabIndex = 3;
            nomeLabel.Text = "Nome:";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabAlunoBindingSource, "Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(115, 86);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(200, 20);
            this.nomeTextBox.TabIndex = 4;
            // 
            // sexoLabel
            // 
            sexoLabel.AutoSize = true;
            sexoLabel.Location = new System.Drawing.Point(50, 115);
            sexoLabel.Name = "sexoLabel";
            sexoLabel.Size = new System.Drawing.Size(34, 13);
            sexoLabel.TabIndex = 5;
            sexoLabel.Text = "Sexo:";
            // 
            // sexoTextBox
            // 
            this.sexoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabAlunoBindingSource, "Sexo", true));
            this.sexoTextBox.Location = new System.Drawing.Point(115, 112);
            this.sexoTextBox.Name = "sexoTextBox";
            this.sexoTextBox.Size = new System.Drawing.Size(200, 20);
            this.sexoTextBox.TabIndex = 6;
            // 
            // cPFLabel
            // 
            cPFLabel.AutoSize = true;
            cPFLabel.Location = new System.Drawing.Point(50, 141);
            cPFLabel.Name = "cPFLabel";
            cPFLabel.Size = new System.Drawing.Size(30, 13);
            cPFLabel.TabIndex = 7;
            cPFLabel.Text = "CPF:";
            // 
            // cPFMaskedTextBox
            // 
            this.cPFMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabAlunoBindingSource, "CPF", true));
            this.cPFMaskedTextBox.Location = new System.Drawing.Point(115, 138);
            this.cPFMaskedTextBox.Name = "cPFMaskedTextBox";
            this.cPFMaskedTextBox.Size = new System.Drawing.Size(200, 20);
            this.cPFMaskedTextBox.TabIndex = 8;
            // 
            // dtNascLabel
            // 
            dtNascLabel.AutoSize = true;
            dtNascLabel.Location = new System.Drawing.Point(50, 168);
            dtNascLabel.Name = "dtNascLabel";
            dtNascLabel.Size = new System.Drawing.Size(49, 13);
            dtNascLabel.TabIndex = 9;
            dtNascLabel.Text = "Dt Nasc:";
            // 
            // dtNascDateTimePicker
            // 
            this.dtNascDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tabAlunoBindingSource, "DtNasc", true));
            this.dtNascDateTimePicker.Location = new System.Drawing.Point(115, 164);
            this.dtNascDateTimePicker.Name = "dtNascDateTimePicker";
            this.dtNascDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dtNascDateTimePicker.TabIndex = 10;
            // 
            // enterLabel
            // 
            enterLabel.AutoSize = true;
            enterLabel.Location = new System.Drawing.Point(50, 193);
            enterLabel.Name = "enterLabel";
            enterLabel.Size = new System.Drawing.Size(35, 13);
            enterLabel.TabIndex = 11;
            enterLabel.Text = "Enter:";
            // 
            // enterTextBox
            // 
            this.enterTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabAlunoBindingSource, "Enter", true));
            this.enterTextBox.Location = new System.Drawing.Point(115, 190);
            this.enterTextBox.Name = "enterTextBox";
            this.enterTextBox.Size = new System.Drawing.Size(200, 20);
            this.enterTextBox.TabIndex = 12;
            // 
            // cidadeLabel
            // 
            cidadeLabel.AutoSize = true;
            cidadeLabel.Location = new System.Drawing.Point(50, 219);
            cidadeLabel.Name = "cidadeLabel";
            cidadeLabel.Size = new System.Drawing.Size(43, 13);
            cidadeLabel.TabIndex = 13;
            cidadeLabel.Text = "Cidade:";
            // 
            // cidadeTextBox
            // 
            this.cidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabAlunoBindingSource, "Cidade", true));
            this.cidadeTextBox.Location = new System.Drawing.Point(115, 216);
            this.cidadeTextBox.Name = "cidadeTextBox";
            this.cidadeTextBox.Size = new System.Drawing.Size(200, 20);
            this.cidadeTextBox.TabIndex = 14;
            // 
            // ufLabel
            // 
            ufLabel.AutoSize = true;
            ufLabel.Location = new System.Drawing.Point(50, 245);
            ufLabel.Name = "ufLabel";
            ufLabel.Size = new System.Drawing.Size(21, 13);
            ufLabel.TabIndex = 15;
            ufLabel.Text = "Uf:";
            // 
            // ufTextBox
            // 
            this.ufTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabAlunoBindingSource, "Uf", true));
            this.ufTextBox.Location = new System.Drawing.Point(115, 242);
            this.ufTextBox.Name = "ufTextBox";
            this.ufTextBox.Size = new System.Drawing.Size(200, 20);
            this.ufTextBox.TabIndex = 16;
            // 
            // foneLabel
            // 
            foneLabel.AutoSize = true;
            foneLabel.Location = new System.Drawing.Point(50, 271);
            foneLabel.Name = "foneLabel";
            foneLabel.Size = new System.Drawing.Size(34, 13);
            foneLabel.TabIndex = 17;
            foneLabel.Text = "Fone:";
            // 
            // foneMaskedTextBox
            // 
            this.foneMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabAlunoBindingSource, "Fone", true));
            this.foneMaskedTextBox.Location = new System.Drawing.Point(115, 268);
            this.foneMaskedTextBox.Name = "foneMaskedTextBox";
            this.foneMaskedTextBox.Size = new System.Drawing.Size(200, 20);
            this.foneMaskedTextBox.TabIndex = 18;
            // 
            // salaLabel
            // 
            salaLabel.AutoSize = true;
            salaLabel.Location = new System.Drawing.Point(50, 297);
            salaLabel.Name = "salaLabel";
            salaLabel.Size = new System.Drawing.Size(31, 13);
            salaLabel.TabIndex = 19;
            salaLabel.Text = "Sala:";
            // 
            // salaTextBox
            // 
            this.salaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabAlunoBindingSource, "Sala", true));
            this.salaTextBox.Location = new System.Drawing.Point(115, 294);
            this.salaTextBox.Name = "salaTextBox";
            this.salaTextBox.Size = new System.Drawing.Size(200, 20);
            this.salaTextBox.TabIndex = 20;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 350);
            this.Controls.Add(codAlunoLabel);
            this.Controls.Add(this.codAlunoTextBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(sexoLabel);
            this.Controls.Add(this.sexoTextBox);
            this.Controls.Add(cPFLabel);
            this.Controls.Add(this.cPFMaskedTextBox);
            this.Controls.Add(dtNascLabel);
            this.Controls.Add(this.dtNascDateTimePicker);
            this.Controls.Add(enterLabel);
            this.Controls.Add(this.enterTextBox);
            this.Controls.Add(cidadeLabel);
            this.Controls.Add(this.cidadeTextBox);
            this.Controls.Add(ufLabel);
            this.Controls.Add(this.ufTextBox);
            this.Controls.Add(foneLabel);
            this.Controls.Add(this.foneMaskedTextBox);
            this.Controls.Add(salaLabel);
            this.Controls.Add(this.salaTextBox);
            this.Controls.Add(this.tabAlunoBindingNavigator);
            this.Name = "Form2";
            this.Text = "Aluno";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bD0703DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabAlunoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabAlunoBindingNavigator)).EndInit();
            this.tabAlunoBindingNavigator.ResumeLayout(false);
            this.tabAlunoBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BD0703DataSet bD0703DataSet;
        private System.Windows.Forms.BindingSource tabAlunoBindingSource;
        private Proj0703.BD0703DataSetTableAdapters.TabAlunoTableAdapter tabAlunoTableAdapter;
        private Proj0703.BD0703DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tabAlunoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tabAlunoBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox codAlunoTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox sexoTextBox;
        private System.Windows.Forms.MaskedTextBox cPFMaskedTextBox;
        private System.Windows.Forms.DateTimePicker dtNascDateTimePicker;
        private System.Windows.Forms.TextBox enterTextBox;
        private System.Windows.Forms.TextBox cidadeTextBox;
        private System.Windows.Forms.TextBox ufTextBox;
        private System.Windows.Forms.MaskedTextBox foneMaskedTextBox;
        private System.Windows.Forms.TextBox salaTextBox;
    }
}