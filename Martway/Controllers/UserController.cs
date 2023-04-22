using Microsoft.AspNetCore.Mvc;
using Martway.Models;
using Microsoft.EntityFrameworkCore;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Martway.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private AppDbContext _context;

        public UserController(AppDbContext context)
        {
            _context = context;
        }


        [HttpGet("UsersList")]
        public async Task<ActionResult<List<User>>> UsersList()
        {

            return Ok(await _context.Users.ToListAsync());
        }

        [HttpGet("GetUser")]
        public async Task<ActionResult<User>> GetUser(int Id)
        {
            var user = await _context.Users.FindAsync(Id);

            if (user == null)
            {
                return NotFound("User Not Found");
            }

            return Ok(user);

        }

        [HttpPost("CreateUser")]
        public async Task<ActionResult<User>> CreateUser(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return Ok(user);
        }

        [HttpPut("UpdateUser")]
        public async Task<ActionResult<User>> UpdateUser(User user)
        {
            var userfinded = await _context.Users.FindAsync(user.Id);

            if (userfinded == null)
            {
                return NotFound("User Not Found");
            }

            userfinded.Name = user.Name;
            userfinded.Email = user.Email;
            userfinded.status = user.status;
            userfinded.Password = user.Password;

            await _context.SaveChangesAsync();

            return Ok(userfinded);

        }

        [HttpDelete("DeleteUser")]

        public async Task<ActionResult<User>> DeleteUser(int Id)
        {
            var user = await _context.Users.FindAsync(Id);

            if (user == null)
            {
                return NotFound("User Not Found");

            }
            
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();

            return Ok("User " + Id +" deleted");
        }

    }
}
