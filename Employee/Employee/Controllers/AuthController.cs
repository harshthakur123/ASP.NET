using Employee.Service;
using Employee.Entity;
using Microsoft.AspNetCore.Mvc;

namespace Auth.Controllers;

public class AuthController:Controller{

    EmployeeService svc=new EmployeeService();

    public AuthController(){
        Console.WriteLine("In auth controller---------------------------->");
    }

    public IActionResult Login(string uname,string psw){
        List<Employees>list=svc.GetAll();
        Console.WriteLine(uname+" "+psw);
        if(uname=="admin" && psw=="admin123"){
             return RedirectToAction("getall","employee");
        }
        foreach(Employees e in list){
            if(e.Email==uname && e.Mobile_No==psw){
                
                return View(svc.GetById(e.Id));
            }
        }
        
        return RedirectToAction("index","home");
    }

     [HttpPost]
     public IActionResult Update(Employees e){
        svc.Update(e);
        return RedirectToAction("login","auth");
    }





}