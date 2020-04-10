using Startup_Forms.Models;

namespace Startup_Forms.Services
{
    public interface IHomeFacade
    {
        ContactDetailsViewModel Map(ContactViewModel model);
    }
}
