using Microsoft.AspNetCore.Mvc;
using UTunes.Core;
using UTunes.Core.Entities;

namespace UTunes.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class SongsController : ControllerBase
{
    private readonly IRepository<Song> repository;

    public SongsController(IRepository<Song> repository)
    {
        this.repository = repository;
    }

    [HttpGet]
    public async Task<IActionResult> GetSongs() => Ok(await this.repository.AllAsync());


    [HttpGet("{albumId}/songs")]
    public async Task<OperationResult<IReadOnlyList<Song>>> GetByAlbum(int albumId)
    {
        if (albumId == -1)
        {
            return (await this.repository.AllAsync()).ToList();
        }
        return this.repository.Filter(x => x.AlbumId == albumId).ToList();
    }

    [HttpGet("{name}")]
    public async Task<OperationResult<IReadOnlyList<Song>>> GetByName(string name)
    {
        return this.repository.Filter(x => x.Name == name).ToList();
    }
}

