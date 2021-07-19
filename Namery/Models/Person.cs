using System;
using System.ComponentModel.DataAnnotations;

namespace Namery.Models
{
    public class Person
    { 
        public int Id { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }
    }
}
