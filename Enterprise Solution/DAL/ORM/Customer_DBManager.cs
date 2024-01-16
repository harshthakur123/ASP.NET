using BOL;

namespace DAL;

public class Customer_DBManager : I_CustomerDBManager
{

    public Customer_DBManager(){
        Console.WriteLine("In customer DBManager ORM---------------------------");
    }

    public bool Delete(int Id)
    {   
        using(var context=new CollectionContext()){
            context.Customers.Remove(context.Customers.Find(Id));
            context.SaveChanges();  // SaveChanges() required after every modification (Delete/Update/Insert)
            return true;
        }
        throw new NotImplementedException();
    }

    public  List<Customer> GetAll()
    {
        using(var context=new CollectionContext()){
            var customers=from cust in context.Customers select cust;
            return customers.ToList<Customer>();
        }
       
    }

    public Customer GetById(int Id)
    {    using(var context=new CollectionContext()){
            var customer=context.Customers.Find(Id);
             Console.WriteLine("In customer details DB "+customer);
            return customer;
        }
        throw new NotImplementedException();
    }

    public bool AddCustomer(Customer c)
    {   
        using(var context =new CollectionContext()){
            Console.WriteLine(c);
            context.Customers.Add(c);
            context.SaveChanges(); // SaveChanges() required after every modification (Delete/Update/Insert)
            return true;

        }
        throw new NotImplementedException();
    }

    public bool Update(Customer c)
    {   
        using(var context=new CollectionContext()){
            var cUpd=context.Customers.Find(c.Id);
            Console.WriteLine(c+"------------->");
            cUpd.Username=c.Username;
            cUpd.Address=c.Address;
            cUpd.Email=c.Email;
            cUpd.Phone=c.Phone;
            context.SaveChanges(); // SaveChanges() required after every modification (Delete/Update/Insert)
            return true;
        }

        throw new NotImplementedException();
    }
}