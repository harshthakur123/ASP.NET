using HRAPP.Entities;
namespace HRAPP.Repositories;

using System.Collections.Generic;
using System.IO;
using System.Text.Json;



public class CustomerRepositoryManager{


    public CustomerRepositoryManager(){
        Console.WriteLine("In customer repository manager");
    }

    public void Serialize(List<Customer> cust,string fileName){

    var options=new JsonSerializerOptions {IncludeFields=true};
    var custJson=JsonSerializer.Serialize<List<Customer>>(cust,options);
    File.WriteAllText(fileName,custJson);
   
    }
    public List<Customer> DeSerialize(string fileName){
   
         //Deserialize from JSON file
            string jsonString = File.ReadAllText(fileName);
            List<Customer> jsonCustomers = JsonSerializer.Deserialize<List<Customer>>(jsonString);
           /* Console.WriteLine("\n JSON :Deserializing data from json file\n \n");
            foreach( Customer emp in jsonCustomers)
            {
                Console.WriteLine($"{emp.Id} : {emp .Name}");   
            }*/      
        return jsonCustomers;
    }
}