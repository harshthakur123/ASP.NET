using System.Data;
using BOL;
using MySql.Data.MySqlClient;

namespace DAL;

public class MySqlDBManager
{

    public List<Customer> GetAll()
    {
        Console.WriteLine("In customer getall");
        List<Customer> customers = new List<Customer>();
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = @"server=localhost; port=3306; user=root; password=root123; database=dotnet";
        MySqlCommand cmd = new MySqlCommand();
        cmd.Connection = con;
        cmd.CommandText = "select * from customer";

        try
        {

            con.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {

                int id = int.Parse(reader["Id"].ToString());
                string? username = reader["Username"].ToString();
                string? password = reader["Password"].ToString();
                string? address = reader["Address"].ToString();
                string? email = reader["Email"].ToString();
                string? phone = reader["Phone"].ToString();


                Customer customer = new Customer
                {
                    Id = id,
                    Username = username,
                    Password = password,
                    Address = address,
                    Email = email,
                    Phone = phone

                };

                customers.Add(customer);
            }
            reader.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
        finally
        {
            con.Close();

        }

        return customers;
    }

    public Customer GetById(int Id)
    {
        Console.WriteLine("In customer details");
        Customer customer = new Customer();

        using (MySqlConnection con = new MySqlConnection(@"server=localhost; port=3306; user=root; password=root123; database=dotnet"))
        {
            con.Open();

            using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM customer WHERE id = @Id", con))
            {
                cmd.Parameters.AddWithValue("@Id", Id);

                try
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            customer.Id = Convert.ToInt32(reader["Id"]);
                            customer.Username = reader["Username"] as string;
                            customer.Password = reader["Password"] as string;
                            customer.Address = reader["Address"] as string;
                            customer.Email = reader["Email"] as string;
                            customer.Phone = reader["Phone"] as string;
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: " + e.Message);
                    // Log the exception or handle it appropriately
                }
            }
        }

        return customer;
    }

    public bool Delete(int Id)
    {
        Console.WriteLine("In customer delete");

        using (MySqlConnection con = new MySqlConnection(@"server=localhost; port=3306; user=root; password=root123; database=dotnet"))
        {
            con.Open();

            using (MySqlCommand cmd = new MySqlCommand("DELETE FROM customer WHERE id = @Id", con))
            {
                cmd.Parameters.AddWithValue("@Id", Id);

                try
                {
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Customer record deleted successfully.");
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("Customer record with specified Id not found.");
                        return false;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: " + e.Message);
                    // Log the exception or handle it appropriately
                    return false;
                }
            }

        }
    }

    public bool Update(Customer customer)
    {
        int id = customer.Id;
        string username = customer.Username;

        string address = customer.Address;
        string email = customer.Email;
        string phone = customer.Phone;


        Console.WriteLine("In customer update");

        using (MySqlConnection con = new MySqlConnection(@"server=localhost; port=3306; user=root; password=root123; database=dotnet"))
        {
            con.Open();

            using (MySqlCommand cmd = new MySqlCommand("update customer set Username=@username,"
            + "Address=@address,Email=@email,Phone=@phone where Id=@id", con))
            {
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@email", email);


                cmd.Parameters.AddWithValue("@Id", id);

                try
                {
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Customer record updated successfully.");
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("Customer record with specified Id not found.");
                        return false;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: " + e.Message);
                    // Log the exception or handle it appropriately
                    return false;
                }
            }

        }
    }

    public bool AddCustomer(Customer customer)
    {
        int id =customer.Id;
        string username = customer.Username;
        string password = customer.Password;
        string address = customer.Address;
        string email = customer.Email;
        string phone = customer.Phone;


        Console.WriteLine("In customer add "+ password);

        using (MySqlConnection con = new MySqlConnection(@"server=localhost; port=3306; user=root; password=root123; database=dotnet"))
        {
            con.Open();

            using (MySqlCommand cmd = new MySqlCommand("insert into customer (Id,Username,Password,Address,Email,Phone) values (@id, @username,@password,@address,@email,@phone)", con))
            {   
                cmd.Parameters.AddWithValue("@id", id);   
                cmd.Parameters.AddWithValue("@username", username);             
                cmd.Parameters.AddWithValue("@password", password); 
                
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@email", email);

               

                try
                {
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Customer record added successfully.");
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("Cannot add");
                        return false;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: " + e.StackTrace);
                    // Log the exception or handle it appropriately
                    return false;
                }
            }

        }
    }
    
    
}