using Microsoft.AspNetCore.Mvc;

namespace Post.API.Controllers;

[Route("/")]
public class PostController : Controller
{
    [HttpGet]
    public IActionResult GetPost()
    {

        return null;
    }
}
