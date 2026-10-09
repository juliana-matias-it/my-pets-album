using Microsoft.AspNetCore.Mvc;
using MyPetsAlbum.Api.Models;

namespace MyPetsAlbum.Api.Controllers;

[ApiController]
[Route("api/pets")]

public class PetsController : ControllerBase
{
    [HttpGet]
    public ActionResult<Pet> Get()
    {
        var pets = new List<Pet>
        {
        new Pet {Id =1, Name = "Baby"},
        new Pet {Id =2, Name = "Gordo"}
        };
        return Ok(pets);
    }
}