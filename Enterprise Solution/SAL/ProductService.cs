using BOL;
using BLL;
using DAL;

namespace SAL;

public class ProductService:IProductService{

    ProductBIManager mgr=new ProductBIManager();
    public ProductService(){
        Console.WriteLine("In product service SAL -------------------------");
    }

    public bool AddCustomer(Products p)
    {   
        mgr.AddCustomer(p);
        throw new NotImplementedException();
    }

    public bool Delete(int Id)
    {   
        mgr.Delete(Id);
        throw new NotImplementedException();
    }

    public List<Products> GetAll()
    {   
        mgr.GetAll();
        throw new NotImplementedException();
    }

    public Products GetById(int Id)
    {   
        mgr.GetById(Id);
        throw new NotImplementedException();
    }

    public bool Update(Products p)
    {   
        mgr.Update(p);
        throw new NotImplementedException();
    }
}