using System.ComponentModel.DataAnnotations;

namespace JWT_advanced.Models.Requests;

public class RegisterModel
{
    public required string UserName { get; set; }

    [EmailAddress]
    public required string EmailAddress { get; set; }

    public required string Password { get; set; }
}
