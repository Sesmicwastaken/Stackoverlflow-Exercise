namespace StackOverflow;

public static class PostHelper
{
    public static bool IsValid(string input)
    {
        return !string.IsNullOrWhiteSpace(input) 
               && string.Equals(input, InputAnswerUserType.UpVote, StringComparison.CurrentCultureIgnoreCase) 
               || string.Equals(input, InputAnswerUserType.DownVote, StringComparison.CurrentCultureIgnoreCase);
    }
}