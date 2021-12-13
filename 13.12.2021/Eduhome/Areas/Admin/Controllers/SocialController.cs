using Eduhome.EduHomeDbContext;
using Eduhome.Models;
using Eduhome.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eduhome.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class SocialController : Controller
    {
        private readonly EduHomeDb _context;
        public SocialController(EduHomeDb context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Social> model = _context.Socials.ToList();
            return View(model);
        }
        public IActionResult Create()
        {
            List<Social> model = _context.Socials.ToList();
            return View(model);
        }
        [HttpPost]
        public IActionResult Create(Social model)
        {
            return View(model);
        }
    }
}
