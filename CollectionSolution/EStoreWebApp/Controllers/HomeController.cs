using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EStoreWebApp.Models;
using HRAPP.Entities;
using HRAPP.Services;

namespace EStoreWebApp.Controllers;

public class HomeController : Controller
{
    //HTTP Incomming WebRequest
    //Action Methods
    //Depends on Request Type
    CustomerService customerService=new CustomerService();
    





    [HttpGet]
    public IActionResult Index()
    {
        return View();

    }
    public IActionResult Customers()
    {
       
        ViewData["Customers"]=customerService.GetAllCustomers();
        return View();
    }

    public IActionResult Aboutus(){
        return View();
    }
    public IActionResult Contact(){
        return View();

    }
    public IActionResult Services(){
        
        return Json(new {Id=45, Name="Mentoring", Company="Transflower"});

    }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
