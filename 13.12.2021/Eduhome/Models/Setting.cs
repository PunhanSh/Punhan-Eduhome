using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Eduhome.Models
{
    public class Setting
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string QuestionPhone { get; set; }
        [MaxLength(250)]
        public string Logo { get; set; }
        [NotMapped]
        public IFormFile LogoFile { get; set; }
        [MaxLength(100)]
        public string Address { get; set; }
        [MaxLength(50)]
        public string Phone1 { get; set; }
        [MaxLength(50)]
        public string Phone2 { get; set; }
        [MaxLength(50)]
        public string Mail { get; set; }
        [MaxLength(50)]
        public string Website { get; set; }
        [MaxLength(50)]
        public string CopyrightName { get; set; }
        [MaxLength(100)]
        public string CopyrightLink { get; set; }
        [MaxLength(2000)]
        public string FooterContent { get; set; }
    }
}
