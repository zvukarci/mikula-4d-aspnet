using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using a.Models;

namespace a.Controllers;

public class TasksController : Controller
{
    private static List<UserInfo> userList { get; set; } = new List<UserInfo>();

    public IActionResult Task1()
    {
        return View();
    }

    public IActionResult Task2()
    {
        return View();
    }

    public IActionResult Task3()
    {
        return View();
    }

    public IActionResult Task4()
    {
        var userInfoList = new List<UserInfo>
        {
            new UserInfo
            {
                Name = "Kylian Mbappé",
                Email = "k.mbappe@example.com"
            },
            new UserInfo
            {
                Name = "Cristiano Ronaldo",
                Email = "c.ronaldo@example.com"
            }
        };
        return View(userInfoList);
    }
    public IActionResult Task5()
    {
        var userInfoList = new List<UserInfo>
        {
            new UserInfo
            {
                Name = "Kylian Mbappé",
                Email = "k.mbappe@example.com"
            },
            new UserInfo
            {
                Name = "Cristiano Ronaldo",
                Email = "c.ronaldo@example.com"
            },
        };
        return View(userInfoList);
    }

        public IActionResult Task6()
    {
        return View();
    }
    
        public IActionResult Task7()
    {
        return View();
    }

        public IActionResult Task8()
    {
        return View();
    }

    [HttpGet]
        public IActionResult Task9Form()
    {
        return View(new UserInfo());
    }

    [HttpPost]
    public IActionResult Task9Form(UserInfo user)
    {
        userList.Add(user);
        return RedirectToAction("Task9Detail");
    }

    // [HttpGet]
    public IActionResult Task9Detail() //UserInfo user
    {
        return View(userList);
    }
}
