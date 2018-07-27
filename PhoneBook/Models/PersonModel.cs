using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneBook.Models
{
    public class PersonModel
    {
        [Required]
        public int ID { get; set; }

        [Required]
        [MaxLength(32)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(64)]
        public string LastName { get; set; }

        [Required]
		[MaxLength(25)]
        public string Phone { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public DateTime? Created { get; set; }

        public DateTime? Updated { get; set; }

    }
}
