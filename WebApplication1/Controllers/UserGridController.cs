using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Areas.Identity;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Authorize]
    public class UserGridController : Controller
    {
        private UserManager<MyIdentityuser> userManager;
        private SignInManager<MyIdentityuser> signInManager;
        private readonly ILogger<HomeController> _logger;
        public UserGridController(UserManager<MyIdentityuser> userManager, ILogger<HomeController> logger,SignInManager<MyIdentityuser> signInManager)
        {
            this.userManager = userManager;
            _logger = logger;
            this.signInManager = signInManager;
        }
        public IActionResult Index()
        {
            if (CheckBan())
            {
                return RedirectToAction("Index", "UserGrid");
            }
            var users = userManager.Users;
            return View(users);
        }

        private bool CheckBan()
        {
            string currutenID = userManager.GetUserId(HttpContext.User);
            if (CheckState(currutenID))
            {
                signInManager.SignOutAsync();
                return true;
            }
            return false;
        }
        
        public async Task DeleteAsync(string[] values)
        {
            if (CheckBan()) return;
            for(int i=0;i<values.Length;i++)
            {
                var user = userManager.Users.FirstOrDefault(u => u.Id == values[i]);
                var result = await userManager.DeleteAsync(user);
            }
        }

        public async Task BlockAsync(string[] values)
        {
            if (CheckBan()) return;
            for (int i = 0; i < values.Length; i++)
            {
                var user = userManager.Users.FirstOrDefault(u => u.Id == values[i]);
                user.isBaned = true;
                var result = await userManager.UpdateAsync(user);
            }
        }

        public async Task UnblockAsync(string[] values)
        {
            if (CheckBan()) return;
            for (int i = 0; i < values.Length; i++)
            {
                var user = userManager.Users.FirstOrDefault(u => u.Id == values[i]);
                user.isBaned = false;
                var result = await userManager.UpdateAsync(user);
            }

        }

        public bool CheckState(string id)
        {
            var user = userManager.Users.FirstOrDefault(u => u.Id == id);
            if(user!=null)  
                return user.isBaned;
            return true;
        }
    }
}
