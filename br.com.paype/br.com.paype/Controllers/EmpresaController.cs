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
    public class EmpresaController : ControllerBase
    {

        private readonly DataContextDB _context;

        public EmpresaController([FromServices] DataContextDB context)
        {
            _context = context;
        }

        [HttpPost]
        [Route("create-empresa-regime")]
        [Authorize]
        public async Task<JsonResult> CreateEmpresaRegime([FromBody] EmpresaRegime model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _context.EmpresaRegime.AddAsync(model);
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

        [HttpPost]
        [Route("create-empresa")]
        [Authorize]
        public async Task<JsonResult> CreateEmpresa([FromBody] Empresa model)
        {
            try
            {
                if (ModelState.IsValid)
                {                    
                    await _context.Empresa.AddAsync(model);
                    await _context.SaveChangesAsync();

                    Empresa empresa = _context.Empresa.Where(x => x.Handle == model.Handle)
                        .Include(e => e.RegimeEstadual)
                        .Include(e => e.RegimeFederal)
                        .FirstOrDefault();

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
