using BOL;
using DAL;
using Microsoft.AspNetCore.Mvc;
using SAL;

public class CustomerController:Controller{

    private readonly ICustomerService _svc;

    public CustomerController(ICustomerService svc){
         Console.WriteLine("Customer Controller Constructor is being Invoked..");
            _svc=svc;
    }

    [HttpGet]
    public IActionResult GetAllCustomers(){
        List<Customer>customers=new List<Customer>();
        customers=_svc.GetAllCustomers();
        ViewData["CustomersList"]=customers;
         Console.WriteLine("In customer getall "+customers);
        
        
        return View();
    }

   
       public IActionResult Details(int id){
        Console.WriteLine("In customer details "+id);
        Customer c=_svc.GetById(id);
         Console.WriteLine("In customer details "+c);
        return View(c);
    }

    
    public IActionResult Delete(int id){
        Console.WriteLine("In delete "+id);
        _svc.Delete(id);
        return RedirectToAction("GetAllCustomers","Customer",null);
    }


    public IActionResult Edit(int id){
        Customer c=_svc.GetById(id);
        Console.WriteLine("--->"+c);
        return View(c);
    }

    public IActionResult Update( Customer c){
         Console.WriteLine("In Update Controller "+c);
         _svc.Update(c);
         return  RedirectToAction("GetAllCustomers","Customer",null);
    }

    
    public IActionResult AddForm(Customer c){
        Console.WriteLine("In customer form");
       
        return View();
    }

    [HttpPost]
    public IActionResult AddCustomer(Customer c){
        Console.WriteLine("In add customer "+c);
        _svc.AddCustomer(c);
        return  RedirectToAction("GetAllCustomers","Customer",null);
    }
}