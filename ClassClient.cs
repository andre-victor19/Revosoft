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
        private List<Client> clients = new List<Client>();
        private List<PhoneClient> phones = new List<PhoneClient>();
        private List<AddressClient> address = new List<AddressClient>();
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

        public void editClient(Client client)
        {
            try {
                ConnectionDB connection = new ConnectionDB();
                connection.openConnection();
                string command = $"UPDATE cliente SET nome = '{client.name}', sobrenome = '{client.surname}', cpf = '{client.cpf}', email = '{client.email}', modificado = NOW(), BancoAcesso_idBancoAcesso = {IdDbAccess} WHERE idcliente = {client.idClient}";
                connection.update(command);
                message = "Cliente atualizado com sucesso !!";
                caption = "Sucesso";
            }
            catch(Exception error) {
                Console.WriteLine(error.ToString());
                message = "Falha ao atualizar cliente.";
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
            try
            {
                ConnectionDB connection = new ConnectionDB();
                connection.openConnection();
                string command = $"DELETE FROM cliente WHERE idcliente = {idClient};";
                connection.delete(command);
                message = "Cliente excluído com sucesso !!";
                caption = "Sucesso";
            }
            catch (Exception error)
            {
                Console.WriteLine(error.ToString());
                message = "Falha ao excluir cliente";
                caption = "Falha";
                icon = MessageBoxIcon.Error;
            }
            finally { MessageBox.Show(message, caption, buttons, icon); }
        }

        public List<PhoneClient> getPhoneClient(int idClient)
        {
            phones.Clear();
            ConnectionDB connection = new ConnectionDB();
            connection.openConnection();
            string command = $"SELECT * FROM telefone WHERE Cliente_idcliente = {idClient};";
            MySqlDataReader result = connection.select(command);
            while (result.Read())
            {
                PhoneClient phone = new PhoneClient(Convert.ToInt32(result[0]), result[1].ToString(), result[2].ToString(), result[3].ToString(), idClient);
                phones.Add(phone);
            }
            result.Close();
            connection.closeConnection();

            return phones;
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

        public void editPhoneClient(int idPhone, string column, string data)
        {
            try {
                ConnectionDB connection = new ConnectionDB();
                connection.openConnection();
                string command = $"UPDATE telefone SET {column} = '{data}' WHERE idtelefone = {idPhone}";
                connection.update(command);
            }
            catch(Exception error)
            {
                Console.WriteLine(error.ToString());
            }
        }

        public void deletePhoneClient(int idPhone)
        {
            try {
                ConnectionDB connection = new ConnectionDB();
                connection.openConnection();
                string command = $"DELETE FROM telefone WHERE idtelefone = {idPhone};";
                connection.delete(command);
                message = "Contato excluído com sucesso !!";
                caption = "Sucesso";
            }
            catch(Exception error) {
                Console.WriteLine(error.ToString());
                message = "Falha ao deletar contato.";
                caption = "Falha";
                icon = MessageBoxIcon.Error;
            }
            finally {
                MessageBox.Show(message, caption, buttons, icon);
            }
        }

        public List<AddressClient> getAddressClients(int idClient)
        {
            address.Clear();
            ConnectionDB connection = new ConnectionDB();
            connection.openConnection();
            string command = $"SELECT * FROM endereco WHERE Cliente_idcliente = {idClient};";
            MySqlDataReader result = connection.select(command);
            while (result.Read())
            {
                AddressClient tempAddress = new AddressClient();
                tempAddress.idAddress = Convert.ToInt32(result[0]);
                tempAddress.address = result[1].ToString();
                tempAddress.number = result[2].ToString();
                tempAddress.comp = result[3].ToString();
                tempAddress.zipcode = result[4].ToString();
                tempAddress.district = result[5].ToString();
                tempAddress.city = result[6].ToString();
                tempAddress.uf = result[7].ToString();
                tempAddress.idProvider = Convert.ToInt32(result[10]);
                tempAddress.idClient = idClient;
                address.Add(tempAddress);
            }
            result.Close();
            connection.closeConnection();
            return address;
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

        public void editAddressClient(int idAddress, string column, string data)
        {
            try
            {
                ConnectionDB connection = new ConnectionDB();
                connection.openConnection();
                string newColumn = column == "NumeroEnd" ? "numero" : column;
                string command = $"UPDATE endereco SET {column} = '{data}' WHERE idEndereco = {idAddress}";
                connection.update(command);
            }
            catch (Exception error)
            {
                Console.WriteLine(error.ToString());
            }
        }

        public void deleteAddressClient(int idAddress)
        {
            try
            {
                ConnectionDB connection = new ConnectionDB();
                connection.openConnection();
                string command = $"DELETE FROM endereco WHERE idEndereco = {idAddress};";
                connection.delete(command);
                message = "Endereço excluído com sucesso !!";
                caption = "Sucesso";
            }
            catch (Exception error)
            {
                Console.WriteLine(error.ToString());
                message = "Falha ao deletar endereço.";
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
