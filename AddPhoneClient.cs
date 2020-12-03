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
    public partial class AddPhoneClient : Form
    {
        ClassClient clients = new ClassClient();
        PhoneClient phone = new PhoneClient();
        public AddPhoneClient()
        {
            InitializeComponent();
        }

        private void AddPhoneClient_Load(object sender, EventArgs e)
        {
            comboPessoa.DisplayMember = "Text";
            comboPessoa.ValueMember = "Value";
            List<Client> listClients = clients.getAllClients();
            listClients.ForEach(client => comboPessoa.Items.Add(new { Text = client.name, Value = client.idClient }));
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            clients.savePhoneClient(phone);
            this.Close();
        }
        private void comboPessoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idClient = (comboPessoa.SelectedItem as dynamic).Value;
            phone.idClient = idClient;
        }

        private void comboTypePhone_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedType = comboTypePhone.SelectedItem.ToString().ToUpper();
            phone.type = selectedType;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            phone.code = txtName.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            phone.number = txtNumber.Text;
        }
    }
}
