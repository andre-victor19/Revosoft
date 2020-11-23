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
    public partial class AddProduct : Form
    {
        private Product newProduct = new Product();
        public AddProduct()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ClassProduct product = new ClassProduct();
            product.saveProduct(newProduct);
            this.Close();
        }

        private void txtCodProduct_TextChanged(object sender, EventArgs e)
        {
            newProduct.codProduct = txtCodProduct.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            newProduct.category = textBox1.Text;
        }

        private void txtModel_TextChanged(object sender, EventArgs e)
        {
            newProduct.model = txtModel.Text;
        }

        private void txtQuantity_ValueChanged(object sender, EventArgs e)
        {
            newProduct.quantity = Convert.ToInt32(txtQuantity.Value);
        }

        private void txtValueProduct_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            newProduct.valueProduct = Convert.ToDouble(txtValueProduct.Text);
        }
    }
}
