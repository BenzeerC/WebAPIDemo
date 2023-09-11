using Microsoft.AspNetCore.Mvc;
using WebAPIDemo.Entites;
using WebAPIDemo.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPIDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookServices services;
        public BookController(IBookServices services) 
        {
            this.services = services;
        
        }
        // GET: api/<BookController>
        [HttpGet]
        [Route("GetBooks")]
        public IActionResult Get()
        {
            try
            {
                return new objectResult(services.GetBooks());
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status204NoContent, ex.Message);
            }
            
        }

        // GET api/<BookController>/5
        [HttpGet("{id}")]
        [Route("GetBookById/{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                return new objectResult(services.GetBookById(id));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status204NoContent, ex.Message);
            }
        }

        // POST api/<BookController>
        [HttpPost]
        [Route("AddBook")]
        public IActionResult Post([FromBody] Book book)
        {
            try
            {
                int result =services.AddBook(book);
                if(result >= 1)
                {
                    return StatusCode(StatusCodes.Status201Created);
                }
                else
                {
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        // PUT api/<BookController>/5
        [HttpPut]
        [Route("UpdateBook")]
        public IActionResult Put( [FromBody] Book book)
        {
            try
            {
                int result = services.UpdateBook(book);
                if (result >= 1)
                {
                    return StatusCode(StatusCodes.Status200OK);
                }
                else
                {
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        // DELETE api/<BookController>/5
        [HttpDelete]
        [Route("DeleteBook/{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                int result = services.DeleteBook(id);
                if (result >= 1)
                {
                    return StatusCode(StatusCodes.Status201Created);
                }
                else
                {
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
