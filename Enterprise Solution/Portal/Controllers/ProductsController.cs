using BOL;
using SAL;
using Microsoft.AspNetCore.Mvc;


public class ProductsController : Controller
{
    
    List<Products>products=new List<Products>();
    ProductService svc=new ProductService();

    public ProductsController(){
        Console.WriteLine("In product controller----------------------->");
        products=svc.GetAll();
    }

    [HttpGet]
    public IActionResult Index()
    {
       
        return View(products);

    } 
}
