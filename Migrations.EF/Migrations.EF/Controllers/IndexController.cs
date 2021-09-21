using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Migrations.EF.Models;
using Migrations.EF.Utils;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Migrations.EF.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IndexController : ControllerBase
    {
        public Database _database;

        public IndexController(Database database)
        {
            var _database = database;
        }

        // GET: api/<IndexController>
        [HttpGet]
        public Pessoa[] Get()
        {
            return "value";
        }

        // GET api/<IndexController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<IndexController>
        [HttpPost]
        public Pessoa Post([FromBody] Pessoa p)
        {
            var optionsBuilder = new DbContextOptionsBuilder<Database>();
            optionsBuilder.UseSqlServer("Data Source=HOMOLOGAESCALA;Initial Catalog=teste_demo4;User ID=sa;Password=#escalasoft123");
            var _context = new Database(optionsBuilder.Options);

            var pessoa = new Pessoa
            {
                handle = "asas1",
                razao = "dkljfdfjkl",
                apelido = "dkljfdfjkl",
                tipo = "dkljfdfjkl",
                identificacao = "dkljfdfjkl",
                email = "dkljfdfjkl",
                telefone = "dkljfdfjkl",
                cliente = "dkljfdfjkl",
            };

            _context.Pessoas.Add(pessoa);
            _context.SaveChanges();

            return pessoa;
        }

        // PUT api/<IndexController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<IndexController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
