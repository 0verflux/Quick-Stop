using QuickStop.Domain.Contracts;
using System.Collections.Generic;
using System.IO;

namespace QuickStop.Infrastructure.Base
{
    public abstract class RepositoryBase<TEntity> where TEntity : IEntity
    {
        protected readonly string baseDirectory;
        
        protected RepositoryBase(string baseDirectory)
        {
            this.baseDirectory = baseDirectory;
        }
    }
}
