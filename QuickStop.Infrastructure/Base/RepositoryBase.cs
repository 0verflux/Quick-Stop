using QuickStop.Infrastructure.Contracts;

namespace QuickStop.Infrastructure.Base
{
    public abstract class RepositoryBase<TEntity>
    {
        protected readonly ISerializer serializer;
        
        protected RepositoryBase(ISerializer serializer)
        {
            this.serializer = serializer;
        }
    }
}
