namespace WindowsFormsApp1
{
    partial class AddProduct
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
            this.txtCodProduct = new System.Windows.Forms.TextBox();
            this.lblCodProduct = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.rxtDescription = new System.Windows.Forms.RichTextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblValueProduct = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtValueProduct = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodProduct
            // 
            this.txtCodProduct.Location = new System.Drawing.Point(101, 15);
            this.txtCodProduct.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodProduct.Name = "txtCodProduct";
            this.txtCodProduct.Size = new System.Drawing.Size(649, 22);
            this.txtCodProduct.TabIndex = 3;
            this.txtCodProduct.TextChanged += new System.EventHandler(this.txtCodProduct_TextChanged);
            // 
            // lblCodProduct
            // 
            this.lblCodProduct.AutoSize = true;
            this.lblCodProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodProduct.Location = new System.Drawing.Point(15, 15);
            this.lblCodProduct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodProduct.Name = "lblCodProduct";
            this.lblCodProduct.Size = new System.Drawing.Size(75, 25);
            this.lblCodProduct.TabIndex = 2;
            this.lblCodProduct.Text = "Código";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(127, 60);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(208, 22);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(15, 60);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(97, 25);
            this.lblCategory.TabIndex = 4;
            this.lblCategory.Text = "Categoria";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(476, 60);
            this.txtModel.Margin = new System.Windows.Forms.Padding(4);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(275, 22);
            this.txtModel.TabIndex = 7;
            this.txtModel.TextChanged += new System.EventHandler(this.txtModel_TextChanged);
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModel.Location = new System.Drawing.Point(387, 60);
            this.lblModel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(77, 25);
            this.lblModel.TabIndex = 6;
            this.lblModel.Text = "Modelo";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(16, 222);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(99, 25);
            this.lblDescription.TabIndex = 8;
            this.lblDescription.Text = "Descrição";
            // 
            // rxtDescription
            // 
            this.rxtDescription.Location = new System.Drawing.Point(131, 149);
            this.rxtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.rxtDescription.Name = "rxtDescription";
            this.rxtDescription.Size = new System.Drawing.Size(624, 180);
            this.rxtDescription.TabIndex = 10;
            this.rxtDescription.Text = "";
            this.rxtDescription.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(15, 106);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(114, 25);
            this.lblQuantity.TabIndex = 11;
            this.lblQuantity.Text = "Quantidade";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(145, 106);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(75, 22);
            this.txtQuantity.TabIndex = 12;
            this.txtQuantity.ValueChanged += new System.EventHandler(this.txtQuantity_ValueChanged);
            // 
            // lblValueProduct
            // 
            this.lblValueProduct.AutoSize = true;
            this.lblValueProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValueProduct.Location = new System.Drawing.Point(280, 106);
            this.lblValueProduct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValueProduct.Name = "lblValueProduct";
            this.lblValueProduct.Size = new System.Drawing.Size(63, 25);
            this.lblValueProduct.TabIndex = 13;
            this.lblValueProduct.Text = "Preço";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(532, 362);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 28);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(656, 362);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 28);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtValueProduct
            // 
            this.txtValueProduct.Location = new System.Drawing.Point(350, 106);
            this.txtValueProduct.Name = "txtValueProduct";
            this.txtValueProduct.Size = new System.Drawing.Size(137, 22);
            this.txtValueProduct.TabIndex = 18;
            this.txtValueProduct.TextChanged += new System.EventHandler(this.txtValueProduct_TextChanged);
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 405);
            this.Controls.Add(this.txtValueProduct);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblValueProduct);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.rxtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.txtCodProduct);
            this.Controls.Add(this.lblCodProduct);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "AddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Produto";
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodProduct;
        private System.Windows.Forms.Label lblCodProduct;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.RichTextBox rxtDescription;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.NumericUpDown txtQuantity;
        private System.Windows.Forms.Label lblValueProduct;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtValueProduct;
    }
}