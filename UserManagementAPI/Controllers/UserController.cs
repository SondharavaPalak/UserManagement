using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using UserManagementAPI.Models;
namespace UserManagementAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        // ✅ In-memory list (acts like database)
        private static List<User> users = new List<User>(){
            new User { Id = 1, Name = "Alice", Email = "a@mail.com", Age = 25 },
            new User { Id = 2, Name = "Bob", Email = "b@mail.com", Age = 30 }
    };
        // 🔹 GET all users
        [HttpGet]
        public IActionResult GetUsers()
        {
            return Ok(users);
        }

        // 🔹 GET user by ID
        [HttpGet("{id}")]
        public IActionResult GetUser(int id)
        {
            var user = users.FirstOrDefault(u => u.Id == id);
            if (user == null) return NotFound();
            return Ok(user);
        }

        // 🔹 POST create user
        [HttpPost]
        public IActionResult CreateUser([FromBody] User user)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            user.Id = users.Count + 1;
            users.Add(user);

            return Ok(user);
        }

        // 🔹 PUT update user
        [HttpPut("{id}")]
        public IActionResult UpdateUser(int id, [FromBody] User updatedUser)
        {
            var user = users.FirstOrDefault(u => u.Id == id);
            if (user == null) return NotFound();

            user.Name = updatedUser.Name;
            user.Email = updatedUser.Email;
            user.Age = updatedUser.Age;

            return Ok(user);
        }

        // 🔹 DELETE user
        [HttpDelete("{id}")]
        public IActionResult DeleteUser(int id)
        {
            var user = users.FirstOrDefault(u => u.Id == id);
            if (user == null) return NotFound();

            users.Remove(user);
            return Ok("User deleted");
        }
    }
}