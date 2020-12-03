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

        ClassClient clients = new ClassClient();
        private int itemClient { get; set; }
        public ListClient()
        {
            InitializeComponent();
        }

        private void CreateListClient()
        {
            listClients.Items.Clear();
            listClients.View = View.Details;
            listClients.GridLines = true;
            listClients.FullRowSelect = true;
            string[] columns = new string[listClients.Columns.Count];

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

        private void ListClient_Load(object sender, EventArgs e)
        {
            this.CreateListClient();
            ToolTip btnRefresh = new ToolTip();
            btnRefresh.SetToolTip(this.btnRefreshList, "Atualizar lista");
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

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddClient formAddClient = new AddClient();
            formAddClient.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void listClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine(listClients.SelectedItems);
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
            this.CreateListClient();
        }

        private void listClients_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ListViewHitTestInfo ht = listClients.HitTest(new Point(e.X, e.Y));
                if (ht.Item != null)
                {
                    Point loc = e.Location;
                    loc.Offset(listClients.Location);
                    menuOptions.Show(loc);
                    itemClient = Convert.ToInt32(listClients.Items[ht.Item.Index].Text);
                }
            }
        }

        private void deletarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Question;
            string message = "Deseja excluir esse cliente ?";
            string caption = "Excluir";
            DialogResult result = MessageBox.Show(message, caption, buttons, icon);
            if (result == DialogResult.Yes)
            {
                clients.deleteClient(itemClient);
            }
        }
    }
}
