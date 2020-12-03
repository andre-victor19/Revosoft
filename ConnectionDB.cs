using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    class ConnectionDB
    {
        private string connSQL = "server=localhost;user=root;database=revosoft;port=3306;";
        MySqlConnection conn;

        public void openConnection()
        {
            conn = new MySqlConnection(connSQL);
            try {
                conn.Open();
            }
            catch(Exception err)
            {
                Console.WriteLine(err.ToString());
            }
        }

        public void closeConnection()
        {
            conn.Close();
        }

        public MySqlDataReader select(string sql)
        {
                MySqlCommand command = new MySqlCommand(sql, conn);
                MySqlDataReader reader = command.ExecuteReader();
                return reader;
        }

        public void insert(string sql)
        {
            try
            {
                MySqlCommand command = new MySqlCommand(sql, conn);
                command.ExecuteNonQuery();
            } catch(Exception err)
            {
                Console.WriteLine(err.ToString());
            }
            finally
            {
                this.closeConnection();
            }
        }

        public void delete(string sql)
        {
            try {
                MySqlCommand command = new MySqlCommand(sql, conn);
                command.ExecuteNonQuery();
            }
            catch(Exception err)
            {
                Console.WriteLine(err.ToString());
            }
            finally
            {
                this.closeConnection();
            }
        }
    }
}
