using System.Diagnostics;
using Lecture49.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lecture49.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }
    }
}
