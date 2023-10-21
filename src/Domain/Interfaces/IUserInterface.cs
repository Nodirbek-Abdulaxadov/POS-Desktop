using POS.Domain.Entities.Auth;
using POS.Domain.Enums;

namespace POS.Domain.Interfaces;

public interface IUserInterface : IRepository<User>
{
    Task<bool> IsInRoleAsync(string phoneNumber, string password, Role role);
}