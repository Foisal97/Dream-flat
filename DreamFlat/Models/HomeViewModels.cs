using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DreamFlat.Models
{
    public class HomeViewModels
    {
        public IEnumerable<HomePropertyPhotoViewModel> FeaturePropertyPhoto { get; set; }
        public IEnumerable<HomeTypeSubTypesViewModel> TypeSubTypes { get; set; }
        public IEnumerable<HomeForViewModel> For { get; set; }
        public IEnumerable<HomeBiddingsViewModel> Biddings { get; set; }
        public IEnumerable<HomePropertyPhotoViewModel> PropertyPhoto { get; set; }
        public PagedList.IPagedList<HomePropertyPhotoViewModel> PropertyPhotoFilterable { get; set; }
        public IEnumerable<HomeRecentPhotoViewModel> RecentPropertyPhoto { get; set; }
        public IEnumerable<BiddingsPhotoViewModel> BiddingPropertyPhoto { get; set; }
    }
}