namespace GeracaoContratoLocacao.Presentation.Forms
{
    partial class PeoplePanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PeoplePanel));
            groupBox4 = new GroupBox();
            panel1 = new Panel();
            cmdFilter = new Button();
            chkShowLesseeFilter = new CheckBox();
            chkShowLessorFilter = new CheckBox();
            txtCPFFilter = new TextBox();
            label1 = new Label();
            txtNameFilter = new TextBox();
            label11 = new Label();
            dtgPeople = new DataGridView();
            toolStrip1 = new ToolStrip();
            cmdVoltar = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            cmdAlterar = new ToolStripButton();
            cmdAdicionar = new ToolStripButton();
            cmdRemover = new ToolStripButton();
            PersonId = new DataGridViewTextBoxColumn();
            PersonName = new DataGridViewTextBoxColumn();
            Document = new DataGridViewTextBoxColumn();
            Category = new DataGridViewTextBoxColumn();
            groupBox4.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgPeople).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox4
            // 
            groupBox4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox4.Controls.Add(panel1);
            groupBox4.Controls.Add(dtgPeople);
            groupBox4.Location = new Point(12, 76);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1090, 413);
            groupBox4.TabIndex = 8;
            groupBox4.TabStop = false;
            groupBox4.Text = "PESSOAS CADASTRADAS";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.GradientInactiveCaption;
            panel1.Controls.Add(cmdFilter);
            panel1.Controls.Add(chkShowLesseeFilter);
            panel1.Controls.Add(chkShowLessorFilter);
            panel1.Controls.Add(txtCPFFilter);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtNameFilter);
            panel1.Controls.Add(label11);
            panel1.Location = new Point(13, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(221, 377);
            panel1.TabIndex = 6;
            // 
            // cmdFilter
            // 
            cmdFilter.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmdFilter.Location = new Point(13, 342);
            cmdFilter.Name = "cmdFilter";
            cmdFilter.Size = new Size(195, 23);
            cmdFilter.TabIndex = 8;
            cmdFilter.Text = "FILTRAR";
            cmdFilter.UseVisualStyleBackColor = true;
            cmdFilter.Click += cmdFilter_Click;
            // 
            // chkShowLesseeFilter
            // 
            chkShowLesseeFilter.AutoSize = true;
            chkShowLesseeFilter.Location = new Point(83, 122);
            chkShowLesseeFilter.Name = "chkShowLesseeFilter";
            chkShowLesseeFilter.RightToLeft = RightToLeft.Yes;
            chkShowLesseeFilter.Size = new Size(125, 19);
            chkShowLesseeFilter.TabIndex = 7;
            chkShowLesseeFilter.Text = "EXIBIR LOCATÁRIO";
            chkShowLesseeFilter.UseVisualStyleBackColor = true;
            // 
            // chkShowLessorFilter
            // 
            chkShowLessorFilter.AutoSize = true;
            chkShowLessorFilter.Location = new Point(91, 147);
            chkShowLessorFilter.Name = "chkShowLessorFilter";
            chkShowLessorFilter.RightToLeft = RightToLeft.Yes;
            chkShowLessorFilter.Size = new Size(117, 19);
            chkShowLessorFilter.TabIndex = 6;
            chkShowLessorFilter.Text = "EXIBIR LOCADOR";
            chkShowLessorFilter.UseVisualStyleBackColor = true;
            // 
            // txtCPFFilter
            // 
            txtCPFFilter.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCPFFilter.Location = new Point(13, 87);
            txtCPFFilter.Name = "txtCPFFilter";
            txtCPFFilter.Size = new Size(195, 23);
            txtCPFFilter.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 69);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 4;
            label1.Text = "CPF";
            // 
            // txtNameFilter
            // 
            txtNameFilter.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNameFilter.Location = new Point(13, 34);
            txtNameFilter.Name = "txtNameFilter";
            txtNameFilter.Size = new Size(195, 23);
            txtNameFilter.TabIndex = 3;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(10, 16);
            label11.Name = "label11";
            label11.Size = new Size(106, 15);
            label11.TabIndex = 2;
            label11.Text = "NOME DA PESSOA";
            // 
            // dtgPeople
            // 
            dtgPeople.AllowUserToAddRows = false;
            dtgPeople.AllowUserToDeleteRows = false;
            dtgPeople.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgPeople.BackgroundColor = SystemColors.ScrollBar;
            dtgPeople.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgPeople.Columns.AddRange(new DataGridViewColumn[] { PersonId, PersonName, Document, Category });
            dtgPeople.Location = new Point(240, 22);
            dtgPeople.Name = "dtgPeople";
            dtgPeople.ReadOnly = true;
            dtgPeople.RowHeadersVisible = false;
            dtgPeople.Size = new Size(838, 377);
            dtgPeople.TabIndex = 5;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { cmdVoltar, toolStripSeparator1, cmdAlterar, cmdAdicionar, cmdRemover });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1114, 73);
            toolStrip1.TabIndex = 7;
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
            // PersonId
            // 
            PersonId.DataPropertyName = "PersonId";
            PersonId.HeaderText = "PersonId";
            PersonId.Name = "PersonId";
            PersonId.ReadOnly = true;
            PersonId.Visible = false;
            // 
            // Name
            // 
            PersonName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PersonName.DataPropertyName = "Name";
            PersonName.HeaderText = "Nome";
            PersonName.Name = "Name";
            PersonName.ReadOnly = true;
            // 
            // Document
            // 
            Document.DataPropertyName = "Document";
            Document.HeaderText = "CPF";
            Document.Name = "Document";
            Document.ReadOnly = true;
            Document.Width = 200;
            // 
            // Category
            // 
            Category.DataPropertyName = "Category";
            Category.HeaderText = "Tipo de Pessoa";
            Category.Name = "Category";
            Category.ReadOnly = true;
            Category.Width = 200;
            // 
            // PeoplePanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1114, 501);
            ControlBox = false;
            Controls.Add(groupBox4);
            Controls.Add(toolStrip1);
            Name = "PeoplePanel";
            ShowIcon = false;
            Text = "PAINEL DE PESSOAS";
            groupBox4.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgPeople).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox4;
        private Panel panel1;
        private TextBox txtNameFilter;
        private Label label11;
        private DataGridView dtgPeople;
        private ToolStrip toolStrip1;
        private ToolStripButton cmdVoltar;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton cmdAlterar;
        private ToolStripButton cmdAdicionar;
        private ToolStripButton cmdRemover;
        private TextBox txtCPFFilter;
        private Label label1;
        private CheckBox chkShowLesseeFilter;
        private CheckBox chkShowLessorFilter;
        private Button cmdFilter;
        private DataGridViewTextBoxColumn PersonId;
        private DataGridViewTextBoxColumn PersonName;
        private DataGridViewTextBoxColumn Document;
        private DataGridViewTextBoxColumn Category;
    }
}