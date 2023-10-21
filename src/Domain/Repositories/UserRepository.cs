using DataLayer.Repositories;
using POS.Domain.DataContext;
using POS.Domain.Entities.Auth;
using POS.Domain.Enums;
using POS.Domain.Interfaces;

namespace POS.Domain.Repositories;
public class UserRepository : Repository<User>, IUserInterface
{
    public UserRepository(ApplicationContext dbContext) 
        : base(dbContext)
    {
    }

    public Task<bool> IsInRoleAsync(string phoneNumber, string password, Role role)
    {
        throw new NotImplementedException();
    }
}