using HRAPP.Entities;
using HRAPP.Repositories;

namespace HRAPP.Services;

public class ProductService:IProductService{

    List<Products>products=new List<Products>();
    ProductsRepositoryManager prm=new ProductsRepositoryManager();
    string filename=@"D:\C-DAC\IACSD\.NET\Material\DotNet Technologies\Day7\CollectionSolution\Product.json";

    public ProductService(){
        products=prm.DeSerialize(filename);
        
    }

    public List<Products> GetAllProducts(){
        return products;

    }
   // public string AddProduct(Products p){}

   // public string DeleteProduct(int pid){}
   // public string UpdateProducts(int id,Products p){}
    



}