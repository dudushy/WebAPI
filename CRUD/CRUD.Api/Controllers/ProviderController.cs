using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRUD.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProviderController : ControllerBase
    {
        // Inject Data from Database
        private readonly DataContext _context;

        public ProviderController(DataContext context)
        {
            _context = context;
        }

        // Read All
        [HttpGet]
        public async Task<ActionResult<List<Provider>>> Read()
        {
            return Ok(await _context.Providers.ToListAsync());
        }

        // Read One
        [HttpGet("{cnpj}")]
        public async Task<ActionResult<Provider>> Read(string cnpj)
        {
            var provider = await _context.Providers.FindAsync(cnpj);

            if (provider == null)
            {
                return BadRequest("Provider not found.");
            }

            return Ok(provider);
        }

        // Create
        [HttpPost]
        public async Task<ActionResult<List<Provider>>> Create(Provider provider)
        {
            for (int i = 0; i < (await _context.Providers.ToListAsync()).Count; i++)
            {
                if (provider.Cnpj == (await _context.Providers.ToListAsync())[i].Cnpj)
                {
                    return BadRequest("CNPJ already in use.");
                }
            }

            _context.Providers.Add(provider);
            await _context.SaveChangesAsync();

            return Ok(await _context.Providers.ToListAsync());
        }

        // Update
        [HttpPut]
        public async Task<ActionResult<List<Provider>>> Update(Provider request)
        {
            var provider = await _context.Providers.FindAsync(request.Cnpj);

            if (provider == null)
            {
                return BadRequest("Provider not found.");
            }

            provider.Cnpj = request.Cnpj;
            provider.Name = request.Name;
            provider.RegisterDate = request.RegisterDate;

            await _context.SaveChangesAsync();

            return Ok(await _context.Providers.ToListAsync());
        }

        // Delete
        [HttpDelete("{cnpj}")]
        public async Task<ActionResult<List<Provider>>> Delete(string cnpj)
        {
            var provider = await _context.Providers.FindAsync(cnpj);

            if (provider == null)
            {
                return BadRequest("Provider not found.");
            }

            _context.Providers.Remove(provider);
            await _context.SaveChangesAsync();

            return Ok(await _context.Providers.ToListAsync());
        }
    }
}
