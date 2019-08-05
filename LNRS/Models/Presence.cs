using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LNRS.Models
{
    public class Presence
    {
        public int Id { get; set; }

        [Required]
        public string Email { get; set; }
        public DateTime StartTime { get; set; }
        public string CauseStart { get; set; }
        public DateTime EndTime { get; set; }
        public string CauseEnd { get; set; }

        //Navigations property
        public ICollection<ApplicationUserPresence> PresentUsers { get; set; }
    }
}
