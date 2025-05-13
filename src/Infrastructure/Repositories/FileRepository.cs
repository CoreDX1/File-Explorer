using Domain.Entities;
using Domain.Interfaces;

namespace Infrastructure.Repositories;

public class FileRepository : IFileRepository
{
    public async Task<List<Files>> GetFilesAsync(string path)
    {

        string fullPath = Path.Combine("/home/christian/Desktop/Projects/File-Explorer/CONTENEDOR", path);

        if (!Directory.Exists(fullPath))
            throw new ArgumentException("El directorio no existe.");

        var files = new List<Files>();

        foreach (var file in Directory.GetFiles(fullPath))
        {
            files.Add(new Files
            {
                Name = Path.GetFileName(file),
                Path = file,
                Size = new FileInfo(file).Length,
                CreatedAt = new FileInfo(file).CreationTime,
                ModifiedAt = new FileInfo(file).LastWriteTime
            });
        }

        return files;
    }

    public Task<string> ReadFileAsync(string filePath)
    {
        throw new NotImplementedException();
    }
}