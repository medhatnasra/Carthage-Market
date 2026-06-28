using Carthage_Market.Models.ViewModels;
using Microsoft.AspNetCore.Identity;

namespace Carthage_Market.Services
{
    public interface IAccountService
    {
        public Task<IdentityResult> AddUser(RegisterViewModel model); 


        public Task<SignInResult> LoginUser(LoginViewModel model);

        public Task LogoutUser(); 
   
    }
}
