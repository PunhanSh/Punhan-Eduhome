using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Eduhome.Models
{
    public class CourseFeature
    {
        [Key]
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        [MaxLength(30)]
        public string Duration { get; set; }
        [MaxLength(30)]
        public string ClassDuration { get; set; }
        [MaxLength(30)]
        public string SkillLevel { get; set; }
        [MaxLength(30)]
        public string Language { get; set; }
        public int Student { get; set; }
        [MaxLength(30)]
        public string Assesment { get; set; }
        public int CoursePrice { get; set; }
        [ForeignKey("Course")]
        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}
