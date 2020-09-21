using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DreamFlat.Models
{
    public class SearchBiddingsPropertyPhViewModel
    {
        public PagedList.IPagedList<BiddingsPhotoViewModel> BiddingsPhotoPaged { get; set; }
        public PagedList.IPagedList<HomePropertyPhotoViewModel> PropertyPhotoPaged { get; set; }
    }
}