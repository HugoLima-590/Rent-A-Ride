namespace P2
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.labelCPF = new System.Windows.Forms.Label();
            this.labelFone = new System.Windows.Forms.Label();
            this.LabelNome = new System.Windows.Forms.Label();
            this.labelCNH = new System.Windows.Forms.Label();
            this.txtCNH = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.list_Busca = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscarCliente = new System.Windows.Forms.TextBox();
            this.botaoFiltrarCliente = new System.Windows.Forms.Button();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veículoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exibirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carrosAlugadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aluguelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.Location = new System.Drawing.Point(40, 238);
            this.buttonCadastrar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(116, 44);
            this.buttonCadastrar.TabIndex = 15;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            this.buttonCadastrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(90, 133);
            this.txtCPF.Margin = new System.Windows.Forms.Padding(4);
            this.txtCPF.MaxLength = 11;
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(246, 22);
            this.txtCPF.TabIndex = 24;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(90, 91);
            this.txtTelefone.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefone.MaxLength = 11;
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(246, 22);
            this.txtTelefone.TabIndex = 23;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(90, 46);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(246, 22);
            this.txtNome.TabIndex = 22;
            // 
            // labelCPF
            // 
            this.labelCPF.AutoSize = true;
            this.labelCPF.Location = new System.Drawing.Point(18, 133);
            this.labelCPF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCPF.Name = "labelCPF";
            this.labelCPF.Size = new System.Drawing.Size(33, 16);
            this.labelCPF.TabIndex = 21;
            this.labelCPF.Text = "CPF";
            // 
            // labelFone
            // 
            this.labelFone.AutoSize = true;
            this.labelFone.Location = new System.Drawing.Point(18, 91);
            this.labelFone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFone.Name = "labelFone";
            this.labelFone.Size = new System.Drawing.Size(61, 16);
            this.labelFone.TabIndex = 20;
            this.labelFone.Text = "Telefone";
            // 
            // LabelNome
            // 
            this.LabelNome.AutoSize = true;
            this.LabelNome.Location = new System.Drawing.Point(18, 46);
            this.LabelNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelNome.Name = "LabelNome";
            this.LabelNome.Size = new System.Drawing.Size(44, 16);
            this.LabelNome.TabIndex = 19;
            this.LabelNome.Text = "Nome";
            // 
            // labelCNH
            // 
            this.labelCNH.AutoSize = true;
            this.labelCNH.Location = new System.Drawing.Point(18, 178);
            this.labelCNH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCNH.Name = "labelCNH";
            this.labelCNH.Size = new System.Drawing.Size(36, 16);
            this.labelCNH.TabIndex = 29;
            this.labelCNH.Text = "CNH";
            // 
            // txtCNH
            // 
            this.txtCNH.Location = new System.Drawing.Point(90, 178);
            this.txtCNH.Margin = new System.Windows.Forms.Padding(4);
            this.txtCNH.MaxLength = 10;
            this.txtCNH.Name = "txtCNH";
            this.txtCNH.Size = new System.Drawing.Size(246, 22);
            this.txtCNH.TabIndex = 30;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(435, 364);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 44);
            this.button2.TabIndex = 34;
            this.button2.Text = "Lista completa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExcluir);
            this.groupBox1.Controls.Add(this.btnNovo);
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Controls.Add(this.txtCNH);
            this.groupBox1.Controls.Add(this.LabelNome);
            this.groupBox1.Controls.Add(this.labelFone);
            this.groupBox1.Controls.Add(this.labelCPF);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.txtTelefone);
            this.groupBox1.Controls.Add(this.labelCNH);
            this.groupBox1.Controls.Add(this.buttonCadastrar);
            this.groupBox1.Controls.Add(this.txtCPF);
            this.groupBox1.Location = new System.Drawing.Point(12, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(416, 373);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Cliente";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(204, 306);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(116, 44);
            this.btnExcluir.TabIndex = 33;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(40, 306);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(116, 44);
            this.btnNovo.TabIndex = 32;
            this.btnNovo.Text = "Limpar";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(204, 238);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(116, 44);
            this.btnEditar.TabIndex = 31;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // list_Busca
            // 
            this.list_Busca.ContextMenuStrip = this.contextMenuStrip1;
            this.list_Busca.HideSelection = false;
            this.list_Busca.Location = new System.Drawing.Point(437, 116);
            this.list_Busca.MultiSelect = false;
            this.list_Busca.Name = "list_Busca";
            this.list_Busca.Size = new System.Drawing.Size(727, 241);
            this.list_Busca.TabIndex = 37;
            this.list_Busca.UseCompatibleStateImageBehavior = false;
            this.list_Busca.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.list_Busca_ItemSelectionChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(122, 28);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(121, 24);
            this.toolStripMenuItem1.Text = "Excluir";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(434, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 16);
            this.label1.TabIndex = 38;
            this.label1.Text = "Buscar cliente pelo Nome ou CPF";
            // 
            // txtBuscarCliente
            // 
            this.txtBuscarCliente.Location = new System.Drawing.Point(437, 76);
            this.txtBuscarCliente.Name = "txtBuscarCliente";
            this.txtBuscarCliente.Size = new System.Drawing.Size(497, 22);
            this.txtBuscarCliente.TabIndex = 39;
            // 
            // botaoFiltrarCliente
            // 
            this.botaoFiltrarCliente.Location = new System.Drawing.Point(953, 70);
            this.botaoFiltrarCliente.Name = "botaoFiltrarCliente";
            this.botaoFiltrarCliente.Size = new System.Drawing.Size(75, 35);
            this.botaoFiltrarCliente.TabIndex = 40;
            this.botaoFiltrarCliente.Text = "Buscar";
            this.botaoFiltrarCliente.UseVisualStyleBackColor = true;
            this.botaoFiltrarCliente.Click += new System.EventHandler(this.botaoFiltrarCliente_Click);
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
            // 
            // veículoToolStripMenuItem
            // 
            this.veículoToolStripMenuItem.Name = "veículoToolStripMenuItem";
            this.veículoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F2)));
            this.veículoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.veículoToolStripMenuItem.Text = "Veículo";
            this.veículoToolStripMenuItem.Click += new System.EventHandler(this.veículoToolStripMenuItem_Click);
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
            this.menuStrip1.Size = new System.Drawing.Size(1199, 28);
            this.menuStrip1.TabIndex = 41;
            this.menuStrip1.Text = "menuStrip1";
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
            this.carrosAlugadosToolStripMenuItem.Click += new System.EventHandler(this.carrosAlugadosToolStripMenuItem_Click_1);
            // 
            // aluguelToolStripMenuItem
            // 
            this.aluguelToolStripMenuItem.Name = "aluguelToolStripMenuItem";
            this.aluguelToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F4)));
            this.aluguelToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.aluguelToolStripMenuItem.Text = "Aluguel";
            this.aluguelToolStripMenuItem.Click += new System.EventHandler(this.aluguelToolStripMenuItem_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 508);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.botaoFiltrarCliente);
            this.Controls.Add(this.txtBuscarCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.list_Busca);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Cliente";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonCadastrar;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label labelCPF;
        private System.Windows.Forms.Label labelFone;
        private System.Windows.Forms.Label LabelNome;
        private System.Windows.Forms.Label labelCNH;
        private System.Windows.Forms.TextBox txtCNH;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView list_Busca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscarCliente;
        private System.Windows.Forms.Button botaoFiltrarCliente;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem criarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veículoToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.ToolStripMenuItem exibirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carrosAlugadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aluguelToolStripMenuItem;
    }
}

