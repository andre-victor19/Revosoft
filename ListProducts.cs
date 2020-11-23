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
    public partial class ListProducts : Form
    {
        public ListProducts()
        {
            InitializeComponent();
        }

        private void cadastrarFornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddProvider formAddProvider = new AddProvider();
            formAddProvider.Show();
        }

        private void listaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Principal formPrincipal = new Principal();
            formPrincipal.Show();
            this.Close();
        }

        private void listaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ListClient formListClient = new ListClient();
            formListClient.Show();
            this.Close();
        }

        private void cadastroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddProduct formAddProduct = new AddProduct();
            formAddProduct.Show();
        }

        private void ListProducts_Load(object sender, EventArgs e)
        {
            listProduct.View = View.Details;
            listProduct.GridLines = true;
            listProduct.FullRowSelect = true;
            string[] columns = new string[listProduct.Columns.Count];

            ClassProduct products = new ClassProduct();
            List<Product> listProducts = products.getAllProducts();

            //Adiciona as informações a listProducts
            ListViewItem item;
            listProducts.ForEach(header =>
            {
                columns[0] = header.idProduct.ToString();
                columns[1] = header.codProduct;
                columns[2] = header.category;
                columns[3] = header.model;
                columns[4] = header.description;
                columns[5] = header.quantity.ToString();
                columns[6] = header.valueProduct.ToString();
                item = new ListViewItem(columns);
                listProduct.Items.Add(item);
            });
        }
    }
}
