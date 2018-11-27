using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _20_MVC_Assignment_1_DOTNET
{
    public class TweetViewModel
    {
        public TweetMessageViewModel TweetMessageViewModel { get; set; }
        public List<TweetMessageViewModel> TweetsViewModel { get; set; }
        public Tweetdetails Tweetdetails { get; set; }

    }
}