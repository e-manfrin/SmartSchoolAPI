using Microsoft.AspNetCore.Mvc;
using SmartSchoolAPI.Models;
using System.Collections.Generic;
using System.Linq;

namespace SmartSchoolAPI.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        public List<Aluno> Alunos = new List<Aluno>()
        {
            new Aluno()
            {
                Id = 1,
                Nome = "Marcos",
                Sobrenome = "Almeida",
                Telefone = "123456"
            },
            new Aluno()
            {
                Id = 2,
                Nome = "Marta",
                Sobrenome = "Kent",
                Telefone = "334433"
            },
            new Aluno()
            {
                Id = 3,
                Nome = "Laura",
                Sobrenome = "Maria",
                Telefone = "455520"
            },
        };
        public AlunoController() {}

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Alunos);
        }

        //api/aluno/byId
        //http://www.localhost:5000/api/aluno/byId/1
        [HttpGet("byId/{id}")]
        public IActionResult GetById(int id)
        {
            var aluno = Alunos.FirstOrDefault(a => a.Id == id);
            if (aluno == null) return BadRequest("Aluno não encontrado");

            return Ok(aluno);
        }

        //api/aluno/nome
        //http://www.localhost:5000/api/aluno/byName?nome=Marta&sobrenome=Kent
        [HttpGet("ByName")]
        public IActionResult GetByName(string nome, string sobrenome)
        {
            var aluno = Alunos.FirstOrDefault(a => 
            a.Nome.Contains(nome) && a.Sobrenome.Contains(sobrenome)
            );
            if (aluno == null) return BadRequest("Aluno não encontrado");

            return Ok(aluno);
        }

        //api/aluno
        [HttpPost]
        public IActionResult Post(Aluno aluno)
        {
            return Ok(aluno);
        }

        //api/aluno/id
        [HttpPut("{id}")]
        public IActionResult Put(int id, Aluno aluno)
        {
            return Ok(aluno);
        }

        //api/aluno/id
        [HttpPatch("{id}")]
        public IActionResult Patch(int id, Aluno aluno)
        {
            return Ok(aluno);
        }

        //api/aluno/id
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok();
        }
    }
}
