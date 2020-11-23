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
        private Login formLogin;

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
            listProvider.View = View.Details;
            listProvider.GridLines = true;
            listProvider.FullRowSelect = true;
            string[] columns = new string[listProvider.Columns.Count];

            ClassProvider providers = new ClassProvider();
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

        private void cadastrarFornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddProvider formAddProvider = new AddProvider(this);
            formAddProvider.Show();
        }

        private string typeSituation(int situation)
        {
            if(situation == 0)
            {
                return "Inativo";
            }
            else { return "Ativo"; }
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
    }
}
