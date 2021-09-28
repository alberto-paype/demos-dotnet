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
using br.com.paype.Models.TI;
using br.com.paype.Services;

namespace br.com.paype.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly DataContextDB _context;

        public UsuarioController([FromServices] DataContextDB context)
        {
            _context = context;
        }

        [HttpGet]
        [Authorize]
        public async Task<ActionResult<List<Usuario>>> Get()
        {
            return await _context.Usuario.ToListAsync();
        }

        [HttpPost]
        [Route("login")]
        [AllowAnonymous]
        public ActionResult<dynamic> Login([FromBody] Usuario model, [FromServices] DataContextDB context)
        {
            var usuario = _context.Usuario.Where(u => u.Username == model.Username && u.Password == model.Password)
                .FirstOrDefault();

            if (usuario == null)
                return NotFound(new { message = "Usuário ou senha inválidos" });

            var token = TokenService.GenerateToken(usuario, context);
          
            return new
            {
                usuario = usuario.Username,
                token
            };

        }

        [HttpGet]
        [Route("authenticated")]
        [Authorize]        
        public string Authenticated() => String.Format("Autenticado - {0}", User.Identity.Name);

        [HttpGet]
        [Route("user")]
        [Authorize]
        public string UserAuth() => string.Format("USUARIO - {0}", User.Identity.Name);

        [HttpGet]
        [Route("admin")]
        [Authorize]
        public string AdminAuth() 
        {
             return string.Format("ADMIN - {0}", User.Identity.Name);
        }


    }
}
