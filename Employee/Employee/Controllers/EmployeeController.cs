using Employee.Service;
using Employee.Entity;
using Microsoft.AspNetCore.Mvc;

namespace Employee.Controllers;

public class EmployeeController:Controller{

    EmployeeService svc=new EmployeeService();

    public EmployeeController(){
        Console.WriteLine("-------------------------------->In EMployee Controller");

    }

    [HttpGet("GetAll")]
    public IActionResult GetAll(){
        List<Employees> list=svc.GetAll();
        
        return View(list);
    }

    
    
    public IActionResult AddForm(){
        return View();
    }

    [HttpPost]
     public IActionResult Add(Employees e){
        svc.Add(e);
        return RedirectToAction("Getall","Employee");
    }


   
     public IActionResult Delete(int Id){
        svc.Delete(Id);
        return RedirectToAction("Getall","Employee");
    }


    
    public IActionResult EditForm(int Id){
        Employees e=svc.GetById(Id);
        
        return View(e);
    }

    [HttpGet("EmpEdit")]
    public IActionResult EmployeeEdit(string uname,string psw){
        int id=0;   
        Console.WriteLine(uname+" "+psw);
        List<Employees>list=svc.GetAll();
        foreach(Employees emp in list){
            if(emp.Email==uname){
                id=emp.Id;
                break;
            }
        }
        Employees e=svc.GetById(id);
        Console.WriteLine(e+"------>");
        
        return View(e);
    }

    [HttpPost]
     public IActionResult Update(Employees e){
        svc.Update(e);
        return RedirectToAction("Getall","Employee");
    }





}