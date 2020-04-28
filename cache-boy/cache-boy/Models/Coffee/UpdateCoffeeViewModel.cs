using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cache_boy.Models.Coffee
{
    public class UpdateCoffeeViewModel
    {
        public int ID { get; set; }
        public string OldName { get; set; }
        public string NewName { get; set; }
        public string OldDescription { get; set; }
        public string NewDescription { get; set; }
        public double OldPrice { get; set; }
        public double NewPrice { get; set; }

    }
}
