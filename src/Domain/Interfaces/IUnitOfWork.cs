using Core.Entities;

namespace Core.Interfaces;

public interface IUnitOfWork : IDictionary
{
    IGenericRepository<TEntity> Repository<TEntity>() where TEntity : BaseEntity;

    Task<bool> Complete();
}