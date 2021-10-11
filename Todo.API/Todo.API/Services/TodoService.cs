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
            new Item(2, "wassen", "", UrgencyLevel.URGENT, DateTime.Now, false),
            new Item(3, "beuzakken", "", UrgencyLevel.URGENT, DateTime.Now, false),
            new Item(4, "", "", UrgencyLevel.URGENT, DateTime.Now, false),
            new Item(5, "stofzuigen", "", UrgencyLevel.URGENT, DateTime.Now, false),
        };

        public Item Get(int id)
        {
            var todoItem = TodoItems.FirstOrDefault(t => t.Id == id);
            return todoItem;
        }

        public List<Item> GetAll()
        {
            return TodoItems;
        }

        public List<Item> Get(string filter)
        {
            var items = TodoItems.Where(t =>
                t.Title.ToLower().Contains(filter.ToLower()) ||
                t.Content.ToLower().Contains(filter.ToLower())
            ).ToList();

            return items;
        }

        public void Add(Item item)
        {
            TodoItems.Add(item);
        }
    }
}
