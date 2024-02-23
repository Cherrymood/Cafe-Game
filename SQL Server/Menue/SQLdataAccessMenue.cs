using System;
using System.Collections.Generic;
using System.Data.SqlClient;

public class DataAccess
    {
        private string connectionString;

        public DataAccess(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<Dish> GetMenu()
        {
            List<Dish> menu = new List<Dish>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Menu"; // Assuming your table name is "Menu"
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Dish menuItem = new Dish(); // Changed variable name to menuItem
                    menuItem.DishID = Convert.ToInt32(reader["MenuID"]);
                    menuItem.DishName = Convert.ToString(reader["MenuName"]);
                    menuItem.Price = Convert.ToInt32(reader["Price"]);
                    menuItem.DishDescription = Convert.ToString(reader["MenuDescription"]);
                    menu.Add(menuItem); // Changed to add menuItem to the menu list
                }

                reader.Close();
            }

            return menu;
        }
    }
