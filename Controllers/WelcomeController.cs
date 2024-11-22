using Microsoft.AspNetCore.Mvc;

namespace David_Eduard_Lab1.Controllers;

public class WelcomeController : Controller
{
    // GET
    public IActionResult Index()
    {
        return Content("Welcome to my first application!");
    }
    
    // GET
    public IActionResult Greetings()
    {
        return Content("Nice to meet you!");
    }
    
    // GET
    public IActionResult UserInfo(int userId, string username)
    {
        return Content(username + ", You are user number " + userId + ".");
    }
}