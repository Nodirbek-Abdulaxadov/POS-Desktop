using System.ComponentModel.DataAnnotations;

namespace POS.Domain.Common;
public abstract class BaseEntity
{
    [Key]
    public int Id { get; set; }
}
