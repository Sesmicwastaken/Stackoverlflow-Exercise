namespace StackOverflow
{
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                var post = new Post();

                Console.Write("Enter the Post Title: ");
                post.PostTitle = Console.ReadLine();

                Console.Write("Enter the Post Discription: ");
                post.PostDiscription = Console.ReadLine();

                Console.Write("Enter the post creation date: ");
                post.PostCreationTime = Convert.ToDateTime(Console.ReadLine());


                Stackoverflow.StorePosts = post;

                Console.Write("\nNo. of posts: " + Stackoverflow.TotalPosts);


                Console.WriteLine("\n\nWhich post do you wish to see?");
                int postId = Convert.ToInt32(Console.ReadLine());


                Stackoverflow.ShowPost(postId);
                while (true)
                {
                    Console.WriteLine("\nUpvote and Downvote? (Enter \"No\" if you don't want to)");
                    string input = Console.ReadLine();

                    //if (string.IsNullOrWhiteSpace(input)) throw new ArgumentNullException(input);

                    if (!PostHelper.IsValid(input))
                  {
                        post.UpVoteDownVote(input.Trim().ToLower());
                        Console.Clear();
                        Stackoverflow.ShowPost(postId);
                  }
                    else if (input.Trim().ToLower() == "no")
                    {
                        break;
                    }
                    else { throw new Exception($"Invalid Input: {input}"); }

                }

                Console.WriteLine("\nDo you wish to add more posts? (\"Yes\" or \"No\")");
                string input2 = Console.ReadLine();
                if (!String.IsNullOrWhiteSpace(input2) )
                {
                    switch (Normalize.NormalizedInput(input2))
                    {
                        case "yes":
                            {
                                Console.Clear();
                                continue;
                            }
                        case "no":
                            {
                                return;

                            }
                    }
                }
                else { throw new Exception($"Invalid Input: {input2}"); }
               

                //else  { throw new Exception($"Invalid Inout {input2}"); }

                //if (input2.Trim().ToLower() == "yes")
                //{
                //    Console.Clear();
                //    continue;
                //}
                //else if (input2.Trim().ToLower() == "no")
                //{
                //    return;
                //}

            }


        }
    }
}