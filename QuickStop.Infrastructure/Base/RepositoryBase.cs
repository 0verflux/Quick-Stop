using QuickStop.Infrastructure.Contracts;

namespace QuickStop.Infrastructure.Base
{
    /// <summary>
    /// Provides a Base class for a Repository.
    /// </summary>
    public abstract class RepositoryBase
    {
        protected readonly ISerializer serializer;

        /// <summary>
        /// Initializes a new Instance of <see cref="RepositoryBase"/>.
        /// </summary>
        /// <param name="serializer">The serializer used for accessing data.</param> 
        protected RepositoryBase(ISerializer serializer)
        {
            this.serializer = serializer;
        }
    }
}
