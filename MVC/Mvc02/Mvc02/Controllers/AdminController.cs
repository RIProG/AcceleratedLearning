using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Mvc02.Models.ViewModels;
using Mvc02.Services;

namespace Mvc02.Controllers
{

    public class AdminController : Controller
    {
        private readonly AuthService _auth;

        public AdminController(AuthService auth)
        {
            _auth = auth;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> AddRoleForUser(AddRoleVm addrole)
        {

            bool userExist = await _auth.UserExist(addrole.Email);

            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("UserDontExist", $"User with email {addrole.Email} does not exist");
                return View("Index");
            }

            bool roleExist = await _auth.RoleExist(addrole.RoleName);

            if (roleExist == false)
            {
                await _auth.CreateRole(addrole.RoleName);
            }

            await _auth.AddRoleToUser(addrole.Email, addrole.RoleName);

            return View("SuccessAddRole");
        }

    }
}