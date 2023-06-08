namespace P2
{
    partial class Aluguel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Aluguel));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veículoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aluguelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtModeloCarro = new System.Windows.Forms.TextBox();
            this.txtCNH = new System.Windows.Forms.TextBox();
            this.buscarCarroModelo = new System.Windows.Forms.Button();
            this.txtBuscarModelo = new System.Windows.Forms.TextBox();
            this.listView2 = new System.Windows.Forms.ListView();
            this.label7 = new System.Windows.Forms.Label();
            this.txtClienteSelecionado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.txtBuscarCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrecoPorDia = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCalc_por_dia = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAlugarCarro = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.dataDevolução = new System.Windows.Forms.DateTimePicker();
            this.dataRetirada = new System.Windows.Forms.DateTimePicker();
            this.form2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.exibirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carrosAlugadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.form2BindingSource)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(1167, 28);
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
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(67, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1088, 537);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alugar Carro";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtModeloCarro);
            this.groupBox3.Controls.Add(this.txtCNH);
            this.groupBox3.Controls.Add(this.buscarCarroModelo);
            this.groupBox3.Controls.Add(this.txtBuscarModelo);
            this.groupBox3.Controls.Add(this.listView2);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtClienteSelecionado);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.listView1);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.txtBuscarCliente);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtPrecoPorDia);
            this.groupBox3.Location = new System.Drawing.Point(57, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(524, 510);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 442);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "Modelo do Carro";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(265, 442);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "CNH";
            // 
            // txtModeloCarro
            // 
            this.txtModeloCarro.Location = new System.Drawing.Point(14, 461);
            this.txtModeloCarro.Name = "txtModeloCarro";
            this.txtModeloCarro.ReadOnly = true;
            this.txtModeloCarro.Size = new System.Drawing.Size(146, 22);
            this.txtModeloCarro.TabIndex = 17;
            // 
            // txtCNH
            // 
            this.txtCNH.Location = new System.Drawing.Point(262, 461);
            this.txtCNH.Name = "txtCNH";
            this.txtCNH.ReadOnly = true;
            this.txtCNH.Size = new System.Drawing.Size(151, 22);
            this.txtCNH.TabIndex = 16;
            // 
            // buscarCarroModelo
            // 
            this.buscarCarroModelo.Location = new System.Drawing.Point(423, 223);
            this.buscarCarroModelo.Name = "buscarCarroModelo";
            this.buscarCarroModelo.Size = new System.Drawing.Size(75, 34);
            this.buscarCarroModelo.TabIndex = 15;
            this.buscarCarroModelo.Text = "Buscar";
            this.buscarCarroModelo.UseVisualStyleBackColor = true;
            this.buscarCarroModelo.Click += new System.EventHandler(this.buscarCarroModelo_Click);
            // 
            // txtBuscarModelo
            // 
            this.txtBuscarModelo.Location = new System.Drawing.Point(12, 229);
            this.txtBuscarModelo.Name = "txtBuscarModelo";
            this.txtBuscarModelo.Size = new System.Drawing.Size(403, 22);
            this.txtBuscarModelo.TabIndex = 14;
            // 
            // listView2
            // 
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(12, 263);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(486, 113);
            this.listView2.TabIndex = 13;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView2_ItemSelectionChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(261, 396);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Cliente";
            // 
            // txtClienteSelecionado
            // 
            this.txtClienteSelecionado.Location = new System.Drawing.Point(262, 415);
            this.txtClienteSelecionado.Name = "txtClienteSelecionado";
            this.txtClienteSelecionado.ReadOnly = true;
            this.txtClienteSelecionado.Size = new System.Drawing.Size(153, 22);
            this.txtClienteSelecionado.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Buscar Cliente";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(11, 63);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(487, 115);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(423, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 8;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBuscarCliente
            // 
            this.txtBuscarCliente.Location = new System.Drawing.Point(11, 31);
            this.txtBuscarCliente.Name = "txtBuscarCliente";
            this.txtBuscarCliente.Size = new System.Drawing.Size(406, 22);
            this.txtBuscarCliente.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 396);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Preço por Dia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Escolha por Modelo";
            // 
            // txtPrecoPorDia
            // 
            this.txtPrecoPorDia.Location = new System.Drawing.Point(11, 415);
            this.txtPrecoPorDia.Name = "txtPrecoPorDia";
            this.txtPrecoPorDia.ReadOnly = true;
            this.txtPrecoPorDia.Size = new System.Drawing.Size(149, 22);
            this.txtPrecoPorDia.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox2.Controls.Add(this.btnCalc_por_dia);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnAlugarCarro);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtTotal);
            this.groupBox2.Controls.Add(this.dataDevolução);
            this.groupBox2.Controls.Add(this.dataRetirada);
            this.groupBox2.Location = new System.Drawing.Point(587, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(487, 498);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Total";
            // 
            // btnCalc_por_dia
            // 
            this.btnCalc_por_dia.Location = new System.Drawing.Point(21, 260);
            this.btnCalc_por_dia.Name = "btnCalc_por_dia";
            this.btnCalc_por_dia.Size = new System.Drawing.Size(87, 34);
            this.btnCalc_por_dia.TabIndex = 8;
            this.btnCalc_por_dia.Text = "Calcular";
            this.btnCalc_por_dia.UseVisualStyleBackColor = true;
            this.btnCalc_por_dia.Click += new System.EventHandler(this.btnCalc_por_dia_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Devolução";
            // 
            // btnAlugarCarro
            // 
            this.btnAlugarCarro.Location = new System.Drawing.Point(17, 430);
            this.btnAlugarCarro.Name = "btnAlugarCarro";
            this.btnAlugarCarro.Size = new System.Drawing.Size(157, 37);
            this.btnAlugarCarro.TabIndex = 5;
            this.btnAlugarCarro.Text = "Alugar";
            this.btnAlugarCarro.UseVisualStyleBackColor = true;
            this.btnAlugarCarro.Click += new System.EventHandler(this.btnAlugarCarro_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Retirada";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(21, 212);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(153, 22);
            this.txtTotal.TabIndex = 4;
            // 
            // dataDevolução
            // 
            this.dataDevolução.Location = new System.Drawing.Point(21, 127);
            this.dataDevolução.Name = "dataDevolução";
            this.dataDevolução.Size = new System.Drawing.Size(286, 22);
            this.dataDevolução.TabIndex = 1;
            // 
            // dataRetirada
            // 
            this.dataRetirada.Location = new System.Drawing.Point(21, 60);
            this.dataRetirada.Name = "dataRetirada";
            this.dataRetirada.Size = new System.Drawing.Size(286, 22);
            this.dataRetirada.TabIndex = 0;
            // 
            // form2BindingSource
            // 
            this.form2BindingSource.DataSource = typeof(P2.Form2);
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
            // Aluguel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 591);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Aluguel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aluguel";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.form2BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem criarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veículoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aluguelToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAlugarCarro;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtBuscarCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource form2BindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrecoPorDia;
        private System.Windows.Forms.DateTimePicker dataDevolução;
        private System.Windows.Forms.DateTimePicker dataRetirada;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtClienteSelecionado;
        private System.Windows.Forms.Button btnCalc_por_dia;
        private System.Windows.Forms.Button buscarCarroModelo;
        private System.Windows.Forms.TextBox txtBuscarModelo;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtModeloCarro;
        private System.Windows.Forms.TextBox txtCNH;
        private System.Windows.Forms.ToolStripMenuItem exibirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carrosAlugadosToolStripMenuItem;
    }
}