using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySimpleTrader.Domain.Models
{
    public class User:DomainObject
    {
    

        public string userName { get; set; }

        public string email { get; set; }

        public string password { get; set; }

        public DateTime dateJoined { get; set; }
    }
}
