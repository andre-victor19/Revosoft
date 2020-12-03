using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class EditProvider : Form
    {
        private int idProvider { get; set; }
        private string companyName { get; set; }
        private string cnpj { get; set; }
        private DateTime openDate { get; set; }
        private string email { get; set; }
        private string situation { get; set; }

        private Provider provider { get; set; }
        public EditProvider()
        {
            InitializeComponent();
        }

        public EditProvider(string idProvider, string companyName, string cnpj, string openDate, string email, string itemSituation)
        {
            InitializeComponent();
            CultureInfo cultureInfo = new CultureInfo("pt-BR");
            this.idProvider = Convert.ToInt32(idProvider);
            this.companyName = companyName;
            this.cnpj = cnpj;
            this.openDate = DateTime.Parse(openDate, cultureInfo);
            this.email = email;
            this.situation = itemSituation;
            int tempSituation = this.situation.ToUpper() == "ATIVO" ? 1 : 0;
            string tempOpenDate = this.openDate.ToString("yyyy-MM-dd");
            provider = new Provider(this.idProvider, this.companyName, this.cnpj, tempOpenDate, this.email, tempSituation);
        }

        private void EditProvider_Load(object sender, EventArgs e)
        {
            this.Text = companyName;
            txtIdProvider.Text = idProvider.ToString();
            txtCompanyName.Text = companyName;
            txtCnpj.Text = cnpj;
            txtEmail.Text = email;
            dateOpenDate.Value = openDate;
            comboRegistration.SelectedItem = situation;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Close();
            ClassProvider classProvider = new ClassProvider();
            classProvider.updateProvider(provider);
        }

        private void txtCompanyName_TextChanged(object sender, EventArgs e)
        {
            companyName = txtCompanyName.Text;
            provider.companyName = companyName;
        }

        private void txtCnpj_TextChanged(object sender, EventArgs e)
        {
            cnpj = txtCnpj.Text;
            provider.cnpj = cnpj;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            email = txtEmail.Text;
            provider.email = email;
        }

        private void comboRegistration_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedRegistration = comboRegistration.SelectedItem.ToString().ToUpper();
            if (selectedRegistration == "INATIVO")
            {
                provider.registrationSituation = 0;
            }
            else
            {
                provider.registrationSituation = 1;
            }
        }

        private void dateOpenDate_ValueChanged(object sender, EventArgs e)
        {
            openDate = dateOpenDate.Value;
            provider.openDate = openDate.ToString("yyyy-MM-dd");
        }
    }
}
