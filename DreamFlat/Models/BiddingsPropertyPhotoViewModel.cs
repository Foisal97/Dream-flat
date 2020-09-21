using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DreamFlat.Models
{
    public class BiddingsPropertyPhotoViewModel
    {
        public PagedList.IPagedList<BiddingsPhotoViewModel> BiddingsPhotoPaged { get; set; }
    }
}