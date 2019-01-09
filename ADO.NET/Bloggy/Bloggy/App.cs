using Bloggy.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bloggy
{
    public class App
    {
        DataAccess dataAccess = new DataAccess();

        public void Run()
        {
            while (true)
            {
                PageMainMenu();
            }
        }

        private void ShowAllBlogPosts()
        {

            List<BlogPost> list = dataAccess.GetAllBlogPostsBrief();

            foreach (var post in list)
            {
                WriteLine($"{post.Id}\t{post.Title.PadRight(40)}{post.Author.PadRight(10)}{post.DateTime}");
                WriteLine($"\t{post.PostContent}");
            }
            WriteLine();
            Console.ReadKey();
        }

        private void PageUpdatePost()
        {
            Console.Clear();
            Header("Uppdatera bloggpost");
            ShowAllBlogPosts();
            WriteLine("Vilken bloggpost vill du uppdatera?");
            int postId = int.Parse(Console.ReadLine());
            WriteLine();

            BlogPost blogpost = dataAccess.GetPostById(postId);

            WriteLine("Vad vill du ändra i inlägget?");
            WriteLine("a) Titeln");
            WriteLine("b) Innehållet");
            WriteLine("c) Författarnamnet");
            ConsoleKey command = Console.ReadKey(true).Key;

            if (command == ConsoleKey.A)
            {
                WriteLine("Den nuvarande titeln är: " + blogpost.Title);

                WriteLine("Skriv in ny titel: ");

                string newTitle = Console.ReadLine();

                blogpost.Title = newTitle;

                dataAccess.UpdateBlogpost(blogpost);

                WriteLine("Bloggposten uppdaterad.");
                Console.ReadKey();
                PageMainMenu();

            }
            if (command == ConsoleKey.B)
            {
                WriteLine("Det nuvarande innehållet är: " + blogpost.PostContent);

                WriteLine("Skriv nytt innehåll: ");

                string newContent = Console.ReadLine();

                blogpost.PostContent = newContent;

                dataAccess.UpdateBlogpost(blogpost);

                WriteLine("Bloggposten uppdaterad.");
                Console.ReadKey();
                PageMainMenu();
            }
            if (command == ConsoleKey.C)
            {
                WriteLine("Den nuvarande författaren är: " + blogpost.Author);

                WriteLine("Skriv in ny författare: ");

                string newAuthor = Console.ReadLine();

                blogpost.Author = newAuthor;

                dataAccess.UpdateBlogpost(blogpost);

                WriteLine("Bloggposten uppdaterad.");
                Console.ReadKey();
                PageMainMenu();
            }

        }

        private void PageMainMenu()
        {
            Console.Clear();
            WriteLine();
            Header("Huvudmeny");

            WriteLine("Vad vill du göra?");
            WriteLine("a) Se alla blogginlägg");
            WriteLine("b) Uppdatera en bloggpost");
            WriteLine("c) Kommentera eller ta bort en kommentar");
            WriteLine("d) Tagga eller ta bort en tagg");
            WriteLine("e) Lägga till ett blogginlägg");
            WriteLine("f) Ta bort ett blogginlägg");
            ConsoleKey command = Console.ReadKey(true).Key;

            if (command == ConsoleKey.A)
            {
                WriteLine();
                ShowAllBlogPosts();
            }
            if (command == ConsoleKey.B)
            {
                PageUpdatePost();
            }
            if (command == ConsoleKey.C)
            {
                CommentMenu();
            }
            if (command == ConsoleKey.D)
            {
                TagMenu();
            }
            if (command == ConsoleKey.E)
            {
                AddPost();
            }
            if (command == ConsoleKey.F)
            {
                RemovePost();
            }
        }

        public void AddPost()
        {
            Header("Lägg till blogginlägg");
            ShowAllBlogPosts();

            BlogPost newBlogPost = new BlogPost();

            WriteLine("Skriv en titel på det nya inlägget: ");
            newBlogPost.Title = Console.ReadLine();
            WriteLine("Skriv innehåll i det nya inlägget");
            newBlogPost.PostContent = Console.ReadLine();
            WriteLine("Vem är författare till inlägget?");
            newBlogPost.Author = Console.ReadLine();
            newBlogPost.DateTime = DateTime.Now;

            dataAccess.AddBlogPost(newBlogPost);

        }

        public void RemovePost()
        {
            Header("Radera blogginlägg");
            ShowAllBlogPosts();
            WriteLine("Vilket inlägg vill du radera?");
            int postId = int.Parse(Console.ReadLine());
            WriteLine();

            BlogPost blogpost = dataAccess.GetPostById(postId);

            dataAccess.RemoveBlogPost(blogpost);
        }

        public void TagMenu()
        {
            Header("Hantera taggar");
            ShowAllBlogPosts();
            WriteLine("Vad vill du göra?");
            WriteLine("a) Tagga ett inlägg");
            WriteLine("b) Ta bort en tag från ett inlägg");
            ConsoleKey command = Console.ReadKey(true).Key;

            if (command == ConsoleKey.A)
            {
                WriteLine("Vilket inlägg vill du tagga?");
                int postId = int.Parse(Console.ReadLine());
                BlogPost blogpost = dataAccess.GetPostById(postId);

                WriteLine("Skriv den nya tya taggen: ");
                string newTag = Console.ReadLine();
                Tag tag = new Tag();
                tag.TagName = newTag;

                dataAccess.AddNewTag(tag, postId);

                WriteLine("Tag tillagd.");
                Console.ReadKey();
                PageMainMenu();

            }

            if (command == ConsoleKey.B)
            {
                WriteLine("Från vilket inlägg vill du ta bort en tag?");
                int postId = int.Parse(Console.ReadLine());
                BlogPost blogpost = dataAccess.GetPostById(postId);

                List<Tag> list = dataAccess.GetAllTags(postId);
                WriteLine("Inlägget har följande taggar: ");

                foreach (var tagItem in list)
                    WriteLine($"{tagItem.TagName}");

                WriteLine("Vilken tag vill du ta bort?");
                string tagName = Console.ReadLine();

                dataAccess.RemoveTag(tagName, postId);

                WriteLine("Tag borttagen.");
                Console.ReadKey();
                PageMainMenu();
            }

        }

        public void CommentMenu()
        {
            Header("Hantera kommentarer");
            WriteLine("Vad vill du göra?");
            WriteLine("a) Kommentera ett inlägg");
            WriteLine("b) Ta bort en kommentar");
            ConsoleKey command = Console.ReadKey(true).Key;
            WriteLine();

            if (command == ConsoleKey.A)
            {
                ShowAllBlogPosts();
                WriteLine("Vilket inlägg vill du kommentera?");
                int postId = int.Parse(Console.ReadLine());
                BlogPost blogpost = dataAccess.GetPostById(postId);

                Comment newComment = new Comment();

                WriteLine("Skriv en rubrik på kommentaren: ");
                newComment.CommentTitle = Console.ReadLine();
                WriteLine("Skriv författarnamn till kommentaren: ");
                newComment.Author = Console.ReadLine();
                WriteLine("Skriv den nya kommentaren: ");
                newComment.CommentText = Console.ReadLine();
                newComment.DateTime = DateTime.Now;
                newComment.BlogPostId = blogpost.Id;

                dataAccess.AddNewComment(newComment);

                WriteLine("Kommentar tillagd.");
                Console.ReadKey();
                PageMainMenu();

            }

            if (command == ConsoleKey.B)
            {
                ShowAllBlogPosts();
                WriteLine("I vilket inlägg vill du ta bort en kommentar?");
                int postId = int.Parse(Console.ReadLine());
                BlogPost blogpost = dataAccess.GetPostById(postId);

                List<Comment> list = dataAccess.GetAllComments(postId);

                foreach (var post in list)
                {
                    WriteLine($"{post.Id}\t{post.CommentTitle.PadRight(40)}{post.Author.PadRight(10)}{post.DateTime}");
                    WriteLine($"\t{post.CommentText}");
                }

                WriteLine("Vilken kommentar vill du ta bort?");
                int commentId = int.Parse(Console.ReadLine());

                Comment comment = dataAccess.GetCommentById(commentId);

                dataAccess.RemoveComment(comment);

                WriteLine("Kommentar borttagen.");
                Console.ReadKey();
                PageMainMenu();

            }

        }

        public void Header(string x)
        {
            Console.Clear();
            WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(x.ToUpper());
            Console.ResetColor();
            Console.WriteLine();
        }

        public void WriteLine(string text = "")
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}
