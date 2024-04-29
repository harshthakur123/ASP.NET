using FruitApp.Entities;

namespace FruitApp.Repositories;

public class DBManager : IDBManager
{   

    public DBManager(){
        Console.WriteLine("--------------------------------->In DBManager");
    }

    public bool AddFruit(Fruit f)
    {   
        using(var context=new CollectionContext()){
            context.Fruits.Add(f);
            context.SaveChanges();
        }
        return true;
        throw new NotImplementedException();
    }

    public bool Delete(string name)
    {   
        using(var context=new CollectionContext()){
            Fruit f=context.Fruits.Find(name);
            context.Fruits.Remove(f);
            context.SaveChanges();
        }
        return true;
        throw new NotImplementedException();
    }

    public List<Fruit> GetAll()
    {   
        using(var context=new CollectionContext()){
            var FruitsList=from fruits in context.Fruits select fruits;
            return FruitsList.ToList<Fruit>();
        }
        throw new NotImplementedException();
    }

    public Fruit GetByName(string name)
    {   
        using(var context=new CollectionContext()){
            Fruit f=context.Fruits.Find(name);
            return f;
        }
        throw new NotImplementedException();
    }

    public bool Update(Fruit f)
    {
        using(var context=new CollectionContext()){
            Fruit fruit=context.Fruits.Find(f.Name);
            fruit.Price=f.Price;
            fruit.Quantity=f.Quantity;
            fruit.Taste=f.Taste;
            fruit.Colour=f.Colour;
            context.SaveChanges();
        }
        return true;
        throw new NotImplementedException();
    }
}