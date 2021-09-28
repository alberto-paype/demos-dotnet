using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Authorization;
using System.Text;

namespace br.com.paype.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class IndexController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public IndexController(IConfiguration Configuration)
        {
            _configuration = Configuration;
        }

        [HttpGet]
        [AllowAnonymous]
        public string Index()
        {
            byte[] bytes = Encoding.Default.GetBytes(_configuration.GetSection("API").GetSection("version").Value);
            return Encoding.UTF8.GetString(bytes);            
        }
    }
}
