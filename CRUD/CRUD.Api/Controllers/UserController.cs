using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRUD.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        // Inject Data from Database
        private readonly DataContext _context;

        public UserController(DataContext context)
        {
            _context = context;
        }

        // Read All
        [HttpGet]
        public async Task<ActionResult<List<User>>> Read()
        {
            return Ok(await _context.Users.ToListAsync());
        }

        // Read One
        [HttpGet("{cpf}")]
        public async Task<ActionResult<User>> Read(string cpf)
        {
            var user = await _context.Users.FindAsync(cpf);

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
            for (int i = 0; i < (await _context.Users.ToListAsync()).Count; i++)
            {
                if (user.Cpf == (await _context.Users.ToListAsync())[i].Cpf)
                {
                    return BadRequest("CPF already in use.");
                }
            }

            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return Ok(await _context.Users.ToListAsync());
        }

        // Update
        [HttpPut]
        public async Task<ActionResult<List<User>>> Update(User request)
        {
            var user = await _context.Users.FindAsync(request.Cpf);

            if (user == null)
            {
                return BadRequest("User not found.");
            }

            user.Cpf = request.Cpf;
            user.BirthDate = request.BirthDate;
            user.Email = request.Email;
            user.Name = request.Name;
            user.Password = request.Password;

            await _context.SaveChangesAsync();

            return Ok(await _context.Users.ToListAsync());
        }

        // Delete
        [HttpDelete("{cpf}")]
        public async Task<ActionResult<List<User>>> Delete(string cpf)
        {
            var user = await _context.Users.FindAsync(cpf);

            if (user == null)
            {
                return BadRequest("User not found.");
            }

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();

            return Ok(await _context.Users.ToListAsync());
        }
    }
}
