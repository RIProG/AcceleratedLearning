﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EfSamurai.Domain
{
    public class QuoteCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Quote> QuotesInCategory { get; set; }
    }
}
