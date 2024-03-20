using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;

public class DataAccess : IGetMenue
{
    public List<Dish> GetMenu()
    {
        List<Dish> menu = new List<Dish>();

        try
        {
            var connectionString = ConfigurationManager.ConnectionStrings["Menu"].ConnectionString; 

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Menu";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Dish menuItem = new Dish();
                    menuItem.DishID = Convert.ToInt32(reader["MenuID"]);
                    menuItem.DishName = Convert.ToString(reader["MenuName"]);
                    menuItem.Price = Convert.ToInt32(reader["Price"]);
                    menuItem.DishDescription = Convert.ToString(reader["MenuDescription"]);
                    menuItem.PrepareTime = Convert.ToInt32(reader["PrepareTime"]);
                    menu.Add(menuItem);
                }
            }
        }
        catch (SqlException ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
            // Handle the exception, log it, or rethrow it as needed.
        }

        return menu;
    }
}
