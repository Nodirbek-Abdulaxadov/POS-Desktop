using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace IdentityModels;

public class User : IdentityUser
{
    [Required]
    [StringLength(50)]
    public string FullName { get; set; } = string.Empty;
}