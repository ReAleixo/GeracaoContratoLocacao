namespace GeracaoContratoLocacao.Presentation.Forms
{
    partial class CadastroImovel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroImovel));
            toolStrip1 = new ToolStrip();
            cmdSalvar = new ToolStripButton();
            cmdCancelar = new ToolStripButton();
            groupBox1 = new GroupBox();
            cmdAdicionarLocador = new Button();
            cmbLocadorProprietario = new ComboBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            chkLocado = new CheckBox();
            txtValorAluguel = new TextBox();
            groupBox3 = new GroupBox();
            txtCEP = new TextBox();
            label8 = new Label();
            txtCidade = new TextBox();
            label7 = new Label();
            txtEstado = new TextBox();
            label6 = new Label();
            txtBairro = new TextBox();
            label5 = new Label();
            txtComplemento = new TextBox();
            label4 = new Label();
            label3 = new Label();
            txtNumero = new TextBox();
            txtRua = new TextBox();
            label2 = new Label();
            label9 = new Label();
            label10 = new Label();
            txtNumeroComodos = new TextBox();
            toolStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { cmdSalvar, cmdCancelar });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(446, 73);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // cmdSalvar
            // 
            cmdSalvar.AutoSize = false;
            cmdSalvar.Image = (Image)resources.GetObject("cmdSalvar.Image");
            cmdSalvar.ImageTransparentColor = Color.Magenta;
            cmdSalvar.Name = "cmdSalvar";
            cmdSalvar.Size = new Size(70, 70);
            cmdSalvar.Text = "&SALVAR";
            cmdSalvar.TextImageRelation = TextImageRelation.ImageAboveText;
            cmdSalvar.Click += cmdSalvar_Click;
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
            // groupBox1
            // 
            groupBox1.Controls.Add(cmdAdicionarLocador);
            groupBox1.Controls.Add(cmbLocadorProprietario);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 73);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(421, 76);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "LOCADOR";
            // 
            // cmdAdicionarLocador
            // 
            cmdAdicionarLocador.Location = new Point(303, 36);
            cmdAdicionarLocador.Name = "cmdAdicionarLocador";
            cmdAdicionarLocador.Size = new Size(106, 23);
            cmdAdicionarLocador.TabIndex = 2;
            cmdAdicionarLocador.Text = "ADICIONAR";
            cmdAdicionarLocador.UseVisualStyleBackColor = true;
            cmdAdicionarLocador.Click += cmdAdicionarLocador_Click;
            // 
            // cmbLocadorProprietario
            // 
            cmbLocadorProprietario.FormattingEnabled = true;
            cmbLocadorProprietario.Location = new Point(13, 37);
            cmbLocadorProprietario.Name = "cmbLocadorProprietario";
            cmbLocadorProprietario.Size = new Size(284, 23);
            cmbLocadorProprietario.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 19);
            label1.Name = "label1";
            label1.Size = new Size(144, 15);
            label1.TabIndex = 0;
            label1.Text = "LOCADOR PROPRIETÁRIO";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(chkLocado);
            groupBox2.Controls.Add(txtValorAluguel);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(txtNumeroComodos);
            groupBox2.Location = new Point(12, 155);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(421, 285);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "INFORMAÇÕES DO IMÓVEL";
            // 
            // chkLocado
            // 
            chkLocado.AutoSize = true;
            chkLocado.Location = new Point(313, 39);
            chkLocado.Name = "chkLocado";
            chkLocado.Size = new Size(103, 19);
            chkLocado.TabIndex = 18;
            chkLocado.Text = "ESTÁ LOCADO";
            chkLocado.UseVisualStyleBackColor = true;
            // 
            // txtValorAluguel
            // 
            txtValorAluguel.Location = new Point(168, 37);
            txtValorAluguel.Name = "txtValorAluguel";
            txtValorAluguel.Size = new Size(139, 23);
            txtValorAluguel.TabIndex = 17;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtCEP);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(txtCidade);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(txtEstado);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(txtBairro);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(txtComplemento);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(txtNumero);
            groupBox3.Controls.Add(txtRua);
            groupBox3.Controls.Add(label2);
            groupBox3.Location = new Point(13, 66);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(395, 206);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "ENDEREÇO";
            // 
            // txtCEP
            // 
            txtCEP.Location = new Point(12, 169);
            txtCEP.Name = "txtCEP";
            txtCEP.Size = new Size(139, 23);
            txtCEP.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(10, 151);
            label8.Name = "label8";
            label8.Size = new Size(28, 15);
            label8.TabIndex = 12;
            label8.Text = "CEP";
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(157, 125);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(226, 23);
            txtCidade.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(155, 107);
            label7.Name = "label7";
            label7.Size = new Size(48, 15);
            label7.TabIndex = 10;
            label7.Text = "CIDADE";
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(12, 125);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(139, 23);
            txtEstado.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 107);
            label6.Name = "label6";
            label6.Size = new Size(50, 15);
            label6.TabIndex = 8;
            label6.Text = "ESTADO";
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(157, 81);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(226, 23);
            txtBairro.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(155, 63);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 6;
            label5.Text = "BAIRRO";
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(12, 81);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(139, 23);
            txtComplemento.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 63);
            label4.Name = "label4";
            label4.Size = new Size(95, 15);
            label4.TabIndex = 4;
            label4.Text = "COMPLEMENTO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(316, 19);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 3;
            label3.Text = "NÚMERO";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(318, 37);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(65, 23);
            txtNumero.TabIndex = 2;
            // 
            // txtRua
            // 
            txtRua.Location = new Point(12, 37);
            txtRua.Name = "txtRua";
            txtRua.Size = new Size(300, 23);
            txtRua.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 19);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 0;
            label2.Text = "RUA";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(166, 19);
            label9.Name = "label9";
            label9.Size = new Size(116, 15);
            label9.TabIndex = 16;
            label9.Text = "VALOR DO ALUGUEL";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(10, 19);
            label10.Name = "label10";
            label10.Size = new Size(137, 15);
            label10.TabIndex = 14;
            label10.Text = "NÚMERO DE CÔMODOS";
            // 
            // txtNumeroComodos
            // 
            txtNumeroComodos.Location = new Point(12, 37);
            txtNumeroComodos.Name = "txtNumeroComodos";
            txtNumeroComodos.Size = new Size(150, 23);
            txtNumeroComodos.TabIndex = 15;
            // 
            // CadastroImovel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(446, 450);
            ControlBox = false;
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(toolStrip1);
            Name = "CadastroImovel";
            ShowIcon = false;
            Text = "CADASTRO DE IMÓVEL";
            Load += CadastroImovel_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton cmdSalvar;
        private ToolStripButton cmdCancelar;
        private GroupBox groupBox1;
        private ComboBox cmbLocadorProprietario;
        private Label label1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label2;
        private TextBox txtEstado;
        private Label label6;
        private TextBox txtBairro;
        private Label label5;
        private TextBox txtComplemento;
        private Label label4;
        private Label label3;
        private TextBox txtNumero;
        private TextBox txtRua;
        private TextBox txtCEP;
        private Label label8;
        private TextBox txtCidade;
        private Label label7;
        private TextBox txtValorAluguel;
        private Label label9;
        private Label label10;
        private TextBox txtNumeroComodos;
        private CheckBox chkLocado;
        private Button cmdAdicionarLocador;
    }
}