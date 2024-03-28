namespace WindowsFormsApplication1
{
    partial class Frmprin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmprin));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uUilitáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calendárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculadoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsExplorerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.internetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editorDeTextoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.arquivoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.utilitáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alunoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.calendárioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.calculadoraToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsExplorerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.internetToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editorDeTextoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.cadastroToolStripMenuItem,
            this.uUilitáriosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(570, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arquivoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.arquivoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("arquivoToolStripMenuItem.Image")));
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(100, 23);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            this.arquivoToolStripMenuItem.ToolTipText = "File";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sairToolStripMenuItem.Image")));
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(172, 24);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.ToolTipText = "Exit";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alunoToolStripMenuItem});
            this.cadastroToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.cadastroToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.cadastroToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cadastroToolStripMenuItem.Image")));
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(110, 23);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            this.cadastroToolStripMenuItem.ToolTipText = "Register";
            // 
            // alunoToolStripMenuItem
            // 
            this.alunoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("alunoToolStripMenuItem.Image")));
            this.alunoToolStripMenuItem.Name = "alunoToolStripMenuItem";
            this.alunoToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.alunoToolStripMenuItem.Text = "Aluno";
            this.alunoToolStripMenuItem.ToolTipText = "Student";
            this.alunoToolStripMenuItem.Click += new System.EventHandler(this.alunoToolStripMenuItem_Click);
            // 
            // uUilitáriosToolStripMenuItem
            // 
            this.uUilitáriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calendárioToolStripMenuItem,
            this.calculadoraToolStripMenuItem,
            this.windowsExplorerToolStripMenuItem,
            this.internetToolStripMenuItem,
            this.editorDeTextoToolStripMenuItem});
            this.uUilitáriosToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.uUilitáriosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.uUilitáriosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("uUilitáriosToolStripMenuItem.Image")));
            this.uUilitáriosToolStripMenuItem.Name = "uUilitáriosToolStripMenuItem";
            this.uUilitáriosToolStripMenuItem.Size = new System.Drawing.Size(118, 23);
            this.uUilitáriosToolStripMenuItem.Text = "Utilitários";
            this.uUilitáriosToolStripMenuItem.ToolTipText = "Utilities";
            // 
            // calendárioToolStripMenuItem
            // 
            this.calendárioToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("calendárioToolStripMenuItem.Image")));
            this.calendárioToolStripMenuItem.Name = "calendárioToolStripMenuItem";
            this.calendárioToolStripMenuItem.Size = new System.Drawing.Size(225, 24);
            this.calendárioToolStripMenuItem.Text = "Calendário";
            this.calendárioToolStripMenuItem.ToolTipText = "Calendar";
            this.calendárioToolStripMenuItem.Click += new System.EventHandler(this.calendárioToolStripMenuItem_Click);
            // 
            // calculadoraToolStripMenuItem
            // 
            this.calculadoraToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("calculadoraToolStripMenuItem.Image")));
            this.calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
            this.calculadoraToolStripMenuItem.Size = new System.Drawing.Size(225, 24);
            this.calculadoraToolStripMenuItem.Text = "Calculadora";
            this.calculadoraToolStripMenuItem.ToolTipText = "Calculator";
            this.calculadoraToolStripMenuItem.Click += new System.EventHandler(this.calculadoraToolStripMenuItem_Click);
            // 
            // windowsExplorerToolStripMenuItem
            // 
            this.windowsExplorerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("windowsExplorerToolStripMenuItem.Image")));
            this.windowsExplorerToolStripMenuItem.Name = "windowsExplorerToolStripMenuItem";
            this.windowsExplorerToolStripMenuItem.Size = new System.Drawing.Size(225, 24);
            this.windowsExplorerToolStripMenuItem.Text = "Windows Explorer";
            this.windowsExplorerToolStripMenuItem.ToolTipText = "Windows explorer";
            this.windowsExplorerToolStripMenuItem.Click += new System.EventHandler(this.windowsExplorerToolStripMenuItem_Click);
            // 
            // internetToolStripMenuItem
            // 
            this.internetToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("internetToolStripMenuItem.Image")));
            this.internetToolStripMenuItem.Name = "internetToolStripMenuItem";
            this.internetToolStripMenuItem.Size = new System.Drawing.Size(225, 24);
            this.internetToolStripMenuItem.Text = "Internet";
            this.internetToolStripMenuItem.ToolTipText = "Internet";
            this.internetToolStripMenuItem.Click += new System.EventHandler(this.internetToolStripMenuItem_Click);
            // 
            // editorDeTextoToolStripMenuItem
            // 
            this.editorDeTextoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editorDeTextoToolStripMenuItem.Image")));
            this.editorDeTextoToolStripMenuItem.Name = "editorDeTextoToolStripMenuItem";
            this.editorDeTextoToolStripMenuItem.Size = new System.Drawing.Size(225, 24);
            this.editorDeTextoToolStripMenuItem.Text = "Editor de texto ";
            this.editorDeTextoToolStripMenuItem.ToolTipText = "Text editor";
            this.editorDeTextoToolStripMenuItem.Click += new System.EventHandler(this.editorDeTextoToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem1,
            this.cadastroToolStripMenuItem1,
            this.utilitáriosToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(158, 76);
            // 
            // arquivoToolStripMenuItem1
            // 
            this.arquivoToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem1});
            this.arquivoToolStripMenuItem1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.arquivoToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("arquivoToolStripMenuItem1.Image")));
            this.arquivoToolStripMenuItem1.Name = "arquivoToolStripMenuItem1";
            this.arquivoToolStripMenuItem1.Size = new System.Drawing.Size(157, 24);
            this.arquivoToolStripMenuItem1.Text = "Arquivo";
            this.arquivoToolStripMenuItem1.ToolTipText = "File";
            // 
            // sairToolStripMenuItem1
            // 
            this.sairToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("sairToolStripMenuItem1.Image")));
            this.sairToolStripMenuItem1.Name = "sairToolStripMenuItem1";
            this.sairToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.sairToolStripMenuItem1.Size = new System.Drawing.Size(172, 24);
            this.sairToolStripMenuItem1.Text = "Sair";
            this.sairToolStripMenuItem1.ToolTipText = "Exit";
            this.sairToolStripMenuItem1.Click += new System.EventHandler(this.sairToolStripMenuItem1_Click);
            // 
            // cadastroToolStripMenuItem1
            // 
            this.cadastroToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alunoToolStripMenuItem1});
            this.cadastroToolStripMenuItem1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.cadastroToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("cadastroToolStripMenuItem1.Image")));
            this.cadastroToolStripMenuItem1.Name = "cadastroToolStripMenuItem1";
            this.cadastroToolStripMenuItem1.Size = new System.Drawing.Size(157, 24);
            this.cadastroToolStripMenuItem1.Text = "Cadastro";
            this.cadastroToolStripMenuItem1.ToolTipText = "Register";
            // 
            // utilitáriosToolStripMenuItem
            // 
            this.utilitáriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calendárioToolStripMenuItem1,
            this.calculadoraToolStripMenuItem1,
            this.windowsExplorerToolStripMenuItem1,
            this.internetToolStripMenuItem1,
            this.editorDeTextoToolStripMenuItem1});
            this.utilitáriosToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.utilitáriosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("utilitáriosToolStripMenuItem.Image")));
            this.utilitáriosToolStripMenuItem.Name = "utilitáriosToolStripMenuItem";
            this.utilitáriosToolStripMenuItem.Size = new System.Drawing.Size(157, 24);
            this.utilitáriosToolStripMenuItem.Text = "Utilitários";
            this.utilitáriosToolStripMenuItem.ToolTipText = "Utilities";
            // 
            // alunoToolStripMenuItem1
            // 
            this.alunoToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("alunoToolStripMenuItem1.Image")));
            this.alunoToolStripMenuItem1.Name = "alunoToolStripMenuItem1";
            this.alunoToolStripMenuItem1.Size = new System.Drawing.Size(152, 24);
            this.alunoToolStripMenuItem1.Text = "Aluno";
            this.alunoToolStripMenuItem1.ToolTipText = "Student";
            this.alunoToolStripMenuItem1.Click += new System.EventHandler(this.alunoToolStripMenuItem1_Click);
            // 
            // calendárioToolStripMenuItem1
            // 
            this.calendárioToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("calendárioToolStripMenuItem1.Image")));
            this.calendárioToolStripMenuItem1.Name = "calendárioToolStripMenuItem1";
            this.calendárioToolStripMenuItem1.Size = new System.Drawing.Size(225, 24);
            this.calendárioToolStripMenuItem1.Text = "Calendário";
            this.calendárioToolStripMenuItem1.ToolTipText = "Calendar";
            this.calendárioToolStripMenuItem1.Click += new System.EventHandler(this.calendárioToolStripMenuItem1_Click);
            // 
            // calculadoraToolStripMenuItem1
            // 
            this.calculadoraToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("calculadoraToolStripMenuItem1.Image")));
            this.calculadoraToolStripMenuItem1.Name = "calculadoraToolStripMenuItem1";
            this.calculadoraToolStripMenuItem1.Size = new System.Drawing.Size(225, 24);
            this.calculadoraToolStripMenuItem1.Text = "Calculadora";
            this.calculadoraToolStripMenuItem1.ToolTipText = "Calculator";
            this.calculadoraToolStripMenuItem1.Click += new System.EventHandler(this.calculadoraToolStripMenuItem1_Click);
            // 
            // windowsExplorerToolStripMenuItem1
            // 
            this.windowsExplorerToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("windowsExplorerToolStripMenuItem1.Image")));
            this.windowsExplorerToolStripMenuItem1.Name = "windowsExplorerToolStripMenuItem1";
            this.windowsExplorerToolStripMenuItem1.Size = new System.Drawing.Size(225, 24);
            this.windowsExplorerToolStripMenuItem1.Text = "Windows Explorer";
            this.windowsExplorerToolStripMenuItem1.ToolTipText = "Windows explorer";
            this.windowsExplorerToolStripMenuItem1.Click += new System.EventHandler(this.windowsExplorerToolStripMenuItem1_Click);
            // 
            // internetToolStripMenuItem1
            // 
            this.internetToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("internetToolStripMenuItem1.Image")));
            this.internetToolStripMenuItem1.Name = "internetToolStripMenuItem1";
            this.internetToolStripMenuItem1.Size = new System.Drawing.Size(225, 24);
            this.internetToolStripMenuItem1.Text = "Internet";
            this.internetToolStripMenuItem1.ToolTipText = "Internet";
            this.internetToolStripMenuItem1.Click += new System.EventHandler(this.internetToolStripMenuItem1_Click);
            // 
            // editorDeTextoToolStripMenuItem1
            // 
            this.editorDeTextoToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("editorDeTextoToolStripMenuItem1.Image")));
            this.editorDeTextoToolStripMenuItem1.Name = "editorDeTextoToolStripMenuItem1";
            this.editorDeTextoToolStripMenuItem1.Size = new System.Drawing.Size(225, 24);
            this.editorDeTextoToolStripMenuItem1.Text = "Editor de texto";
            this.editorDeTextoToolStripMenuItem1.ToolTipText = "Text editor";
            this.editorDeTextoToolStripMenuItem1.Click += new System.EventHandler(this.editorDeTextoToolStripMenuItem1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 347);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(570, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.AutoSize = false;
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(400, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.AutoSize = false;
            this.toolStripStatusLabel2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(150, 17);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Frmprin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(570, 369);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frmprin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema 2º Bimestre";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uUilitáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calendárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculadoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsExplorerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem internetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editorDeTextoToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem alunoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem utilitáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calendárioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem calculadoraToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem windowsExplorerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem internetToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editorDeTextoToolStripMenuItem1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}