namespace Web.Controllers;

using Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class FolderController : ControllerBase
{
    private readonly IFolderServices _folderServices;

    public FolderController(IFolderServices folderServices)
    {
        _folderServices = folderServices;
    }

    [HttpGet]
    [Route("folders")]
    public async Task<IActionResult> GetSubFoldersAsync(string path)
    {
        var subFolders = await _folderServices.GetSubFoldersAsync(path);

        return Ok(subFolders);
    }

    [HttpGet]
    [Route("folders/{path}")]
    public async Task<IActionResult> GetFilesAsync(string path)
    {
        var files = await _folderServices.GetFilesAsync(path);

        return Ok(files);
    }
}