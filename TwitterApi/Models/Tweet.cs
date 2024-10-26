using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TwitterApi.Models
{


    public class Tweet
    {
        public int Id { get; set; }
        public string CreatedAt { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public string? Image { get; set; } = string.Empty;
        public int? NumberOfComments { get; set; }
        public int? NumberOfRetweets { get; set; }
        public int? NumberOfLikes { get; set; }
        public int? UserId { get; set; }
        public int? Impressions { get; set; }
        
        public User User { get; set; }
         
    }

}