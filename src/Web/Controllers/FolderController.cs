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
    [Route("list")]
    public async Task<IActionResult> GetSubFoldersAsync(string path)
    {
        var subFolders = await _folderServices.GetSubFoldersAsync(path);

        return Ok(subFolders);
    }

    [HttpGet]
    [Route("{path}")]
    public async Task<IActionResult> GetFilesAsync(string path)
    {
        var files = await _folderServices.GetFilesAsync(path);

        return Ok(files);
    }

    [HttpPut("rename")]
    public async Task<IActionResult> RenameFolder(string oldPath, string newPath)
    {
        try
        {
            await _folderServices.RenameFolderAsync(oldPath, newPath);
            return Ok();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpDelete("delete")]
    public async Task<IActionResult> DeleteFolder(string path)
    {
        try
        {
            await _folderServices.DeleteFolderAsync(path);
            return Ok();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPost("create")]
    public async Task<IActionResult> CreateFolder(string path)
    {
        try
        {
            await _folderServices.CreateFolderAsync(path);
            return Ok();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}