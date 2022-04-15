using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflow;

public class PostHelper
{
    public static bool IsValid(string input)
    {
        return String.IsNullOrWhiteSpace(input) || !String.Equals(input,InputAnswerUserType.UpVote, StringComparison.CurrentCultureIgnoreCase) && !String.Equals(input,InputAnswerUserType.DownVote, StringComparison.CurrentCultureIgnoreCase);
    }


   
}
