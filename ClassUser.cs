using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public class ClassUser
    {
        public string user = "";
        public string password = "";

        public bool sendLoginAccess()
        {
            if(user != "" && password != "")
            {
                ConnectionDB connection = new ConnectionDB();
                connection.openConnection();
                string command = $"SELECT * FROM bancoacesso WHERE login = '{user}' AND senha = '{password}'";
                MySqlDataReader result = connection.executeCommand(command);    
                bool isLogged = result.Read();
                result.Close();
                connection.closeConnection();
                return isLogged;
            }
            return false;
        }
    }
}
