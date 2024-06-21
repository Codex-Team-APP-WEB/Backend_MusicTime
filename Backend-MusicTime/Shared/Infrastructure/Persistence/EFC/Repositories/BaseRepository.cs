using Backend_MusicTime.Shared.Domain.Repositories;
using Backend_MusicTime.Shared.Infrastructure.Persistence.EFC.Configuration;
using Microsoft.EntityFrameworkCore;

namespace Backend_MusicTime.Shared.Infrastructure.Persistence.EFC.Repositories;

public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
{
    protected readonly AppDbContext Context;
    protected BaseRepository(AppDbContext context) => Context = context;
    public async Task AddAsync(TEntity entity) => await Context.Set<TEntity>().AddAsync(entity);
    public virtual Task<TEntity?> FindByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<TEntity?> FindByGroupAsync(string group)
    {
        throw new NotImplementedException();
    }

    public async Task<TEntity?> FindByIdAsync(string id) => await Context.Set<TEntity>().FindAsync(id);
    public void Update(TEntity entity) => Context.Set<TEntity>().Update(entity);
    public void Remove(TEntity entity) => Context.Set<TEntity>().Remove(entity);
    public async Task<IEnumerable<TEntity>> ListAsync() => await Context.Set<TEntity>().ToListAsync();
}