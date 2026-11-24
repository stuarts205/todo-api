using System;
using System.Collections.Generic;
using System.Text;

namespace Todo.Intrastructure.Persistence.Entities
{
    public class Tag : BaseAudittableEntity
    {
        public string Name { get; set; }
        public string ColorCode { get; set; }

        public ICollection<TodoItemTag> TodoItemTags { get; set; }
    }
}
