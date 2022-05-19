using Microsoft.AspNetCore.Mvc;
using System;
using TodoList.Entity;
using TodoList.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TodoList.Controllers
{
    [Route("v1/TodoItem")]
    [ApiController]
    public class TodoListController : ControllerBase
    {
        TodoService _todoService = null;
        ServiceResult _serviceResult = null;
        public TodoListController()
        {
            _todoService = new TodoService();
            _serviceResult = new ServiceResult();
        }

        [HttpGet("{userID}")]
        public IActionResult GetTodoItemList(int userID)
        {
            _serviceResult = _todoService.GetTodoItemList(userID);

            return Ok(_serviceResult);
        }

        // POST api/<TodoListController>
        [HttpPost]
        public IActionResult AddTodoItem([FromBody] TodoItem todoItem)
        {
            _serviceResult = _todoService.AddTodoItem(todoItem);
            return Ok(_serviceResult);
        }

    }
}
