using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Todo.API.Services;
using Todo.Lib;
using Todo.Lib.DTOs;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Todo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private readonly ITodoService _service;
        public TodoController(ITodoService service)
        {
            _service = service;
        }
        // GET: api/<TodoController>
        [HttpGet]
        public IEnumerable<Item> Get()
        {
            return _service.GetAll();
        }

        // GET api/<TodoController>/5
        [HttpGet("{id}")]
        public ActionResult<Item> Get(Guid id)
        {
            return _service.Get(id);
        }

        // GET api/<TodoController>/filter
        [HttpGet("filter")]
        public ActionResult<IEnumerable<Item>> GetWithFilter([FromQuery] string filter)
        {
            return _service.Get(filter);
        }

        [HttpGet("random")]
        public ActionResult<Item> GimmeRandomTodo()
        {
            return _service.GimmeRandomTodo();
        }

        // POST api/<TodoController>
        [HttpPost]
        public void Post([FromBody] CreateItemDTO item)
        {
            _service.Add(item);
        }


        // DELETE api/<TodoController>/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            _service.Delete(id);
        }
    }
}
