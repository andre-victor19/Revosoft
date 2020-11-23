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
    public partial class AddProvider : Form
    {
        private Principal formPrincipal;
        private Provider newProvider = new Provider();
        public AddProvider()
        {
            InitializeComponent();
        }

        public AddProvider(Principal formPrincipal)
        {
            InitializeComponent();
            this.formPrincipal = formPrincipal;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ClassProvider provider = new ClassProvider();
            provider.saveProvicer(newProvider);
            this.Close();
        }

        private void txtCompanyName_TextChanged(object sender, EventArgs e)
        {
            newProvider.companyName = txtCompanyName.Text;
        }

        private void txtCnpj_TextChanged(object sender, EventArgs e)
        {
            newProvider.cnpj = txtCnpj.Text;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            newProvider.email = txtEmail.Text;
        }

        private void comboRegistration_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedRegistration = comboRegistration.SelectedItem.ToString().ToUpper();
            if(selectedRegistration == "INATIVO")
            {
                newProvider.registrationSituation = 0;
            }
            else
            {
                newProvider.registrationSituation = 1;
            }
            
        }

        private void dateOpenDate_ValueChanged(object sender, EventArgs e)
        {
            newProvider.openDate = dateOpenDate.Value.ToString("yyyy-MM-dd");
        }
    }
}
