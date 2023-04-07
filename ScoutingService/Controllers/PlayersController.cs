using Microsoft.AspNetCore.Mvc;

namespace ScoutingService.Controllers;

[ApiController]
[Route("api/c/[controller]")]
public class PlayersController : ControllerBase
{
 public PlayersController()
 {
    
 }

 [HttpPost]
 public ActionResult TestInboundConnection() {
    Console.WriteLine("--> Invound POST # Command Service");

    return Ok("Inbound test of from Platforms Controller");
 }
}
