// FileExplorer.Infrastructure/Repositories/FolderRepository.cs
using Domain.Entities;
using Domain.Interfaces;

namespace Infrastructure.Repositories;

public class FolderRepository : IFolderRepository
{

    public async Task<List<Folder>> GetSubFoldersAsync(string path)
    {
        string fullPath = Path.Combine("/home/christian/Desktop/Projects/File-Explorer/CONTENEDOR", path);

        if (!Directory.Exists(fullPath))
            throw new ArgumentException("El directorio no existe.");

        var subFolders = new List<Folder>();

        foreach (var dir in Directory.GetDirectories(fullPath))
        {
            subFolders.Add(new Folder
            {
                Name = Path.GetFileName(dir),
                Path = dir,
                CreatedAt = new FileInfo(dir).CreationTime,
                ModifiedAt = new FileInfo(dir).LastWriteTime,
                Size = new DirectoryInfo(dir).EnumerateFiles().Sum(file => file.Length)
            });
        }

        return subFolders;
    }

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
                Size = new FileInfo(file).Length
            });
        }

        return files;
    }

    public async Task<string> ReadFileAsync(string filePath)
    {
        string fullPath = Path.Combine("/home/christian/Desktop/Projects/File-Explorer/CONTENEDOR", filePath);

        if (!File.Exists(fullPath))
            throw new ArgumentException("El archivo no existe.");

        return await File.ReadAllTextAsync(fullPath);
    }
}