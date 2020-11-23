namespace WindowsFormsApp1
{
    partial class Principal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fornecedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarFornecedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.telefoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.endereçoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listaToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.listProvider = new System.Windows.Forms.ListView();
            this.idProvider = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.companyName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cnpj = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.openDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.registrationSituation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateCreate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.listaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fornecedorToolStripMenuItem,
            this.clienteToolStripMenuItem,
            this.produtosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(799, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fornecedorToolStripMenuItem
            // 
            this.fornecedorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarFornecedorToolStripMenuItem,
            this.listaToolStripMenuItem});
            this.fornecedorToolStripMenuItem.Name = "fornecedorToolStripMenuItem";
            this.fornecedorToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.fornecedorToolStripMenuItem.Text = "Fornecedor";
            // 
            // cadastrarFornecedorToolStripMenuItem
            // 
            this.cadastrarFornecedorToolStripMenuItem.Name = "cadastrarFornecedorToolStripMenuItem";
            this.cadastrarFornecedorToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.cadastrarFornecedorToolStripMenuItem.Text = "Cadastro";
            this.cadastrarFornecedorToolStripMenuItem.Click += new System.EventHandler(this.cadastrarFornecedorToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.listaToolStripMenuItem1});
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.clienteToolStripMenuItem.Text = "Cliente";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem1,
            this.telefoneToolStripMenuItem,
            this.endereçoToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // clienteToolStripMenuItem1
            // 
            this.clienteToolStripMenuItem1.Name = "clienteToolStripMenuItem1";
            this.clienteToolStripMenuItem1.Size = new System.Drawing.Size(123, 22);
            this.clienteToolStripMenuItem1.Text = "Cliente";
            // 
            // telefoneToolStripMenuItem
            // 
            this.telefoneToolStripMenuItem.Name = "telefoneToolStripMenuItem";
            this.telefoneToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.telefoneToolStripMenuItem.Text = "Telefone";
            // 
            // endereçoToolStripMenuItem
            // 
            this.endereçoToolStripMenuItem.Name = "endereçoToolStripMenuItem";
            this.endereçoToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.endereçoToolStripMenuItem.Text = "Endereço";
            // 
            // listaToolStripMenuItem1
            // 
            this.listaToolStripMenuItem1.Name = "listaToolStripMenuItem1";
            this.listaToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.listaToolStripMenuItem1.Text = "Lista";
            this.listaToolStripMenuItem1.Click += new System.EventHandler(this.listaToolStripMenuItem1_Click);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem1,
            this.listaToolStripMenuItem2});
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.produtosToolStripMenuItem.Text = "Produtos";
            // 
            // cadastroToolStripMenuItem1
            // 
            this.cadastroToolStripMenuItem1.Name = "cadastroToolStripMenuItem1";
            this.cadastroToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.cadastroToolStripMenuItem1.Text = "Cadastro";
            this.cadastroToolStripMenuItem1.Click += new System.EventHandler(this.cadastroToolStripMenuItem1_Click);
            // 
            // listaToolStripMenuItem2
            // 
            this.listaToolStripMenuItem2.Name = "listaToolStripMenuItem2";
            this.listaToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.listaToolStripMenuItem2.Text = "Lista";
            this.listaToolStripMenuItem2.Click += new System.EventHandler(this.listaToolStripMenuItem2_Click);
            // 
            // listProvider
            // 
            this.listProvider.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listProvider.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idProvider,
            this.companyName,
            this.cnpj,
            this.openDate,
            this.email,
            this.registrationSituation,
            this.dateCreate});
            this.listProvider.GridLines = true;
            this.listProvider.HideSelection = false;
            this.listProvider.Location = new System.Drawing.Point(1, 70);
            this.listProvider.Name = "listProvider";
            this.listProvider.Size = new System.Drawing.Size(798, 379);
            this.listProvider.TabIndex = 3;
            this.listProvider.UseCompatibleStateImageBehavior = false;
            // 
            // idProvider
            // 
            this.idProvider.Text = "#ID";
            // 
            // companyName
            // 
            this.companyName.Text = "Fornecedor";
            this.companyName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.companyName.Width = 100;
            // 
            // cnpj
            // 
            this.cnpj.Text = "CNPJ";
            this.cnpj.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // openDate
            // 
            this.openDate.Text = "Data de Abertura";
            this.openDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.openDate.Width = 100;
            // 
            // email
            // 
            this.email.Text = "Email";
            this.email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.email.Width = 100;
            // 
            // registrationSituation
            // 
            this.registrationSituation.Text = "Situação";
            this.registrationSituation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.registrationSituation.Width = 100;
            // 
            // dateCreate
            // 
            this.dateCreate.Text = "Data de criação";
            this.dateCreate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dateCreate.Width = 100;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(797, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Lista de Fornecedores";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listaToolStripMenuItem
            // 
            this.listaToolStripMenuItem.Name = "listaToolStripMenuItem";
            this.listaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listaToolStripMenuItem.Text = "Lista";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listProvider);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Revosoft";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fornecedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarFornecedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem telefoneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem endereçoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listaToolStripMenuItem2;
        private System.Windows.Forms.ListView listProvider;
        private System.Windows.Forms.ColumnHeader idProvider;
        private System.Windows.Forms.ColumnHeader companyName;
        private System.Windows.Forms.ColumnHeader cnpj;
        private System.Windows.Forms.ColumnHeader openDate;
        private System.Windows.Forms.ColumnHeader email;
        private System.Windows.Forms.ColumnHeader registrationSituation;
        private System.Windows.Forms.ColumnHeader dateCreate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem listaToolStripMenuItem;
    }
}