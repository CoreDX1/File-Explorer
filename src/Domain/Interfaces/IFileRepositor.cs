using Domain.Entities;

namespace Domain.Interfaces;

public interface IFileRepository
{
    public Task<List<FileItem>> GetFilesAsync(string path);
    public Task<string> ReadFileAsync(string filePath);
}