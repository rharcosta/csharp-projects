namespace WindowsFormsApplication1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.Txtnome = new System.Windows.Forms.TextBox();
            this.Btadicionar = new System.Windows.Forms.Button();
            this.Lstnome = new System.Windows.Forms.ListBox();
            this.Btremove = new System.Windows.Forms.Button();
            this.Btremovetudo = new System.Windows.Forms.Button();
            this.Btcancela = new System.Windows.Forms.Button();
            this.Btsair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item para a lista";
            // 
            // Txtnome
            // 
            this.Txtnome.Location = new System.Drawing.Point(159, 32);
            this.Txtnome.Name = "Txtnome";
            this.Txtnome.Size = new System.Drawing.Size(100, 20);
            this.Txtnome.TabIndex = 1;
            // 
            // Btadicionar
            // 
            this.Btadicionar.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btadicionar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btadicionar.Location = new System.Drawing.Point(225, 87);
            this.Btadicionar.Name = "Btadicionar";
            this.Btadicionar.Size = new System.Drawing.Size(118, 35);
            this.Btadicionar.TabIndex = 2;
            this.Btadicionar.Text = "Adicionar item";
            this.Btadicionar.UseVisualStyleBackColor = true;
            this.Btadicionar.Click += new System.EventHandler(this.Btadicionar_Click);
            // 
            // Lstnome
            // 
            this.Lstnome.FormattingEnabled = true;
            this.Lstnome.Location = new System.Drawing.Point(26, 81);
            this.Lstnome.Name = "Lstnome";
            this.Lstnome.Size = new System.Drawing.Size(130, 212);
            this.Lstnome.Sorted = true;
            this.Lstnome.TabIndex = 3;
            // 
            // Btremove
            // 
            this.Btremove.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.Btremove.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btremove.Location = new System.Drawing.Point(225, 128);
            this.Btremove.Name = "Btremove";
            this.Btremove.Size = new System.Drawing.Size(118, 35);
            this.Btremove.TabIndex = 4;
            this.Btremove.Text = "Remover Item";
            this.Btremove.UseVisualStyleBackColor = true;
            this.Btremove.Click += new System.EventHandler(this.Btremove_Click);
            // 
            // Btremovetudo
            // 
            this.Btremovetudo.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.Btremovetudo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btremovetudo.Location = new System.Drawing.Point(225, 169);
            this.Btremovetudo.Name = "Btremovetudo";
            this.Btremovetudo.Size = new System.Drawing.Size(118, 35);
            this.Btremovetudo.TabIndex = 5;
            this.Btremovetudo.Text = "Remover tudo";
            this.Btremovetudo.UseVisualStyleBackColor = true;
            this.Btremovetudo.Click += new System.EventHandler(this.Btremovetudo_Click);
            // 
            // Btcancela
            // 
            this.Btcancela.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.Btcancela.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btcancela.Location = new System.Drawing.Point(225, 210);
            this.Btcancela.Name = "Btcancela";
            this.Btcancela.Size = new System.Drawing.Size(118, 35);
            this.Btcancela.TabIndex = 6;
            this.Btcancela.Text = "Cancelar";
            this.Btcancela.UseVisualStyleBackColor = true;
            this.Btcancela.Click += new System.EventHandler(this.Btcancela_Click);
            // 
            // Btsair
            // 
            this.Btsair.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.Btsair.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btsair.Location = new System.Drawing.Point(225, 251);
            this.Btsair.Name = "Btsair";
            this.Btsair.Size = new System.Drawing.Size(118, 35);
            this.Btsair.TabIndex = 7;
            this.Btsair.Text = "Sair";
            this.Btsair.UseVisualStyleBackColor = true;
            this.Btsair.Click += new System.EventHandler(this.Btsair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(406, 338);
            this.Controls.Add(this.Btsair);
            this.Controls.Add(this.Btcancela);
            this.Controls.Add(this.Btremovetudo);
            this.Controls.Add(this.Btremove);
            this.Controls.Add(this.Lstnome);
            this.Controls.Add(this.Btadicionar);
            this.Controls.Add(this.Txtnome);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txtnome;
        private System.Windows.Forms.Button Btadicionar;
        private System.Windows.Forms.ListBox Lstnome;
        private System.Windows.Forms.Button Btremove;
        private System.Windows.Forms.Button Btremovetudo;
        private System.Windows.Forms.Button Btcancela;
        private System.Windows.Forms.Button Btsair;
    }
}

