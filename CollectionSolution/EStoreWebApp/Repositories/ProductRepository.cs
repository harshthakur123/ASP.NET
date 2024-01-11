using HRAPP.Entities;
namespace HRAPP.Repositories;

using System.Collections.Generic;
using System.IO;
using System.Text.Json;



public class ProductsRepositoryManager{


    public ProductsRepositoryManager(){
        Console.WriteLine("In Products repository manager");
    }

    public void Serialize(List<Products> prod,string fileName){

    var options=new JsonSerializerOptions {IncludeFields=true};
    var custJson=JsonSerializer.Serialize<List<Products>>(prod,options);
    File.WriteAllText(fileName,custJson);
   
    }
    public List<Products> DeSerialize(string fileName){
   
         //Deserialize from JSON file
            string jsonString = File.ReadAllText(fileName);
            List<Products> jsonProducts = JsonSerializer.Deserialize<List<Products>>(jsonString);
           /* Console.WriteLine("\n JSON :Deserializing data from json file\n \n");
            foreach( Products emp in jsonProductss)
            {
                Console.WriteLine($"{emp.Id} : {emp .Name}");   
            }*/      
        return jsonProducts;
    }
}