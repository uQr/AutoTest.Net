namespace AutoTest.Core.FileSystem
{
    public interface IFileSystemService
    {
        string[] GetFiles(string path, string searchPattern);
        string ReadFileAsText(string path);
        bool DirectoryExists(string path);
        bool FileExists(string file);
    }
}