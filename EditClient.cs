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
        MessageBoxButtons buttons { get; set; }
        MessageBoxIcon icon { get; set; }
        string message { get; set; }
        string caption { get; set; }
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
            classClient.editClient(client);
        }

        private void DGPhones_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string column = DGPhones.Columns[e.ColumnIndex].Name;
            string row = DGPhones.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            int idPhone = Convert.ToInt32(DGPhones.Rows[e.RowIndex].Cells[0].Value.ToString());
            classClient.editPhoneClient(idPhone, column, row);
        }

        private void DGAddress_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string column = DGAddress.Columns[e.ColumnIndex].Name;
            string row = DGAddress.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            int idAddress = Convert.ToInt32(DGAddress.Rows[e.RowIndex].Cells[0].Value.ToString());
            classClient.editAddressClient(idAddress, column, row);
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            client.name = txtName.Text;
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            client.surname = txtLastName.Text;
        }

        private void txtCPF_TextChanged(object sender, EventArgs e)
        {
            client.cpf = txtCPF.Text;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            client.email = txtEmail.Text;
        }

        private void DGPhones_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            buttons = MessageBoxButtons.YesNo;
            icon = MessageBoxIcon.Question;
            message = "Deseja excluir esse contato ?";
            caption = "Excluir";
            DialogResult result = MessageBox.Show(message, caption, buttons, icon);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                int idPhone = Convert.ToInt32(e.Row.Cells[0].Value);
                classClient.deletePhoneClient(idPhone);
            }
        }

        private void DGAddress_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            buttons = MessageBoxButtons.YesNo;
            icon = MessageBoxIcon.Question;
            message = "Deseja excluir esse endereço ?";
            caption = "Excluir";
            DialogResult result = MessageBox.Show(message, caption, buttons, icon);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                int idAddress = Convert.ToInt32(e.Row.Cells[0].Value);
                classClient.deleteAddressClient(idAddress);
            }
        }
    }
}
