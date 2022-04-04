namespace StackOverflow;

public class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Post post = new();

            Console.Write("Enter the Post Title: ");
            post.PostTitle = Console.ReadLine();

            Console.Write("Enter the Post Discription: ");
            post.PostDescription = Console.ReadLine();

            Console.Write("Enter the post creation date: ");
            post.PostCreationTime = Convert.ToDateTime(Console.ReadLine());


            Stackoverflow.StorePosts = post;

            Console.Write("\nNo. of posts: " + Stackoverflow.TotalPosts);




            Console.WriteLine("\n\nWhich post do you wish to see?");
            int postID = Convert.ToInt32(Console.ReadLine());


            Stackoverflow.ShowPost(postID);
            while (true)
            {
                Console.WriteLine("\nUpvote and Downvote? (Enter \"No\" if you don't want to)");
                string input = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(input))
                {
                    throw new ArgumentNullException(input);
                }

                if (input.Trim().ToLower() == "upvote" || input.Trim().ToLower() == "downvote")
                {
                    post.UpvoteDownVote(input.Trim().ToLower());
                    Console.Clear();
                    Stackoverflow.ShowPost(postID);
                }
                else if (input.Trim().ToLower() == "no")
                {
                    break;
                }


            }

            Console.WriteLine("\nDo you wish to add more posts? (\"Yes\" or \"No\")");
            string input2 = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(input2))
            {
                throw new ArgumentNullException(input2);
            }
            if (input2.Trim().ToLower() == "yes")
            {
                Console.Clear();
                continue;
            }
            else if (input2.Trim().ToLower() == "no")
            {
                return;
            }

        }


    }
}
