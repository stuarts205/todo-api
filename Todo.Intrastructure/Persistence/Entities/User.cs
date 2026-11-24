using System.Data;

namespace Todo.Intrastructure.Persistence.Entities
{
    public class User : BaseAudittableEntity
    {
        public string fullName { get; set; }
        public string email { get; set; }
        public string passwordHash { get; set; }
    }
}
