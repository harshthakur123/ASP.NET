using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BOL;

[Serializable]
[Table("Product")]
public class Products{
    [Key]
    public int PId{get;set;}
    public string? Name{get;set;}
    public string? Type{get;set;}
    public double? Price{get;set;}
    public string? Brand{get;set;}
    public Boolean IsAcoustic{get;set;} 



}