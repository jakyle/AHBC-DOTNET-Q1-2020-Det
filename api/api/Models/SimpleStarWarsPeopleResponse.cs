using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class SimpleStarWarsPeopleResponse
    {
        public IEnumerable<SimplePerson> People { get; set; }
    }

    public class SimplePerson
    {
        public string Name { get; set; }
        public string HomeWorld { get; set; }
        public string BirthYear { get; set; }
        public IEnumerable<string> Films { get; set; }
    }
}
