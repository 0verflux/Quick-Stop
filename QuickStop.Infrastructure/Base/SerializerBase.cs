using System.IO;
using System.Text.RegularExpressions;

namespace QuickStop.Infrastructure.Base
{
    public abstract class SerializerBase
    {
        protected readonly Regex parser;
        protected readonly string baseDirectory;
        protected readonly string extension;
        protected readonly string folder;
        protected readonly char[] delimiters;
        
        protected SerializerBase(string baseDirectory, string folder, params char[] delimiters)
        {
            parser = new Regex(",(?=(?:[^\"]*\"[^\"]*\")*(?![^\"]*\"))");
            extension = ".txt";

            this.baseDirectory = baseDirectory;
            this.delimiters = delimiters;
            this.folder = folder;

            Directory.CreateDirectory(baseDirectory + folder);
        }

        protected string FilePath(string fileName) => baseDirectory + folder + fileName + extension;
    }
}
