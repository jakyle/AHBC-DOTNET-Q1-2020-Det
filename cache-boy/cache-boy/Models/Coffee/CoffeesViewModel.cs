using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cache_boy.Models.Coffee
{
    public class CoffeesViewModel
    {
        public IEnumerable<CoffeeNameAndID> Coffees {get; set;}
    }
}
