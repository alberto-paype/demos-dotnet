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
    public class PessoaController : ControllerBase
    {

        private DataContextDB _context;

        public PessoaController([FromServices] DataContextDB context)
        {
            _context = context;
        }


        [HttpPost]
        [Authorize]
        [Route("create")]
        public async Task<JsonResult> Create ([FromBody] Pessoa model)
        {            

            try
            {
                if (ModelState.IsValid)
                {
                    await _context.pessoa.AddAsync(model);
                    await _context.SaveChangesAsync();
                    return new JsonResult(model);
                } 
                else
                {
                    return new JsonResult(BadRequest(ModelState));
                }
            }
            catch (Exception e)
            {
                return new JsonResult(e);
            }

        }
    }
}
