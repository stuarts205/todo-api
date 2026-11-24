using System;
using System.Collections.Generic;
using System.Text;

namespace Todo.Intrastructure.Persistence.Entities
{
    public class Comment : BaseAudittableEntity
    {
        public Guid TodoItemId { get; set; }
        public TodoItem TodoItem { get; set; }

        public Guid UserId { get; set; }
        public User User { get; set; }

        public string Message { get; set; }
    }
}
