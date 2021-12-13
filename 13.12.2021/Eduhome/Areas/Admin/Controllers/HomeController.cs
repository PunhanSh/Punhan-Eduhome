using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using Eduhome.EduHomeDbContext;
using System.Linq;
using System.Threading.Tasks;
using Eduhome.Models.ViewModels;

namespace Eduhome.Areas.Admin.Controllers
{
    [Area("Admin")] 
    public class HomeController : Controller
    {
        private readonly EduHomeDb _context;
        public HomeController(EduHomeDb context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            HomeModel model = new HomeModel()
            {
                Socials = _context.Socials.ToList(),
                Setting = _context.Settings.FirstOrDefault()
            };
            return View(model);
        }
    }
}
