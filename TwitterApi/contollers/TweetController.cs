using Microsoft.AspNetCore.Mvc;
using TwitterApi.Data;
using TwitterApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace TwitterApi.Controllers
{
    [Route("api/Tweets")]
    [ApiController]
    public class TweetController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public TweetController(ApplicationDbContext context)
        {
            _context = context;
        }


        [HttpGet]
        public IActionResult GetAll()
        {
            var tweets = _context.Tweets
                .Include(t => t.User)  
                .Select(t => new 
                {
                    t.Id,
                    t.Content,
                    t.Image,
                    t.NumberOfLikes,
                    t.CreatedAt,
                    t.NumberOfRetweets,
                    t.NumberOfComments,
                    t.Impressions,
                    User = new
                    {
                        t.User.Username,
                        t.User.Name,
                        t.User.Image,
                        t.User.Id
                    }
                })
                .ToList();
            return Ok(tweets);
        }


        [HttpGet("user/{userId}")]
        public IActionResult GetTweetsByUser(int userId)
        {
            var tweetsByUser = _context.Tweets
                .Where(t => t.UserId == userId)
                .Include(t => t.User).Select(x => new Tweet
                    { Id = x.Id, Content = x.Content, Image = x.Image, NumberOfLikes = x.NumberOfLikes ,
                        CreatedAt = x.CreatedAt,NumberOfRetweets = x.NumberOfRetweets ,
                        NumberOfComments =x.NumberOfComments,Impressions = x.Impressions})
                .ToList();

            if (!tweetsByUser.Any())
            {
                return NotFound($"No tweets found for user with ID {userId}");
            }

            return Ok(tweetsByUser);
        }
    }
}