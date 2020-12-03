using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class ClassUser
    {
        public int idProvider { get; set; }
        public string user { get; set; }
        public string password { get; set; }
        private MessageBoxButtons buttons = MessageBoxButtons.OK;
        private MessageBoxIcon icon;
        private string message { get; set; }
        private string caption { get; set; }

        public bool sendLoginAccess()
        {
            if(user != "" && password != "")
            {
                ConnectionDB connection = new ConnectionDB();
                connection.openConnection();
                string command = $"SELECT * FROM bancoacesso WHERE login = '{user}' AND senha = '{password}'";
                MySqlDataReader result = connection.select(command);    
                bool isLogged = result.Read();
                if (isLogged)
                {
                    Properties.Settings.Default.IdDbAccess = result[0];
                    Properties.Settings.Default.IdProvider = result[3];
                }
                result.Close();
                connection.closeConnection();
                return isLogged;
            }
            return false;
        }

        public void addUser(ClassUser user)
        {
            try {
                ConnectionDB connection = new ConnectionDB();
                connection.openConnection();
                string command = $"INSERT INTO bancoacesso (idBancoAcesso, login, senha, Fornecedor_idfornecedor, Fornecedor_Telefone_idtelefone, Fornecedor_Telefone_Cliente_idcliente) VALUES (null,'{user.user}', '{user.password}', {user.idProvider}, 1, 1);";
                connection.insert(command);
                message = "Acesso criado com sucesso !!";
                caption = "Sucesso";
            }
            catch(Exception error)
            {
                Console.WriteLine(error.ToString());
                message = "Falha ao criar acesso.";
                caption = "Falha";
                icon = MessageBoxIcon.Error;
            }
            finally
            {
                MessageBox.Show(message, caption, buttons, icon);
            }
        }
    }
}
