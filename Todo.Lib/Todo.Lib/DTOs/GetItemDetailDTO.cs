using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo.Lib.DTOs
{
    public class GetItemDetailDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public UrgencyLevel UrgencyLevel { get; set; }
        public DateTime Deadline { get; set; }
        public bool IsDone { get; set; }
    }
}
