using Allup.DAL;
using Allup.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Allup.Areas.Admin.Controllers
{
    [Area("admin")]
    public class UserController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public UserController(UserManager<User> userManager, SignInManager<User> signInManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }

        public IActionResult Index()
        {
            var users = _userManager.Users.Include(u=>u.Orders).ToList();

            return View(users);

        }

        public async Task<IActionResult> Update(string id)
        {
            User user = await _userManager.FindByIdAsync(id);

            if (user == null) return NotFound();

            var userRoles = await _userManager.GetRolesAsync(user);


            var roles = await _roleManager.Roles.ToListAsync();

            ViewBag.Userroles = userRoles;
            ViewBag.roles = roles;

            return View(user);
        }

    }
}
