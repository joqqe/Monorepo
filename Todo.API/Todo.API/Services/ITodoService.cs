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
    }
}
