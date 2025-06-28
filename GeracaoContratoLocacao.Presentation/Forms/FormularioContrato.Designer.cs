namespace GeracaoContratoLocacao
{
    partial class FormularioContrato
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grbLocatario = new GroupBox();
            txtRGLocatario = new TextBox();
            lblRGLocatario = new Label();
            txtCPFLocatario = new TextBox();
            lblCPFLocatario = new Label();
            txtNomeLocatario = new TextBox();
            lblNomeLocatario = new Label();
            groupBox1 = new GroupBox();
            label3 = new Label();
            txtValorAluguel = new TextBox();
            label4 = new Label();
            cmbNumeroCasa = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            txtPrazo = new TextBox();
            txtDataInicio = new TextBox();
            lblPrazo = new Label();
            lblDataInicio = new Label();
            cmdGerarContrato = new Button();
            grbLocatario.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // grbLocatario
            // 
            grbLocatario.Controls.Add(txtRGLocatario);
            grbLocatario.Controls.Add(lblRGLocatario);
            grbLocatario.Controls.Add(txtCPFLocatario);
            grbLocatario.Controls.Add(lblCPFLocatario);
            grbLocatario.Controls.Add(txtNomeLocatario);
            grbLocatario.Controls.Add(lblNomeLocatario);
            grbLocatario.Font = new Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbLocatario.Location = new Point(12, 7);
            grbLocatario.Name = "grbLocatario";
            grbLocatario.Size = new Size(308, 115);
            grbLocatario.TabIndex = 0;
            grbLocatario.TabStop = false;
            grbLocatario.Text = "LOCATÁRIO";
            // 
            // txtRGLocatario
            // 
            txtRGLocatario.Font = new Font("Arial", 9F);
            txtRGLocatario.Location = new Point(185, 77);
            txtRGLocatario.MaxLength = 14;
            txtRGLocatario.Name = "txtRGLocatario";
            txtRGLocatario.Size = new Size(108, 21);
            txtRGLocatario.TabIndex = 3;
            // 
            // lblRGLocatario
            // 
            lblRGLocatario.AutoSize = true;
            lblRGLocatario.Font = new Font("Arial", 9F);
            lblRGLocatario.Location = new Point(182, 60);
            lblRGLocatario.Name = "lblRGLocatario";
            lblRGLocatario.Size = new Size(25, 15);
            lblRGLocatario.TabIndex = 4;
            lblRGLocatario.Text = "RG";
            // 
            // txtCPFLocatario
            // 
            txtCPFLocatario.Font = new Font("Arial", 9F);
            txtCPFLocatario.Location = new Point(15, 77);
            txtCPFLocatario.MaxLength = 14;
            txtCPFLocatario.Name = "txtCPFLocatario";
            txtCPFLocatario.Size = new Size(164, 21);
            txtCPFLocatario.TabIndex = 2;
            txtCPFLocatario.KeyPress += txtCPFLocatario_KeyPress;
            // 
            // lblCPFLocatario
            // 
            lblCPFLocatario.AutoSize = true;
            lblCPFLocatario.Font = new Font("Arial", 9F);
            lblCPFLocatario.Location = new Point(12, 60);
            lblCPFLocatario.Name = "lblCPFLocatario";
            lblCPFLocatario.Size = new Size(31, 15);
            lblCPFLocatario.TabIndex = 2;
            lblCPFLocatario.Text = "CPF";
            // 
            // txtNomeLocatario
            // 
            txtNomeLocatario.Font = new Font("Arial", 9F);
            txtNomeLocatario.Location = new Point(15, 35);
            txtNomeLocatario.MaxLength = 200;
            txtNomeLocatario.Name = "txtNomeLocatario";
            txtNomeLocatario.Size = new Size(278, 21);
            txtNomeLocatario.TabIndex = 1;
            // 
            // lblNomeLocatario
            // 
            lblNomeLocatario.AutoSize = true;
            lblNomeLocatario.Font = new Font("Arial", 9F);
            lblNomeLocatario.Location = new Point(12, 18);
            lblNomeLocatario.Name = "lblNomeLocatario";
            lblNomeLocatario.Size = new Size(42, 15);
            lblNomeLocatario.TabIndex = 0;
            lblNomeLocatario.Text = "NOME";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtValorAluguel);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(cmbNumeroCasa);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtPrazo);
            groupBox1.Controls.Add(txtDataInicio);
            groupBox1.Controls.Add(lblPrazo);
            groupBox1.Controls.Add(lblDataInicio);
            groupBox1.Font = new Font("Arial", 8.25F, FontStyle.Bold);
            groupBox1.Location = new Point(12, 128);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(308, 119);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "LOCAÇÃO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9F);
            label3.Location = new Point(182, 86);
            label3.Name = "label3";
            label3.Size = new Size(23, 15);
            label3.TabIndex = 13;
            label3.Text = "R$";
            // 
            // txtValorAluguel
            // 
            txtValorAluguel.Font = new Font("Arial", 9F);
            txtValorAluguel.Location = new Point(207, 82);
            txtValorAluguel.MaxLength = 7;
            txtValorAluguel.Name = "txtValorAluguel";
            txtValorAluguel.Size = new Size(86, 21);
            txtValorAluguel.TabIndex = 7;
            txtValorAluguel.KeyPress += txtValorAluguel_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9F);
            label4.Location = new Point(182, 65);
            label4.Name = "label4";
            label4.Size = new Size(103, 15);
            label4.TabIndex = 11;
            label4.Text = "VALOR ALUGUEL";
            // 
            // cmbNumeroCasa
            // 
            cmbNumeroCasa.Font = new Font("Arial", 9F);
            cmbNumeroCasa.FormattingEnabled = true;
            cmbNumeroCasa.Items.AddRange(new object[] { "Casa 1", "Casa 2", "Casa 3", "Casa 4", "Casa 5", "Casa 6" });
            cmbNumeroCasa.Location = new Point(15, 82);
            cmbNumeroCasa.Name = "cmbNumeroCasa";
            cmbNumeroCasa.Size = new Size(164, 23);
            cmbNumeroCasa.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9F);
            label2.Location = new Point(12, 65);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 9;
            label2.Text = "CASA";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9F);
            label1.Location = new Point(249, 39);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 8;
            label1.Text = "MESES";
            // 
            // txtPrazo
            // 
            txtPrazo.Font = new Font("Arial", 9F);
            txtPrazo.Location = new Point(185, 35);
            txtPrazo.MaxLength = 2;
            txtPrazo.Name = "txtPrazo";
            txtPrazo.Size = new Size(58, 21);
            txtPrazo.TabIndex = 5;
            txtPrazo.KeyPress += txtPrazo_KeyPress;
            // 
            // txtDataInicio
            // 
            txtDataInicio.Font = new Font("Arial", 9F);
            txtDataInicio.Location = new Point(15, 35);
            txtDataInicio.MaxLength = 10;
            txtDataInicio.Name = "txtDataInicio";
            txtDataInicio.Size = new Size(164, 21);
            txtDataInicio.TabIndex = 4;
            txtDataInicio.KeyPress += txtDataInicio_KeyPress;
            // 
            // lblPrazo
            // 
            lblPrazo.AutoSize = true;
            lblPrazo.Font = new Font("Arial", 9F);
            lblPrazo.Location = new Point(182, 18);
            lblPrazo.Name = "lblPrazo";
            lblPrazo.Size = new Size(105, 15);
            lblPrazo.TabIndex = 6;
            lblPrazo.Text = "PRAZO ALUGUEL";
            // 
            // lblDataInicio
            // 
            lblDataInicio.AutoSize = true;
            lblDataInicio.Font = new Font("Arial", 9F);
            lblDataInicio.Location = new Point(12, 18);
            lblDataInicio.Name = "lblDataInicio";
            lblDataInicio.Size = new Size(93, 15);
            lblDataInicio.TabIndex = 6;
            lblDataInicio.Text = "DATA DE INÍCIO";
            // 
            // cmdGerarContrato
            // 
            cmdGerarContrato.Font = new Font("Arial", 9F);
            cmdGerarContrato.Location = new Point(11, 253);
            cmdGerarContrato.Name = "cmdGerarContrato";
            cmdGerarContrato.Size = new Size(310, 43);
            cmdGerarContrato.TabIndex = 8;
            cmdGerarContrato.Text = "GERAR CONTRATO";
            cmdGerarContrato.UseVisualStyleBackColor = true;
            cmdGerarContrato.Click += cmdGerarContrato_Click;
            // 
            // FormularioContrato
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(333, 306);
            Controls.Add(cmdGerarContrato);
            Controls.Add(groupBox1);
            Controls.Add(grbLocatario);
            Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormularioContrato";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GERAÇÃO DE CONTRATO";
            grbLocatario.ResumeLayout(false);
            grbLocatario.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbLocatario;
        private TextBox txtCPFLocatario;
        private Label lblCPFLocatario;
        private TextBox txtNomeLocatario;
        private Label lblNomeLocatario;
        private TextBox txtRGLocatario;
        private Label lblRGLocatario;
        private GroupBox groupBox1;
        private TextBox txtPrazo;
        private TextBox txtDataInicio;
        private Label lblPrazo;
        private Label lblDataInicio;
        private Label label1;
        private Label label3;
        private TextBox txtValorAluguel;
        private Label label4;
        private ComboBox cmbNumeroCasa;
        private Label label2;
        private Button cmdGerarContrato;
    }
}
