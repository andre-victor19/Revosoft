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
    class ClassProvider
    {
        List<Provider> providers = new List<Provider>();
        MessageBoxButtons buttons = MessageBoxButtons.OK;
        MessageBoxIcon icon;
        string message = "";
        string caption = "";

        public List<Provider> getAllProviders()
        {
            providers.Clear();
            ConnectionDB connection = new ConnectionDB();
            connection.openConnection();
            string command = $"SELECT * FROM fornecedor;";
            MySqlDataReader result = connection.select(command);
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
            try {
                ConnectionDB connection = new ConnectionDB();
                connection.openConnection();
                string command = $"INSERT INTO fornecedor (idfornecedor, razaoSocial, cnpj, dataAbertura, email, situacaoCadastro, criado,Telefone_idtelefone,Telefone_Cliente_idcliente) VALUES (null,'{provider.companyName}', '{provider.cnpj}', '{provider.openDate}', '{provider.email}', {provider.registrationSituation}, NOW(), 0, 0);";
                connection.insert(command);
                message = "Fornecedor inserido com sucesso !!";
                caption = "Sucesso";
                MessageBox.Show(message, caption, buttons, icon);  
            }
            catch(Exception err)
            {
                Console.WriteLine(err.ToString());
                message = "Falha ao inserir novo fornecedor.";
                caption = "Falha";
                icon = MessageBoxIcon.Error;
                MessageBox.Show(message, caption, buttons, icon);
            }            
         }

        public void deleteProvider(int idProvider)
        {
            try {
                ConnectionDB connection = new ConnectionDB();
                connection.openConnection();
                string command = $"DELETE FROM fornecedor WHERE idfornecedor = {idProvider};";
                connection.delete(command);
                message = "Fornecedor excluído com sucesso !!";
                caption = "Sucesso";
            }
            catch(Exception error)
            {
                Console.WriteLine(error.ToString());
                message = "Falha ao inserir novo fornecedor.";
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
