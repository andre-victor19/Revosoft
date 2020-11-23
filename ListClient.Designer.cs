namespace WindowsFormsApp1
{
    partial class ListClient
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
            this.label1 = new System.Windows.Forms.Label();
            this.listClients = new System.Windows.Forms.ListView();
            this.idClient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.surname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cpf = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fornecedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarFornecedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.telefoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.endereçoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listaToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(797, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "Lista de Clientes";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listClients
            // 
            this.listClients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listClients.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idClient,
            this.name,
            this.surname,
            this.cpf,
            this.email});
            this.listClients.GridLines = true;
            this.listClients.HideSelection = false;
            this.listClients.Location = new System.Drawing.Point(2, 71);
            this.listClients.Name = "listClients";
            this.listClients.Size = new System.Drawing.Size(798, 379);
            this.listClients.TabIndex = 6;
            this.listClients.UseCompatibleStateImageBehavior = false;
            // 
            // idClient
            // 
            this.idClient.Text = "#ID";
            // 
            // name
            // 
            this.name.Text = "Fornecedor";
            this.name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.name.Width = 100;
            // 
            // surname
            // 
            this.surname.Text = "CNPJ";
            this.surname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cpf
            // 
            this.cpf.Text = "Data de Abertura";
            this.cpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cpf.Width = 100;
            // 
            // email
            // 
            this.email.Text = "Email";
            this.email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.email.Width = 100;
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
            this.menuStrip1.Location = new System.Drawing.Point(1, 1);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(799, 24);
            this.menuStrip1.TabIndex = 5;
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
            // listaToolStripMenuItem
            // 
            this.listaToolStripMenuItem.Name = "listaToolStripMenuItem";
            this.listaToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.listaToolStripMenuItem.Text = "Lista";
            this.listaToolStripMenuItem.Click += new System.EventHandler(this.listaToolStripMenuItem_Click_1);
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
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
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
            this.listaToolStripMenuItem1.Size = new System.Drawing.Size(121, 22);
            this.listaToolStripMenuItem1.Text = "Lista";
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
            this.cadastroToolStripMenuItem1.Size = new System.Drawing.Size(121, 22);
            this.cadastroToolStripMenuItem1.Text = "Cadastro";
            this.cadastroToolStripMenuItem1.Click += new System.EventHandler(this.cadastroToolStripMenuItem1_Click);
            // 
            // listaToolStripMenuItem2
            // 
            this.listaToolStripMenuItem2.Name = "listaToolStripMenuItem2";
            this.listaToolStripMenuItem2.Size = new System.Drawing.Size(121, 22);
            this.listaToolStripMenuItem2.Text = "Lista";
            this.listaToolStripMenuItem2.Click += new System.EventHandler(this.listaToolStripMenuItem2_Click);
            // 
            // ListClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listClients);
            this.Controls.Add(this.menuStrip1);
            this.MaximizeBox = false;
            this.Name = "ListClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Revosoft";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ListClient_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listClients;
        private System.Windows.Forms.ColumnHeader idClient;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader surname;
        private System.Windows.Forms.ColumnHeader cpf;
        private System.Windows.Forms.ColumnHeader email;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fornecedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarFornecedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem telefoneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem endereçoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listaToolStripMenuItem2;
    }
}