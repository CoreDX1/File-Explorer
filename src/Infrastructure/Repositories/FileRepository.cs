using Domain.Entities;
using Domain.Interfaces;

namespace Infrastructure.Repositories;

public class FileRepository : IFileRepository
{
    public async Task<List<Files>> GetFilesAsync(string path)
    {
        if (!Directory.Exists(path))
            throw new ArgumentException("El directorio no existe.");

        string fullPath = Path.Combine("/home/christian/Desktop/Projects/File-Explorer/CONTENEDOR", path);

        var files = Directory.GetFiles(path).Select(file => new Files
        {
            Name = Path.GetFileName(file),
            Path = file,
            Size = new FileInfo(file).Length
        }).ToList();

        return files;
    }

    public Task<string> ReadFileAsync(string filePath)
    {
        throw new NotImplementedException();
    }
}