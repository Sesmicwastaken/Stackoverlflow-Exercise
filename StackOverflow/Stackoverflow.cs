using System.Text;

namespace StackOverflow;

public static class Stackoverflow
{

    private static readonly List<Post> Posts = new();

    public static Post StorePosts
    {
        set => Posts.Add(value);
    }
    public static int TotalPosts => Posts.Count;

    public static void ShowPost(int postId)
    {
        if (postId - 1 >= Posts.Count)
        {
            throw new NullReferenceException("\nPost Id is Invalid.");
        }
        var postFormat = new StringBuilder();
        postFormat.Append("\nTitle: " + Posts[postId - 1].PostTitle).AppendLine().AppendLine();
        postFormat.Append("Asked: " + Posts[postId - 1].PostCreationTime).AppendLine().AppendLine();
        postFormat.Append("Description: " + Posts[postId - 1].PostDescription).AppendLine().AppendLine();
        postFormat.Append("Votes: " + Posts[postId - 1].NoOfVotes);
        Console.WriteLine(postFormat);
    }
}
