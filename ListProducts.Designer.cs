namespace WindowsFormsApp1
{
    partial class ListProducts
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
            this.listProduct = new System.Windows.Forms.ListView();
            this.idProduct = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.codProduto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.model = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.valueProduct = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.label1.TabIndex = 10;
            this.label1.Text = "Lista de Produtos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listProduct
            // 
            this.listProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listProduct.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idProduct,
            this.codProduto,
            this.category,
            this.model,
            this.description,
            this.quantity,
            this.valueProduct});
            this.listProduct.GridLines = true;
            this.listProduct.HideSelection = false;
            this.listProduct.Location = new System.Drawing.Point(2, 71);
            this.listProduct.Name = "listProduct";
            this.listProduct.Size = new System.Drawing.Size(798, 379);
            this.listProduct.TabIndex = 9;
            this.listProduct.UseCompatibleStateImageBehavior = false;
            // 
            // idProduct
            // 
            this.idProduct.Text = "#ID";
            // 
            // codProduto
            // 
            this.codProduto.Text = "Código";
            this.codProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.codProduto.Width = 100;
            // 
            // category
            // 
            this.category.Text = "Categoria";
            this.category.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // model
            // 
            this.model.Text = "Modelo";
            this.model.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.model.Width = 100;
            // 
            // description
            // 
            this.description.Text = "Descrição";
            this.description.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.description.Width = 100;
            // 
            // quantity
            // 
            this.quantity.Text = "Quantidade";
            this.quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.quantity.Width = 100;
            // 
            // valueProduct
            // 
            this.valueProduct.Text = "Preço";
            this.valueProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.valueProduct.Width = 100;
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
            this.menuStrip1.TabIndex = 8;
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
            this.listaToolStripMenuItem.Click += new System.EventHandler(this.listaToolStripMenuItem_Click);
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
            this.cadastroToolStripMenuItem1.Size = new System.Drawing.Size(121, 22);
            this.cadastroToolStripMenuItem1.Text = "Cadastro";
            this.cadastroToolStripMenuItem1.Click += new System.EventHandler(this.cadastroToolStripMenuItem1_Click);
            // 
            // listaToolStripMenuItem2
            // 
            this.listaToolStripMenuItem2.Name = "listaToolStripMenuItem2";
            this.listaToolStripMenuItem2.Size = new System.Drawing.Size(121, 22);
            this.listaToolStripMenuItem2.Text = "Lista";
            // 
            // ListProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listProduct);
            this.Controls.Add(this.menuStrip1);
            this.MaximizeBox = false;
            this.Name = "ListProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Revosoft";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ListProducts_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listProduct;
        private System.Windows.Forms.ColumnHeader idProduct;
        private System.Windows.Forms.ColumnHeader codProduto;
        private System.Windows.Forms.ColumnHeader category;
        private System.Windows.Forms.ColumnHeader model;
        private System.Windows.Forms.ColumnHeader description;
        private System.Windows.Forms.ColumnHeader quantity;
        private System.Windows.Forms.ColumnHeader valueProduct;
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