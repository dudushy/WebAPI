using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRUD.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        // Inject Data from Database
        private readonly DataContext _context;

        public ProductController(DataContext context)
        {
            _context = context;
        }

        // Read All
        [HttpGet]
        public async Task<ActionResult<List<Product>>> Read()
        {
            return Ok(await _context.Products.ToListAsync());
        }

        // Read One
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> Read(long id)
        {
            var product = await _context.Products.FindAsync(id);

            if (product == null)
            {
                return BadRequest("Product not found.");
            }
            
            return Ok(product);
        }

        // Create
        [HttpPost]
        public async Task<ActionResult<List<Product>>> Create(Product product)
        {
            for (int i = 0; i < (await _context.Products.ToListAsync()).Count; i++)
            {
                if (product.Id == (await _context.Products.ToListAsync())[i].Id)
                {
                    return BadRequest("ID already in use.");
                }
            }

            _context.Products.Add(product);
            await _context.SaveChangesAsync();

            return Ok(await _context.Products.ToListAsync());
        }

        // Update
        [HttpPut]
        public async Task<ActionResult<List<Product>>> Update(Product request)
        {
            var product = await _context.Products.FindAsync(request.Id);

            if (product == null)
            {
                return BadRequest("Product not found.");
            }

            product.Name = request.Name;
            product.Description = request.Description;
            product.Weight = request.Weight;

            await _context.SaveChangesAsync();

            return Ok(await _context.Products.ToListAsync());
        }

        // Delete
        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Product>>> Delete(long id)
        {
            var product = await _context.Products.FindAsync(id);

            if (product == null)
            {
                return BadRequest("Product not found.");
            }

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();

            return Ok(await _context.Products.ToListAsync());
        }
    }
}
