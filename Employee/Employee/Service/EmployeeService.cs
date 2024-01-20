using Employee.Repositories;
using Employee.Entity;

namespace Employee.Service;

public class EmployeeService : IEmployeeService
{   

    DBManager mgr=new DBManager();

    public EmployeeService(){

        Console.WriteLine("------------------------------>In Employee Service");
    }


    public bool Add(Employees e)
    {   
        mgr.Add(e);
        return true;
        throw new NotImplementedException();
    }

    public bool Delete(int Id)
    {   
        mgr.Delete(Id);
        return true;
        throw new NotImplementedException();
    }

    public List<Employees> GetAll()
    {   
       
        return  mgr.GetAll(); ;
        throw new NotImplementedException();
    }

    public Employees GetById(int Id)
    {   
        return mgr.GetById(Id);
        throw new NotImplementedException();
    }

    public bool Update(Employees e)
    {   
        mgr.Update(e);
        return true;
        throw new NotImplementedException();
    }
}