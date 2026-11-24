namespace Todo.Infrastructure.Persistence.Entities
{
    public abstract class BaseAudittableEntity : BaseEntity
    {
        public DateTime createdAt { get; set; } = DateTime.UtcNow;
        public DateTime? updatedAt { get; set; } = DateTime.UtcNow;
        public string createdBy { get; set; }
        public string? updatedBy { get; set; }
    }
}
