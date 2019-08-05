using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LNRS.Models
{
    //kopplingstabell för många till många relationen mellan Presence och ApplicationUser
    public class ApplicationUserPresence
    {
        //Composit keys
        public int Id { get; set; }
        public int PresenceId { get; set; }
        public int ApplicationUserId { get; set; }

        //Navigation properties
        public ApplicationUser ApplictionUser { get; set; }
        public Presence Presence { get; set; }
    }
}
