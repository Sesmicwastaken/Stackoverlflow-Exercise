using System.Text;

namespace StackOverflow
{
    public class Stackoverflow
    {

        private static readonly List<Post> _posts = new();

        public static Post StorePosts
        {
            set
            {
                _posts.Add(value);
            }
        }
        public static int TotalPosts
        {
            get
            {
                return _posts.Count;
            }

        }

        public static void ShowPost(int postID)
        {
            if (postID - 1 >= _posts.Count)
            {
                throw new NullReferenceException("\nPost Id is Invalid.");
            }
            StringBuilder PostFormat = new();
            PostFormat.Append("\nTitle: " + _posts[postID - 1].PostTitle).AppendLine().AppendLine();
            PostFormat.Append("Asked: " + _posts[postID - 1].PostCreationTime).AppendLine().AppendLine();
            PostFormat.Append("Description: " + _posts[postID - 1].PostDiscription).AppendLine().AppendLine();
            PostFormat.Append("Votes: " + _posts[postID - 1].NoOfVotes);
            Console.WriteLine(PostFormat);
        }
    }
}
