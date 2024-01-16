using DAL;
using BOL;

namespace BLL;

public class ProductBIManager{

    Product_DBManager mgr=new Product_DBManager();
    public ProductBIManager(){
        Console.WriteLine("In product BIManager-------------->");
    }


    public List<Products>GetAll(){
        return mgr.GetAll();
    }
    public Products GetById(int Id){
        return mgr.GetById(Id);
    }
    public Boolean Delete(int Id){
        return mgr.Delete(Id);
    }
    public Boolean Update(Products p){
        return mgr.Update(p);
    }
    public Boolean AddCustomer(Products p){
        return mgr.AddCustomer(p);
    }



}