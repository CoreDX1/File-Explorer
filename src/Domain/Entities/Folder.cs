using System;

namespace Domain.Entities;

// Esta clase está obsoleta, usar DirectoryItem en su lugar
[Obsolete("Esta clase está obsoleta, usar DirectoryItem en su lugar")]
public class DirectoryItems
{
    public string Name { get; set; } = string.Empty;
    public string Path { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }
    public DateTime ModifiedAt { get; set; }
    public long Size { get; set; }
    public List<FileItem> Files { get; set; } = new List<FileItem>();
    public List<DirectoryItems> SubFolders { get; set; } = new List<DirectoryItems>();
}