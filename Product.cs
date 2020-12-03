using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Product
    {
        public int idProduct { get; set; }
        public string codProduct { get; set; }
        public string category { get; set; }
        public string model { get; set; }
        public string description { get; set; }
        public int quantity { get; set; }
        public decimal valueProduct { get; set; }

        public Product() { }
        public Product(int tempIdProduct, string tempCodProduct, string tempCategory, string tempModel, string tempDescription, int tempQuantity, decimal tempValueProduct)
        {
            idProduct = tempIdProduct;
            codProduct = tempCodProduct;
            category = tempCategory;
            model = tempModel;
            description = tempDescription;
            quantity = tempQuantity;
            valueProduct = tempValueProduct;
        }
    }
}
