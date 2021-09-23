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
using web_api_3_balta.io.Services;

namespace web_api_3_balta.io.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private DataContextDB _context;

        public UsuarioController([FromServices] DataContextDB context)
        {
            _context = context;
        }

        [HttpGet]
        [Authorize]
        public async Task<ActionResult<List<Usuario>>> Get()
        {
            return await _context.usuario.ToListAsync();
        }

        [HttpPost]
        [Route("login")]
        [AllowAnonymous]
        public async Task<ActionResult<dynamic>> Login([FromBody] Usuario model)
        {
            var usuario = _context.usuario.Where(u => u.Username == model.Username && u.Password == model.Password)
                .FirstOrDefault();

            if (usuario == null)
                return NotFound(new { message = "Usuário ou senha inválidos" });

            var token = TokenService.GenerateToken(usuario);
          
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
        [Authorize(Roles = "admin,user")]
        public string UserAuth() => string.Format("USUARIO - {0}", User.Identity.Name);

        [HttpGet]
        [Route("admin")]
        [Authorize(Roles = "admin")]
        public string AdminAuth() 
        {
             return string.Format("ADMIN - {0}", User.Identity.Name);
        }


    }
}
