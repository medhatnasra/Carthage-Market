using Carthage_Market.Models;
using Carthage_Market.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Carthage_Market.Services
{
    public class AccountService : IAccountService
    {
        private readonly UserManager<ApplicationUser> _userManager;

        private readonly SignInManager<ApplicationUser> _signInManager;

        public AccountService(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signinManager)
        {
            _userManager = userManager;
            _signInManager = signinManager;
        }
        public async Task<IdentityResult> AddUser(RegisterViewModel model)
        {
            ApplicationUser User = new ApplicationUser
            {
                Email = model.Email,
                UserName = model.Email
            };

            return await _userManager.CreateAsync(User,model.Password);

         
        }

        public async Task<SignInResult> LoginUser(LoginViewModel model)
        {
            return await _signInManager.PasswordSignInAsync(model.Email, model.Password, false, false); 
        }

        public async Task LogoutUser()
        {
            await _signInManager.SignOutAsync();            
        }
    }
}
