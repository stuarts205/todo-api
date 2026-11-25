namespace Todo.Application.Dtos.Request
{
    public record CreateUserDto(string Email, string FullName, string Password);
}
