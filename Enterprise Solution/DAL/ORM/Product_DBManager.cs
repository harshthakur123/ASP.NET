using BOL;

namespace DAL;

public class Product_DBManager : I_ProductDBManager
{
    public bool AddCustomer(Products p)
    {   using(var context=new CollectionContext()){
        context.Add(p);
        return true;
    }
        throw new NotImplementedException();
    }

   

    public bool Delete(int Id)
    {   using(var context=new CollectionContext()){
        context.Remove(context.Products.Find(Id));
        context.SaveChanges();
        return true;
    }
        throw new NotImplementedException();
    }

    public List<Products> GetAll()
    {   
        using(var context=new CollectionContext()){
            var products=from product in context.Products select product;
            return products.ToList<Products>();
        }
        throw new NotImplementedException();
    }

    public Products GetById(int Id)
    {   
        using(var context=new CollectionContext()){
            var product = context.Products.Find(Id);
            return product;
        }
        throw new NotImplementedException();
    }

    public bool Update(Products p)
    {   
        using(var context=new CollectionContext()){
            var product=context.Products.Find(p.PId);
            product.Name=p.Name;
            product.Price=p.Price;
            product.Brand=p.Brand;
            product.IsAcoustic=p.IsAcoustic;
            product.Type=p.Type;
            context.SaveChanges();
            return true;
        }
        throw new NotImplementedException();
    }
}