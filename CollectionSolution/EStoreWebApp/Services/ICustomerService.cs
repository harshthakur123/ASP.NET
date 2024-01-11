using HRAPP.Entities;
namespace HRAPP.Services;

public interface ICustomerService{


    public List<Customer>GetAllCustomers();
    public Customer GetById(int Id);
    public Boolean UpdateCustomer(Customer c);
    public string AddCustomer(Customer c);
    public  Boolean DeleteCustomer(int Id);
    public Boolean ChangePassword(string username,string password);


}