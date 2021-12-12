using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Eduhome.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("CourseCategory")]
        public int CategoryId { get; set; }
        public CourseCategory CourseCategory { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(500)]
        public string Content { get; set; }
        [MaxLength(250)]
        public string Image { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
        public List<CourseFeature> CourseFeatures { get; set; }
        public List<CourseContent> CourseContents { get; set; }
        public List<TagToCourse> TagToCourses { get; set; }
    }
}
