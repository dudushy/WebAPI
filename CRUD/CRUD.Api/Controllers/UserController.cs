using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRUD.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private static List<User> users = new List<User>
            {
                new User {
                    Cpf = "12345678901",
                    BirthDate = "28/12/2022",
                    Email = "test@123.com",
                    Name = "Test Dummy",
                    Password = "123"
                },
                new User {
                    Cpf = "08855672901",
                    BirthDate = "02/11/2002",
                    Email = "dummy@123.com",
                    Name = "Dummy Test",
                    Password = "1234"
                }
            };

        // Get All
        [HttpGet]
        public async Task<ActionResult<List<User>>> Get()
        {
            return Ok(users);
        }

        // Get One
        [HttpGet("{cpf}")]
        public async Task<ActionResult<User>> Get(string cpf)
        {
            var user = users.Find(u => u.Cpf == cpf);
            if(user == null)
            {
                return BadRequest("User not found.");
            }
            return Ok(user);
        }

        // Create
        [HttpPost]
        public async Task<ActionResult<List<User>>> Create(User user)
        {
            for (int i = 0; i < users.Count; i++)
            {
                if (user.Cpf == users[i].Cpf)
                {
                    return BadRequest("CPF already in use.");
                }
            }
            
            users.Add(user);

            return Ok(users);
        }
    }
}
