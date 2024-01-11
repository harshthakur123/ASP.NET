using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EStoreWebApp.Models;

namespace EStoreWebApp.Controllers;

public class DashboardController : Controller
{


    [HttpGet]
    public IActionResult Pie()
    {
        return View();

    }
    public IActionResult Bar()
    {
        return View();
    }

    public IActionResult Line(){
        return View();
    }
    
}
