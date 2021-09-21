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
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {

        [HttpGet]
        [Route("categories")]
        [Authorize]
        public async Task<ActionResult<List<Category>>> categories([FromServices] DataContextDB context)
        {
            var categories = await context.categories.Include(c => c.Products).ThenInclude(p => p.Images).AsNoTracking().ToListAsync();
            return categories;
        }

        [HttpPost]
        [Route("categories/salvar")]
        [Authorize]
        public async Task<ActionResult<Category>> salvar(
            [FromServices] DataContextDB context,
            [FromBody] Category categoria
            )
        {

            if (ModelState.IsValid)
            {
                context.categories.Add(categoria);
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
