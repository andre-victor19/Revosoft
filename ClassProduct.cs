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
    class ClassProduct
    {
        List<Product> products = new List<Product>();
        MessageBoxButtons buttons = MessageBoxButtons.OK;
        MessageBoxIcon icon = MessageBoxIcon.Information;
        private string message { get; set; }
        private string caption { get; set; }
        public List<Product> getAllProducts()
        {
            products.Clear();
            ConnectionDB connection = new ConnectionDB();
            connection.openConnection();
            string command = $"SELECT * FROM produto;";
            MySqlDataReader result = connection.select(command);
            while (result.Read())
            {
                Product tempProduct = new Product(Convert.ToInt32(result[0]), result[1].ToString(), result[2].ToString(), result[3].ToString(), result[4].ToString(), Convert.ToInt32(result[5].ToString()), Convert.ToDecimal(result[6].ToString()));
                products.Add(tempProduct);
            }
            connection.closeConnection();
            return products;
        }

        public void saveProduct(Product product)
        {
            try {
                ConnectionDB connection = new ConnectionDB();
                connection.openConnection();
                string newValue = product.valueProduct.ToString().Replace(',', '.');
                string command = $"INSERT INTO produto (idproduto, codProduto, categoria, modelo, descricao, quantidade, valorProduto, criado) VALUES (null,'{product.codProduct}', '{product.category}', '{product.model}', '{product.description}', {product.quantity}, {newValue}, NOW());";
                connection.insert(command);
                message = "Produto inserido com sucesso !!";
                caption = "Sucesso";
            }
            catch(Exception err)
            {
                Console.WriteLine(err.ToString());
                message = "Falha ao inserir novo produto.";
                caption = "Falha";
                icon = MessageBoxIcon.Error;
            }
            finally
            {
                MessageBox.Show(message, caption, buttons, icon);
            }
            
        }

        public void updateProduct(Product product)
        {
            try {
                ConnectionDB connection = new ConnectionDB();
                connection.openConnection();
                string newValue = product.valueProduct.ToString().Replace(',', '.');
                string command = $"UPDATE produto SET codProduto = '{product.codProduct}', categoria = '{product.category}', modelo = '{product.model}', descricao = '{product.description}', quantidade = {product.quantity}, valorProduto = {newValue}, modificado = NOW() WHERE idproduto = {product.idProduct};";
                connection.update(command);
                message = "Produto atualizado com sucesso !!";
                caption = "Sucesso";
            }
            catch(Exception error) {
                Console.WriteLine(error.ToString());
                message = "Falha ao atualizar produto.";
                caption = "Falha";
                icon = MessageBoxIcon.Error;
            }
            finally {
                MessageBox.Show(message, caption, buttons, icon);
            }
        }

        public void deleteProduct(int idProduct)
        {
            try {
                ConnectionDB connection = new ConnectionDB();
                connection.openConnection();
                string command = $"DELETE FROM produto WHERE idproduto = {idProduct};";
                connection.delete(command);
                message = "Produto excluído com sucesso !!";
                caption = "Sucesso";
            }
            catch(Exception error)
            {
                Console.WriteLine(error.ToString());
                message = "Falha ao inserir novo produto.";
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
