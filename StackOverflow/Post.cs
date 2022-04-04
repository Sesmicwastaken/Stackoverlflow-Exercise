namespace StackOverflow;

public class Post
{
    private string? _postDescription;
    private string? _postTitle;

    public string? PostTitle
    {
        get => _postTitle;
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
                _postTitle = value;
            else
                throw new ArgumentNullException(value);
        }
    }

    public string? PostDescription
    {
        get => _postDescription;
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
                _postDescription = value;
            else
                throw new ArgumentNullException(value);
        }
    }

    public DateTime PostCreationTime { get; set; }

    public int NoOfVotes { get; private set; }

    public void UpvoteDownVote(string input)
    {
        if (string.IsNullOrWhiteSpace(input) || input != "upvote" && input != "downvote")
            throw new ArgumentException("Invalid Input");

        switch (input.Trim().ToLower())
        {
            case "upvote":
                UpVote();
                break;
            case "downvote":
                DownVote();
                break;
        }
    }

    private void UpVote()
    {
        NoOfVotes += 1;
    }

    private void DownVote()
    {
        NoOfVotes -= 1;
    }
}