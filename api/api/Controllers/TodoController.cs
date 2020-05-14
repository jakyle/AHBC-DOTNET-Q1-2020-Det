using System.Collections.Generic;
using System.Linq;
using api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;

namespace api.Controllers
{
    namespace api.Controllers
    {
        [ApiController]
        [Route("[controller]")]
        public class TodoController : ControllerBase
        {

            private readonly ILogger<TodoController> _logger;
            private ICollection<Todo> _todos;

            public TodoController(IMemoryCache cache, ILogger<TodoController> logger)
            {
                if (cache.TryGetValue("todos", out ICollection<Todo> todos))
                {
                    _todos = todos;
                }
                else
                {
                    _todos = new List<Todo>
                    {
                        new Todo()
                        {
                            ID = 1,
                            Name = "Clean Kitchen",
                            Description = "Theres this really strange black spot on the stove...",
                            IsCompleted = false
                        },

                        new Todo()
                        {
                            ID = 2,
                            Name = "Walk Dog",
                            Description = "I've been neglacting my pet... :p",
                            IsCompleted = true
                        },

                        new Todo()
                        {
                            ID = 3,
                            Name = "Beat Metro 2033",
                            Description = "fucking pwnage",
                            IsCompleted = true
                        }
                    };

                    cache.Set("todos", _todos);
                }
            }

            [HttpGet]
            public IEnumerable<Todo> GetAllTodos()
            {
                return _todos;
            }

            [HttpGet]
            [Route("{id}")]
            public IActionResult GetTodo(int id)
            {
                var todo = _todos
                    .Where(todo => todo.ID == id)
                    .FirstOrDefault();

                if (todo == null)
                {
                   return NotFound("Todo item does not exist!");
                }

                return Ok(todo);
            }

            [HttpPost]
            public string PostTodo([FromBody] Todo model)
            {
                _todos.Add(model);
                return "Added Todo item";
            }

            [HttpPut]
            public IActionResult PutTodo([FromBody] Todo model)
            {
                var todoToUpdate = _todos.FirstOrDefault(todo => todo.ID == model.ID);
                // acutally update the guy..


                if (todoToUpdate == null)
                {
                    return NotFound("Could not find the todo item to update");
                }

                todoToUpdate.Description = model.Description;
                todoToUpdate.Name = model.Name;
                todoToUpdate.IsCompleted = model.IsCompleted;


                return Created("todo", "Succesfuly updated todo item");
            }

            [HttpDelete]
            [Route("{id}")]
            public IActionResult DeleteTodo(int id)
            {
                var todo = _todos.FirstOrDefault(todo => todo.ID == id);

                if (todo == null)
                {
                    return NotFound("Could not find the todo item to remove");
                }

                _todos.Remove(todo);

                return Ok("Succesfuly removed todo item");
            }
        }
    }
}

