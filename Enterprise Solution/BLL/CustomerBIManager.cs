using DAL;
using BOL;


namespace BLL;

public class CustomerBIManager{

    //MySqlDBManager mgr=new MySqlDBManager();
    Customer_DBManager mgr=new Customer_DBManager();
    

   public CustomerBIManager(){
          Console.WriteLine("In customer BIManager---------------------------");
    }

    public List<Customer> GetAllCusomter(){
       
        List<Customer> customers=new List<Customer>();
        customers=mgr.GetAll();
        
        return customers;
    }

    public Customer GetById(int Id){
      
        

        return mgr.GetById(Id);
    }

    public Boolean Delete(int id){
       return mgr.Delete(id);
    }

    public Boolean Update(Customer c){
         Console.WriteLine("In customer BLL update "+c);
        return mgr.Update(c);
    }
     public Boolean AddCustomer(Customer c){
         Console.WriteLine("In customer BLL add "+c);
        return mgr.AddCustomer(c);
    }
}