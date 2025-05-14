namespace Application.Services;

using Application.Services.Interfaces;
using Domain.Entities;
using Domain.Interfaces;


public class FolderServices : IFolderServices
{
    private readonly IFolderRepository _folderRepository;

    public FolderServices(IFolderRepository folderRepository)
    {
        _folderRepository = folderRepository;
    }

    public async Task<List<DirectoryItem>> GetSubFoldersAsync(string path)
    {
        return await _folderRepository.GetSubFoldersAsync(path);
    }

    public async Task<List<FileItem>> GetFilesAsync(string path)
    {
        return await _folderRepository.GetFilesAsync(path);
    }

    public Task<string> ReadFileAsync(string filePath)
    {
        return _folderRepository.ReadFileAsync(filePath);
    }

    public Task CreateFolderAsync(string path)
    {
        return _folderRepository.CreateFolderAsync(path);
    }

    public Task RenameFolderAsync(string oldPath, string newPath)
    {
        return _folderRepository.RenameFolderAsync(oldPath, newPath);
    }

    public Task DeleteFolderAsync(string path)
    {
        return _folderRepository.DeleteFolderAsync(path);
    }
}