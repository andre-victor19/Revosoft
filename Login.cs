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
    public partial class Login : Form
    {
        ClassUser login { get; set; }
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            login = new ClassUser();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            login.password = txtPassword.Text;
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            login.user = txtUsuario.Text;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool logged = login.sendLoginAccess();
            Principal formPrincipal = new Principal(this);
            lblAlertLogin.Hide();
            if (logged)
            {
                formPrincipal.Show();
                this.Visible = false;

            }
            else
            {
                lblAlertLogin.Show();
            }
        }

        private void linkCreateAccess_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddUser formAddUser = new AddUser();
            formAddUser.Show();
        }
    }
}
