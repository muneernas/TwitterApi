using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TwitterApi.Models;
namespace TwitterApi.Data;

public class UserRepository
{
    private readonly List<User> _User;

    public UserRepository()
    {
        _User = new List<User>
        {
            new User
            {
                Id = 1, Username = "antone236", Name = "Antone",
                Image = "https://notjustdev-dummy.s3.us-east-2.amazonaws.com/avatars/vadim.png"
            },
            new User
            {
                Id = 2, Username = "muneernas", Name = "Muneer",
                Image = "https://notjustdev-dummy.s3.us-east-2.amazonaws.com/avatars/jeff.jpeg"
            },
            new User
            {
                Id = 3, Username = "zuck", Name = "Zuck",
                Image = "https://notjustdev-dummy.s3.us-east-2.amazonaws.com/avatars/zuck.jpeg"
            },
            new User
            {
                Id = 4, Username = "fawzi@2024", Name = "Fawzi Shiyab",
                Image = "https://notjustdev-dummy.s3.us-east-2.amazonaws.com/avatars/6.png"
            },

        };
      
    }
    public User GetUserById(int userId)
    {
        var user = _User.FirstOrDefault(u => u.Id == userId);
        if (user != null) return user;
        return null;
    }

    public IActionResult CreateUser(UserDto user)
    {
        var existingUser = _User.FirstOrDefault(u => u.Username == user.Username);
        if (existingUser != null)
        {
            return new BadRequestObjectResult("User with this username already exists.");
        }
        var newUser = new User
        {
            Id = _User.Max(u => u.Id) + 1, 
            Username = user.Username,
            Name = user.Name,
            Image = user.Image
        };
        
        
        _User.Add(newUser);
        
        return new OkObjectResult(newUser); 
    }
}
    

