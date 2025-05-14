// FileExplorer.Infrastructure/Repositories/FolderRepository.cs
using Domain.Entities;
using Domain.Interfaces;

namespace Infrastructure.Repositories;

public class FolderRepository : IFolderRepository
{

    public async Task<List<DirectoryItem>> GetSubFoldersAsync(string path)
    {
        string fullPath = Path.Combine("/home/christian/Desktop/Projects/File-Explorer/CONTENEDOR", path);

        if (!Directory.Exists(fullPath))
            throw new ArgumentException("El directorio no existe.");

        var subFolders = new List<DirectoryItem>();

        foreach (var dir in Directory.GetDirectories(fullPath))
        {
            subFolders.Add(new DirectoryItem(
                name: Path.GetFileName(dir),
                path: dir,
                size : new DirectoryInfo(dir).EnumerateFiles().Sum(file => file.Length),
                createdAt: new FileInfo(dir).CreationTime,
                modifiedAt: new FileInfo(dir).LastWriteTime
            ));
        }

        return subFolders;
    }

    public async Task<List<FileItem>> GetFilesAsync(string path)
    {
        string fullPath = Path.Combine("/home/christian/Desktop/Projects/File-Explorer/CONTENEDOR", path);

        if (!Directory.Exists(fullPath))
            throw new ArgumentException("El directorio no existe.");

        var files = new List<FileItem>();

        foreach (var file in Directory.GetFiles(fullPath))
        {
            var fileInfo = new FileInfo(file);
            files.Add(new FileItem(
                name: Path.GetFileName(file),
                path: file,
                size: fileInfo.Length,
                createdAt: fileInfo.CreationTime,
                modifiedAt: fileInfo.LastWriteTime
            ));
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