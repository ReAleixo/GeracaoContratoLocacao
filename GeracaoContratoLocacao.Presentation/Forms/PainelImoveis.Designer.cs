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
            Id = new DataGridViewTextBoxColumn();
            Locado = new DataGridViewTextBoxColumn();
            OwnerId = new DataGridViewTextBoxColumn();
            NomeLocador = new DataGridViewTextBoxColumn();
            Imovel = new DataGridViewTextBoxColumn();
            ImovelStatus = new DataGridViewTextBoxColumn();
            NumeroComodos = new DataGridViewTextBoxColumn();
            ValorAluguel = new DataGridViewTextBoxColumn();
            Rua = new DataGridViewTextBoxColumn();
            Numero = new DataGridViewTextBoxColumn();
            Complemento = new DataGridViewTextBoxColumn();
            Bairro = new DataGridViewTextBoxColumn();
            Cidade = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            CEP = new DataGridViewTextBoxColumn();
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
            dgvHouses.Columns.AddRange(new DataGridViewColumn[] { Id, Locado, OwnerId, NomeLocador, Imovel, ImovelStatus, NumeroComodos, ValorAluguel, Rua, Numero, Complemento, Bairro, Cidade, Estado, CEP });
            dgvHouses.Location = new Point(13, 64);
            dgvHouses.Name = "dgvHouses";
            dgvHouses.ReadOnly = true;
            dgvHouses.RowHeadersVisible = false;
            dgvHouses.Size = new Size(1065, 335);
            dgvHouses.TabIndex = 5;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            // 
            // Locado
            // 
            Locado.DataPropertyName = "ImovelLocado";
            Locado.HeaderText = "Locado";
            Locado.Name = "Locado";
            Locado.ReadOnly = true;
            Locado.Visible = false;
            // 
            // OwnerId
            // 
            OwnerId.DataPropertyName = "IdProprietario";
            OwnerId.HeaderText = "OwnerId";
            OwnerId.Name = "OwnerId";
            OwnerId.ReadOnly = true;
            OwnerId.Visible = false;
            // 
            // NomeLocador
            // 
            NomeLocador.DataPropertyName = "NomeProprietario";
            NomeLocador.HeaderText = "Nome do Locador";
            NomeLocador.Name = "NomeLocador";
            NomeLocador.ReadOnly = true;
            NomeLocador.Width = 230;
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
            // Rua
            // 
            Rua.DataPropertyName = "Rua";
            Rua.HeaderText = "Rua";
            Rua.Name = "Rua";
            Rua.ReadOnly = true;
            Rua.Visible = false;
            // 
            // Numero
            // 
            Numero.DataPropertyName = "Numero";
            Numero.HeaderText = "Número";
            Numero.Name = "Numero";
            Numero.ReadOnly = true;
            Numero.Visible = false;
            // 
            // Complemento
            // 
            Complemento.DataPropertyName = "Complemento";
            Complemento.HeaderText = "Complemento";
            Complemento.Name = "Complemento";
            Complemento.ReadOnly = true;
            Complemento.Visible = false;
            // 
            // Bairro
            // 
            Bairro.DataPropertyName = "Bairro";
            Bairro.HeaderText = "Bairro";
            Bairro.Name = "Bairro";
            Bairro.ReadOnly = true;
            Bairro.Visible = false;
            // 
            // Cidade
            // 
            Cidade.DataPropertyName = "Cidade";
            Cidade.HeaderText = "Cidade";
            Cidade.Name = "Cidade";
            Cidade.ReadOnly = true;
            Cidade.Visible = false;
            // 
            // Estado
            // 
            Estado.DataPropertyName = "Estado";
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            Estado.Visible = false;
            // 
            // CEP
            // 
            CEP.DataPropertyName = "CEP";
            CEP.HeaderText = "CEP";
            CEP.Name = "CEP";
            CEP.ReadOnly = true;
            CEP.Visible = false;
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
            chkFiltroExibirLocados.Checked = true;
            chkFiltroExibirLocados.CheckState = CheckState.Checked;
            chkFiltroExibirLocados.Location = new Point(426, 15);
            chkFiltroExibirLocados.Name = "chkFiltroExibirLocados";
            chkFiltroExibirLocados.RightToLeft = RightToLeft.Yes;
            chkFiltroExibirLocados.Size = new Size(164, 19);
            chkFiltroExibirLocados.TabIndex = 4;
            chkFiltroExibirLocados.Text = "EXIBIR IMÓVEIS LOCADOS";
            chkFiltroExibirLocados.UseVisualStyleBackColor = true;
            chkFiltroExibirLocados.CheckedChanged += FilterHousesGrid;
            // 
            // txtFiltroLocador
            // 
            txtFiltroLocador.Location = new Point(160, 12);
            txtFiltroLocador.Name = "txtFiltroLocador";
            txtFiltroLocador.Size = new Size(260, 23);
            txtFiltroLocador.TabIndex = 3;
            txtFiltroLocador.TextChanged += FilterHousesGrid;
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
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "PainelImoveis";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
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
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Locado;
        private DataGridViewTextBoxColumn OwnerId;
        private DataGridViewTextBoxColumn NomeLocador;
        private DataGridViewTextBoxColumn Imovel;
        private DataGridViewTextBoxColumn ImovelStatus;
        private DataGridViewTextBoxColumn NumeroComodos;
        private DataGridViewTextBoxColumn ValorAluguel;
        private DataGridViewTextBoxColumn Rua;
        private DataGridViewTextBoxColumn Numero;
        private DataGridViewTextBoxColumn Complemento;
        private DataGridViewTextBoxColumn Bairro;
        private DataGridViewTextBoxColumn Cidade;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn CEP;
    }
}