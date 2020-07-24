using QuickStop.Domain.Contracts;
using System.Collections.Generic;

namespace QuickStop.Infrastructure.Contracts
{
    public interface IDataAccess<TEntity> where TEntity : IEntity
    {
        IEnumerable<TEntity> GetCollection();
        TEntity GetByID(int id);
    }
}
