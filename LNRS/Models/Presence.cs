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

        [Required(ErrorMessage ="Ange Din e-post")]
        [Display(Name = "E-post")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Ange datum")]
        [DataType(DataType.DateTime)]
        [Display(Name = "Inloggad")]
        public DateTime StartTime { get; set; }

        [Display(Name = "Orsak (efter 0900)")]
        public string CauseStart { get; set; }

        [Required(ErrorMessage = "Ange datum")]
        [DataType(DataType.DateTime)]
        [Display(Name = "Utloggad")]
        public DateTime EndTime { get; set; }

        [Display(Name = "Orsak (före 1600)")]
        public string CauseEnd { get; set; }

        //Navigations property
        public ICollection<ApplicationUserPresence> PresentUsers { get; set; }
    }
}
