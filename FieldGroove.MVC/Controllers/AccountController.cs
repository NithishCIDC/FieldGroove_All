﻿using Microsoft.AspNetCore.Mvc;

namespace FieldGroove.MVC.Controllers
{
    public class AccountController : Controller
    {

		public IActionResult Index()
		{
			return RedirectToAction("Login");
		}
		public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }
    }
}
