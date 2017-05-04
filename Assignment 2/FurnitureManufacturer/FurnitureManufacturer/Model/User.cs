using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureManufacturer.Model
{
    public class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }

        //public IList<Account> Accounts { get; set; }

        public string firstName { get; set; }
        public string lastName { get; set; }
    }
}
