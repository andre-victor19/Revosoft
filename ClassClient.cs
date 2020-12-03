using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    class ClassClient
    {
        List<Client> clients = new List<Client>();
        private int IdDbAccess = Convert.ToInt32(Properties.Settings.Default.IdDbAccess);
        private int IdProvider = Convert.ToInt32(Properties.Settings.Default.IdProvider);
        MessageBoxButtons buttons = MessageBoxButtons.OK;
        MessageBoxIcon icon = MessageBoxIcon.Information;
        private string message { get; set; }
        private string caption { get; set; }
        public List<Client> getAllClients()
        {
            clients.Clear();
            ConnectionDB connection = new ConnectionDB();
            connection.openConnection();
            string command = $"SELECT * FROM cliente;";
            MySqlDataReader result = connection.select(command);
            while (result.Read())
            {
                Client client = new Client(Convert.ToInt32(result[0]), result[1].ToString(), result[2].ToString(), result[3].ToString(), result[4].ToString());
                clients.Add(client);
               
            }
            result.Close();
            connection.closeConnection();
            
            return clients;
        }

        public void saveClient(Client client)
        {
            try {
                ConnectionDB connection = new ConnectionDB();
                connection.openConnection();
                string command = $"INSERT INTO cliente (idcliente, nome, sobrenome, cpf, email, criado, BancoAcesso_idBancoAcesso) VALUES (null,'{client.name}', '{client.surname}', '{client.cpf}', '{client.email}', NOW(), {IdDbAccess});";
                connection.insert(command);
                message = "Cliente inserido com sucesso !!";
                caption = "Sucesso";
                icon = MessageBoxIcon.Information;
                
            }
            catch(Exception err)
            {
                Console.WriteLine(err.ToString());
                message = "Falha ao inserir novo cliente.";
                caption = "Falha";
                icon = MessageBoxIcon.Error;
            }
            finally
            {
                MessageBox.Show(message, caption, buttons, icon);
            }
        }

        public void savePhoneClient(PhoneClient phone)
        {
            try {
                ConnectionDB connection = new ConnectionDB();
                connection.openConnection();
                string command = $"INSERT INTO telefone (idtelefone, tipo, codArea, numero, criado, Cliente_idcliente) VALUES (null,'{phone.type}', '{phone.code}', '{phone.number}', NOW(), {phone.idClient});";
                connection.insert(command);
                message = "Contato inserido com sucesso !!";
                caption = "Sucesso";
            }
            catch(Exception err)
            {
                Console.WriteLine(err.ToString());
                message = "Falha ao inserir novo contato.";
                caption = "Falha";
                icon = MessageBoxIcon.Error;
            }
            finally
            {
                MessageBox.Show(message, caption, buttons, icon);
            }
        }

        public void saveAddressClient(AddressClient address)
        {
            try {
                ConnectionDB connection = new ConnectionDB();
                connection.openConnection();
                string command = $"INSERT INTO endereco (idEndereco, rua, numero, complemento, cep, bairro, municipio, uf, criado, Fornecedor_idfornecedor, Cliente_idcliente) VALUES (null,'{address.address}', '{address.number}', '{address.comp}', '{address.zipcode}', '{address.district}', '{address.city}', '{address.uf}', NOW(), {IdProvider}, {address.idClient});";
                connection.insert(command);
                message = "Endereço inserido com sucesso !!";
                caption = "Sucesso";
            }
            catch(Exception err)
            {
                Console.WriteLine(err.ToString());
                message = "Falha ao inserir novo endereço.";
                caption = "Falha";
                icon = MessageBoxIcon.Error;
            }
            finally
            {
                MessageBox.Show(message, caption, buttons, icon);
            }
        }

        public void deleteClient(int idClient)
        {
            try {
                ConnectionDB connection = new ConnectionDB();
                connection.openConnection();
                string command = $"DELETE FROM cliente WHERE idcliente = {idClient};";
                connection.delete(command);
                message = "Cliente excluído com sucesso !!";
                caption = "Sucesso";
            }
            catch(Exception error) {
                Console.WriteLine(error.ToString());
                message = "Falha ao excluir cliente";
                caption = "Falha";
                icon = MessageBoxIcon.Error;
            }
            finally { MessageBox.Show(message, caption, buttons, icon); }
        }
    }
}
