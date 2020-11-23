using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Product
    {
        public int idProduct = 0;
        public string codProduct = "";
        public string category = "";
        public string model = "";
        public string description = "";
        public int quantity = 1;
        public double valueProduct = 0;

        public Product() { }
        public Product(int tempIdProduct, string tempCodProduct, string tempCategory, string tempModel, string tempDescription, int tempQuantity, double tempValueProduct)
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
