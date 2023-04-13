using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;

class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Salary { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        string connectionString = "Data Source=(local);Initial Catalog=MyDatabase;Integrated Security=True";
        List<Employee> employees = new List<Employee>();

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string sql = "SELECT * FROM Employees";
            SqlCommand command = new SqlCommand(sql, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Employee employee = new Employee();
                employee.Id = (int)reader["Id"];
                employee.Name = reader["Name"].ToString();
                employee.Salary = (decimal)reader["Salary"];
                employees.Add(employee);
            }

            reader.Close();
        }

        // Сортування співробітників за зарплатою за зростанням
        List<Employee> sortedEmployees = employees.OrderBy(e => e.Salary).ToList();

        // Виведення відсортованого списку співробітників
        Console.WriteLine("Список співробітників, відсортований за зарплатою за зростанням:");
        foreach (Employee employee in sortedEmployees)
        {
            Console.WriteLine($"Id: {employee.Id}, Name: {employee.Name}, Salary: {employee.Salary}");
        }
    }
}
