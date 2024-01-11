using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EStoreWebApp.Models;
using HRAPP.Entities;
using HRAPP.Services;

namespace EStoreWebApp.Controllers;

public class ProductsController : Controller
{
    
    List<Products>products=new List<Products>();
    ProductService productService=new ProductService();


    [HttpGet]
    public IActionResult Index()
    {
        products=productService.GetAllProducts();
       
        return View(products);

    } 
}
