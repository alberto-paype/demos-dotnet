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
    public class CategoryController : ControllerBase
    {

        [HttpGet]
        [Route("categories")]
        [Authorize]
        public async Task<ActionResult<List<Category>>> Categories([FromServices] DataContextDB context)
        {
            var categories = await context.Categories.Include(c => c.Products).ThenInclude(p => p.Images).AsNoTracking().ToListAsync();
            return categories;
        }

        [HttpPost]
        [Route("categories/salvar")]
        [Authorize]
        public async Task<ActionResult<Category>> Salvar(
            [FromServices] DataContextDB context,
            [FromBody] Category categoria
            )
        {

            if (ModelState.IsValid)
            {
                context.Categories.Add(categoria);
                await context.SaveChangesAsync();
                return categoria;
            } 
            else
            {
                return BadRequest(ModelState);
            }

        }



    }
}
