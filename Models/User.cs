namespace AutoMapperExample.Models;

public enum UserStatus
{
    Offline,
    Online
}

public class User
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int Status { get; set; }
    public DateTime BirthDate { get; set; }
}