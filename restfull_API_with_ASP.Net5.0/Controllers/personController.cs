using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using restfull_API_with_ASP.Net5._0.model;
using restfull_API_with_ASP.Net5._0.Services.Implementations;

namespace restfull_API_with_ASP.Net5._0.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {

        private readonly ILogger<PersonController> _logger;
        private IPersonService _personService;

        public PersonController(ILogger<PersonController> logger, IPersonService personService)
        {
            _logger = logger;
            _personService = personService;
        }

        [HttpGet]
        public IActionResult Get(string fisrtNumber, string secondNumber)
        {
            return Ok(_personService.FindAll());

        }

        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            var person = _personService.FindByID(id);
            if (person == null) return NotFound();
            return Ok(person);

        }

        [HttpPost]
        public IActionResult Post([FromBody] Person person)
        {
            
            if (person == null) return BadRequest();
            return Ok(_personService.Create(person));

        }

        [HttpPut]
        public IActionResult Put([FromBody] Person person)
        {

            if (person == null) return BadRequest();
            return Ok(_personService.Update(person));

        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _personService.Delete(id);
            return NoContent();

        }

    }
}
