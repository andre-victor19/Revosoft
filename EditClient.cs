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
    public partial class EditClient : Form
    {
        Client client { get; set; }
        ClassClient classClient { get; set; }
        List<PhoneClient> phones { get; set; }
        List<AddressClient> addresses { get; set; }
        public EditClient()
        {
            InitializeComponent();
        }

        public EditClient(string idClient, string name, string surname, string cpf, string email)
        {
            InitializeComponent();
            client = new Client();
            classClient = new ClassClient();
            client.idClient = Convert.ToInt32(idClient);
            client.name = name;
            client.surname = surname;
            client.cpf = cpf;
            client.email = email;
            phones = classClient.getPhoneClient(client.idClient);
            addresses = classClient.getAddressClients(client.idClient);
        }

        private void CreateListPhones()
        {
            listPhones.Items.Clear();
            listPhones.View = View.Details;
            listPhones.GridLines = true;
            listPhones.FullRowSelect = true;
            string[] columns = new string[listPhones.Columns.Count];

            ListViewItem item;
            phones.ForEach(phone => {
                columns[0] = phone.idPhone.ToString();
                columns[1] = phone.type;
                columns[2] = phone.code;
                columns[3] = phone.number;
                item = new ListViewItem(columns);
                listPhones.Items.Add(item);
            });
        }

        private void CreateListAddress()
        {
            listAddress.Items.Clear();
            listAddress.View = View.Details;
            listAddress.GridLines = true;
            listAddress.FullRowSelect = true;
            string[] columns = new string[listAddress.Columns.Count];

            ListViewItem item;
            addresses.ForEach(endereco => {
                columns[0] = endereco.idAddress.ToString();
                columns[1] = endereco.address;
                columns[2] = endereco.district;
                columns[3] = endereco.city;
                columns[4] = endereco.uf;
                columns[5] = endereco.zipcode;
                columns[6] = endereco.number;
                columns[7] = endereco.comp;
                item = new ListViewItem(columns);
                listAddress.Items.Add(item);
            });
        }

        private void EditClient_Load(object sender, EventArgs e)
        {
            this.Text = client.name.ToUpper();
            txtIdClient.Text = client.idClient.ToString();
            txtName.Text = client.name;
            txtLastName.Text = client.surname;
            txtCPF.Text = client.cpf;
            txtEmail.Text = client.email;
            this.CreateListPhones();
            this.CreateListAddress();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
