namespace GeracaoContratoLocacao.Presentation.Forms
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            toolStrip1 = new ToolStrip();
            cmdClose = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            cmdHousesPanel = new ToolStripButton();
            cmdPeoplePanel = new ToolStripButton();
            cmdFormularioContrato = new ToolStripButton();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { cmdClose, toolStripSeparator1, cmdHousesPanel, cmdPeoplePanel, cmdFormularioContrato });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(582, 73);
            toolStrip1.TabIndex = 8;
            toolStrip1.Text = "toolStrip1";
            // 
            // cmdClose
            // 
            cmdClose.AutoSize = false;
            cmdClose.Image = (Image)resources.GetObject("cmdClose.Image");
            cmdClose.ImageTransparentColor = Color.Magenta;
            cmdClose.Name = "cmdClose";
            cmdClose.Size = new Size(70, 70);
            cmdClose.Text = "&FECHAR";
            cmdClose.Click += cmdClose_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 73);
            // 
            // cmdHousesPanel
            // 
            cmdHousesPanel.Image = (Image)resources.GetObject("cmdHousesPanel.Image");
            cmdHousesPanel.ImageTransparentColor = Color.Magenta;
            cmdHousesPanel.Name = "cmdHousesPanel";
            cmdHousesPanel.Size = new Size(121, 70);
            cmdHousesPanel.Text = "PAINEL DE &CASAS";
            cmdHousesPanel.Click += cmdHousesPanel_Click;
            // 
            // cmdPeoplePanel
            // 
            cmdPeoplePanel.Image = (Image)resources.GetObject("cmdPeoplePanel.Image");
            cmdPeoplePanel.ImageTransparentColor = Color.Magenta;
            cmdPeoplePanel.Name = "cmdPeoplePanel";
            cmdPeoplePanel.Size = new Size(133, 70);
            cmdPeoplePanel.Text = "PAINEL DE &PESSOAS";
            cmdPeoplePanel.Click += cmdPeoplePanel_Click;
            // 
            // cmdFormularioContrato
            // 
            cmdFormularioContrato.Image = (Image)resources.GetObject("cmdFormularioContrato.Image");
            cmdFormularioContrato.ImageTransparentColor = Color.Magenta;
            cmdFormularioContrato.Name = "cmdFormularioContrato";
            cmdFormularioContrato.Size = new Size(221, 70);
            cmdFormularioContrato.Text = "PAINEL DE &GERAÇÃO DE CONTRATO";
            cmdFormularioContrato.Click += cmdGeradorContrato_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 449);
            ControlBox = false;
            Controls.Add(toolStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Menu";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MENU";
            Load += Menu_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton cmdClose;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton cmdHousesPanel;
        private ToolStripButton cmdPeoplePanel;
        private ToolStripButton cmdFormularioContrato;
    }
}