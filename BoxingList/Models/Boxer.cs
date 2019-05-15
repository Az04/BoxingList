using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BoxingList.Models
{
    public class Boxer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Division { get; set; }
        public string Record { get; set; }
    }
}
