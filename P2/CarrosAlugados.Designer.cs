namespace P2
{
    partial class CarrosAlugados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarrosAlugados));
            this.listViewCarrosAlugados = new System.Windows.Forms.ListView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veículoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aluguelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carrosAlugadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewCarrosAlugados
            // 
            this.listViewCarrosAlugados.HideSelection = false;
            this.listViewCarrosAlugados.Location = new System.Drawing.Point(24, 60);
            this.listViewCarrosAlugados.Name = "listViewCarrosAlugados";
            this.listViewCarrosAlugados.Size = new System.Drawing.Size(737, 326);
            this.listViewCarrosAlugados.TabIndex = 0;
            this.listViewCarrosAlugados.UseCompatibleStateImageBehavior = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.criarToolStripMenuItem,
            this.exibirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.arquivoToolStripMenuItem.Text = "Opções";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // criarToolStripMenuItem
            // 
            this.criarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.veículoToolStripMenuItem,
            this.aluguelToolStripMenuItem});
            this.criarToolStripMenuItem.Name = "criarToolStripMenuItem";
            this.criarToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.criarToolStripMenuItem.Text = "Criar";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // veículoToolStripMenuItem
            // 
            this.veículoToolStripMenuItem.Name = "veículoToolStripMenuItem";
            this.veículoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F2)));
            this.veículoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.veículoToolStripMenuItem.Text = "Veículo";
            this.veículoToolStripMenuItem.Click += new System.EventHandler(this.veículoToolStripMenuItem_Click);
            // 
            // aluguelToolStripMenuItem
            // 
            this.aluguelToolStripMenuItem.Name = "aluguelToolStripMenuItem";
            this.aluguelToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F4)));
            this.aluguelToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.aluguelToolStripMenuItem.Text = "Aluguel";
            this.aluguelToolStripMenuItem.Click += new System.EventHandler(this.aluguelToolStripMenuItem_Click);
            // 
            // exibirToolStripMenuItem
            // 
            this.exibirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.carrosAlugadosToolStripMenuItem});
            this.exibirToolStripMenuItem.Name = "exibirToolStripMenuItem";
            this.exibirToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.exibirToolStripMenuItem.Text = "Exibir";
            // 
            // carrosAlugadosToolStripMenuItem
            // 
            this.carrosAlugadosToolStripMenuItem.Name = "carrosAlugadosToolStripMenuItem";
            this.carrosAlugadosToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.K)));
            this.carrosAlugadosToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.carrosAlugadosToolStripMenuItem.Text = "Carros Alugados";
            this.carrosAlugadosToolStripMenuItem.Click += new System.EventHandler(this.carrosAlugadosToolStripMenuItem_Click);
            // 
            // CarrosAlugados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.listViewCarrosAlugados);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CarrosAlugados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carros Alugados";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewCarrosAlugados;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem criarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veículoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aluguelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exibirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carrosAlugadosToolStripMenuItem;
    }
}