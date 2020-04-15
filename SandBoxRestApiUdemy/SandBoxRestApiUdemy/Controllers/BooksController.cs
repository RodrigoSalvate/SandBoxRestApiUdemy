using Microsoft.AspNetCore.Mvc;
using SandBoxRestApiUdemy.Business;
using SandBoxRestApiUdemy.Model;

namespace SandBoxRestApiUdemy.Controllers
{
    [ApiVersion("1")]
    [Route("api/[controller]/v{version:apiVersion}")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private IBookBusiness _bookBusiness;

        public BooksController(IBookBusiness bookService)
        {
            _bookBusiness = bookService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_bookBusiness.FindAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var person = _bookBusiness.FindById(id);

            if (person == null) return NotFound();

            return Ok(person);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Book person)
        {
            if (person == null) return BadRequest();

            return new ObjectResult(_bookBusiness.Create(person));
        }

        [HttpPut]
        public IActionResult Put([FromBody] Book person)
        {
            if (person == null) return BadRequest();

            return new ObjectResult(_bookBusiness.Update(person));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _bookBusiness.Delete(id);
            return NoContent();
        }
    }
}

