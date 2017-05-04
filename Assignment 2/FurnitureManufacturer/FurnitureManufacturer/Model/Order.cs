using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureManufacturer.Model
{
    public class Order
    {
        public int idOrder { get; set; }
        public string Customer { get; set; }
        public string ShippingAddress { get; set; }
        public int IdentificationNumber { get; set; }
        public DateTime DeliveryDate { get; set; }
        public string Status { get; set; }
    }
}