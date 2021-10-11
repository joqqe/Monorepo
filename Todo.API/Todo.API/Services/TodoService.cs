using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Todo.Lib;

namespace Todo.API.Services
{
    public class TodoService : ITodoService
    {
        private Random r = new Random();
        public List<Item> TodoItems { get; set; } = new List<Item>()
        {
            new Item( "stofzuigen", "voor manu", UrgencyLevel.URGENT, DateTime.Now, false),
            new Item( "komazuipen", "", UrgencyLevel.URGENT, DateTime.Now, false),
            new Item( "bloemen plukken in de natuur", "", UrgencyLevel.URGENT, DateTime.Now, false),
            new Item( "meer glimlachen", "", UrgencyLevel.URGENT, DateTime.Now, false),
            new Item( "meer dan drie koffies per dag drinken", "", UrgencyLevel.URGENT, DateTime.Now, false),
            new Item( "vaker het openbaar vervoer nemen", "", UrgencyLevel.URGENT, DateTime.Now, false),
            new Item( "experimenteren met xtc", "", UrgencyLevel.URGENT, DateTime.Now, false),
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

        public Item GimmeRandomTodo()
        {
            var random = r.Next(0, TodoItems.Count());

            return TodoItems[random];
        }
    }
}
