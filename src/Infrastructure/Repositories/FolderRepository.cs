// FileExplorer.Infrastructure/Repositories/FolderRepository.cs
using Domain.Entities;
using Domain.Interfaces;

namespace Infrastructure.Repositories;

public class FolderRepository : IFolderRepository
{

    private string FullPath = "/home/christian/Desktop/Projects/File-Explorer/CONTENEDOR";

    public async Task<List<DirectoryItem>> GetSubFoldersAsync(string path)
    {
        string fullPath = Path.Combine(FullPath, path);

        if (!Directory.Exists(fullPath))
            throw new ArgumentException("El directorio no existe.");

        var subFolders = new List<DirectoryItem>();

        foreach (var dir in Directory.GetDirectories(fullPath))
        {
            subFolders.Add(new DirectoryItem(
                name: Path.GetFileName(dir),
                path: dir,
                size: new DirectoryInfo(dir).EnumerateFiles().Sum(file => file.Length),
                createdAt: new FileInfo(dir).CreationTime,
                modifiedAt: new FileInfo(dir).LastWriteTime
            ));
        }

        return subFolders;
    }

    public async Task<List<FileItem>> GetFilesAsync(string path)
    {
        string fullPath = Path.Combine(FullPath, path);

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
        string fullPath = Path.Combine(FullPath, filePath);

        if (!File.Exists(fullPath))
            throw new ArgumentException("El archivo no existe.");

        return await File.ReadAllTextAsync(fullPath);
    }

    public Task RenameFolderAsync(string oldPath, string newPath)
    {
        string fullPath = Path.Combine(FullPath, oldPath);
        string newFullPath = Path.Combine(FullPath, newPath);

        if (!Directory.Exists(fullPath))
            throw new ArgumentException("El directorio no existe.");

        Directory.Move(fullPath, newFullPath);

        return Task.CompletedTask;
    }

    public Task DeleteFolderAsync(string path)
    {
        string fullPath = Path.Combine(FullPath, path);

        if (!Directory.Exists(fullPath))
            throw new ArgumentException("El directorio no existe.");

        Directory.Delete(fullPath, true);

        return Task.CompletedTask;
    }

    public Task CreateFolderAsync(string path)
    {
        string fullPath = Path.Combine(FullPath, path);

        if (Directory.Exists(fullPath))
            throw new ArgumentException("El directorio ya existe.");

        Directory.CreateDirectory(fullPath);

        return Task.CompletedTask;
    }
}