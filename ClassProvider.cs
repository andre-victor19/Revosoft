using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    class ClassProvider
    {
        List<Provider> providers = new List<Provider>();

        public List<Provider> getAllProviders()
        {
            ConnectionDB connection = new ConnectionDB();
            connection.openConnection();
            string command = $"SELECT * FROM fornecedor;";
            MySqlDataReader result = connection.executeCommand(command);
            while (result.Read())
            {
                Provider tempProvider = new Provider(Convert.ToInt32(result[0]), result[1].ToString(), result[2].ToString(), result[3].ToString(), result[4].ToString(), Convert.ToInt32(result[5]));
                providers.Add(tempProvider);
            }
            result.Close();
            connection.closeConnection();
            return providers;
        }

        public void saveProvicer(Provider provider)
        {
            Provider newProvider = new Provider(0, provider.companyName, provider.cnpj, provider.openDate, provider.email, provider.registrationSituation);
            Console.WriteLine(newProvider);
        }
    }
}
