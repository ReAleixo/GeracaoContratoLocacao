namespace GeracaoContratoLocacao.Presentation.Forms
{
    partial class EditPerson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditPerson));
            toolStrip1 = new ToolStrip();
            cmdSave = new ToolStripButton();
            cmdCancel = new ToolStripButton();
            tabPessoas = new TabControl();
            tabLocadorLocatario = new TabPage();
            groupBox2 = new GroupBox();
            cmbGender = new ComboBox();
            label11 = new Label();
            picDocument = new PictureBox();
            rdbLessee = new RadioButton();
            rdbLessor = new RadioButton();
            cmdAttachDocument = new Button();
            cmbMaritalStatus = new ComboBox();
            label5 = new Label();
            txtBirthDate = new TextBox();
            label4 = new Label();
            txtRG = new TextBox();
            label3 = new Label();
            txtDocument = new TextBox();
            label2 = new Label();
            txtName = new TextBox();
            label1 = new Label();
            tabConjuge = new TabPage();
            groupBox1 = new GroupBox();
            cmbSpouseGender = new ComboBox();
            label8 = new Label();
            txtSpouseRG = new TextBox();
            label9 = new Label();
            txtSpouseDocument = new TextBox();
            label12 = new Label();
            picSpouseDocument = new PictureBox();
            cmdAttachSpouseDocument = new Button();
            txtSpouseBirthDate = new TextBox();
            label7 = new Label();
            txtSpouseName = new TextBox();
            label10 = new Label();
            toolStrip1.SuspendLayout();
            tabPessoas.SuspendLayout();
            tabLocadorLocatario.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picDocument).BeginInit();
            tabConjuge.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picSpouseDocument).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { cmdSave, cmdCancel });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(377, 73);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // cmdSave
            // 
            cmdSave.AutoSize = false;
            cmdSave.Image = (Image)resources.GetObject("cmdSave.Image");
            cmdSave.ImageTransparentColor = Color.Magenta;
            cmdSave.Name = "cmdSave";
            cmdSave.Size = new Size(70, 70);
            cmdSave.Text = "&SALVAR";
            cmdSave.TextImageRelation = TextImageRelation.ImageAboveText;
            cmdSave.Click += cmdSalvar_Click;
            // 
            // cmdCancel
            // 
            cmdCancel.AutoSize = false;
            cmdCancel.Image = (Image)resources.GetObject("cmdCancel.Image");
            cmdCancel.ImageTransparentColor = Color.Magenta;
            cmdCancel.Name = "cmdCancel";
            cmdCancel.Size = new Size(70, 70);
            cmdCancel.Text = "&CANCELAR";
            cmdCancel.TextImageRelation = TextImageRelation.ImageAboveText;
            cmdCancel.Click += cmdCancelar_Click;
            // 
            // tabPessoas
            // 
            tabPessoas.Controls.Add(tabLocadorLocatario);
            tabPessoas.Controls.Add(tabConjuge);
            tabPessoas.Location = new Point(0, 76);
            tabPessoas.Name = "tabPessoas";
            tabPessoas.SelectedIndex = 0;
            tabPessoas.Size = new Size(377, 371);
            tabPessoas.TabIndex = 2;
            // 
            // tabLocadorLocatario
            // 
            tabLocadorLocatario.Controls.Add(groupBox2);
            tabLocadorLocatario.Location = new Point(4, 24);
            tabLocadorLocatario.Name = "tabLocadorLocatario";
            tabLocadorLocatario.Padding = new Padding(3);
            tabLocadorLocatario.Size = new Size(369, 343);
            tabLocadorLocatario.TabIndex = 0;
            tabLocadorLocatario.Text = "  LOCADOR LOCATARIO  ";
            tabLocadorLocatario.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cmbGender);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(picDocument);
            groupBox2.Controls.Add(rdbLessee);
            groupBox2.Controls.Add(rdbLessor);
            groupBox2.Controls.Add(cmdAttachDocument);
            groupBox2.Controls.Add(cmbMaritalStatus);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtBirthDate);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtRG);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtDocument);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtName);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(8, 6);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(353, 331);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "INFORMAÇÕES DO CADASTRO";
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Location = new Point(259, 81);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(82, 23);
            cmbGender.TabIndex = 33;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(256, 63);
            label11.Name = "label11";
            label11.Size = new Size(52, 15);
            label11.TabIndex = 32;
            label11.Text = "GÊNERO";
            // 
            // picDocument
            // 
            picDocument.BorderStyle = BorderStyle.FixedSingle;
            picDocument.Location = new Point(13, 183);
            picDocument.Name = "picDocument";
            picDocument.Size = new Size(328, 142);
            picDocument.TabIndex = 31;
            picDocument.TabStop = false;
            // 
            // rdbLessee
            // 
            rdbLessee.AutoSize = true;
            rdbLessee.Location = new Point(253, 17);
            rdbLessee.Name = "rdbLessee";
            rdbLessee.RightToLeft = RightToLeft.Yes;
            rdbLessee.Size = new Size(88, 19);
            rdbLessee.TabIndex = 30;
            rdbLessee.TabStop = true;
            rdbLessee.Text = "LOCATÁRIO";
            rdbLessee.UseVisualStyleBackColor = true;
            // 
            // rdbLessor
            // 
            rdbLessor.AutoSize = true;
            rdbLessor.Location = new Point(167, 17);
            rdbLessor.Name = "rdbLessor";
            rdbLessor.RightToLeft = RightToLeft.Yes;
            rdbLessor.Size = new Size(80, 19);
            rdbLessor.TabIndex = 29;
            rdbLessor.TabStop = true;
            rdbLessor.Text = "LOCADOR";
            rdbLessor.UseVisualStyleBackColor = true;
            // 
            // cmdAttachDocument
            // 
            cmdAttachDocument.Location = new Point(13, 154);
            cmdAttachDocument.Name = "cmdAttachDocument";
            cmdAttachDocument.Size = new Size(328, 23);
            cmdAttachDocument.TabIndex = 28;
            cmdAttachDocument.Text = "ANEXAR DOCUMENTO";
            cmdAttachDocument.UseVisualStyleBackColor = true;
            // 
            // cmbMaritalStatus
            // 
            cmbMaritalStatus.FormattingEnabled = true;
            cmbMaritalStatus.Location = new Point(182, 125);
            cmbMaritalStatus.Name = "cmbMaritalStatus";
            cmbMaritalStatus.Size = new Size(159, 23);
            cmbMaritalStatus.TabIndex = 27;
            cmbMaritalStatus.SelectedIndexChanged += cmbMaritalStatus_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(179, 107);
            label5.Name = "label5";
            label5.Size = new Size(80, 15);
            label5.TabIndex = 26;
            label5.Text = "ESTADO CIVIL";
            // 
            // txtBirthDate
            // 
            txtBirthDate.Location = new Point(13, 125);
            txtBirthDate.MaxLength = 10;
            txtBirthDate.Name = "txtBirthDate";
            txtBirthDate.Size = new Size(163, 23);
            txtBirthDate.TabIndex = 25;
            txtBirthDate.KeyPress += Date_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 107);
            label4.Name = "label4";
            label4.Size = new Size(131, 15);
            label4.TabIndex = 24;
            label4.Text = "DATA DE NASCIMENTO";
            // 
            // txtRG
            // 
            txtRG.Location = new Point(136, 81);
            txtRG.MaxLength = 14;
            txtRG.Name = "txtRG";
            txtRG.Size = new Size(117, 23);
            txtRG.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(133, 63);
            label3.Name = "label3";
            label3.Size = new Size(22, 15);
            label3.TabIndex = 22;
            label3.Text = "RG";
            // 
            // txtDocument
            // 
            txtDocument.Location = new Point(13, 81);
            txtDocument.MaxLength = 14;
            txtDocument.Name = "txtDocument";
            txtDocument.Size = new Size(117, 23);
            txtDocument.TabIndex = 21;
            txtDocument.KeyPress += Document_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 63);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 20;
            label2.Text = "CPF";
            // 
            // txtName
            // 
            txtName.Location = new Point(13, 37);
            txtName.MaxLength = 200;
            txtName.Name = "txtName";
            txtName.Size = new Size(328, 23);
            txtName.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 19);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 1;
            label1.Text = "NOME";
            // 
            // tabConjuge
            // 
            tabConjuge.Controls.Add(groupBox1);
            tabConjuge.Location = new Point(4, 24);
            tabConjuge.Name = "tabConjuge";
            tabConjuge.Padding = new Padding(3);
            tabConjuge.Size = new Size(369, 343);
            tabConjuge.TabIndex = 1;
            tabConjuge.Text = "  CÔNJUGE  ";
            tabConjuge.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbSpouseGender);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtSpouseRG);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtSpouseDocument);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(picSpouseDocument);
            groupBox1.Controls.Add(cmdAttachSpouseDocument);
            groupBox1.Controls.Add(txtSpouseBirthDate);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtSpouseName);
            groupBox1.Controls.Add(label10);
            groupBox1.Location = new Point(8, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(353, 331);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "INFORMAÇÕES DO CADASTRO";
            // 
            // cmbSpouseGender
            // 
            cmbSpouseGender.FormattingEnabled = true;
            cmbSpouseGender.Location = new Point(259, 81);
            cmbSpouseGender.Name = "cmbSpouseGender";
            cmbSpouseGender.Size = new Size(82, 23);
            cmbSpouseGender.TabIndex = 39;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(256, 63);
            label8.Name = "label8";
            label8.Size = new Size(52, 15);
            label8.TabIndex = 38;
            label8.Text = "GÊNERO";
            // 
            // txtSpouseRG
            // 
            txtSpouseRG.Location = new Point(136, 81);
            txtSpouseRG.MaxLength = 14;
            txtSpouseRG.Name = "txtSpouseRG";
            txtSpouseRG.Size = new Size(117, 23);
            txtSpouseRG.TabIndex = 37;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(133, 63);
            label9.Name = "label9";
            label9.Size = new Size(22, 15);
            label9.TabIndex = 36;
            label9.Text = "RG";
            // 
            // txtSpouseDocument
            // 
            txtSpouseDocument.Location = new Point(13, 81);
            txtSpouseDocument.MaxLength = 14;
            txtSpouseDocument.Name = "txtSpouseDocument";
            txtSpouseDocument.Size = new Size(117, 23);
            txtSpouseDocument.TabIndex = 35;
            txtSpouseDocument.KeyPress += Document_KeyPress;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(10, 63);
            label12.Name = "label12";
            label12.Size = new Size(28, 15);
            label12.TabIndex = 34;
            label12.Text = "CPF";
            // 
            // picSpouseDocument
            // 
            picSpouseDocument.BorderStyle = BorderStyle.FixedSingle;
            picSpouseDocument.Location = new Point(13, 154);
            picSpouseDocument.Name = "picSpouseDocument";
            picSpouseDocument.Size = new Size(328, 171);
            picSpouseDocument.TabIndex = 31;
            picSpouseDocument.TabStop = false;
            // 
            // cmdAttachSpouseDocument
            // 
            cmdAttachSpouseDocument.Location = new Point(182, 125);
            cmdAttachSpouseDocument.Name = "cmdAttachSpouseDocument";
            cmdAttachSpouseDocument.Size = new Size(159, 23);
            cmdAttachSpouseDocument.TabIndex = 28;
            cmdAttachSpouseDocument.Text = "ANEXAR DOCUMENTO";
            cmdAttachSpouseDocument.UseVisualStyleBackColor = true;
            // 
            // txtSpouseBirthDate
            // 
            txtSpouseBirthDate.Location = new Point(13, 125);
            txtSpouseBirthDate.MaxLength = 10;
            txtSpouseBirthDate.Name = "txtSpouseBirthDate";
            txtSpouseBirthDate.Size = new Size(163, 23);
            txtSpouseBirthDate.TabIndex = 25;
            txtSpouseBirthDate.KeyPress += Date_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(10, 107);
            label7.Name = "label7";
            label7.Size = new Size(131, 15);
            label7.TabIndex = 24;
            label7.Text = "DATA DE NASCIMENTO";
            // 
            // txtSpouseName
            // 
            txtSpouseName.Location = new Point(13, 37);
            txtSpouseName.MaxLength = 200;
            txtSpouseName.Name = "txtSpouseName";
            txtSpouseName.Size = new Size(328, 23);
            txtSpouseName.TabIndex = 19;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(10, 19);
            label10.Name = "label10";
            label10.Size = new Size(42, 15);
            label10.TabIndex = 1;
            label10.Text = "NOME";
            // 
            // EditPerson
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(377, 450);
            ControlBox = false;
            Controls.Add(tabPessoas);
            Controls.Add(toolStrip1);
            Name = "EditPerson";
            ShowIcon = false;
            Text = "EDIT OR CREATE PERSON";
            Load += EditPerson_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            tabPessoas.ResumeLayout(false);
            tabLocadorLocatario.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picDocument).EndInit();
            tabConjuge.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picSpouseDocument).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton cmdSave;
        private ToolStripButton cmdCancel;
        private TabControl tabPessoas;
        private TabPage tabLocadorLocatario;
        private TabPage tabConjuge;
        private GroupBox groupBox2;
        private Label label1;
        private TextBox txtName;
        private TextBox txtBirthDate;
        private Label label4;
        private TextBox txtRG;
        private Label label3;
        private TextBox txtDocument;
        private Label label2;
        private Label label5;
        private ComboBox cmbMaritalStatus;
        private Button cmdAttachDocument;
        private RadioButton rdbLessor;
        private RadioButton rdbLessee;
        private PictureBox picDocument;
        private GroupBox groupBox1;
        private PictureBox picSpouseDocument;
        private Button cmdAttachSpouseDocument;
        private TextBox txtSpouseBirthDate;
        private Label label7;
        private TextBox txtSpouseName;
        private Label label10;
        private ComboBox cmbGender;
        private Label label11;
        private ComboBox cmbSpouseGender;
        private Label label8;
        private TextBox txtSpouseRG;
        private Label label9;
        private TextBox txtSpouseDocument;
        private Label label12;
    }
}