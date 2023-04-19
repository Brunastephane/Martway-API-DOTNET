using Microsoft.AspNetCore.Mvc;
using Martway.Models;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Martway.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        [HttpGet("RetornaUser")]
        public User RetornaUser()
        {
            var user = new User()
            {
                Name= "Test",
                Email= "test@test.com",
                Password="123456",
                Id= 1
            };


            return user;
        }

        [HttpPut("AtualizaPassword")]

        public User AtualizaPassword([FromBody] string newPassword)
        {
            var user = new User()
            {
                Name = "Test",
                Email = "test@test.com",
                Password = "123456",
                Id = 1
            };

            user.Password = newPassword;


            return user;
        }

    }
}
