using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace JWT_advanced.Models.Requests;

public class LoginModel
{
    [EmailAddress]
    public required string EmailAddress { get; set; }

    public required string Password { get; set; }
}
