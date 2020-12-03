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
    public partial class AddAddressClient : Form
    {
        ClassClient clients = new ClassClient();
        AddressClient address = new AddressClient();
        public AddAddressClient()
        {
            InitializeComponent();
            comboPessoa.DisplayMember = "Text";
            comboPessoa.ValueMember = "Value";
            List<Client> listClients = clients.getAllClients();
            listClients.ForEach(client => comboPessoa.Items.Add(new { Text = client.name, Value = client.idClient }));
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            address.address = txtAddress.Text;
        }

        private void txtDistrict_TextChanged(object sender, EventArgs e)
        {
            address.district = txtDistrict.Text;
        }

        private void txtCity_TextChanged(object sender, EventArgs e)
        {
            address.city = txtCity.Text;
        }

        private void txtNumber_ValueChanged(object sender, EventArgs e)
        {
            address.number = txtNumber.Value.ToString();
        }

        private void comboUF_SelectedIndexChanged(object sender, EventArgs e)
        {
            address.uf = comboUF.SelectedItem.ToString();
        }

        private void txtZipcode_TextChanged(object sender, EventArgs e)
        {
            address.zipcode = txtZipcode.Text;
        }

        private void txtComp_TextChanged(object sender, EventArgs e)
        {
            address.comp = txtComp.Text;
        }

        private void comboPessoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idClient = (comboPessoa.SelectedItem as dynamic).Value;
            address.idClient = idClient;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            clients.saveAddressClient(address);
            this.Close();
        }
    }
}
