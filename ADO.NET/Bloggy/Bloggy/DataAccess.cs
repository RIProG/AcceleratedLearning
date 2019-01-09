using Bloggy.Domain;
using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bloggy
{
    public class DataAccess
    {

        private readonly string conString = "Server=(localdb)\\mssqllocaldb; Database=BlogPost";

        public List<BlogPost> GetAllBlogPostsBrief()
        {
            var sql = @"SELECT [Id], [Title], [Author], [PostContent], [DateTime] FROM BlogPost";

            using (SqlConnection connection = new SqlConnection(conString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                var list = new List<BlogPost>();

                while (reader.Read())
                {
                    var bp = new BlogPost
                    {
                        Id = reader.GetSqlInt32(0).Value,
                        Title = reader.GetSqlString(1).Value,
                        Author = reader.GetSqlString(2).Value,
                        PostContent = reader.GetSqlString(3).Value,
                        DateTime = reader.GetDateTime(4).Date,
                    };
                    list.Add(bp);
                }

                return list;
            }


            //var b1 = new BlogPost { Id = 1, Author = "Ali", Title = "Måndag igen" };
            //var b2 = new BlogPost { Id = 2, Author = "Sue", Title = "Inga julklappar" };
            //var b3 = new BlogPost { Id = 3, Author = "Markus", Title = "Lunch" };

            //var list = new List<BlogPost>
            //{
            //    b1,
            //    b2,
            //    b3
            //};

            //return new List<BlogPost>
            //{
            //    new BlogPost { Id = 1, Author = "Ali", Title = "Måndag igen" },
            //    new BlogPost { Id = 2, Author = "Sue", Title = "Inga julklappar" },
            //    new BlogPost { Id = 3, Author = "Markus", Title = "Lunch" }
            //};
        }

        public void UpdateBlogpost(BlogPost blogpost)
        {
            var sql = @"UPDATE BlogPost SET Title=@Title WHERE Id=@Id";
            using (SqlConnection connection = new SqlConnection(conString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();
                command.Parameters.Add(new SqlParameter("Id", blogpost.Id));
                command.Parameters.Add(new SqlParameter("Title", blogpost.Title));
                command.ExecuteNonQuery();
            }
        }

        public BlogPost GetPostById(int postId)
        {
            var sql = @"SELECT [Id], [Title], [Author], [PostContent], [DateTime] FROM BlogPost WHERE Id=@Id";
            using (SqlConnection connection = new SqlConnection(conString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();
                command.Parameters.Add(new SqlParameter("Id", postId));

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    var bp = new BlogPost
                    {
                        Id = reader.GetSqlInt32(0).Value,
                        Title = reader.GetSqlString(1).Value,
                        Author = reader.GetSqlString(2).Value,
                        PostContent = reader.GetSqlString(3).Value,
                        DateTime = reader.GetDateTime(4).Date,
                    };
                    return bp;
                }
                else
                {
                    throw new ArgumentException();
                }

            }
        }

        public void RemoveBlogPost(BlogPost blogpost)
        {
            var sql = @"DELETE FROM BlogPost WHERE Id=@Id";
            using (SqlConnection connection = new SqlConnection(conString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();
                command.Parameters.Add(new SqlParameter("Id", blogpost.Id));
                command.ExecuteNonQuery();
            }

        }

        public void AddBlogPost(BlogPost newBlogPost)
        {
            var sql = @"INSERT INTO BlogPost (Title, PostContent, Author, DateTime ) VALUES (@Title, @PostContent, @Author, @DateTime)";
            using (SqlConnection connection = new SqlConnection(conString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();
                command.Parameters.Add(new SqlParameter("Title", newBlogPost.Title));
                command.Parameters.Add(new SqlParameter("PostContent", newBlogPost.PostContent));
                command.Parameters.Add(new SqlParameter("Author", newBlogPost.Author));
                command.Parameters.Add(new SqlParameter("DateTime", newBlogPost.DateTime));
                command.ExecuteNonQuery();
            }
        }

        public void AddNewComment(Comment newComment)
        {
            var sql = @"INSERT INTO Comment (CommentTitle, Author, CommentText, DateTime, BlogPostId ) VALUES (@CommentTitle, @Author, @CommentText, @DateTime, @BlogPostId))";
            using (SqlConnection connection = new SqlConnection(conString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();
                command.Parameters.Add(new SqlParameter("CommentTitle", newComment.CommentTitle));
                command.Parameters.Add(new SqlParameter("Author", newComment.Author));
                command.Parameters.Add(new SqlParameter("CommentText", newComment.CommentText));
                command.Parameters.Add(new SqlParameter("DateTime", newComment.DateTime));
                command.Parameters.Add(new SqlParameter("BlogPostId", newComment.BlogPostId));
                command.ExecuteNonQuery();
            }
        }

        public void AddNewTag(Tag tag, int postId)
        {
            var sql = "SELECT TagName FROM Tag WHERE TagName=@TagName";
            var sql2 = "INSERT INTO Tag (TagName) VALUES (@TagName)";
            var sql3 = "INSERT INTO TagsToPosts VALUES (@TagName, @BlosPostId)";

            using (SqlConnection connection = new SqlConnection(conString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            using (SqlCommand command2 = new SqlCommand(sql2, connection))
            using (SqlCommand command3 = new SqlCommand(sql3, connection))
            {
                connection.Open();
                command.Parameters.Add(new SqlParameter("TagName", tag.TagName));

                SqlDataReader reader = command.ExecuteReader();

                bool tagExist = reader.Read();
                reader.Close();

                if (!tagExist)
                {
                    command2.Parameters.Add(new SqlParameter("TagName", tag.TagName));
                    command2.ExecuteNonQuery();
                }

                command3.Parameters.Add(new SqlParameter("TagName", tag.TagName));
                command3.Parameters.Add(new SqlParameter("BlogPostId", postId));

                try
                {
                    command3.ExecuteNonQuery();
                }

                catch (SqlException)
                {
                }

            }
        }

        public List<Comment> GetAllComments(int postId)
        {
            var sql = "SELECT Id, CommentTitle, CommentText, Author, DateTime FROM Comment WHERE BlogPostId=@BlogPostId";

            using (SqlConnection connection = new SqlConnection(conString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();
                command.Parameters.Add(new SqlParameter("BlogPostId", postId));
                SqlDataReader reader = command.ExecuteReader();

                var list = new List<Comment>();

                while (reader.Read())
                {
                    var c = new Comment
                    {
                        Id = reader.GetSqlInt32(0).Value,
                        CommentTitle = reader.GetSqlString(1).Value,
                        CommentText = reader.GetSqlString(2).Value,
                        Author = reader.GetSqlString(3).Value,
                        DateTime = reader.GetDateTime(4).Date,
                    };
                    list.Add(c);
                }

                return list;
            }
        }

        public void RemoveTag(string tagName, int postId)
        {
            var sql = "DELETE FROM TagsToPosts WHERE BlogPostId=@Id AND TagName=@tagName";
            using (SqlConnection connection = new SqlConnection(conString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();
                command.Parameters.Add(new SqlParameter("Id", postId));
                command.Parameters.Add(new SqlParameter("tagName", tagName));
                command.ExecuteNonQuery();
            }

        }

        public List<Tag> GetAllTags(int postId)
        {
            var sql = "SELECT TagName FROM TagsToPosts WHERE BlogPostId=@BlogPostId";

            using (SqlConnection connection = new SqlConnection(conString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();
                command.Parameters.Add(new SqlParameter("BlogPostId", postId));
                SqlDataReader reader = command.ExecuteReader();

                var list = new List<Tag>();

                while (reader.Read())
                {
                    var t = new Tag
                    {
                        TagName = reader.GetSqlString(0).Value,

                    };
                    list.Add(t);
                }

                return list;
            }
        }

        internal Comment GetCommentById(int commentId)
        {
            var sql = "SELECT Id, CommentTitle, CommentText, Author, DateTime FROM Comment WHERE Id=@Id";
            using (SqlConnection connection = new SqlConnection(conString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();
                command.Parameters.Add(new SqlParameter("Id", commentId));

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    var c = new Comment
                    {
                        Id = reader.GetSqlInt32(0).Value,
                        CommentTitle = reader.GetSqlString(1).Value,
                        CommentText = reader.GetSqlString(2).Value,
                        Author = reader.GetSqlString(3).Value,
                        DateTime = reader.GetDateTime(4).Date,
                    };
                    return c;
                }
                else
                {
                    throw new ArgumentException();
                }

            }
        }

        public void RemoveComment(Comment comment)
        {
            var sql = "DELETE FROM Comment WHERE Id=@Id";
            using (SqlConnection connection = new SqlConnection(conString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();
                command.Parameters.Add(new SqlParameter("Id", comment.Id));
                command.ExecuteNonQuery();
            }
        }
    }
}
