using Domain.Entities;

namespace Domain.Interfaces;

public interface IFolderRepository
{
    public Task<List<Folder>> GetSubFoldersAsync(string path);
    public Task<List<Files>> GetFilesAsync(string path);
    public Task<string> ReadFileAsync(string filePath);
}