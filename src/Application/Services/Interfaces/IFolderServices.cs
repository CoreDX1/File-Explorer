using Domain.Entities;

namespace Application.Services.Interfaces;

public interface IFolderServices
{
    Task<List<Folder>> GetSubFoldersAsync(string path);
    Task<List<Files>> GetFilesAsync(string path);
    Task<string> ReadFileAsync(string filePath);
}