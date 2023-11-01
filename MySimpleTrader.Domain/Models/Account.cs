using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySimpleTrader.Domain.Models
{
    public class Account:DomainObject
    {
       
        public User accountHolder { get; set; }

        public double Balance { get; set; }

        public IEnumerable<AssestTransAction> assestTransActions { get; set; }
    }
}
