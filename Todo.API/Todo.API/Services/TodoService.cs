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
            new Item( "stofzuigen", "voor manu", UrgencyLevel.URGENT, DateTime.Now, false),
            new Item( "wassen", "", UrgencyLevel.URGENT, DateTime.Now, false),
            new Item( "beuzakken", "", UrgencyLevel.URGENT, DateTime.Now, false),
            new Item( "", "", UrgencyLevel.URGENT, DateTime.Now, false),
            new Item( "stofzuigen", "", UrgencyLevel.URGENT, DateTime.Now, false),
        };

        public Item Get(Guid id)
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

        public bool Delete(Guid id)
        {
            var item = TodoItems.FirstOrDefault(t => t.Id == id);

            return TodoItems.Remove(item);
        }
    }
}
