namespace SistemaComercial_Manha
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.controleAcessoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.comercialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.financeiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ferramentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCalculadora = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbProduto = new System.Windows.Forms.ToolStripButton();
            this.tsbCliente = new System.Windows.Forms.ToolStripButton();
            this.usuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.telasSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.txtUsuario);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 260);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(454, 44);
            this.panel1.TabIndex = 0;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.Black;
            this.txtUsuario.Location = new System.Drawing.Point(346, 10);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(96, 26);
            this.txtUsuario.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(282, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Usuário:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.controleAcessoToolStripMenuItem,
            this.cadastroToolStripMenuItem,
            this.comercialToolStripMenuItem,
            this.financeiroToolStripMenuItem,
            this.ferramentaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(454, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // controleAcessoToolStripMenuItem
            // 
            this.controleAcessoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuárioToolStripMenuItem,
            this.perfilToolStripMenuItem,
            this.telasSistemaToolStripMenuItem,
            this.toolStripMenuItem1,
            this.sairToolStripMenuItem});
            this.controleAcessoToolStripMenuItem.Name = "controleAcessoToolStripMenuItem";
            this.controleAcessoToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.controleAcessoToolStripMenuItem.Text = "Controle Acesso";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmProduto});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // tsmProduto
            // 
            this.tsmProduto.Name = "tsmProduto";
            this.tsmProduto.Size = new System.Drawing.Size(152, 22);
            this.tsmProduto.Text = "Produto";
            this.tsmProduto.Click += new System.EventHandler(this.tsmProduto_Click);
            // 
            // comercialToolStripMenuItem
            // 
            this.comercialToolStripMenuItem.Name = "comercialToolStripMenuItem";
            this.comercialToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.comercialToolStripMenuItem.Text = "Comercial";
            // 
            // financeiroToolStripMenuItem
            // 
            this.financeiroToolStripMenuItem.Name = "financeiroToolStripMenuItem";
            this.financeiroToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.financeiroToolStripMenuItem.Text = "Financeiro";
            // 
            // ferramentaToolStripMenuItem
            // 
            this.ferramentaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCalculadora});
            this.ferramentaToolStripMenuItem.Name = "ferramentaToolStripMenuItem";
            this.ferramentaToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.ferramentaToolStripMenuItem.Text = "Ferramenta";
            // 
            // tsmCalculadora
            // 
            this.tsmCalculadora.Name = "tsmCalculadora";
            this.tsmCalculadora.Size = new System.Drawing.Size(152, 22);
            this.tsmCalculadora.Text = "Calculadora";
            this.tsmCalculadora.Click += new System.EventHandler(this.tsmCalculadora_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbProduto,
            this.tsbCliente});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(454, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbProduto
            // 
            this.tsbProduto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbProduto.Image = ((System.Drawing.Image)(resources.GetObject("tsbProduto.Image")));
            this.tsbProduto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbProduto.Name = "tsbProduto";
            this.tsbProduto.Size = new System.Drawing.Size(23, 22);
            this.tsbProduto.Text = "toolStripButton1";
            this.tsbProduto.Click += new System.EventHandler(this.tsbProduto_Click);
            // 
            // tsbCliente
            // 
            this.tsbCliente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCliente.Image = ((System.Drawing.Image)(resources.GetObject("tsbCliente.Image")));
            this.tsbCliente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCliente.Name = "tsbCliente";
            this.tsbCliente.Size = new System.Drawing.Size(23, 22);
            this.tsbCliente.Text = "toolStripButton2";
            // 
            // usuárioToolStripMenuItem
            // 
            this.usuárioToolStripMenuItem.Name = "usuárioToolStripMenuItem";
            this.usuárioToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.usuárioToolStripMenuItem.Text = "Usuário";
            // 
            // perfilToolStripMenuItem
            // 
            this.perfilToolStripMenuItem.Name = "perfilToolStripMenuItem";
            this.perfilToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.perfilToolStripMenuItem.Text = "Perfil";
            // 
            // telasSistemaToolStripMenuItem
            // 
            this.telasSistemaToolStripMenuItem.Name = "telasSistemaToolStripMenuItem";
            this.telasSistemaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.telasSistemaToolStripMenuItem.Text = "Telas Sistema";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 304);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrincipal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem controleAcessoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmProduto;
        private System.Windows.Forms.ToolStripMenuItem comercialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem financeiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ferramentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmCalculadora;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbProduto;
        private System.Windows.Forms.ToolStripButton tsbCliente;
        private System.Windows.Forms.ToolStripMenuItem usuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem telasSistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
    }
}