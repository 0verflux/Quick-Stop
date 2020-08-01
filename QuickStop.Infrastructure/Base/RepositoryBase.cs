using QuickStop.Infrastructure.Contracts;

namespace QuickStop.Infrastructure.Base
{
    /// <summary>
    /// Provides a Base class for a Repository.
    /// </summary>
    public abstract class RepositoryBase
    {
        protected readonly IModelStream modelStream;

        /// <summary>
        /// Initializes a new Instance of <see cref="RepositoryBase"/>.
        /// </summary>
        /// <param name="modelStream">The stream used for accessing data.</param> 
        protected RepositoryBase(IModelStream modelStream)
        {
            this.modelStream = modelStream;
        }
    }
}
