using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using web_api_3_balta.io.Data;
using web_api_3_balta.io.Models;

namespace web_api_3_balta.io.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        private DataContextDB _context;

        public ProductController([FromServices] DataContextDB context)
        {
            _context = context;
        }

        [HttpGet]
        [Authorize]
        public async Task<ActionResult<List<Product>>> Get()
        {
            return await _context.products.ToListAsync();
        }

        [HttpGet]
        [Route("produto/{id:int}")]
        [Authorize]
        public async Task<ActionResult<Product>> GetById(int id)
        {
            return await _context.products.Where(p => p.Id == id).Include(p => p.Category).AsNoTracking().FirstAsync();
        }

        [HttpPost]
        [Authorize]
        public async Task<ActionResult<List<Product>>> Post([FromBody] Product produto)
        {
            await _context.products.AddAsync(produto);
            await _context.SaveChangesAsync();
            return await _context.products.Include(x => x.Category).ToListAsync();            
        }

    }
}
