using Microsoft.AspNetCore.Mvc;
using WebApi.Models;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using System.Linq;
using Microsoft.AspNetCore.Authorization;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [AllowAnonymous]
    public class CharacterController: ControllerBase
    {
        private static List<Character> characters = new List<Character>
        {
            new Character(),
            new Character {Id = 1, Name = "Sam"}
        };

        [HttpGet("GetAll")]
        public IActionResult Get()
        {
            var model = characters;
            if (model == null) return NotFound();
            return Ok(model);
        }
        [HttpGet("{id}")]
        public IActionResult GetSingle(int id)
        {
            var model = characters.FirstOrDefault(c => c.Id == id);
            if (model == null) return NotFound();
            return Ok(model);
        }
    }
}