using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _20_MVC_Assignment_1_DOTNET
{
    public class TweetMessageViewModel
    {
        public int TweetId { get; set; } = 0;

        [Required(ErrorMessage = "Tweet Required")]
        [MaxLength(140, ErrorMessage = "Tweet message max length is 140 charaters")]
        public string TweetMessage { get; set; }

        public string userid { get; set; }

        public DateTime Created { get; set; }

        public bool isUserTweet { get; set; }

    }
}