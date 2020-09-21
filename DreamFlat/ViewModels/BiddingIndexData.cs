﻿using DreamFlat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DreamFlat.ViewModels
{
    public class BiddingIndexData
    {
        public IEnumerable<Property> Properties { get; set; }
        public IEnumerable<Bidding> Biddings { get; set; }
        public IEnumerable<Bid> Bids { get; set; }

    }
}