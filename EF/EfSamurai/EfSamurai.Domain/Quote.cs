using System;
using System.Collections.Generic;
using System.Text;

namespace EfSamurai.Domain
{
    public class Quote
    {
        public int QuoteId { get; set; }
        public int SamuraiId { get; set; }
        public QuoteCategory Category { get; set; }
        public string Text { get; set; }
    }
}
