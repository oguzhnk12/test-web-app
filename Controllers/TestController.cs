using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class TestController : ControllerBase
{
    // GET: api/test?name=Ahmet
    [HttpGet]
    public IActionResult Get([FromQuery] string name)
    {
        return Ok($"Merhaba, {name ?? "Ziyaretçi"}!");
    }

    // POST: api/test
    [HttpPost]
    public IActionResult Post([FromBody] UserDto user)
    {
        return Ok($"Hoş geldin {user.FirstName} {user.LastName}, yaşın: {user.Age}");
    }
}

public class UserDto
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public int Age { get; set; }
}
