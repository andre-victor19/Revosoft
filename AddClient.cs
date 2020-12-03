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
    public partial class AddClient : Form
    {
        private Client newClient = new Client();
        public AddClient()
        {
            InitializeComponent();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            newClient.name = txtName.Text;
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            newClient.surname = txtLastName.Text;
        }

        private void txtCPF_TextChanged(object sender, EventArgs e)
        {
            newClient.cpf = txtCPF.Text;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            newClient.email = txtEmail.Text;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ClassClient client = new ClassClient();
            client.saveClient(newClient);
            this.Close();
        }
    }
}
