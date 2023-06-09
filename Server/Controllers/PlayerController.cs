using Microsoft.AspNetCore.Mvc;
using SharedLibrary;

namespace Server.Controllers;

[ApiController]
[Route("[controller]")]
public class PlayerController : ControllerBase
{
    [HttpGet]
    public Player Get([FromQuery] int id)
    {
        var player = new Player() {Id = id};

        return player;
    }

    [HttpPost]
    public Player Post(Player player)
    {
        Console.WriteLine("Player has been added to the DB");

        return player;
    }
}