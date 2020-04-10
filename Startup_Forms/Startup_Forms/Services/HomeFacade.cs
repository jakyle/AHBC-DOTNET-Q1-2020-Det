using Startup_Forms.Models;

namespace Startup_Forms.Services
{
    public class HomeFacade : IHomeFacade
    {
        private readonly IAllCapsContactService _allCapsContactService;

        public HomeFacade(IAllCapsContactService allCapsContactService)
        {
            _allCapsContactService = allCapsContactService;
        }

        public ContactDetailsViewModel Map(ContactViewModel model)
        {
            var viewModel = new ContactDetailsViewModel();
            _allCapsContactService.CapsAllProperties(model);
            viewModel.Name = model.Name;
            viewModel.PhoneNumber = model.PhoneNumber;
            viewModel.EmailAddress = model.EmailAddress;
            return viewModel;
        }

    }
}
