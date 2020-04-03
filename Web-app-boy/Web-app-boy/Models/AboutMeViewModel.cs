using System.Collections.Generic;

namespace Web_app_boy.Models
{
    public class AboutMeViewModel
    {
        public AboutMeViewModel(string name, string description, IEnumerable<string> hobbies)
        {
            Name = name;
            Description = description;
            Hobbies = hobbies;
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public IEnumerable<string> Hobbies { get; set; }
    }
}
