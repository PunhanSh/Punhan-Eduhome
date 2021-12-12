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
    public class CourseDetailsController : Controller
    {
        private readonly EduHomeDb _context;
        public CourseDetailsController(EduHomeDb context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            HomeModel homemodels = new HomeModel();

            Setting setting = _context.Settings.FirstOrDefault();
            Subscribe subscribe = _context.Subscribes.FirstOrDefault();
            List<Social> socials = _context.Socials.ToList();
            List<Course> courses = _context.Courses.ToList();
            List<CourseCategory> courseCategories = _context.CourseCategories.ToList();
            CourseContent courseContent = _context.CourseContents.FirstOrDefault();
            CourseFeature courseFeature = _context.CourseFeatures.FirstOrDefault();
            List<CourseMessage> courseMessages = _context.CourseMessages.ToList();
            List<Tag> tags = _context.Tags.ToList();
            List<TagToCourse> tagToCourses = _context.TagToCourses.ToList();

            homemodels.Setting = setting;
            homemodels.TagToCourses = tagToCourses;
            homemodels.Tags = tags;
            homemodels.CourseMessages = courseMessages;
            homemodels.CourseFeature = courseFeature;
            homemodels.CourseContent = courseContent;
            homemodels.CourseCategories = courseCategories;
            homemodels.Courses = courses;
            homemodels.Subscribe = subscribe;
            homemodels.Socials = socials;
            return View(homemodels);
        }
    }
}
