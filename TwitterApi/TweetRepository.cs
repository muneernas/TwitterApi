using System.Collections.Generic;
using TwitterApi.Models;

namespace TwitterApi.Data
{
    public class TweetRepository
    {
        private readonly List<Tweet> _tweets;

        public TweetRepository()
        {
            
            var user1 = new User { Id = 1, Username = "antone236", Name = "Antone", Image = "https://notjustdev-dummy.s3.us-east-2.amazonaws.com/avatars/vadim.png" };
            var user2 = new User { Id = 2, Username = "muneernas", Name = "Muneer", Image = "https://notjustdev-dummy.s3.us-east-2.amazonaws.com/avatars/jeff.jpeg" };
            var user3 = new User { Id = 3, Username = "zuck", Name = "Zuck", Image = "https://notjustdev-dummy.s3.us-east-2.amazonaws.com/avatars/zuck.jpeg" };
            var user4 = new User { Id = 4, Username = "fawzi@2024", Name = "Fawzi Shiyab", Image = "https://notjustdev-dummy.s3.us-east-2.amazonaws.com/avatars/6.png" };
            
            _tweets = new List<Tweet>
            {
                new Tweet
                {
                    Id = 1,
                    CreatedAt = "2020-08-27T12:00:00.000Z",
                    Content = "Can you please check if the Subscribe button on Youtube works?",
                    Image = "https://notjustdev-dummy.s3.us-east-2.amazonaws.com/images/thumbnail.png",
                    NumberOfComments = 123,
                    NumberOfRetweets = 11,
                    NumberOfLikes = 10,
                    UserId = user1.Id,
                    User = user1
                },
                new Tweet
                {
                    Id = 2,
                    CreatedAt = "2023-04-28T08:30:00.000Z",
                    Content = "Just had a great workout at the gym! 💪 #fitness #healthylifestyle",
                    NumberOfComments = 2,
                    NumberOfRetweets = 5,
                    NumberOfLikes = 25,
                    Impressions = 500,
                    UserId = user2.Id,
                    User = user2
                },
                new Tweet
                {
                    Id = 3,
                    CreatedAt = "2024-10-17T09:45:00.000Z",
                    Content = "Had an amazing surf session this morning",
                    Image = "https://notjustdev-dummy.s3.us-east-2.amazonaws.com/images/8.jpg",
                    NumberOfComments = 10,
                    NumberOfRetweets = 20,
                    NumberOfLikes = 100,
                    Impressions = 1000,
                    UserId = user3.Id,
                    User = user3
                },
                new Tweet
                {
                    Id = 5,
                    CreatedAt = "2020-08-27T12:00:00.000Z",
                    Content = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.",
                    Image = "https://i.insider.com/5d03aa8e6fc9201bc7002b43?width=1136&format=jpeg",
                    NumberOfComments = 123,
                    NumberOfRetweets =11,
                    NumberOfLikes = 10,
                    Impressions = 12,
                    UserId = user1.Id,
                    User = user1
                },
                new Tweet
                {
                    Id = 6,
                    CreatedAt = "2020-08-27T12:00:00.000Z",
                    Content = "Hey Hey Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.",
                    
                    NumberOfComments = 4,
                    NumberOfRetweets = 11,
                    NumberOfLikes = 99,
                    Impressions = 15,
                    UserId = user1.Id,
                    User = user1
                },
                new Tweet
                {
                    Id = 7,
                    CreatedAt = "2024-10-17T09:45:00.000Z",
                    Content = "Hello world!",
                    NumberOfComments = 140,
                    NumberOfRetweets = 25,
                    NumberOfLikes = 990,
                    Impressions = 1000,
                    UserId = user1.Id,
                    User = user1
                },
                new Tweet
                {
                    Id = 8,
                    CreatedAt = "2024-10-17T09:45:00.000Z",
                    Content =  "Hey Hey Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.",
                   
                    NumberOfComments = 4,
                    NumberOfRetweets = 11,
                    NumberOfLikes = 99,
                    
                    UserId = user1.Id,
                    User = user1
                },
                new Tweet
                {
                    Id = 4,
                    CreatedAt = "2024-10-17T12:45:00.000Z",
                    Content = "Excited to announce that I will be speaking at the upcoming tech conference in San Francisco! 🎉 #womenintech",
                    NumberOfComments = 5,
                    NumberOfRetweets = 10,
                    NumberOfLikes = 50,
                    Impressions = 999,
                    UserId = user4.Id,
                    User = user4
                }
            };
        }

        
        public List<Tweet> GetAllTweets()
        {
            return _tweets;
        }
        public List<Tweet> GetTweetsByUserId(int userId)
        {
            return _tweets.Where(tweet => tweet.UserId == userId).ToList();
        }
      
    }
}
