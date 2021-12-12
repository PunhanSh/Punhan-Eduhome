using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eduhome.Models.ViewModels
{
    public class HomeModel
    {
        public Setting Setting { get; set; }
        public Subscribe Subscribe { get; set; }
        public List<Social> Socials { get; set; }
        public Banner Banner { get; set; }
        public List<Course> Courses { get; set; }
        public List<CourseCategory> CourseCategories { get; set; }
        public CourseContent CourseContent { get; set; }
        public CourseFeature CourseFeature { get; set; }
        public List<CourseMessage> CourseMessages { get; set; }
        public List<Tag> Tags { get; set; }
        public List<TagToCourse> TagToCourses { get; set; }

    }
}
