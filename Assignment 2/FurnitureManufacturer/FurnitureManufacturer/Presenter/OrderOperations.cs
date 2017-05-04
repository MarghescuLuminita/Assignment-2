using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FurnitureManufacturer.Presenter;
using FurnitureManufacturer.Model;

namespace FurnitureManufacturer.Presenter
{
    public class OrderOperations
    {
        public void AddOrder(Order order)
        {
            DataAccess dal = new DataAccess();
            dal.AddOrder(order);
        }

        public void UpdateOrder(Order order)
        {
            DataAccess dal = new DataAccess();
            dal.UpdateOrder(order);
        }

        public IList<Order> RetrieveOrders()
        {
            IList<Order> listOrder = new List<Order>();
            DataAccess dal = new DataAccess();
            listOrder = dal.RetrieveOrders();

            return listOrder;
        }
    }
}