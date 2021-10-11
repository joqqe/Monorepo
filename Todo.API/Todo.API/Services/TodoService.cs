using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Todo.Lib;

namespace Todo.API.Services
{
    public class TodoService : ITodoService
    {
        public List<Item> TodoItems { get; set; } = new List<Item>()
        {
            new Item(1, "stofzuigen", "voor manu", UrgencyLevel.URGENT, DateTime.Now, false),
            new Item(2, "stofzuigen", "voor manu", UrgencyLevel.URGENT, DateTime.Now, false),
            new Item(3, "stofzuigen", "voor manu", UrgencyLevel.URGENT, DateTime.Now, false),
            new Item(4, "stofzuigen", "voor manu", UrgencyLevel.URGENT, DateTime.Now, false),
            new Item(5, "stofzuigen", "voor manu", UrgencyLevel.URGENT, DateTime.Now, false),
        };
        public List<Item> GetAll()
        {
            return TodoItems;
        }
    }
}
