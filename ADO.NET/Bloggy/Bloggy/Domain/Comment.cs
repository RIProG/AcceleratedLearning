using System;
using System.Collections.Generic;
using System.Text;

namespace Bloggy.Domain
{
    public class Comment
    {
        public int Id { get; set; }
        public string CommentTitle { get; set; }
        public string CommentText { get; set; }
        public int BlogPostId { get; set; }
        public string Author { get; set; }
        public DateTime DateTime { get; set; }
    }
}
