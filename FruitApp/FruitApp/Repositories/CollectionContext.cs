using Microsoft.EntityFrameworkCore;
using FruitApp.Entities;
namespace FruitApp.Repositories;
public class CollectionContext : DbContext
{


    public DbSet<Fruit> Fruits { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        string ConnectionString = @"server=localhost;port=3306;user=root;password=root123;database=dotnet1";
        optionsBuilder.UseMySQL(ConnectionString);
    }


}