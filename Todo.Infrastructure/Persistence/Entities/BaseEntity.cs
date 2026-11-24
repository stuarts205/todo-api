namespace Todo.Infrastructure.Persistence.Entities
{
    public abstract class BaseEntity
    {
        public Guid id { get; set; } = Guid.NewGuid();
    }
}
