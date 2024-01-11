using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EStoreWebApp.Models;
using HRAPP.Entities;
using HRAPP.Repositories;
using HRAPP.Services;
using Microsoft.AspNetCore.Identity;
namespace EStoreWebApp.Controllers;

public class CustomersController:Controller{

    CustomerService customerService=new CustomerService();
    public CustomersController(){
        Console.WriteLine("In customer controller...");
    }
    

    [HttpGet]
     public IActionResult GetAllCustomers()
    {
       List<Customer> customers=new List<Customer>();
       customers=customerService.GetAllCustomers();
      
        ViewData["CustomersList"]=customers;
        
        return View();
    }

    [HttpGet]
     public Customer GetById(int Id)
    {
        Console.WriteLine("Get by id");
        return customerService.GetById(Id);
    }


        public IActionResult DeleteCustomer(int id)
        {
            Console.WriteLine("In delete");
           
                bool deletionResult = customerService.DeleteCustomer(id);

                if (deletionResult)
                {
                    // Customer successfully deleted
                    
                     Console.WriteLine("DeleteCustomer action reached with customerID: " + id);
                    return RedirectToAction("GetAllCustomers","Customers",null);
                }
                else
                {
                    // Customer not found or unable to delete
                    return NotFound();
                }
            
            
        }

        [HttpGet]
        public IActionResult Edit(int Id){
            Console.WriteLine("In edit "+Id);
           
            Customer c=customerService.GetById(Id);
           
            Console.WriteLine(c);
            return View("Edit",c);
        }

        [HttpPost]
        public IActionResult Update(Customer c){
             Console.WriteLine("In update"+c);
            customerService.UpdateCustomer(c);
             Console.WriteLine(c);
           return RedirectToAction("GetAllCustomers","Customers",null);
        }


}