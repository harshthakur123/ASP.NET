using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Employee.Entity;

[Serializable]
[Table("Employee")]
public class Employees{

    [Key]
    public int Id{get;set;}
    public string Name{get;set;}
    public string Email{get;set;}
    public string Mobile_No{get;set;}
    public string Address{get;set;}
    public double? Salary{get;set;}
    public string Department{get;set;}
    public double? Commission{get;set;}

    public override string ToString()
    {
        return Id+" "+Name+" "+Salary+" "+Department+" "+Commission;
    }

}