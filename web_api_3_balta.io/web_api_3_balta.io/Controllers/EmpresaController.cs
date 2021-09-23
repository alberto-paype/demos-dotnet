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
    public class EmpresaController : ControllerBase
    {

        private DataContextDB _context;

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
                    await _context.empresaRegime.AddAsync(model);
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
                    await _context.empresa.AddAsync(model);
                    await _context.SaveChangesAsync();

                    Empresa empresa = _context.empresa.Where(x => x.Handle == model.Handle)
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
