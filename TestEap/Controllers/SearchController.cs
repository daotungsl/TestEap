using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestEap.Models;

namespace TestEap.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchController : ControllerBase
    {
        private readonly TestEapContext _context;

        public SearchController(TestEapContext context)
        {
            _context = context;
        }

        [HttpGet("{name}")]
        public async Task<IActionResult> SearchName([FromRoute] string name)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var employees = _context.Employee.Where(e => e.Department == name).ToList();
            if (employees == null || employees.Count == 0)
            {
                return NotFound();
            }

            return Ok(employees);
        }
    }
}
