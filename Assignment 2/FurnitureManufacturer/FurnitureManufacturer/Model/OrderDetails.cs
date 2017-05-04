﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureManufacturer.Model
{
    public class OrderDetails
    {
        public int idOrder { get; set; }
        public int idProduct { get; set; }
        public int PriceUnit { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
    }
}