using Application.Services.Interfaces;
using Domain.Entities;
using Domain.Interfaces;

namespace Application.Services;

public class FileServices : IFileServices
{
    private readonly IFileRepository _fileRepository;

    public FileServices(IFileRepository fileRepository)
    {
        _fileRepository = fileRepository;
    }

    public async Task<List<FileItem>> GetFilesAsync(string path)
    {
        return await _fileRepository.GetFilesAsync(path);
    }

    public Task<string> ReadFileAsync(string filePath)
    {
        return _fileRepository.ReadFileAsync(filePath);
    }
}