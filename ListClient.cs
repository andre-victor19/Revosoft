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
    public partial class ListClient : Form
    {
        public ListClient()
        {
            InitializeComponent();
        }

        private void ListClient_Load(object sender, EventArgs e)
        {
            listClients.View = View.Details;
            listClients.GridLines = true;
            listClients.FullRowSelect = true;
            string[] columns = new string[listClients.Columns.Count];

            ClassClient clients = new ClassClient();
            List<Client> listClient = clients.getAllClients();

            //Adiciona as informações a listClient
            ListViewItem item;
            listClient.ForEach(header => {
                columns[0] = header.idClient.ToString();
                columns[1] = header.name;
                columns[2] = header.surname;
                columns[3] = header.cpf;
                columns[4] = header.email;
                item = new ListViewItem(columns);
                listClients.Items.Add(item);
            });
        }

        private void listaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Principal formPrincipal = new Principal();
            formPrincipal.Show();
            this.Close();
        }

        private void cadastrarFornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddProvider formAddProvider = new AddProvider();
            formAddProvider.Show();
        }

        private void listaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ListProducts formListProducts = new ListProducts();
            formListProducts.Show();
            this.Close();
        }

        private void cadastroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddProduct formAddProduct = new AddProduct();
            formAddProduct.Show();
        }
    }
}
