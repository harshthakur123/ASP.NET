using Employee.Entity;

namespace Employee.Repositories;

public interface IDBManager
{

    public List<Employees> GetAll();

    public Employees GetById(int Id);

    public bool Delete(int Id);

    public bool Update(Employees e);
    public bool Add(Employees e);



}