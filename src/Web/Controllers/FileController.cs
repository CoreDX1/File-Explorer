using Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]
[Route("api/[controller]")]
public class FileController : ControllerBase
{
    private readonly IFileServices _fileServices;

    public FileController(IFileServices fileServices)
    {
        _fileServices = fileServices;
    }

    [HttpGet]
    [Route("files")]
    public async Task<IActionResult> GetFilesAsync(string path)
    {
        var files = await _fileServices.GetFilesAsync(path);

        return Ok(files);
    }

    [HttpGet]
    [Route("files/{filePath}")]
    public async Task<IActionResult> ReadFileAsync(string filePath)
    {
        var file = await _fileServices.ReadFileAsync(filePath);

        return Ok(file);
    }
}