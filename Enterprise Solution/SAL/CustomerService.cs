using BOL;
using BLL;
using DAL;

namespace SAL;

public class CustomerService:ICustomerService{


    public CustomerService(){
          Console.WriteLine("In customer Services ---------------------------");
    }
    
    
    CustomerBIManager BI=new CustomerBIManager();
    public List<Customer> GetAllCustomers(){
       List<Customer> customers=new List<Customer>();
       
        customers=BI.GetAllCusomter();
       

        return customers;
    }
    
    public Customer GetById(int Id){
   
        return BI.GetById(Id);
    }

    public Boolean Delete(int id){
       return BI.Delete(id);
    }

    public Boolean Update(Customer c){
        return BI.Update(c);
    }
    public Boolean AddCustomer(Customer c){
        return BI.AddCustomer(c);
    }

}