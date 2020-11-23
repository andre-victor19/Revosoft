using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    class ClassClient
    {
        List<Client> clients = new List<Client>();
        public List<Client> getAllClients()
        {
            ConnectionDB connection = new ConnectionDB();
            connection.openConnection();
            string command = $"SELECT * FROM cliente;";
            MySqlDataReader result = connection.executeCommand(command);
            while (result.Read())
            {
                Client client = new Client(Convert.ToInt32(result[0]), result[1].ToString(), result[2].ToString(), result[3].ToString(), result[4].ToString());
                clients.Add(client);
               
            }
            result.Close();
            connection.closeConnection();
            
            return clients;
        }
    }
}
