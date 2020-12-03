using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    class ClassUser
    {
        public string user { get; set; }
        public string password { get; set; }

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
    }
}
