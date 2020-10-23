using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AuthSystem.Controllers
{
    public class UserRegistrationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
