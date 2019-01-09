using System;
using System.Collections.Generic;
using System.Text;

namespace Bloggy.Domain
{
    public class BlogPost
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string PostContent { get; set; }
        public DateTime DateTime { get; set; }
    }
}
