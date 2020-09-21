using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DreamFlat.Models
{
    public class HomeTypeSubTypesViewModel
    {
        public OfType Type { get; set; }
        public List<OfSubType> SubTypes { get; set; }
    }
}