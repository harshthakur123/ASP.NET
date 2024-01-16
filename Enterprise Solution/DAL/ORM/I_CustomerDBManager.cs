namespace DAL;

using BOL;

public interface I_CustomerDBManager{

    public List<Customer>GetAll();
    public Customer GetById(int Id);
    public Boolean Delete(int Id);
    public Boolean Update(Customer c);
    public Boolean AddCustomer(Customer c);

}