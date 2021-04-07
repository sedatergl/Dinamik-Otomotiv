using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SanalSatis.BLL.Abstract;
using SanalSatis.Entities.Concrete;
using SanalSatis.WebUI.Entities;
using SanalSatis.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SanalSatis.WebUI.Controllers
{
    public class AccountController : Controller
    {
        private IUserService _userManager;

        public AccountController(IUserService userManager)
        {
            _userManager = userManager;
        }

        public ActionResult Register()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginViewModel loginViewModel)
        {
            if (ModelState.IsValid)
            {
                User user = _userManager.GetByNameAndPassword(loginViewModel.UserName, loginViewModel.Password);

                if (user != null)
                {
                    return RedirectToAction("Index", "Admin");
                }

                ModelState.AddModelError("", "Invalid login!");
            }
            return View(loginViewModel);
        }
    }
}
