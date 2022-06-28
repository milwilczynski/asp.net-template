using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace kekAuth.API;

public class HomeController : Controller
{
    [HttpGet]
    public async Task<IActionResult> Sample()
    {
        return Ok("Sample");
    }
}