namespace P2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.labelCarroDesejado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.txtNDP = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPPD = new System.Windows.Forms.TextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabCarros = new System.Windows.Forms.TabControl();
            this.tabCadastro = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBuscarCarro = new System.Windows.Forms.Button();
            this.txtBuscarCarro = new System.Windows.Forms.TextBox();
            this.listCarrosCadastrados = new System.Windows.Forms.ListView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veículoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aluguelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carrosAlugadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.tabCarros.SuspendLayout();
            this.tabCadastro.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.Location = new System.Drawing.Point(10, 248);
            this.buttonCadastrar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(105, 39);
            this.buttonCadastrar.TabIndex = 21;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // labelCarroDesejado
            // 
            this.labelCarroDesejado.AutoSize = true;
            this.labelCarroDesejado.Location = new System.Drawing.Point(7, 94);
            this.labelCarroDesejado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCarroDesejado.Name = "labelCarroDesejado";
            this.labelCarroDesejado.Size = new System.Drawing.Size(53, 16);
            this.labelCarroDesejado.TabIndex = 20;
            this.labelCarroDesejado.Text = "Modelo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 130);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 27;
            this.label2.Text = "Ano";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 161);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "Numero de Portas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 198);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 29;
            this.label4.Text = "Preço por dia";
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(138, 124);
            this.txtAno.Margin = new System.Windows.Forms.Padding(4);
            this.txtAno.MaxLength = 4;
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(132, 22);
            this.txtAno.TabIndex = 31;
            // 
            // txtNDP
            // 
            this.txtNDP.Location = new System.Drawing.Point(138, 158);
            this.txtNDP.Margin = new System.Windows.Forms.Padding(4);
            this.txtNDP.MaxLength = 1;
            this.txtNDP.Name = "txtNDP";
            this.txtNDP.Size = new System.Drawing.Size(132, 22);
            this.txtNDP.TabIndex = 32;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(138, 91);
            this.txtModelo.Margin = new System.Windows.Forms.Padding(4);
            this.txtModelo.MaxLength = 100;
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(132, 22);
            this.txtModelo.TabIndex = 34;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(138, 56);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(4);
            this.txtMarca.MaxLength = 100;
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(132, 22);
            this.txtMarca.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 36;
            this.label1.Text = "Marca";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPPD);
            this.groupBox1.Controls.Add(this.btnExcluir);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.labelCarroDesejado);
            this.groupBox1.Controls.Add(this.buttonCadastrar);
            this.groupBox1.Controls.Add(this.txtMarca);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtModelo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNDP);
            this.groupBox1.Controls.Add(this.txtAno);
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 394);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro de Carro";
            // 
            // txtPPD
            // 
            this.txtPPD.Location = new System.Drawing.Point(138, 192);
            this.txtPPD.Name = "txtPPD";
            this.txtPPD.Size = new System.Drawing.Size(132, 22);
            this.txtPPD.TabIndex = 40;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(138, 317);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(105, 39);
            this.btnExcluir.TabIndex = 39;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(138, 248);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 39);
            this.button2.TabIndex = 38;
            this.button2.Text = "Editar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 39);
            this.button1.TabIndex = 37;
            this.button1.Text = "Limpar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabCarros
            // 
            this.tabCarros.Controls.Add(this.tabCadastro);
            this.tabCarros.Location = new System.Drawing.Point(369, 26);
            this.tabCarros.Name = "tabCarros";
            this.tabCarros.SelectedIndex = 0;
            this.tabCarros.Size = new System.Drawing.Size(1002, 406);
            this.tabCarros.TabIndex = 38;
            // 
            // tabCadastro
            // 
            this.tabCadastro.Controls.Add(this.label6);
            this.tabCadastro.Controls.Add(this.btnBuscarCarro);
            this.tabCadastro.Controls.Add(this.txtBuscarCarro);
            this.tabCadastro.Controls.Add(this.listCarrosCadastrados);
            this.tabCadastro.Location = new System.Drawing.Point(4, 25);
            this.tabCadastro.Name = "tabCadastro";
            this.tabCadastro.Padding = new System.Windows.Forms.Padding(3);
            this.tabCadastro.Size = new System.Drawing.Size(994, 377);
            this.tabCadastro.TabIndex = 0;
            this.tabCadastro.Text = "Carros Cadastrados";
            this.tabCadastro.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 16);
            this.label6.TabIndex = 43;
            // 
            // btnBuscarCarro
            // 
            this.btnBuscarCarro.Location = new System.Drawing.Point(519, 41);
            this.btnBuscarCarro.Name = "btnBuscarCarro";
            this.btnBuscarCarro.Size = new System.Drawing.Size(75, 36);
            this.btnBuscarCarro.TabIndex = 41;
            this.btnBuscarCarro.Text = "Buscar";
            this.btnBuscarCarro.UseVisualStyleBackColor = true;
            this.btnBuscarCarro.Click += new System.EventHandler(this.btnBuscarCarro_Click);
            // 
            // txtBuscarCarro
            // 
            this.txtBuscarCarro.Location = new System.Drawing.Point(3, 48);
            this.txtBuscarCarro.Name = "txtBuscarCarro";
            this.txtBuscarCarro.Size = new System.Drawing.Size(495, 22);
            this.txtBuscarCarro.TabIndex = 40;
            // 
            // listCarrosCadastrados
            // 
            this.listCarrosCadastrados.HideSelection = false;
            this.listCarrosCadastrados.Location = new System.Drawing.Point(0, 83);
            this.listCarrosCadastrados.MultiSelect = false;
            this.listCarrosCadastrados.Name = "listCarrosCadastrados";
            this.listCarrosCadastrados.Size = new System.Drawing.Size(994, 284);
            this.listCarrosCadastrados.TabIndex = 39;
            this.listCarrosCadastrados.UseCompatibleStateImageBehavior = false;
            this.listCarrosCadastrados.SelectedIndexChanged += new System.EventHandler(this.listCarrosCadastrados_SelectedIndexChanged);
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
            this.menuStrip1.Size = new System.Drawing.Size(1383, 28);
            this.menuStrip1.TabIndex = 39;
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
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click_1);
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
            this.veículoToolStripMenuItem.Click += new System.EventHandler(this.veículoToolStripMenuItem_Click_1);
            // 
            // aluguelToolStripMenuItem
            // 
            this.aluguelToolStripMenuItem.Name = "aluguelToolStripMenuItem";
            this.aluguelToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F4)));
            this.aluguelToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.aluguelToolStripMenuItem.Text = "Aluguel";
            this.aluguelToolStripMenuItem.Click += new System.EventHandler(this.aluguelToolStripMenuItem_Click_1);
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
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1383, 449);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tabCarros);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Carro";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabCarros.ResumeLayout(false);
            this.tabCadastro.ResumeLayout(false);
            this.tabCadastro.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonCadastrar;
        private System.Windows.Forms.Label labelCarroDesejado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.TextBox txtNDP;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabCarros;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPPD;
        private System.Windows.Forms.TabPage tabCadastro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBuscarCarro;
        private System.Windows.Forms.TextBox txtBuscarCarro;
        private System.Windows.Forms.ListView listCarrosCadastrados;
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