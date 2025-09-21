namespace GeracaoContratoLocacao.Presentation.Forms
{
    partial class frmGeradorContrato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGeradorContrato));
            toolStrip1 = new ToolStrip();
            cmdGerar = new ToolStripButton();
            cmdCancelar = new ToolStripButton();
            label3 = new Label();
            cmbLocador = new ComboBox();
            cmdAdicionarLocador = new Button();
            groupBox2 = new GroupBox();
            cmdAdicionarLocatario = new Button();
            cmbLocatario = new ComboBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            cmdAdicionarImovel = new Button();
            cmbImoveisLocador = new ComboBox();
            label4 = new Label();
            groupBox3 = new GroupBox();
            txtDataGeracaoContrato = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            txtDataInicio = new TextBox();
            txtPrazo = new TextBox();
            label5 = new Label();
            cmdAdcionarModeloContrato = new Button();
            cmbModeloContrato = new ComboBox();
            label2 = new Label();
            toolStrip1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { cmdGerar, cmdCancelar });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(446, 73);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // cmdGerar
            // 
            cmdGerar.AutoSize = false;
            cmdGerar.Image = (Image)resources.GetObject("cmdGerar.Image");
            cmdGerar.ImageTransparentColor = Color.Magenta;
            cmdGerar.Name = "cmdGerar";
            cmdGerar.Size = new Size(70, 70);
            cmdGerar.Text = "&GERAR";
            cmdGerar.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // cmdCancelar
            // 
            cmdCancelar.AutoSize = false;
            cmdCancelar.Image = (Image)resources.GetObject("cmdCancelar.Image");
            cmdCancelar.ImageTransparentColor = Color.Magenta;
            cmdCancelar.Name = "cmdCancelar";
            cmdCancelar.Size = new Size(70, 70);
            cmdCancelar.Text = "&CANCELAR";
            cmdCancelar.TextImageRelation = TextImageRelation.ImageAboveText;
            cmdCancelar.Click += cmdCancelar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 19);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 0;
            label3.Text = "LOCADOR";
            // 
            // cmbLocador
            // 
            cmbLocador.FormattingEnabled = true;
            cmbLocador.Location = new Point(13, 37);
            cmbLocador.Name = "cmbLocador";
            cmbLocador.Size = new Size(284, 23);
            cmbLocador.TabIndex = 1;
            // 
            // cmdAdicionarLocador
            // 
            cmdAdicionarLocador.Location = new Point(303, 36);
            cmdAdicionarLocador.Name = "cmdAdicionarLocador";
            cmdAdicionarLocador.Size = new Size(106, 23);
            cmdAdicionarLocador.TabIndex = 2;
            cmdAdicionarLocador.Text = "ADICIONAR";
            cmdAdicionarLocador.UseVisualStyleBackColor = true;
            cmdAdicionarLocador.Click += AdicionarPessoa;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cmdAdicionarLocatario);
            groupBox2.Controls.Add(cmbLocatario);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(cmdAdicionarLocador);
            groupBox2.Controls.Add(cmbLocador);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(12, 76);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(421, 122);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "PARTES DO CONTRATO";
            // 
            // cmdAdicionarLocatario
            // 
            cmdAdicionarLocatario.Location = new Point(303, 80);
            cmdAdicionarLocatario.Name = "cmdAdicionarLocatario";
            cmdAdicionarLocatario.Size = new Size(106, 23);
            cmdAdicionarLocatario.TabIndex = 5;
            cmdAdicionarLocatario.Text = "ADICIONAR";
            cmdAdicionarLocatario.UseVisualStyleBackColor = true;
            cmdAdicionarLocatario.Click += AdicionarPessoa;
            // 
            // cmbLocatario
            // 
            cmbLocatario.FormattingEnabled = true;
            cmbLocatario.Location = new Point(13, 81);
            cmbLocatario.Name = "cmbLocatario";
            cmbLocatario.Size = new Size(284, 23);
            cmbLocatario.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 63);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 3;
            label1.Text = "LOCATÁRIO";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmdAdicionarImovel);
            groupBox1.Controls.Add(cmbImoveisLocador);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(12, 204);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(421, 77);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "IMÓVEL";
            // 
            // cmdAdicionarImovel
            // 
            cmdAdicionarImovel.Location = new Point(303, 36);
            cmdAdicionarImovel.Name = "cmdAdicionarImovel";
            cmdAdicionarImovel.Size = new Size(106, 23);
            cmdAdicionarImovel.TabIndex = 2;
            cmdAdicionarImovel.Text = "ADICIONAR";
            cmdAdicionarImovel.UseVisualStyleBackColor = true;
            // 
            // cmbImoveisLocador
            // 
            cmbImoveisLocador.FormattingEnabled = true;
            cmbImoveisLocador.Location = new Point(13, 37);
            cmbImoveisLocador.Name = "cmbImoveisLocador";
            cmbImoveisLocador.Size = new Size(284, 23);
            cmbImoveisLocador.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 19);
            label4.Name = "label4";
            label4.Size = new Size(200, 15);
            label4.TabIndex = 0;
            label4.Text = "IMÓVEIS DISPONÍVEIS DO LOCADOR";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtDataGeracaoContrato);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(txtDataInicio);
            groupBox3.Controls.Add(txtPrazo);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(cmdAdcionarModeloContrato);
            groupBox3.Controls.Add(cmbModeloContrato);
            groupBox3.Controls.Add(label2);
            groupBox3.Location = new Point(12, 287);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(421, 151);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "CONTRATO";
            // 
            // txtDataGeracaoContrato
            // 
            txtDataGeracaoContrato.Location = new Point(278, 89);
            txtDataGeracaoContrato.Name = "txtDataGeracaoContrato";
            txtDataGeracaoContrato.Size = new Size(131, 23);
            txtDataGeracaoContrato.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(86, 92);
            label8.Name = "label8";
            label8.Size = new Size(42, 15);
            label8.TabIndex = 9;
            label8.Text = "MESES";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(276, 71);
            label7.Name = "label7";
            label7.Size = new Size(110, 15);
            label7.TabIndex = 8;
            label7.Text = "DATA DE GERAÇÃO";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(134, 71);
            label6.Name = "label6";
            label6.Size = new Size(91, 15);
            label6.TabIndex = 7;
            label6.Text = "DATA DE INÍCIO";
            // 
            // txtDataInicio
            // 
            txtDataInicio.Location = new Point(136, 89);
            txtDataInicio.Name = "txtDataInicio";
            txtDataInicio.Size = new Size(131, 23);
            txtDataInicio.TabIndex = 5;
            // 
            // txtPrazo
            // 
            txtPrazo.Location = new Point(13, 89);
            txtPrazo.Name = "txtPrazo";
            txtPrazo.Size = new Size(67, 23);
            txtPrazo.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 71);
            label5.Name = "label5";
            label5.Size = new Size(118, 15);
            label5.TabIndex = 3;
            label5.Text = "PRAZO DO ALUGUEL";
            // 
            // cmdAdcionarModeloContrato
            // 
            cmdAdcionarModeloContrato.Location = new Point(303, 36);
            cmdAdcionarModeloContrato.Name = "cmdAdcionarModeloContrato";
            cmdAdcionarModeloContrato.Size = new Size(106, 23);
            cmdAdcionarModeloContrato.TabIndex = 2;
            cmdAdcionarModeloContrato.Text = "ADICIONAR";
            cmdAdcionarModeloContrato.UseVisualStyleBackColor = true;
            // 
            // cmbModeloContrato
            // 
            cmbModeloContrato.FormattingEnabled = true;
            cmbModeloContrato.Location = new Point(13, 37);
            cmbModeloContrato.Name = "cmbModeloContrato";
            cmbModeloContrato.Size = new Size(284, 23);
            cmbModeloContrato.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 19);
            label2.Name = "label2";
            label2.Size = new Size(138, 15);
            label2.TabIndex = 0;
            label2.Text = "MODELO DE CONTRATO";
            // 
            // frmGeradorContrato
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(446, 450);
            ControlBox = false;
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(toolStrip1);
            Name = "frmGeradorContrato";
            ShowIcon = false;
            Text = "Gerador de Contrato";
            Load += frmGeradorContrato_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolStrip toolStrip1;
        private ToolStripButton cmdGerar;
        private ToolStripButton cmdCancelar;
        private Label label3;
        private ComboBox cmbLocador;
        private Button cmdAdicionarLocador;
        private GroupBox groupBox2;
        private Button cmdAdicionarLocatario;
        private ComboBox cmbLocatario;
        private Label label1;
        private GroupBox groupBox1;
        private Button cmdAdicionarImovel;
        private ComboBox cmbImoveisLocador;
        private Label label4;
        private GroupBox groupBox3;
        private Button cmdAdcionarModeloContrato;
        private ComboBox cmbModeloContrato;
        private Label label2;
        private TextBox txtPrazo;
        private Label label5;
        private TextBox txtDataGeracaoContrato;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox txtDataInicio;
    }
}