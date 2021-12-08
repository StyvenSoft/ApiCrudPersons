using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCrudPersons.Models
{
    public class Person
    {
        public int Id { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public string lastName { get; set; }
        [Required]
        public string typeDocument { get; set; }
        [Required]
        public int numDocument { get; set; }
        [Required]
        public string address { get; set; }
        [Required]
        public char gender { get; set; }
        public DateTime createdAt { get; set; }
    }
}
