using QuickStop.Domain.Contracts;
using System.Collections.Generic;

namespace QuickStop.Infrastructure.Base
{
    public abstract class DataAccessBase<TEntity> where TEntity : IEntity
    {
        protected IList<TEntity> collection;

        protected DataAccessBase()
        {
            // TODO: Call serializer to assign collection of objects
        }
    }
}
