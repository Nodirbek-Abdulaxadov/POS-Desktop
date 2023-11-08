using Microsoft.EntityFrameworkCore;
using POS.Domain.Common;
using POS.Domain.DataContext;
using POS.Domain.Interfaces;

namespace DataLayer.Repositories;

public class Repository<TEntity>
        : IRepository<TEntity> where TEntity : BaseEntity
{
    private readonly ApplicationDbContext _dbContext;

    public Repository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public async Task<TEntity> AddAsync(TEntity entity)
    {
        var model = await _dbContext.Set<TEntity>().AddAsync(entity);
        await _dbContext.SaveChangesAsync();
        return model.Entity;
    }

    public virtual async Task<IEnumerable<TEntity>> GetAllAsync()
        => await _dbContext.Set<TEntity>()
                           .AsNoTracking()
                           .ToListAsync();

    public async Task<TEntity?> GetByIdAsync(int id)
        => await _dbContext.Set<TEntity>()
                           .AsNoTracking()
                           .FirstOrDefaultAsync(x => x.Id == id);

    public Task RemoveAsync(TEntity entity)
    {
        _dbContext.Set<TEntity>().Remove(entity);
        return Task.CompletedTask;
    }

    public Task UpdateAsync(TEntity entity)
    {
        _dbContext.Set<TEntity>().Update(entity);
        return Task.FromResult(entity);
    }
}