using Employee.Entity;

namespace Employee.Repositories;

public class DBManager : IDBManager
{
    public DBManager(){
        Console.WriteLine("---------------------------> In dbmanager");
    }

    public bool Add(Employees e)
    {   
        using(var context=new CollectionContext()){
            context.EmployeeSet.Add(e);
            context.SaveChanges();
        }
        return true;
        
    }

    public bool Delete(int Id)
    {   
        using(var context=new CollectionContext()){
            Employees e=context.EmployeeSet.Find(Id);
            context.EmployeeSet.Remove(e);
            context.SaveChanges();
            return true;
        }
       
        throw new NotImplementedException();
    }

    public List<Employees> GetAll()
    {   
        using(var context=new CollectionContext()){
            var EmployeeList=from emp in context.EmployeeSet select emp;
            return EmployeeList.ToList<Employees>();
        }
        throw new NotImplementedException();
    }

    public Employees GetById(int Id)
    {   
        using(var context=new CollectionContext()){
            Employees e=context.EmployeeSet.Find(Id);
            return e;
        }
        throw new NotImplementedException();
    }

    public bool Update(Employees e)
    {   
        using(var context=new CollectionContext()){
            Employees eUpd=context.EmployeeSet.Find(e.Id);
            eUpd.Name=e.Name;
            eUpd.Salary=e.Salary;
            eUpd.Department=e.Department;
            eUpd.Commission=e.Commission;
            eUpd.Address=e.Address;
            eUpd.Email=e.Email;
            eUpd.Mobile_No=e.Mobile_No;
            context.SaveChanges();
            return true;
        }
        throw new NotImplementedException();
    }
}