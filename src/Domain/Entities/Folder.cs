namespace Domain.Entities;

public class Folder
{
    public string Name { get; set; } = string.Empty;
    public string Path { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }
    public DateTime ModifiedAt { get; set; }
    public long Size { get; set; }
    public List<Files> Files { get; set; } = new List<Files>();
    public List<Folder> SubFolders { get; set; } = new List<Folder>();
}