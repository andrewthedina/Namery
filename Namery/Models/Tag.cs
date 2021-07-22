using System;
using System.ComponentModel.DataAnnotations;

namespace Namery.Models
{
    public class Tag
    {
        [Key]
        public int TagId { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }
    }
}
