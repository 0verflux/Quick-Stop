namespace QuickStop.Infrastructure.Base
{
    public abstract class SerializerBase
    {
        protected readonly string baseDirectory;
        protected readonly string extension;
        protected readonly char[] delimiters;

        protected SerializerBase(string baseDirectory, params char[] delimiters)
        {
            this.baseDirectory = baseDirectory;
            this.delimiters = delimiters;
            this.extension = ".txt";
            
        }
    }
}
