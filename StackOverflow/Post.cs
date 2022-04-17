namespace StackOverflow
{
    public class Post
    {
        private string? _postTitle;
        private string? _postDescription;



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
            get { return _postDescription; }
            set
            {
                if (!String.IsNullOrWhiteSpace(value))
                { _postDescription = value; }
                else
                {
                    throw new ArgumentNullException(value);
                }
            }
        }
        public DateTime PostCreationTime { get; set; }
        public int NoOfVotes { get; private set; }
        
        public void UpVoteDownVote(string input)
        {


            if (PostHelper.IsValid(input)) throw new ArgumentException("Invalid Input");
            
                     

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
            NoOfVotes ++;
        }
        private void DownVote()
        {
            NoOfVotes --;
        }


    }
}
