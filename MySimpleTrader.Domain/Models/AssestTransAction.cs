using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySimpleTrader.Domain.Models
{
    public class AssestTransAction:DomainObject
    {
     
        public Account account { get; set; }
        public bool isPurchase { get; set; }

        public Stock Stock { get; set; }

        public int shares { get; set; }

        public DateTime dateProcess { get; set; }

    }
}
