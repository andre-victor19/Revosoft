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
    public partial class AddUser : Form
    {
        ClassUser user { get; set; }
        ClassProvider provider { get; set; }
        public AddUser()
        {
            InitializeComponent();
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            user = new ClassUser();
            provider = new ClassProvider();
            comboProvider.DisplayMember = "Text";
            comboProvider.ValueMember = "Value";
            List<Provider> providers = provider.getAllProviders();
            providers.ForEach(prov => comboProvider.Items.Add(new { Text = prov.companyName, Value = prov.idProvider}));
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Close();
            user.addUser(user);
        }
        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            user.user = txtUser.Text;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            user.password = txtPassword.Text;
        }

        private void comboProvider_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idProvider = (comboProvider.SelectedItem as dynamic).Value;
            user.idProvider = idProvider;
        }
    }
}
