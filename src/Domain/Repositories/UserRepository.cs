using DataLayer.Repositories;
using POS.Domain.DataContext;
using POS.Domain.Entities.Auth;
using POS.Domain.Enums;
using POS.Domain.Interfaces;

namespace POS.Domain.Repositories;
public class UserRepository : Repository<User>, IUserInterface
{
    public UserRepository(ApplicationDbContext dbContext) 
        : base(dbContext)
    {
    }
}