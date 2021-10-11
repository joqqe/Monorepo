using System;

namespace Todo.Lib
{
    public class Item
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public UrgencyLevel UrgencyLevel { get; set; }
        public DateTime Deadline { get; set; }
        public bool IsDone { get; set; }

        public Item()
        {

        }

        public Item(int id, string title, string content, UrgencyLevel urgencylevel, DateTime deadline, bool isDone)
        {
            Id = id;
            Title = title;
            Content = content;
            UrgencyLevel = urgencylevel;
            Deadline = deadline;
            IsDone = isDone;
        }
    }
}
