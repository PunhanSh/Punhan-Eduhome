using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Eduhome.Models
{
    public class Subscribe
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        public string Mail { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
