using System.ComponentModel.DataAnnotations;
using POS.Domain.Common;

namespace POS.Domain.Entities.Auth;

public class User : BaseEntity
{
    [Required, StringLength(50)]
    public string FirstName { get; set; } = string.Empty;
    [StringLength(50)]
    public string LastName { get; set; } = string.Empty;
    [StringLength(15)]
    public string PhoneNumber { get; set; } = string.Empty;
    public string PasswordHash { get; set; } = string.Empty;
}