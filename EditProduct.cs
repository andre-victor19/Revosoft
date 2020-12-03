using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class EditProduct : Form
    {
        Product product { get; set; }
        ClassProduct classProduct { get; set; }
        public EditProduct()
        {
            InitializeComponent();
        }

        public EditProduct(string idProduct, string codProduct, string category, string model, string description, string quantity, string value)
        {
            InitializeComponent();
            product = new Product();
            product.idProduct = Convert.ToInt32(idProduct);
            product.codProduct = codProduct;
            product.category = category;
            product.model = model;
            product.description = description;
            product.quantity = Convert.ToInt32(quantity);
            product.valueProduct = Convert.ToDecimal(value);
        }

        private void EditProduct_Load(object sender, EventArgs e)
        {
            this.Text = product.codProduct;
            txtIdProduct.Text = product.idProduct.ToString();
            txtCodProduct.Text = product.codProduct;
            txtCategory.Text = product.category;
            txtModel.Text = product.model;
            txtQuantity.Value = product.quantity;
            txtValueProduct.Text = product.valueProduct.ToString();
            rxtDescription.Text = product.description;
            classProduct = new ClassProduct();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Close();
            classProduct.updateProduct(product);
        }

        private void txtCodProduct_TextChanged(object sender, EventArgs e)
        {
            product.codProduct = txtCodProduct.Text;
        }

        private void txtCategory_TextChanged(object sender, EventArgs e)
        {
            product.category = txtCategory.Text;
        }

        private void txtModel_TextChanged(object sender, EventArgs e)
        {
            product.model = txtModel.Text;
        }

        private void rxtDescription_TextChanged(object sender, EventArgs e)
        {
            product.description = rxtDescription.Text;
        }

        private void txtValueProduct_TextChanged(object sender, EventArgs e)
        {
            product.valueProduct = Convert.ToDecimal(txtValueProduct.Text);
        }

        private void txtQuantity_ValueChanged(object sender, EventArgs e)
        {
            product.quantity = Convert.ToInt32(txtQuantity.Value);
        }
    }
}
