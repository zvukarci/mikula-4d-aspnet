using Microsoft.AspNetCore.Mvc;

namespace a.Controllers;

public class TasksController : Controller
{
    public IActionResult Task1()
    {
        return View();
    }

    public IActionResult Task2()
    {
        return View();
    }
}
