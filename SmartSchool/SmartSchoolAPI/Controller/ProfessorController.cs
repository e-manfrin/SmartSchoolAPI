using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


namespace SmartSchoolAPI.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfessorController : ControllerBase
    {
        public ProfessorController() {}

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Professores: Marta, Paula, Lucas, Rafa");
        }
    }
}
