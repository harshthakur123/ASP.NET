using FruitApp.Entities;
namespace FruitApp.Repositories;

public interface IDBManager{

    public List<Fruit>GetAll();
    public Fruit GetByName(string name);
    public bool AddFruit(Fruit f);
    public bool Update(Fruit f);
    public bool Delete(string name);




}