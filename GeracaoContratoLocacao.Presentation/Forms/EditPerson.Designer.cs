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
            cmdSalvar = new ToolStripButton();
            cmdCancelar = new ToolStripButton();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            groupBox2 = new GroupBox();
            toolStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { cmdSalvar, cmdCancelar });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(377, 73);
            toolStrip1.TabIndex = 1;
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
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(0, 76);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(377, 371);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(369, 343);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(369, 343);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(8, 6);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(353, 331);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "INFORMAÇÕES DO IMÓVEL";
            // 
            // EditPerson
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(377, 450);
            ControlBox = false;
            Controls.Add(tabControl1);
            Controls.Add(toolStrip1);
            Name = "EditPerson";
            ShowIcon = false;
            Text = "EDIT OR CREATE PERSON";
            Load += EditPerson_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton cmdSalvar;
        private ToolStripButton cmdCancelar;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private GroupBox groupBox2;
    }
}