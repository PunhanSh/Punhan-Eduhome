using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Eduhome.Models
{
    public class CourseContent
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        public string FirstHead { get; set; }
        [MaxLength(1000)]
        public string FirstTitle { get; set; }
        [MaxLength(100)]
        public string SecondHead { get; set; }
        [MaxLength(1000)]
        public string SecondTitle { get; set; }
        [MaxLength(100)]
        public string ThirdHead { get; set; }
        [MaxLength(1000)]
        public string ThirdTitle { get; set; }
        [ForeignKey("Course")]
        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}
