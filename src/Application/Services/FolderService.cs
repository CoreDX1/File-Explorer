using System.IO;
using System.Threading.Tasks;
using Domain.Interfaces;

namespace Application.Services
{
    public class FolderService : IFolderService
    {
        public Task RenameFolderAsync(string oldPath, string newPath)
        {
            Directory.Move(oldPath, newPath);
            return Task.CompletedTask;
        }

        public Task DeleteFolderAsync(string path)
        {
            Directory.Delete(path, true);
            return Task.CompletedTask;
        }
    }
}