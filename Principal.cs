using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Principal : Form
    {
        private Login formLogin { get; set; }
        private ClassProvider providers { get; set; }
        private int itemProvider { get; set; }
        private int idxItem { get; set; }

        public Principal()
        {
            InitializeComponent();
        }
        public Principal(Login formLogin)
        {
            InitializeComponent();
            this.formLogin = formLogin;
            
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            providers = new ClassProvider();
            this.loadListProviders();
            ToolTip btnRefresh = new ToolTip();
            btnRefresh.SetToolTip(this.btnRefreshList, "Atualizar lista");
        }

        private void cadastrarFornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddProvider formAddProvider = new AddProvider(this);
            formAddProvider.Show();
        }


        private void listaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ListClient formListClient = new ListClient();
            formListClient.Show();
            this.Close();
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

        private string typeSituation(int situation)
        {
            if (situation == 0)
            {
                return "Inativo";
            }
            else { return "Ativo"; }
        }

        private void loadListProviders()
        {
            listProvider.Items.Clear();
            listProvider.View = View.Details;
            listProvider.GridLines = true;
            listProvider.FullRowSelect = true;
            string[] columns = new string[listProvider.Columns.Count];
            List<Provider> listProviders = providers.getAllProviders();

            //Adiciona as informações a listProvider
            ListViewItem item;
            listProviders.ForEach(header => {
                columns[0] = header.idProvider.ToString();
                columns[1] = header.companyName;
                columns[2] = header.cnpj;
                columns[3] = header.openDate;
                columns[4] = header.email;
                columns[5] = this.typeSituation(header.registrationSituation);
                columns[6] = header.dateCreate;
                item = new ListViewItem(columns);
                listProvider.Items.Add(item);
            });
            
        }

        private void btnRefreshList_Click(object sender, EventArgs e)
        {
            this.loadListProviders();
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

        private void listProvider_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                ListViewHitTestInfo ht = listProvider.HitTest(new Point(e.X, e.Y));
                if(ht.Item != null)
                {
                    Point loc = e.Location;
                    loc.Offset(listProvider.Location);
                    menuOptions.Show(loc);
                    idxItem = ht.Item.Index;
                    itemProvider = Convert.ToInt32(listProvider.Items[idxItem].Text);
                    
                }
            }
        }

        private void deletarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Question;
            string message = "Deseja excluir esse fornecedor ?";
            string caption = "Excluir";
            DialogResult result = MessageBox.Show(message, caption, buttons, icon);
            if (result == DialogResult.Yes) {
                providers.deleteProvider(itemProvider);
            }
        }

        private void atualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string itemId = listProvider.Items[idxItem].SubItems[0].Text;
            string itemCompanyName = listProvider.Items[idxItem].SubItems[1].Text;
            string itemCnpj = listProvider.Items[idxItem].SubItems[2].Text;
            string itemOpenDate = listProvider.Items[idxItem].SubItems[3].Text;
            string itemEmail = listProvider.Items[idxItem].SubItems[4].Text;
            string itemSituation = listProvider.Items[idxItem].SubItems[5].Text;
            EditProvider formEditProvider = new EditProvider(itemId, itemCompanyName, itemCnpj, itemOpenDate, itemEmail, itemSituation);
            formEditProvider.Show();
        }
    }
}
