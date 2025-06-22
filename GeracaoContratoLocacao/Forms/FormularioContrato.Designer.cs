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
            button1 = new Button();
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
            lblRGLocatario.Font = new Font("Arial", 8.25F);
            lblRGLocatario.Location = new Point(182, 60);
            lblRGLocatario.Name = "lblRGLocatario";
            lblRGLocatario.Size = new Size(22, 14);
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
            // 
            // lblCPFLocatario
            // 
            lblCPFLocatario.AutoSize = true;
            lblCPFLocatario.Font = new Font("Arial", 8.25F);
            lblCPFLocatario.Location = new Point(12, 60);
            lblCPFLocatario.Name = "lblCPFLocatario";
            lblCPFLocatario.Size = new Size(26, 14);
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
            lblNomeLocatario.Font = new Font("Arial", 8.25F);
            lblNomeLocatario.Location = new Point(12, 18);
            lblNomeLocatario.Name = "lblNomeLocatario";
            lblNomeLocatario.Size = new Size(36, 14);
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
            label3.Font = new Font("Arial", 8.25F);
            label3.Location = new Point(182, 86);
            label3.Name = "label3";
            label3.Size = new Size(20, 14);
            label3.TabIndex = 13;
            label3.Text = "R$";
            // 
            // txtValorAluguel
            // 
            txtValorAluguel.Font = new Font("Arial", 8.25F);
            txtValorAluguel.Location = new Point(207, 82);
            txtValorAluguel.MaxLength = 8;
            txtValorAluguel.Name = "txtValorAluguel";
            txtValorAluguel.Size = new Size(86, 20);
            txtValorAluguel.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 8.25F);
            label4.Location = new Point(182, 65);
            label4.Name = "label4";
            label4.Size = new Size(111, 14);
            label4.TabIndex = 11;
            label4.Text = "VALOR DO ALUGUEL";
            // 
            // cmbNumeroCasa
            // 
            cmbNumeroCasa.Font = new Font("Arial", 8.25F);
            cmbNumeroCasa.FormattingEnabled = true;
            cmbNumeroCasa.Location = new Point(15, 82);
            cmbNumeroCasa.Name = "cmbNumeroCasa";
            cmbNumeroCasa.Size = new Size(164, 22);
            cmbNumeroCasa.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 8.25F);
            label2.Location = new Point(12, 65);
            label2.Name = "label2";
            label2.Size = new Size(37, 14);
            label2.TabIndex = 9;
            label2.Text = "CASA";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 8.25F);
            label1.Location = new Point(249, 39);
            label1.Name = "label1";
            label1.Size = new Size(41, 14);
            label1.TabIndex = 8;
            label1.Text = "MESES";
            // 
            // txtPrazo
            // 
            txtPrazo.Font = new Font("Arial", 8.25F);
            txtPrazo.Location = new Point(185, 35);
            txtPrazo.MaxLength = 2;
            txtPrazo.Name = "txtPrazo";
            txtPrazo.Size = new Size(58, 20);
            txtPrazo.TabIndex = 5;
            // 
            // txtDataInicio
            // 
            txtDataInicio.Font = new Font("Arial", 8.25F);
            txtDataInicio.Location = new Point(15, 35);
            txtDataInicio.MaxLength = 10;
            txtDataInicio.Name = "txtDataInicio";
            txtDataInicio.Size = new Size(164, 20);
            txtDataInicio.TabIndex = 4;
            // 
            // lblPrazo
            // 
            lblPrazo.AutoSize = true;
            lblPrazo.Font = new Font("Arial", 8.25F);
            lblPrazo.Location = new Point(182, 18);
            lblPrazo.Name = "lblPrazo";
            lblPrazo.Size = new Size(108, 14);
            lblPrazo.TabIndex = 6;
            lblPrazo.Text = "PRAZO COMBINADO";
            // 
            // lblDataInicio
            // 
            lblDataInicio.AutoSize = true;
            lblDataInicio.Font = new Font("Arial", 8.25F);
            lblDataInicio.Location = new Point(12, 18);
            lblDataInicio.Name = "lblDataInicio";
            lblDataInicio.Size = new Size(80, 14);
            lblDataInicio.TabIndex = 6;
            lblDataInicio.Text = "DATA DE INÍCIO";
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 8.25F);
            button1.Location = new Point(11, 253);
            button1.Name = "button1";
            button1.Size = new Size(310, 43);
            button1.TabIndex = 8;
            button1.Text = "GERAR CONTRATO";
            button1.UseVisualStyleBackColor = true;
            button1.Click += cmdGerarContrato_Click;
            // 
            // FormularioContrato
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(333, 306);
            ControlBox = false;
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(grbLocatario);
            Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
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
        private Button button1;
    }
}
