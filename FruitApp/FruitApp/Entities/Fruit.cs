using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace FruitApp.Entities;

[Serializable]
[Table("Fruit")]
public class Fruit{
    [Key]
    public string Name{get;set;}
    [NotNull]
    public double Price{get;set;}
     [NotNull]
    public string Taste{get;set;}
     [NotNull]
    public string Colour{get;set;}
     [NotNull]
    public int Quantity{get;set;}

    public override string ToString()
    {
        return Name+" "+Price+" "+Taste+" "+Colour+" "+Quantity;
    }


}