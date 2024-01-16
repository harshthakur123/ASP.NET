using BLL;
using BOL;

namespace DAL;

public interface ICustomerService{

    public List<Customer> GetAllCustomers();

    public Customer GetById(int Id);
    
    public Boolean Delete(int id);

    public Boolean Update(Customer c);

    public Boolean AddCustomer(Customer c);

}