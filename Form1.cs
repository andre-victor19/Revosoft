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
    public partial class Form1 : Form
    {
        ClassUser login = new ClassUser();
        public Form1()
        {
            InitializeComponent();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

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
            lblAlertLogin.Hide();
            if (logged)
            {
                pnlLogin.Hide();
                pnlListProvider.Show();
            }
            else
            {
                lblAlertLogin.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblAlertLogin.Hide();
            pnlListProvider.Hide();
        }
    }
}
