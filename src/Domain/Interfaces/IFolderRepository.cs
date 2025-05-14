using Domain.Entities;

namespace Domain.Interfaces;

public interface IFolderRepository
{
    public Task<List<DirectoryItem>> GetSubFoldersAsync(string path);
    public Task<List<FileItem>> GetFilesAsync(string path);
    public Task<string> ReadFileAsync(string filePath);

    public Task CreateFolderAsync(string path);
    public Task RenameFolderAsync(string oldPath, string newPath);
    public Task DeleteFolderAsync(string path);
}