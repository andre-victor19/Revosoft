using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    class ClassProduct
    {
        List<Product> products = new List<Product>();

        public List<Product> getAllProducts()
        {
            ConnectionDB connection = new ConnectionDB();
            connection.openConnection();
            string command = $"SELECT * FROM produto;";
            MySqlDataReader result = connection.executeCommand(command);
            while (result.Read())
            {
                Product tempProduct = new Product(Convert.ToInt32(result[0]), result[1].ToString(), result[2].ToString(), result[3].ToString(), result[4].ToString(), Convert.ToInt32(result[5].ToString()), Convert.ToDouble(result[6].ToString()));
                products.Add(tempProduct);
            }
            return products;
        }

        public void saveProduct(Product product)
        {
            Product newProduct = new Product(product.idProduct, product.codProduct, product.category, product.model, product.description, product.quantity, product.valueProduct);
            Console.WriteLine(newProduct);
        }

    }
}
