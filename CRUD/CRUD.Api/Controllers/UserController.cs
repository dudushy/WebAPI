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

        // Read All
        [HttpGet]
        public async Task<ActionResult<List<User>>> Read()
        {
            return Ok(users);
        }

        // Read One
        [HttpGet("{cpf}")]
        public async Task<ActionResult<User>> Read(string cpf)
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

        // Update
        [HttpPut]
        public async Task<ActionResult<List<User>>> Update(User request)
        {
            var user = users.Find(u => u.Cpf == request.Cpf);

            if (user == null)
            {
                return BadRequest("User not found.");
            }

            user.Cpf = request.Cpf;
            user.BirthDate = request.BirthDate;
            user.Email = request.Email;
            user.Name = request.Name;
            user.Password = request.Password;

            return Ok(user);
        }

        // Delete
        [HttpDelete("{cpf}")]
        public async Task<ActionResult<List<User>>> Delete(string cpf)
        {
            var user = users.Find(u => u.Cpf == cpf);

            if (user == null)
            {
                return BadRequest("User not found.");
            }

            users.Remove(user);

            return Ok(users);
        }
    }
}
