using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;

string connectionString = "Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;";
SqlConnection connection = new SqlConnection(connectionString);
connection.Open();

string connectionString = "Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;";
SqlConnection connection = new SqlConnection(connectionString);
connection.Open();

List<Product> products = new List<Product>();

while (reader.Read())
{
    Product product = new Product
    {
        Id = (int)reader["Id"],
        Name = reader["Name"].ToString(),
        Category = reader["Category"].ToString(),
        Price = (decimal)reader["Price"]
    };
    products.Add(product);
}

var groupedProducts = products.GroupBy(p => p.Category);
foreach (var group in groupedProducts)
{
    Console.WriteLine("Category: " + group.Key);
    foreach (var product in group)
    {
        Console.WriteLine(" - " + product.Name + " (" + product.Price + ")");
    }
}
