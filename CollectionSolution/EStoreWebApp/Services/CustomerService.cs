using HRAPP.Entities;
using HRAPP.Repositories;

namespace HRAPP.Services;

public class CustomerService : ICustomerService
{


    CustomerRepositoryManager crm = new CustomerRepositoryManager();
    List<Customer> customers = new List<Customer>();
    string filename = @"D:\C-DAC\IACSD\.NET\Material\DotNet Technologies\Day7\CollectionSolution\Customer.json";




    public CustomerService()
    {
        Console.WriteLine("In Customer Service");
        customers = crm.DeSerialize(filename);
    }

    public List<Customer> GetAllCustomers()
    {
        Console.WriteLine("Get all");
        return customers;
    }

    public Customer GetById(int Id)
    {
        Console.WriteLine("Get by id");
        return customers.Find(customer=>customer.Id==Id);
    }

    public string AddCustomer(Customer c)
    {

        customers.Add(c);
        crm.Serialize(customers, filename);
        return "Customer registered successfully!!!";

    }

    public Boolean DeleteCustomer(int Id)
    {
        Console.WriteLine("in delete service " + Id);
        Customer c = customers.Find(customer => customer.Id == Id);
        Console.WriteLine(c);
        if (c != null)
        {
            customers.Remove(c);
            crm.Serialize(customers, filename);
            return true;
        }

        // If the customer with the specified Id is not found, you might want to return false or throw an exception.
        return false;
    }


    public Boolean UpdateCustomer(Customer c){
        Console.WriteLine("In service update "+c);
        Customer updCust=customers.Find(customer=>customer.Id==c.Id);
        Console.WriteLine(updCust);
        updCust.Username=c.Username;
        updCust.Address=c.Address;
        updCust.Phone=c.Phone;
        updCust.Email=c.Email;
        crm.Serialize(customers,filename);
        return true;
    }

    public Boolean ChangePassword(string username,string password){
        Console.WriteLine(username+" "+password);
         Customer c=customers.Find(customer=>customer.Username==username);
         Console.WriteLine(c);
         c.Password=password;
         crm.Serialize(customers,filename);
         return true;   
    }

    public Boolean IsUsernameValid(string username){
        foreach(Customer c in customers){
            if(c.Username==username){
                return true;
            }
        }

        return false;
    }


}