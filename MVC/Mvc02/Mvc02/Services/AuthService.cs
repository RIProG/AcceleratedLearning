using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Mvc02.Services
{
    public class AuthService
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AuthService(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager, SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
        }

        public async Task<bool> UserExist(string email)
        {
            IdentityUser user = await _userManager.FindByEmailAsync(email);
            return user != null;
        }

        public async Task<bool> RoleExist(string roleName)
        {
            IdentityRole role = await _roleManager.FindByNameAsync(roleName);
            return role != null;
        }

        public async Task CreateRole(string roleName)
        {
            IdentityResult roleResult;
            roleResult = await _roleManager.CreateAsync(new IdentityRole(roleName));
        }

        public async Task AddRoleToUser(string email, string roleName)
        {
            IdentityUser user = await _userManager.FindByEmailAsync(email);
            await _userManager.AddToRoleAsync(user, roleName);
        }

    }
}