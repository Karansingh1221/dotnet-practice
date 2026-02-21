using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;

namespace AdoNetDataReaderDemo
{
    // Product Model
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string connectionString =
                "Data Source=SYSTUMM\\SQLEXPRESS;" +
            "initial catalog=CollegeDb;Integrated Security=True;Connect Timeout=30;" +
            "Encrypt=True;TrustServerCertificate=True;";

            List<Product> products = new List<Product>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT Id, Name, Price, Stock FROM Products";

                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Product product = new Product
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Price = reader.GetDecimal(2),
                            Stock = reader.GetInt32(3)
                        };

                        products.Add(product);
                    }
                }
            }

            // Output
            foreach (var p in products)
            {
                Console.WriteLine($"{p.Id} - {p.Name} - {p.Price} - {p.Stock}");
            }
        }
    }
}