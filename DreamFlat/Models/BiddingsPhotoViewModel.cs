using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DreamFlat.Models
{
    public class BiddingsPhotoViewModel
    {
        public Bidding Bidding { get; set; }
        public Property Property { get; set; }
        public OfSubType OfSubType { get; set; }
        public Photo Photo { get; set; }
    }
}