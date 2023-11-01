using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySimpleTrader.Domain.Models
{
    public class Stock
    {
        public string symbole {  get; set; }

        public double priePerShare { get; set; }
    }
}
