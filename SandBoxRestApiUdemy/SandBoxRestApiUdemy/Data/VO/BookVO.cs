﻿using System;
using System.Collections.Generic;
using Tapioca.HATEOAS;

namespace SandBoxRestApiUdemy.Data.VO
{
    public class BookVO : ISupportsHyperMedia
    {
        public int? Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime LaunchDate { get; set; }
        public decimal Price { get; set; }
        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();
    }
}
