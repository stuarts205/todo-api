namespace Todo.Intrastructure.Persistence.Entities
{
    public abstract class BaseEntity
    {
        public Guid id { get; set; } = Guid.NewGuid();
    }
}
