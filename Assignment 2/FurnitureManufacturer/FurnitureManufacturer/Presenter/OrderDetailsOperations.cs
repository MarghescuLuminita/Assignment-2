using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FurnitureManufacturer.Model;

namespace FurnitureManufacturer.Presenter
{
    public class OrderDetailsOperations
    {
        public void AddProductToOrder(OrderDetails orderDetails)
        {
            DataAccess dal = new DataAccess();
            dal.AddProductToOrder(orderDetails);
        }

        public IList<OrderDetails> RetrieveOrderDetails()
        {
            IList<OrderDetails> listOrderDetails = new List<OrderDetails>();
            DataAccess dal = new DataAccess();
            listOrderDetails = dal.RetrieveOrderDetails();

            return listOrderDetails;
        }
    }
}
