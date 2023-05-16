using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.SwaggerGen;
using UTunes.Core;
using UTunes.Core.Entities;

namespace UTunes.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class AlbumsController : ControllerBase
{
    private readonly IRepository<Album> repository;
    private readonly IRepository<Song> songrepository;

    public AlbumsController(IRepository<Album> repository, IRepository<Song> songrepository)
    {
        this.repository = repository;
        this.songrepository = songrepository;
    }
    [HttpGet]
    public async Task<IActionResult> GetAlbums() => Ok(await this.repository.AllAsync());

    [HttpGet("{id}")]
    public Task<IActionResult> GetAlbumById(int id)
    {
        var album =  repository.GetById(id);
        if (album == null)
            return Task.FromResult<IActionResult>(NotFound());

        return Task.FromResult<IActionResult>(Ok(album));
    }

    [HttpGet("{id}/songs")]
    public Task<IActionResult> GetSongByAlbumId(int id)
    {
        var album = repository.GetById(id);
        if (album == null)
            return Task.FromResult<IActionResult>(NotFound());
        var songs = songrepository.Filter(x => x.AlbumId == id).ToList();
             
            return Task.FromResult<IActionResult>(Ok(songs)); 
    }

    [HttpPost("{id}/like")]
    public async Task<IActionResult> Like(int id)
    {
        var album = repository.GetById(id);
        album.Rating += 1;
        album.TotalVotes += 1;
        await  repository.CommitAsync();
        return await Task.FromResult<IActionResult>(Ok(album));
    }


    [HttpPost("{id}/dislike")]
    public async Task<IActionResult> Dislikes(int id)
    {
        var album = repository.GetById(id);
        album.TotalVotes += 1;
        await repository.CommitAsync();

        return await Task.FromResult<IActionResult>(Ok(album));
    }

}