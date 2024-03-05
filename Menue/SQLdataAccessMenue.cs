using System;
using System.Collections.Generic;
using System.Data.SqlClient;

public class DataAccess : IGetMenue
    {
        private string connectionString;

        public DataAccess(string connectionString)
        {
            this.connectionString = Helper.GetConnectionString("Menue");
        }

        public List<Dish> GetMenu()
        {
            List<Dish> menu = new List<Dish>();

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
                    menu.Add(menuItem); // Changed to add menuItem to the menu list
                }

                reader.Close();
            }

            return menu;
        }
    }
