using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskAPI.Models;

namespace TaskAPI.Services
{
    public class TodoService
    {
        public List<Todo> AllTodos()
        {
            var todos = new List<Todo>();

            var todo1 = new Todo
            {
                ID = 1,
                Title = "Get Books",
                Description = "Get Books for School",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(15),
                Status = TodoStatus.New

            };
            var todo2 = new Todo
            {
                ID = 2,
                Title = "Get Vegetables",
                Description = "Get Vegetables for Cook",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(3),
                Status = TodoStatus.InProgress

            };
            var todo3 = new Todo
            {
                ID = 3,
                Title = "Visit Grandpa",
                Description = "Visit Grandpa in weekend",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(2),
                Status = TodoStatus.Completed

            };

            todos.Add(todo1);
            todos.Add(todo2);
            todos.Add(todo3);

            return todos;
        }
    }
}
