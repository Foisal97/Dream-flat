using IdentitySample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DreamFlat.Models
{
    public class ControlDeskActiveDE
    {
        // Count Developers Team - Online Developers
        public int DevelopersCount { get; set; }
        public List<ApplicationUser> Developers { get; set; }

        // SELECT COUNT(*) from information_schema.tables WHERE table_type = 'base table') 
        public int APIsDoc { get; set; }
        // SP_SPACEUSED
        public string DBSize { get; set; }
   }
}