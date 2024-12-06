using JeverlyStroe.Domain.Enum;

namespace JeverlyStroe.Domain.Models;

public class User
{
    public Guid Id { get; set; }
    public string Login { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public Role Role { get; set; }
    public string ProfileImagePath { get; set; }
    public DateTime CreatedAt { get; set; }

    public List<Order> Orders { get; set; }


}