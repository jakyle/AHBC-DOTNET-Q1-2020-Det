using Startup_Forms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Startup_Forms.Services
{
    public interface IAllCapsContactService
    {
        void CapsAllProperties(ContactViewModel model);
        public void CapsEverOtherLetter(ContactViewModel model);
    }
}
