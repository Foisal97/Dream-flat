using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DreamFlat.Models
{
    public class DetailsReviewRepliesViewModel
    {
        public Review Review { get; set; }
        public List<Reply> Replies { get; set; }
    }
}