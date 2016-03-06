using System.IO.Compression;

namespace ZipFolder
{
    class Program
    {
        static void Main(string[] args)
        {
            var folderName = args[0];
            var archiveName = args[1];
            ZipFile.CreateFromDirectory(folderName, archiveName, CompressionLevel.Optimal, true);
        }
    }
}
