﻿using System;
using System.Collections.Generic;
using UTB.Eshop.Web.Models.Entities;
using UTB.Eshop.Web.Models.Identity;

namespace UTB.Eshop.Web.Models.ViewModels
{
    public class HomeIndexViewModel
    {
        public IList<CarouselItem> CarouselItems { get; set; }
        public IList<Product> Products { get; set; }

        public IList<Coupon> Coupons { get; set; }
        public IList<User> Users { get; set; }

        public IList<Group> Groups { get; set; }
    }
}