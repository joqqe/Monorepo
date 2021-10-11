using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Todo.Lib;

namespace Todo.API.Services
{
    public interface ITodoService
    {
        List<Item> GetAll();
        Item Get(Guid id);
        List<Item> Get(string filter);
        void Add(Item item);
        bool Delete(Guid id);
        Item GimmeRandomTodo();
    }
}
