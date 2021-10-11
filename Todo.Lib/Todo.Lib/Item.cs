using System;

namespace Todo.Lib
{
    public class Item
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string? Content { get; set; }
        public UrgencyLevel UrgencyLevel { get; set; }
        public DateTime Deadline { get; set; }
        public bool IsDone { get; set; }

        public Item()
        {

        }

        public Item(string title, string content, UrgencyLevel urgencylevel, DateTime deadline, bool isDone)
        {
            Id = Guid.NewGuid();
            Title = title;
            Content = content;
            UrgencyLevel = urgencylevel;
            Deadline = deadline;
            IsDone = isDone;
        }

        public Item(string title, UrgencyLevel urgencylevel, DateTime deadline, bool isDone)
        {
            Id = Guid.NewGuid();
            Title = title;
            UrgencyLevel = urgencylevel;
            Deadline = deadline;
            IsDone = !isDone;
        }
    }
}
