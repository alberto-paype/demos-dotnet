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
using br.com.paype.Models.Fiscal;

namespace br.com.paype.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoaController : ControllerBase
    {

        private readonly DataContextDB _context;

        public PessoaController([FromServices] DataContextDB context)
        {
            _context = context;
        }

        [Route("create")]
        [HttpPost]
        [RouteAuthorize("PROG_PESSOA", "VISUALIZAR,EXCLUIR")]
        public async Task<JsonResult> Create ([FromBody] Pessoa model)
        {            

            try
            {
                if (ModelState.IsValid)
                {
                    await _context.Pessoa.AddAsync(model);
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

