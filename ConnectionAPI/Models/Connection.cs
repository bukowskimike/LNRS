using System;
using System.ComponentModel.DataAnnotations;

namespace ConnectionAPI.Models
{
    public class Connection
    {
        public Guid Id { get; set; }

        [Display(Name = "Epost")]
        public string Email { get; set; }

        [Display(Name = "Status Inloggad")]
        public bool LoggedIn { get; set; }
    }
}
