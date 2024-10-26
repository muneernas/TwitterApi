using Microsoft.AspNetCore.Mvc;
using TwitterApi.Data;
using TwitterApi.Models;

using Microsoft.EntityFrameworkCore;

namespace TwitterApi.Controllers
{
    [Route("api/User")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public UserController(ApplicationDbContext context)
        {
            _context = context;
        }

        
        [HttpGet("{userId}")]
        public async Task<IActionResult> GetUserById(int userId)
        {
            var user = await _context.Users
                .Where(u => u.Id == userId)
                .Select(u => new 
                {
                    u.Id,
                    u.Username,
                    u.Name,
                    u.Image
                })
                .FirstOrDefaultAsync();

            if (user == null)
            {
                return NotFound($"User with ID {userId} not found.");
            }

            return Ok(user);
        }

      
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] UserDto userDto)
        {
         
            var existingUser = await _context.Users
                                             .FirstOrDefaultAsync(u => u.Username == userDto.Username);
            if (existingUser != null)
            {
                return BadRequest("User with this username already exists.");
            }

            
            var newUser = new User
            {
                Id=200000,
                Username = userDto.Username,
                Name = userDto.Name,
                Image = userDto.Image
            };

          
            _context.Users.Add(newUser);
            await _context.SaveChangesAsync(); 

           
            return CreatedAtAction(nameof(GetUserById), new { userId = newUser.Id }, newUser);
        }

       
    }
}
