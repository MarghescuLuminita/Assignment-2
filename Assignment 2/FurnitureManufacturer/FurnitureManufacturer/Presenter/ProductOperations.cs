using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FurnitureManufacturer.Model;

namespace FurnitureManufacturer.Presenter
{
    public class ProductOperations
    {
        /**
        private readonly ProductOperations productOperations;

        public ProductOperations(DataAccess data)
        {
            this.productOperations= productOperations;
        }
    */
        public IList<Product> RetrieveProducts()
        {
            IList<Product> listProduct = new List<Product>();
            DataAccess dal = new DataAccess();
            listProduct = dal.RetrieveProducts();

            return listProduct;
        }

        public void AddProduct(Product product)
        {
            DataAccess dal = new DataAccess();
            dal.AddProduct(product);
        }

        public void UpdateProduct(Product product)
        {
            DataAccess dal = new DataAccess();
            dal.UpdateProduct(product);
        }

        public void DeleteProduct(Product product)
        {
            DataAccess dal = new DataAccess();
            dal.DeleteProduct(product);
        }


    }
}