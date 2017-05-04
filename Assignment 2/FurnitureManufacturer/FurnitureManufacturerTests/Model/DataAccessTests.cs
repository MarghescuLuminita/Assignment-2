using Microsoft.VisualStudio.TestTools.UnitTesting;
using FurnitureManufacturer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureManufacturer.Model.Tests
{
    [TestClass()]
    public class DataAccessTests
    {
        [TestMethod()]
        public void AddProductTest()
        {
            Product p = new Product();

            p.Title = "noptiera";
            p.Description = "de noapte";
            p.Color = "alba";
            p.Size = 1;
            p.Price = 2;
            p.Stock = 2;
            IList<Product> list1 = new List<Product>();
            IList<Product> list2 = new List<Product>();

            DataAccess dal = new DataAccess();
            list1 = dal.RetrieveProducts();
            dal.AddProduct(p);
            list2 = dal.RetrieveProducts();
            Assert.AreNotEqual(list1, list2);
        }
    }
}