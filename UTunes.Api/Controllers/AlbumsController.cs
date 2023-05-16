using Microsoft.AspNetCore.Mvc;
using UTunes.Core;
using UTunes.Core.Entities;

namespace UTunes.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class AlbumsController : ControllerBase
{
    private readonly IRepository<Album> repository;

    public AlbumsController(IRepository<Album> repository)
    {
        this.repository = repository;
    }
    [HttpGet]
    public async Task<IActionResult> GetAlbums() => Ok(await this.repository.AllAsync());


    [HttpGet("{id}")]
    public async Task<OperationResult<IReadOnlyList<Album>>> GetById(int id)
    {
        if (id == -1)
        {
            return (await this.repository.AllAsync()).ToList();
        }
        return this.repository.Filter(x => x.Id == id).ToList();
    }

    [HttpGet("{id}/songs")]
    public async Task<OperationResult<IReadOnlyList<Album>>> GetSongsById(int id)
    {   
        if (id == -1)
        {
            return (await this.repository.AllAsync()).ToList();
        }
        return this.repository.Filter(x => x.Id == id).ToList();
    }
}

