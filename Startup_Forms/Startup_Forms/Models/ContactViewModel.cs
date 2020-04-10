using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Startup_Forms.Models
{
    public class ContactViewModel 
    {
        [Required]
        [StringLength(50, ErrorMessage = "Invalid name ya shmuck!", MinimumLength = 2)]
        public string Name { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "that email is no good here sir")]
        public string EmailAddress { get; set; }

        [Required]
        [Phone(ErrorMessage = "not a phone number...")]
        public string PhoneNumber { get; set; }

        public string ErrorMessage { get; set; }
    }
}
