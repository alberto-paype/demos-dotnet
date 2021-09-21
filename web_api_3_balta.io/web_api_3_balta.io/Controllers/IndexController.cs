using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace web_api_3_balta.io.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class IndexController : Controller
    {
        private IConfiguration _configuration;

        public IndexController(IConfiguration Configuration)
        {
            _configuration = Configuration;
        }

        [HttpGet]
        public string Index()
        {
            string smtp = _configuration.GetSection("email_config").GetSection("smtp").Value;
            return smtp;
        }
    }
}
