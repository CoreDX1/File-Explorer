using Domain.Entities;

namespace Application.Services.Interfaces;

public interface IFolderServices
{
    Task<List<DirectoryItem>> GetSubFoldersAsync(string path);
    Task<List<FileItem>> GetFilesAsync(string path);
    Task<string> ReadFileAsync(string filePath);
}