using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRUD.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProviderController : ControllerBase
    {
        private static List<Provider> providers = new List<Provider>
            {
                new Provider {
                    Cnpj = "12345678901234",
                    Name = "Dummy Test",
                    RegisterDate = DateTime.Now.ToString()
                },
                new Provider {
                    Cnpj = "12040578701624",
                    Name = "Wasd Uldr",
                    RegisterDate = DateTime.Now.ToString()
                }
            };

        // Read All
        [HttpGet]
        public async Task<ActionResult<List<Provider>>> Read()
        {
            return Ok(providers);
        }

        // Read One
        [HttpGet("{cnpj}")]
        public async Task<ActionResult<Provider>> Read(string cnpj)
        {
            var provider = providers.Find(pr => pr.Cnpj == cnpj);

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
            for (int i = 0; i < providers.Count; i++)
            {
                if (provider.Cnpj == providers[i].Cnpj)
                {
                    return BadRequest("CNPJ already in use.");
                }
            }

            providers.Add(provider);

            return Ok(providers);
        }

        // Update
        [HttpPut]
        public async Task<ActionResult<List<Provider>>> Update(Provider request)
        {
            var provider = providers.Find(pr => pr.Cnpj == request.Cnpj);

            if (provider == null)
            {
                return BadRequest("Provider not found.");
            }

            provider.Cnpj = request.Cnpj;
            provider.Name = request.Name;
            provider.RegisterDate = request.RegisterDate;

            return Ok(provider);
        }

        // Delete
        [HttpDelete("{cnpj}")]
        public async Task<ActionResult<List<Provider>>> Delete(string cnpj)
        {
            var provider = providers.Find(pr => pr.Cnpj == cnpj);

            if (provider == null)
            {
                return BadRequest("Provider not found.");
            }

            providers.Remove(provider);

            return Ok(providers);
        }
    }
}
