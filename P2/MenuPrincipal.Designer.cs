namespace P2
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veículoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aluguelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.botaoCliente = new System.Windows.Forms.Button();
            this.btnAlugel = new System.Windows.Forms.Button();
            this.exibirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carrosAlugadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCarroAlugado = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(683, 28);
            this.menuStrip1.TabIndex = 0;
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
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // veículoToolStripMenuItem
            // 
            this.veículoToolStripMenuItem.Name = "veículoToolStripMenuItem";
            this.veículoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F2)));
            this.veículoToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.veículoToolStripMenuItem.Text = "Veículo";
            this.veículoToolStripMenuItem.Click += new System.EventHandler(this.veículoToolStripMenuItem_Click);
            // 
            // aluguelToolStripMenuItem
            // 
            this.aluguelToolStripMenuItem.Name = "aluguelToolStripMenuItem";
            this.aluguelToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F4)));
            this.aluguelToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.aluguelToolStripMenuItem.Text = "Aluguel";
            this.aluguelToolStripMenuItem.Click += new System.EventHandler(this.aluguelToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Book", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(487, 63);
            this.label1.TabIndex = 1;
            this.label1.Text = " Cadastro Rent-a-Ride";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(223, 316);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(192, 41);
            this.button2.TabIndex = 3;
            this.button2.Text = "Veículos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // botaoCliente
            // 
            this.botaoCliente.Location = new System.Drawing.Point(223, 244);
            this.botaoCliente.Name = "botaoCliente";
            this.botaoCliente.Size = new System.Drawing.Size(188, 41);
            this.botaoCliente.TabIndex = 4;
            this.botaoCliente.Text = "Clientes";
            this.botaoCliente.UseVisualStyleBackColor = true;
            this.botaoCliente.Click += new System.EventHandler(this.botaoCliente_Click);
            // 
            // btnAlugel
            // 
            this.btnAlugel.Location = new System.Drawing.Point(227, 176);
            this.btnAlugel.Name = "btnAlugel";
            this.btnAlugel.Size = new System.Drawing.Size(188, 41);
            this.btnAlugel.TabIndex = 5;
            this.btnAlugel.Text = "Aluguel";
            this.btnAlugel.UseVisualStyleBackColor = true;
            this.btnAlugel.Click += new System.EventHandler(this.btnAlugel_Click);
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
            // btnCarroAlugado
            // 
            this.btnCarroAlugado.Location = new System.Drawing.Point(223, 381);
            this.btnCarroAlugado.Name = "btnCarroAlugado";
            this.btnCarroAlugado.Size = new System.Drawing.Size(192, 41);
            this.btnCarroAlugado.TabIndex = 6;
            this.btnCarroAlugado.Text = "Carros Alugados";
            this.btnCarroAlugado.UseVisualStyleBackColor = true;
            this.btnCarroAlugado.Click += new System.EventHandler(this.btnCarroAlugado_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(683, 460);
            this.Controls.Add(this.btnCarroAlugado);
            this.Controls.Add(this.btnAlugel);
            this.Controls.Add(this.botaoCliente);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuPrincipal_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem criarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veículoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button botaoCliente;
        private System.Windows.Forms.Button btnAlugel;
        private System.Windows.Forms.ToolStripMenuItem aluguelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exibirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carrosAlugadosToolStripMenuItem;
        private System.Windows.Forms.Button btnCarroAlugado;
    }
}