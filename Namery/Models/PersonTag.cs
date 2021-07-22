using System;
using System.ComponentModel.DataAnnotations;

namespace Namery.Models
{
    public class PersonTag
    {
        public int PersonId { get; set; }
        public Person Person { get; set; }

        public int TagId { get; set; }
        public Tag Tag { get; set; }
    }
}
