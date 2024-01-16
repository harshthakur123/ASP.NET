using BOL;
using BLL;

namespace SAL;

public interface IProductService{

    public List<Products>GetAll();
    public Products GetById(int Id);
    public Boolean Delete(int Id);
    public Boolean Update(Products p);
    public Boolean AddCustomer(Products p);


}