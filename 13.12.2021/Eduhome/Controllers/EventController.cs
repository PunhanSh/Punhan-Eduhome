using Eduhome.EduHomeDbContext;
using Eduhome.Models;
using Eduhome.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eduhome.Controllers
{
    public class EventController : Controller
    {
        private readonly EduHomeDb _context;
        public EventController(EduHomeDb context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            HomeModel homemodels = new HomeModel();

            Setting setting = _context.Settings.FirstOrDefault();
            Subscribe subscribe = _context.Subscribes.FirstOrDefault();
            List<Social> socials = _context.Socials.ToList();

            homemodels.Setting = setting;
            homemodels.Subscribe = subscribe;
            homemodels.Socials = socials;
            return View(homemodels);
        }
    }
}
