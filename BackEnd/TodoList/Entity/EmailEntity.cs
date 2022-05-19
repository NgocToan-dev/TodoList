using System;

namespace TodoList.Entity
{
    public class EmailEntity 
    {
        public string FullName { get; set; }
        public string Email { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }

        public DateTime DeadlineTime { get; set; }

    }
}
