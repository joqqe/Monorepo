using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo.Lib.DTOs
{
    public class UpdateIsDoneDTO
    {
        public int Id { get; set; }
        public bool IsDone { get; set; }
    }
}
