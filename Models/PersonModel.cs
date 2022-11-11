using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models
{
    public class PersonModel
    {
        [Required]
        public string FirstName { get; set; }

        public string? MiddleName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Email { get; set; }

        public Person ToPerson()
        {
            Person result = new Person();

            result.FirstName = this.FirstName;
            result.MiddleName = this.MiddleName;
            result.LastName = this.LastName;
            result.Email = this.Email;
            return result;
        }

    }
}
