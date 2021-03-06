﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace doremi.Controllers
{
    [Authorize(Roles = Pages.MainMenu.Event.RoleName)]
    public class EventController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}