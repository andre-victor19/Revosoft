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
            DGPhones.Rows.Clear();
            phones.ForEach(phone => 
                DGPhones.Rows.Add(phone.idPhone.ToString(), phone.type, phone.code, phone.number)
            );
        }

        private void CreateListAddress()
        {
            DGAddress.Rows.Clear();
            addresses.ForEach(endereco =>
                DGAddress.Rows.Add(endereco.idAddress.ToString(), endereco.address, endereco.district, endereco.city, endereco.uf, endereco.zipcode, endereco.number, endereco.comp)
            );
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
