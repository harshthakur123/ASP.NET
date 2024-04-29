using FruitApp.Entities;
using FruitApp.Service;
using Microsoft.AspNetCore.Mvc;

namespace FruitApp.Controllers;

public class FruitController:Controller{

    FruitService svc=new FruitService();

    public FruitController(){
        Console.WriteLine("-------------------------------------------->In FruitController");
    }

    public IActionResult GetAll(){
        List<Fruit> fruits=svc.GetAll();
        return View(fruits);
    }

    public IActionResult Details(string name){
        Console.WriteLine("--------------------------->name"+name);
        Fruit f=svc.GetByName(name);
        Console.WriteLine(f+"----------------------->ctrll");
        return View(f);
    }

    public IActionResult AddForm(){
        return View();
    }

    [HttpPost]
    public IActionResult Add(Fruit f){
        svc.AddFruit(f);
        return RedirectToAction("getall","fruit");
    }

    public IActionResult UpdateForm(string name){
        Fruit f=svc.GetByName(name);
        return View(f);
    }

    
    [HttpPost]
    public IActionResult Update(Fruit f){
        svc.Update(f);
        return RedirectToAction("getall","fruit");
    }

    public IActionResult Delete(string name){
        svc.Delete(name);
       return RedirectToAction("getall","fruit");
    }




}