using System.Text;
using System.Text.RegularExpressions;

namespace QuickStop.Infrastructure.Base
{
    public abstract class SerializerBase
    {
        protected readonly Regex parser;
        protected readonly string baseDirectory;
        protected readonly string extension;
        protected readonly char[] delimiters;

        protected SerializerBase(string baseDirectory, params char[] delimiters)
        {
            this.parser = new Regex(",(?=(?:[^\"]*\"[^\"]*\")*(?![^\"]*\"))");

            this.baseDirectory = baseDirectory;
            this.delimiters = delimiters;
            this.extension = ".txt";
        }
    }
}
