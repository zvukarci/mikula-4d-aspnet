using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using a.Models;

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
                Email = "k.mbappe@example.com",
                Mobile = "+33 6 12 34 56 78",
                Username = "k.mbappe"
            },
            new UserInfo
            {
                Name = "Cristiano Ronaldo",
                Email = "c.ronaldo@example.com",
                Mobile = "+33 6 12 34 56 80",
                Username = "c.ronaldo"
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
                Email = "k.mbappe@example.com",
                Mobile = "+33 6 12 34 56 78",
                Username = "k.mbappe"
            },
            new UserInfo
            {
                Name = "Cristiano Ronaldo",
                Email = "c.ronaldo@example.com",
                Mobile = "+33 6 12 34 56 80",
                Username = "c.ronaldo"
            },
        };
        return View(userInfoList);
    }

        public IActionResult Task6()
    {
        return View();
    }
}
