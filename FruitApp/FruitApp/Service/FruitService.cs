using FruitApp.Repositories;
using FruitApp.Entities;

namespace FruitApp.Service;

public class FruitService : IFruitService
{   
    DBManager mgr=new DBManager();
     public FruitService(){
        Console.WriteLine("--------------------------------------->In Fruit servcie");
     }   
    public bool AddFruit(Fruit f)
    {   
        mgr.AddFruit(f);
        return true;
        throw new NotImplementedException();
    }

    public bool Delete(string name)
    {   
        mgr.Delete(name);
        return true;
        throw new NotImplementedException();
    }

    public List<Fruit> GetAll()
    {   
        return mgr.GetAll();
        throw new NotImplementedException();
    }

    public Fruit GetByName(string name)
    {   return mgr.GetByName(name);
        throw new NotImplementedException();
    }

    public bool Update(Fruit f)
    {   
        mgr.Update(f);
        return true;
        throw new NotImplementedException();
    }
}