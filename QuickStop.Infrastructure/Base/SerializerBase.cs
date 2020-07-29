using System.IO;
using System.Text.RegularExpressions;

namespace QuickStop.Infrastructure.Base
{
    /// <summary>
    /// Provides a Base class for <see cref="Contracts.ISerializer"/>.
    /// </summary>
    public abstract class SerializerBase
    {
        protected readonly Regex parser;
        protected readonly string baseDirectory;
        protected readonly string extension;
        protected readonly string folder;
        protected readonly char[] delimiters;
        
        /// <summary>
        /// Initializes a new instance of <see cref="SerializerBase"/>.
        /// </summary>
        /// <param name="baseDirectory">The base directory of the file.</param>
        /// <param name="folder">The folder of a contained file.</param>
        /// <param name="delimiters">A collection of characters used to read data each delimiter.</param>
        protected SerializerBase(string baseDirectory, string folder, params char[] delimiters)
        {
            parser = new Regex(",(?=(?:[^\"]*\"[^\"]*\")*(?![^\"]*\"))");
            extension = ".txt";

            this.baseDirectory = baseDirectory;
            this.delimiters = delimiters;
            this.folder = folder;

            Directory.CreateDirectory(baseDirectory + folder);
        }

        /// <summary>
        /// Constructs a full filePath of a Text File.
        /// </summary>
        /// <param name="fileName">The Name of a Text File.</param>
        /// <returns></returns>
        protected string FilePath(string fileName) => baseDirectory + folder + fileName + extension;
    }
}
