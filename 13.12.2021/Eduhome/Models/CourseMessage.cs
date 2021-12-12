using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Eduhome.Models
{
    public class CourseMessage
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        public string SupTitle { get; set; }
        [MaxLength(1000)]
        public string Title { get; set; }
        [MaxLength(50)]
        public string? Name { get; set; }
        [MaxLength(50)]
        public string? Mail { get; set; }
        [MaxLength(500)]
        public string? Subject { get; set; }
        [MaxLength(2000)]
        public string? Message { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
