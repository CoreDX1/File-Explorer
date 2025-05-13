using Domain.Entities;

namespace Application.Services.Interfaces;

public interface IFileServices
{
    Task<List<Files>> GetFilesAsync(string path);
    Task<string> ReadFileAsync(string filePath);
}