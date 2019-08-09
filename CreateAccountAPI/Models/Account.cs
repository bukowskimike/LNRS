using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AccountAPI.Models
{
    public class Account
    {
        public Guid Id { get; set; }

        [Required]
        [Display(Name = "För-/efternamn")]
        public string Name { get; set; }

        [Required]
        [Display(Name="Användarnamn")]
        public string UserName { get; set; }

        [Required]
        [Display(Name = "Epost")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Lösenord")]
        public string Password { get; set; }
    }
}
