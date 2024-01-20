using Employee.Repositories;
using Employee.Entity;

namespace Employee.Service;

public interface IEmployeeService
{


    public List<Employees> GetAll();

    public Employees GetById(int Id);

    public bool Delete(int Id);

    public bool Update(Employees e);
    public bool Add(Employees e);



}