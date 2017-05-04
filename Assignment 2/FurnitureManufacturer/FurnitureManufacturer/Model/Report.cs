using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureManufacturer.Model
{
    public class Report
    {
        public int idReport { get; set; }
        public string Customer { get; set; }
        public int addOp { get; set; }
        public int updateOp { get; set; }
        public int viewOp { get; set; }
        public DateTime date { get; set; }
    }
}
