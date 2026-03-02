using Microsoft.Data.SqlClient;
using System.Data;
namespace ADO.NETCoreDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string connectionString= "Data Source=LAPTOP-HP1513\\SQLEXPRESS01;Initial Catalog=Employeedb;TrustServerCertificate=True;Integrated Security=True";
                GetAllEmployees(connectionString);
                int EmployeeId = 1;
                GetEmployeeById()
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Something went wrong: {ex.Message}");
            }
            static void GetAllEmployees(string connectionstring)
            {
                Console.WriteLine("Get All Employees Stored Procedure Called");
                using(SqlConnection connection = new SqlConnection(connectionstring))
                {
                    SqlCommand command = new SqlCommand("GetAllEmployees", connection);
                    command.CommandType=CommandType.StoredProcedure;
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine($"EmployeeId: {reader["EmployeeId"]},"+$" FirstName: {reader["FirstName"]}, LastName: {reader["LastName"]}

                    }
                }
            }
        }
    }
}
