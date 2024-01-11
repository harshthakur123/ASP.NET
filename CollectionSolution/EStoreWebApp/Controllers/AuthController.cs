using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EStoreWebApp.Models;
using HRAPP.Entities;
using HRAPP.Repositories;
using HRAPP.Services;
using Microsoft.AspNetCore.Identity;
namespace EStoreWebApp.Controllers;

public class AuthController : Controller
{
    CustomerService customerService=new CustomerService();
    
    [HttpGet]
    public IActionResult SignIn()
    {
        return View();
    }

    [HttpGet]
    public IActionResult Register()
    {
        return View();
    }

 [HttpPost]
public IActionResult SignIn(string uname, string psw)
{
    List<Customer> customers = customerService.GetAllCustomers();

    bool isValidUser = false;

    foreach (Customer c in customers)
    {
        if (uname == c.Username && psw == c.Password)
        {
            isValidUser = true;
            return RedirectToAction("Index", "Products", null);
        }
    }

    if (!isValidUser)
    {
        // Add a model error indicating that the credentials are invalid
        ModelState.AddModelError("", "Invalid username or password. Please try again.");

        // Return the view with the updated ModelState
        return View();
    }

    // Redirect to the SignIn action of the Auth controller
    return Redirect("/Auth/SignIn");
}



[HttpPost]
public IActionResult AddCustomers(Customer customer)
{
    Customer c = new Customer
    {
        Id = customer.Id,
        Username = customer.Username,
        Password = customer.Password,
        Address = customer.Address,
        Email = customer.Email,
        Phone = customer.Phone
    };

    customerService.AddCustomer(c);

    // Redirect to the SignIn action after successfully registering a customer
    return RedirectToAction("SignIn");
}




    public IActionResult ChangePasswordForm(){
      
        return View();
    }

    [HttpPost]
public IActionResult ChangePassword(string username, string psw)
{
    bool isUsernameValid = customerService.IsUsernameValid(username);

    if (isUsernameValid)
    {
        customerService.ChangePassword(username, psw);
        ViewData["SuccessMessage"] = "Password changed successfully!";
        return RedirectToAction("signin", "auth", null);
    }
    else
    {
        ViewData["ErrorMessage"] = "Invalid username. Please enter a valid username.";
        return View("ChangePasswordForm"); // Replace "YourViewName" with the actual name of your view
    }
}

    
}