using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DreamFlat.Models
{
    public class ControlDeskActiveDEPropertyViewModels
    {
        public ControlDeskActiveDE ControlDeskActiveDE { get; set; }
        public IEnumerable<Property> Properties { get; set; }
    }
}