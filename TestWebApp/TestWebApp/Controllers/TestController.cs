using Microsoft.AspNetCore.Mvc;
using TestWebApp.Data;
using TestWebApp.Model.Dto;
using TestWebApp.Repos;

namespace TestWebApp.Controllers;

[ApiController]
[Route("api/test")]
public class TestController : ControllerBase
{
    private readonly IRepo _repo;

    public TestController(IRepo repo)
    {
        _repo = repo;
    }
    
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var result = await _repo.Get<TestDto0>(1, x => new TestDto0
        {
            Id = x.Id,
            Name = x.Name
        });

        return Ok(result);
    }
    
    [HttpGet("1")]
    public async Task<IActionResult> Get1()
    {
        var result = await _repo.GetByAge<TestDto1>(20, x => new TestDto1
        {
            Name = x.Name,
            Surname = x.Surname,
            Age = x.Age
        });

        return Ok(result);
    }
    
    [HttpGet("2")]
    public async Task<IActionResult> Get2()
    {
        var result = await _repo.Get<TestDto2>(1, x => new TestDto2
        {
            Name = x.Name
        });

        return Ok(result);
    }
    
    [HttpGet("3")]
    public async Task<IActionResult> Get3()
    {
        var result = await _repo.Get<TestDto0>(1, x => new TestDto0
        {
            Id = x.Id,
            Name = x.Name
        },3);

        return Ok(result);
    }
    
}