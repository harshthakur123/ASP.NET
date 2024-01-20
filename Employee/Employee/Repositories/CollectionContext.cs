using Microsoft.EntityFrameworkCore;
using Employee.Entity;

namespace Employee.Repositories;

public class CollectionContext:DbContext{

    public DbSet<Employees>EmployeeSet{get;set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        string ConnectionString=@"server=localhost;user=root;password=root123;port=3306;database=dotnet1";
        optionsBuilder.UseMySQL(ConnectionString);
    }



}