using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using br.com.paype.Data;
using br.com.paype.Models;

namespace br.com.paype.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        private readonly DataContextDB _context;

        public ProductController([FromServices] DataContextDB context)
        {
            _context = context;
        }

        [HttpGet]
        [Authorize]
        public async Task<ActionResult<List<Product>>> Get()
        {
            return await _context.Products.ToListAsync();
        }

        [HttpGet]
        [Route("produto/{id:int}")]
        [Authorize]
        public async Task<ActionResult<Product>> GetById(int id)
        {
            return await _context.Products.Where(p => p.Id == id).Include(p => p.Category).AsNoTracking().FirstAsync();
        }

        [HttpPost]
        [Authorize]
        public async Task<ActionResult<List<Product>>> Post([FromBody] Product produto)
        {
            await _context.Products.AddAsync(produto);
            await _context.SaveChangesAsync();
            return await _context.Products.Include(x => x.Category).ToListAsync();            
        }

        

    }
}
