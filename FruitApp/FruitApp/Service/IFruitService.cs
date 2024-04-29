using FruitApp.Entities;
using FruitApp.Repositories;

namespace FruitApp.Service;

public interface IFruitService{
    public List<Fruit>GetAll();
    public Fruit GetByName(string name);
    public bool AddFruit(Fruit f);
    public bool Update(Fruit f);
    public bool Delete(string name);
}