namespace StackOverflow;

public class Post
{
    private string _postTitle;
    private string _postDiscription;
    private DateTime _postCreationTime;
    private int _votes = 0;


    public string PostTitle
    {
        get { return _postTitle; }
        set
        {
            if (!String.IsNullOrWhiteSpace(value))
            { _postTitle = value; }
            else
            {
                throw new ArgumentNullException(value);
            }
        }
    }

    public string PostDiscription
    {
        get { return _postDiscription; }
        set
        {
            if (!String.IsNullOrWhiteSpace(value))
            { _postDiscription = value; }
            else
            {
                throw new ArgumentNullException(value);
            }
        }
    }
    public DateTime PostCreationTime
    {
        get { return _postCreationTime; }
        set
        {

            _postCreationTime = value;
        }
    }
    public int NoOfVotes
    {
        get
        {
            return _votes;
        }
    }
    public void UpvoteDownvote(string input)
    {


        if (String.IsNullOrWhiteSpace(input) || input != "upvote" && input != "downvote")
        {
            throw new ArgumentException("Invalid Input");
        }

        if (input.Trim().ToLower() == "upvote")
        {
            UpVote();
        }
        else if (input.Trim().ToLower() == "downvote")
        {
            DownVote();
        }
    }
    internal void UpVote()
    {
        _votes += 1;
    }
    internal void DownVote()
    {
        _votes -= 1;
    }


}
