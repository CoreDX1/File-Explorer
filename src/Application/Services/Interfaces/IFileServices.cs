using Domain.Entities;

namespace Application.Services.Interfaces;

public interface IFileServices
{
    Task<List<FileItem>> GetFilesAsync(string path);
    Task<string> ReadFileAsync(string filePath);
}