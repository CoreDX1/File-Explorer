namespace Domain.Entities;

public class Folder
{
     public string Name { get; set; } = string.Empty;
    public string Path { get; set; } = string.Empty;
    public List<Files> Files { get; set; } = new List<Files>();
    public List<Folder> SubFolders { get; set; } = new List<Folder>();
}