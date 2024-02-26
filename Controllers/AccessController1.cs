using Microsoft.AspNetCore.Mvc;

using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace ToDoList.Controllers
{
    public class AccessController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
