namespace JWT_advanced.Entities;

public class User
{
    public string Id { get; set; }
    public string UserName { get; set; }
    public string Email { get; set; }
    public string Roll { get; set; } = "User";
    public byte[] PasswordHash { get; set; }
    public byte[] PasswordSalt { get; set; }
    public string RefreshToken { get; set; }
    public DateTime TokenCreated { get; set; }
    public DateTime TokenExpired { get; set; }
}
