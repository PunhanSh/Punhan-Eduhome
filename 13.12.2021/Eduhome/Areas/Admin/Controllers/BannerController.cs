using Eduhome.EduHomeDbContext;
using Eduhome.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eduhome.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BannerController : Controller
    {
        private readonly EduHomeDb _context;
        public BannerController(EduHomeDb context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Banner> model = _context.Banners.ToList();
            return View(model);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Banner model)
        {
            if (ModelState.IsValid)
            {
                _context.Banners.Add(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(model);
        }
        public IActionResult Update(int id)
        {
            return View(_context.Banners.Find(id));
        }

        [HttpPost]
        public IActionResult Update(Banner model)
        {
            if (ModelState.IsValid)
            {
                _context.Banners.Update(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(model);
        }
        public IActionResult Delete(int id)
        {
            Banner banner = _context.Banners.Find(id);
            _context.Banners.Remove(banner);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
