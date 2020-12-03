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
        ClassProduct products = new ClassProduct();
        private int itemProduct { get; set; }
        public ListProducts()
        {
            InitializeComponent();
        }

        private void CreateListProducts()
        {
            listProduct.Items.Clear();
            listProduct.View = View.Details;
            listProduct.GridLines = true;
            listProduct.FullRowSelect = true;
            string[] columns = new string[listProduct.Columns.Count];
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
            this.CreateListProducts();
            ToolTip btnRefresh = new ToolTip();
            btnRefresh.SetToolTip(this.btnRefreshList, "Atualizar lista");
        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddClient formAddClient = new AddClient();
            formAddClient.Show();
        }

        private void telefoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPhoneClient formPhone = new AddPhoneClient();
            formPhone.Show();
        }

        private void endereçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddAddressClient formAddress = new AddAddressClient();
            formAddress.Show();
        }

        private void btnRefreshList_Click(object sender, EventArgs e)
        {
            this.CreateListProducts();
        }

        private void listProduct_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ListViewHitTestInfo ht = listProduct.HitTest(new Point(e.X, e.Y));
                if (ht.Item != null)
                {
                    Point loc = e.Location;
                    loc.Offset(listProduct.Location);
                    menuOptions.Show(loc);
                    itemProduct = Convert.ToInt32(listProduct.Items[ht.Item.Index].Text);

                }
            }
        }

        private void deletarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Question;
            string message = "Deseja excluir esse produto ?";
            string caption = "Excluir";
            DialogResult result = MessageBox.Show(message, caption, buttons, icon);
            if (result == DialogResult.Yes)
            {
                products.deleteProduct(itemProduct);
            }
        }
    }
}
