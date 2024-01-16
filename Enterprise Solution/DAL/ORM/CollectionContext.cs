using Microsoft.EntityFrameworkCore;
//using MySql.EntityFrameworkCore.Extensions;
using BOL;

namespace DAL;

public class CollectionContext:DbContext{


    public DbSet<Customer> Customers {get;set;}
    public DbSet<Products> Products {get;set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string ConnectionString=@"server=localhost; port=3306; user=root; password=root123; database=dotnet";
        optionsBuilder.UseMySQL(ConnectionString);

    }

    // protected override void OnModelCreating(ModelBuilder modelBuilder)
    // {
    //     base.OnModelCreating(modelBuilder);
    //     modelBuilder.Entity<Customer>(entity=>{
    //         entity.HasKey(e=>e.Id);
    //         entity.Property(e=>e.Username);
    //         entity.Property(e=>e.Password);
    //         entity.Property(e=>e.Address);
    //         entity.Property(e=>e.Email);
    //         entity.Property(e=>e.Phone);

    //     });
    // }


}
