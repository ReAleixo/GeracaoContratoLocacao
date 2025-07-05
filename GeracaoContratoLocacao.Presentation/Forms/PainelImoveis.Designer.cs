namespace GeracaoContratoLocacao.Presentation.Forms
{
    partial class PainelImoveis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PainelImoveis));
            toolStrip1 = new ToolStrip();
            cmdVoltar = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            cmdAlterar = new ToolStripButton();
            cmdAdicionar = new ToolStripButton();
            cmdRemover = new ToolStripButton();
            dgvHouses = new DataGridView();
            HouseId = new DataGridViewTextBoxColumn();
            NomeLocador = new DataGridViewTextBoxColumn();
            Imovel = new DataGridViewTextBoxColumn();
            ImovelStatus = new DataGridViewTextBoxColumn();
            NumeroComodos = new DataGridViewTextBoxColumn();
            ValorAluguel = new DataGridViewTextBoxColumn();
            groupBox4 = new GroupBox();
            panel1 = new Panel();
            chkFiltroExibirLocados = new CheckBox();
            txtFiltroLocador = new TextBox();
            label11 = new Label();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHouses).BeginInit();
            groupBox4.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { cmdVoltar, toolStripSeparator1, cmdAlterar, cmdAdicionar, cmdRemover });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1114, 73);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // cmdVoltar
            // 
            cmdVoltar.AutoSize = false;
            cmdVoltar.Image = (Image)resources.GetObject("cmdVoltar.Image");
            cmdVoltar.ImageTransparentColor = Color.Magenta;
            cmdVoltar.Name = "cmdVoltar";
            cmdVoltar.Size = new Size(70, 70);
            cmdVoltar.Text = "&VOLTAR";
            cmdVoltar.TextImageRelation = TextImageRelation.ImageAboveText;
            cmdVoltar.Click += cmdVoltar_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 73);
            // 
            // cmdAlterar
            // 
            cmdAlterar.Image = (Image)resources.GetObject("cmdAlterar.Image");
            cmdAlterar.ImageTransparentColor = Color.Magenta;
            cmdAlterar.Name = "cmdAlterar";
            cmdAlterar.Size = new Size(59, 70);
            cmdAlterar.Text = "AL&TERAR";
            cmdAlterar.TextImageRelation = TextImageRelation.ImageAboveText;
            cmdAlterar.Visible = false;
            cmdAlterar.Click += cmdAlterar_Click;
            // 
            // cmdAdicionar
            // 
            cmdAdicionar.AutoSize = false;
            cmdAdicionar.Image = (Image)resources.GetObject("cmdAdicionar.Image");
            cmdAdicionar.ImageTransparentColor = Color.Magenta;
            cmdAdicionar.Name = "cmdAdicionar";
            cmdAdicionar.Size = new Size(74, 70);
            cmdAdicionar.Text = "&ADICIONAR";
            cmdAdicionar.TextImageRelation = TextImageRelation.ImageAboveText;
            cmdAdicionar.Click += cmdAdicionar_Click;
            // 
            // cmdRemover
            // 
            cmdRemover.Image = (Image)resources.GetObject("cmdRemover.Image");
            cmdRemover.ImageTransparentColor = Color.Magenta;
            cmdRemover.Name = "cmdRemover";
            cmdRemover.Size = new Size(64, 70);
            cmdRemover.Text = "&REMOVER";
            cmdRemover.TextImageRelation = TextImageRelation.ImageAboveText;
            cmdRemover.Visible = false;
            cmdRemover.Click += cmdRemover_Click;
            // 
            // dgvHouses
            // 
            dgvHouses.AllowUserToAddRows = false;
            dgvHouses.AllowUserToDeleteRows = false;
            dgvHouses.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvHouses.BackgroundColor = SystemColors.ScrollBar;
            dgvHouses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHouses.Columns.AddRange(new DataGridViewColumn[] { HouseId, NomeLocador, Imovel, ImovelStatus, NumeroComodos, ValorAluguel });
            dgvHouses.Location = new Point(13, 64);
            dgvHouses.Name = "dgvHouses";
            dgvHouses.ReadOnly = true;
            dgvHouses.RowHeadersVisible = false;
            dgvHouses.Size = new Size(1065, 335);
            dgvHouses.TabIndex = 5;
            // 
            // HouseId
            // 
            HouseId.DataPropertyName = "HouseId";
            HouseId.HeaderText = "HouseId";
            HouseId.Name = "HouseId";
            HouseId.ReadOnly = true;
            HouseId.Visible = false;
            // 
            // NomeLocador
            // 
            NomeLocador.DataPropertyName = "NomeProprietario";
            NomeLocador.HeaderText = "Nome do Locador";
            NomeLocador.Name = "NomeLocador";
            NomeLocador.ReadOnly = true;
            NomeLocador.Width = 280;
            // 
            // Imovel
            // 
            Imovel.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Imovel.DataPropertyName = "EnderecoCompleto";
            Imovel.HeaderText = "Imóvel";
            Imovel.Name = "Imovel";
            Imovel.ReadOnly = true;
            // 
            // ImovelStatus
            // 
            ImovelStatus.DataPropertyName = "ImovelLocadoPorExtenso";
            ImovelStatus.HeaderText = "Status do Imóvel";
            ImovelStatus.Name = "ImovelStatus";
            ImovelStatus.ReadOnly = true;
            ImovelStatus.Width = 120;
            // 
            // NumeroComodos
            // 
            NumeroComodos.DataPropertyName = "NumeroComodos";
            NumeroComodos.HeaderText = "Numero de Cômodos";
            NumeroComodos.Name = "NumeroComodos";
            NumeroComodos.ReadOnly = true;
            NumeroComodos.Width = 150;
            // 
            // ValorAluguel
            // 
            ValorAluguel.DataPropertyName = "ValorAluguel";
            ValorAluguel.HeaderText = "Valor de Aluguel";
            ValorAluguel.Name = "ValorAluguel";
            ValorAluguel.ReadOnly = true;
            ValorAluguel.Width = 120;
            // 
            // groupBox4
            // 
            groupBox4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox4.Controls.Add(panel1);
            groupBox4.Controls.Add(dgvHouses);
            groupBox4.Location = new Point(12, 76);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1090, 413);
            groupBox4.TabIndex = 6;
            groupBox4.TabStop = false;
            groupBox4.Text = "CASAS CADASTRADAS";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.GradientInactiveCaption;
            panel1.Controls.Add(chkFiltroExibirLocados);
            panel1.Controls.Add(txtFiltroLocador);
            panel1.Controls.Add(label11);
            panel1.Location = new Point(13, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(1065, 45);
            panel1.TabIndex = 6;
            // 
            // chkFiltroExibirLocados
            // 
            chkFiltroExibirLocados.AutoSize = true;
            chkFiltroExibirLocados.Location = new Point(426, 15);
            chkFiltroExibirLocados.Name = "chkFiltroExibirLocados";
            chkFiltroExibirLocados.RightToLeft = RightToLeft.Yes;
            chkFiltroExibirLocados.Size = new Size(163, 19);
            chkFiltroExibirLocados.TabIndex = 4;
            chkFiltroExibirLocados.Text = "EXIBIR IMÓVEIS LOCADAS";
            chkFiltroExibirLocados.UseVisualStyleBackColor = true;
            // 
            // txtFiltroLocador
            // 
            txtFiltroLocador.Location = new Point(160, 12);
            txtFiltroLocador.Name = "txtFiltroLocador";
            txtFiltroLocador.Size = new Size(260, 23);
            txtFiltroLocador.TabIndex = 3;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(10, 16);
            label11.Name = "label11";
            label11.Size = new Size(144, 15);
            label11.TabIndex = 2;
            label11.Text = "LOCADOR PROPRIETÁRIO";
            // 
            // PainelImoveis
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1114, 501);
            ControlBox = false;
            Controls.Add(groupBox4);
            Controls.Add(toolStrip1);
            Name = "PainelImoveis";
            ShowIcon = false;
            Text = "PAINEL DE IMÓVEIS";
            Load += PainelImoveis_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHouses).EndInit();
            groupBox4.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton cmdVoltar;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton cmdAlterar;
        private ToolStripButton cmdRemover;
        private ToolStripButton cmdAdicionar;
        private DataGridView dgvHouses;
        private GroupBox groupBox4;
        private Panel panel1;
        private Label label11;
        private TextBox txtFiltroLocador;
        private CheckBox chkFiltroExibirLocados;
        private DataGridViewTextBoxColumn HouseId;
        private DataGridViewTextBoxColumn NomeLocador;
        private DataGridViewTextBoxColumn Imovel;
        private DataGridViewTextBoxColumn ImovelStatus;
        private DataGridViewTextBoxColumn NumeroComodos;
        private DataGridViewTextBoxColumn ValorAluguel;
    }
}