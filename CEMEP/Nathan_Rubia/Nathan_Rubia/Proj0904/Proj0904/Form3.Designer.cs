namespace Proj0904
{
    partial class FrmConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsulta));
            System.Windows.Forms.Label códLabel;
            System.Windows.Forms.Label dataLabel;
            System.Windows.Forms.Label horaLabel;
            System.Windows.Forms.Label médicoLabel;
            System.Windows.Forms.Label paciente_CodLabel;
            this.bDProva0904DataSet = new Proj0904.BDProva0904DataSet();
            this.consultaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consultaTableAdapter = new Proj0904.BDProva0904DataSetTableAdapters.ConsultaTableAdapter();
            this.tableAdapterManager = new Proj0904.BDProva0904DataSetTableAdapters.TableAdapterManager();
            this.consultaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.consultaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.códTextBox = new System.Windows.Forms.TextBox();
            this.dataDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.horaMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.médicoTextBox = new System.Windows.Forms.TextBox();
            this.paciente_CodTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pacienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pacienteTableAdapter = new Proj0904.BDProva0904DataSetTableAdapters.PacienteTableAdapter();
            this.bDProva0904DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pacienteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bDProva0904DataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            códLabel = new System.Windows.Forms.Label();
            dataLabel = new System.Windows.Forms.Label();
            horaLabel = new System.Windows.Forms.Label();
            médicoLabel = new System.Windows.Forms.Label();
            paciente_CodLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bDProva0904DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultaBindingNavigator)).BeginInit();
            this.consultaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDProva0904DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDProva0904DataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // bDProva0904DataSet
            // 
            this.bDProva0904DataSet.DataSetName = "BDProva0904DataSet";
            this.bDProva0904DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // consultaBindingSource
            // 
            this.consultaBindingSource.DataMember = "Consulta";
            this.consultaBindingSource.DataSource = this.bDProva0904DataSet;
            // 
            // consultaTableAdapter
            // 
            this.consultaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ConsultaTableAdapter = this.consultaTableAdapter;
            this.tableAdapterManager.PacienteTableAdapter = this.pacienteTableAdapter;
            this.tableAdapterManager.UpdateOrder = Proj0904.BDProva0904DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // consultaBindingNavigator
            // 
            this.consultaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.consultaBindingNavigator.BindingSource = this.consultaBindingSource;
            this.consultaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.consultaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.consultaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.consultaBindingNavigatorSaveItem});
            this.consultaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.consultaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.consultaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.consultaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.consultaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.consultaBindingNavigator.Name = "consultaBindingNavigator";
            this.consultaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.consultaBindingNavigator.Size = new System.Drawing.Size(503, 25);
            this.consultaBindingNavigator.TabIndex = 0;
            this.consultaBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 22);
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
            // consultaBindingNavigatorSaveItem
            // 
            this.consultaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.consultaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("consultaBindingNavigatorSaveItem.Image")));
            this.consultaBindingNavigatorSaveItem.Name = "consultaBindingNavigatorSaveItem";
            this.consultaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.consultaBindingNavigatorSaveItem.Text = "Save Data";
            this.consultaBindingNavigatorSaveItem.Click += new System.EventHandler(this.consultaBindingNavigatorSaveItem_Click);
            // 
            // códLabel
            // 
            códLabel.AutoSize = true;
            códLabel.BackColor = System.Drawing.Color.Transparent;
            códLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            códLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            códLabel.Location = new System.Drawing.Point(12, 66);
            códLabel.Name = "códLabel";
            códLabel.Size = new System.Drawing.Size(63, 22);
            códLabel.TabIndex = 1;
            códLabel.Text = "Código:";
            // 
            // códTextBox
            // 
            this.códTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultaBindingSource, "Cód", true));
            this.códTextBox.Location = new System.Drawing.Point(155, 66);
            this.códTextBox.Name = "códTextBox";
            this.códTextBox.Size = new System.Drawing.Size(200, 20);
            this.códTextBox.TabIndex = 2;
            this.códTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataLabel
            // 
            dataLabel.AutoSize = true;
            dataLabel.BackColor = System.Drawing.Color.Transparent;
            dataLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            dataLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataLabel.Location = new System.Drawing.Point(12, 93);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new System.Drawing.Size(47, 22);
            dataLabel.TabIndex = 3;
            dataLabel.Text = "Data:";
            // 
            // dataDateTimePicker
            // 
            this.dataDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.consultaBindingSource, "Data", true));
            this.dataDateTimePicker.Location = new System.Drawing.Point(155, 92);
            this.dataDateTimePicker.Name = "dataDateTimePicker";
            this.dataDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dataDateTimePicker.TabIndex = 4;
            // 
            // horaLabel
            // 
            horaLabel.AutoSize = true;
            horaLabel.BackColor = System.Drawing.Color.Transparent;
            horaLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            horaLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            horaLabel.Location = new System.Drawing.Point(12, 118);
            horaLabel.Name = "horaLabel";
            horaLabel.Size = new System.Drawing.Size(49, 22);
            horaLabel.TabIndex = 5;
            horaLabel.Text = "Hora:";
            // 
            // horaMaskedTextBox
            // 
            this.horaMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultaBindingSource, "Hora", true));
            this.horaMaskedTextBox.Location = new System.Drawing.Point(155, 118);
            this.horaMaskedTextBox.Mask = "00:00";
            this.horaMaskedTextBox.Name = "horaMaskedTextBox";
            this.horaMaskedTextBox.Size = new System.Drawing.Size(200, 20);
            this.horaMaskedTextBox.TabIndex = 6;
            this.horaMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.horaMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // médicoLabel
            // 
            médicoLabel.AutoSize = true;
            médicoLabel.BackColor = System.Drawing.Color.Transparent;
            médicoLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            médicoLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            médicoLabel.Location = new System.Drawing.Point(12, 144);
            médicoLabel.Name = "médicoLabel";
            médicoLabel.Size = new System.Drawing.Size(64, 22);
            médicoLabel.TabIndex = 7;
            médicoLabel.Text = "Médico:";
            // 
            // médicoTextBox
            // 
            this.médicoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultaBindingSource, "Médico", true));
            this.médicoTextBox.Location = new System.Drawing.Point(155, 144);
            this.médicoTextBox.Name = "médicoTextBox";
            this.médicoTextBox.Size = new System.Drawing.Size(200, 20);
            this.médicoTextBox.TabIndex = 8;
            this.médicoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // paciente_CodLabel
            // 
            paciente_CodLabel.AutoSize = true;
            paciente_CodLabel.BackColor = System.Drawing.Color.Transparent;
            paciente_CodLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            paciente_CodLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            paciente_CodLabel.Location = new System.Drawing.Point(12, 170);
            paciente_CodLabel.Name = "paciente_CodLabel";
            paciente_CodLabel.Size = new System.Drawing.Size(144, 22);
            paciente_CodLabel.TabIndex = 9;
            paciente_CodLabel.Text = "Código do Paciente:";
            // 
            // paciente_CodTextBox
            // 
            this.paciente_CodTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultaBindingSource, "Paciente_Cod", true));
            this.paciente_CodTextBox.Location = new System.Drawing.Point(155, 170);
            this.paciente_CodTextBox.Name = "paciente_CodTextBox";
            this.paciente_CodTextBox.Size = new System.Drawing.Size(200, 20);
            this.paciente_CodTextBox.TabIndex = 10;
            this.paciente_CodTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(402, 236);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(53, 27);
            this.button2.TabIndex = 22;
            this.toolTip1.SetToolTip(this.button2, "Fechar");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.consultaBindingSource, "Paciente_Cod", true));
            this.comboBox1.DataSource = this.pacienteBindingSource1;
            this.comboBox1.DisplayMember = "Nome";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(361, 170);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 23;
            this.comboBox1.ValueMember = "CódPaciente";
            // 
            // pacienteBindingSource
            // 
            this.pacienteBindingSource.DataMember = "Paciente";
            this.pacienteBindingSource.DataSource = this.bDProva0904DataSet;
            // 
            // pacienteTableAdapter
            // 
            this.pacienteTableAdapter.ClearBeforeFill = true;
            // 
            // bDProva0904DataSetBindingSource
            // 
            this.bDProva0904DataSetBindingSource.DataSource = this.bDProva0904DataSet;
            this.bDProva0904DataSetBindingSource.Position = 0;
            // 
            // pacienteBindingSource1
            // 
            this.pacienteBindingSource1.DataMember = "Paciente";
            this.pacienteBindingSource1.DataSource = this.bDProva0904DataSet;
            // 
            // bDProva0904DataSetBindingSource1
            // 
            this.bDProva0904DataSetBindingSource1.DataSource = this.bDProva0904DataSet;
            this.bDProva0904DataSetBindingSource1.Position = 0;
            // 
            // FrmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(503, 275);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(códLabel);
            this.Controls.Add(this.códTextBox);
            this.Controls.Add(dataLabel);
            this.Controls.Add(this.dataDateTimePicker);
            this.Controls.Add(horaLabel);
            this.Controls.Add(this.horaMaskedTextBox);
            this.Controls.Add(médicoLabel);
            this.Controls.Add(this.médicoTextBox);
            this.Controls.Add(paciente_CodLabel);
            this.Controls.Add(this.paciente_CodTextBox);
            this.Controls.Add(this.consultaBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Consulta";
            this.Load += new System.EventHandler(this.FrmConsulta_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmConsulta_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.bDProva0904DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultaBindingNavigator)).EndInit();
            this.consultaBindingNavigator.ResumeLayout(false);
            this.consultaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDProva0904DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDProva0904DataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BDProva0904DataSet bDProva0904DataSet;
        private System.Windows.Forms.BindingSource consultaBindingSource;
        private Proj0904.BDProva0904DataSetTableAdapters.ConsultaTableAdapter consultaTableAdapter;
        private Proj0904.BDProva0904DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator consultaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton consultaBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox códTextBox;
        private System.Windows.Forms.DateTimePicker dataDateTimePicker;
        private System.Windows.Forms.MaskedTextBox horaMaskedTextBox;
        private System.Windows.Forms.TextBox médicoTextBox;
        private System.Windows.Forms.TextBox paciente_CodTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolTip toolTip1;
        private Proj0904.BDProva0904DataSetTableAdapters.PacienteTableAdapter pacienteTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource pacienteBindingSource;
        private System.Windows.Forms.BindingSource pacienteBindingSource1;
        private System.Windows.Forms.BindingSource bDProva0904DataSetBindingSource;
        private System.Windows.Forms.BindingSource bDProva0904DataSetBindingSource1;
    }
}