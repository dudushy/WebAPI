﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRUD.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private static List<Product> products = new List<Product>
            {
                new Product {
                    Id = 1,
                    Name = "Banana",
                    Description = "This is a really yellow banana.",
                    Weight = 13.37
                },
                new Product {
                    Id = 2,
                    Name = "Orange",
                    Description = "This is a really orange orange.",
                    Weight = 0.07
                }
            };

        // Read All
        [HttpGet]
        public async Task<ActionResult<List<Product>>> Read()
        {
            return Ok(products);
        }

        // Read One
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> Read(int id)
        {
            var product = products.Find(pd => pd.Id == id);

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
            for (int i = 0; i < products.Count; i++)
            {
                if (product.Id == products[i].Id)
                {
                    return BadRequest("ID already in use.");
                }
            }

            products.Add(product);

            return Ok(products);
        }

        // Update
        [HttpPut]
        public async Task<ActionResult<List<Product>>> Update(Product request)
        {
            var product = products.Find(pd => pd.Id == request.Id);

            if (product == null)
            {
                return BadRequest("Product not found.");
            }

            product.Name = request.Name;
            product.Description = request.Description;
            product.Weight = request.Weight;

            return Ok(product);
        }

        // Delete
        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Product>>> Delete(int id)
        {
            var product = products.Find(pd => pd.Id == id);

            if (product == null)
            {
                return BadRequest("Product not found.");
            }

            products.Remove(product);

            return Ok(products);
        }
    }
}