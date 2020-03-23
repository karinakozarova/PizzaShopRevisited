using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShop
{
    class Drink
    {
        const string tableName = "drink";
        public string Name
        {
            get;
            set;
        }

        // TODO: this can have restictions on the minimum price
        public decimal Price
        {
            get;
            set;
        }

        // TODO: this can have restictions on the maximum price
        public int Quantity
        {
            get;
            set;
        }

        public int Id
        {
            get;
            private set;
        }

        // constructors
        public Drink(string name, decimal price, int quantity)
        {
            this.Name = name;
            this.Quantity = quantity;
            this.Price = price;
            this.Id = AddDrinkToDb(name, price, quantity);
        }

        public Drink(int id, string name, decimal price, int quantity)
        {
            this.Name = name;
            this.Quantity = quantity;
            this.Price = price;
            this.Id = id;
        }

        public static int AddDrinkToDb(string name, decimal price, int quantity)
        {
            MySqlConnection conn = Utils.GetConnection();
            int id;
            try
            {
                string sql = "INSERT INTO " + tableName + "(name, price) VALUES (@name, @price);";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@price", price);
                conn.Open();
                cmd.ExecuteNonQuery();
                id = Convert.ToInt32(cmd.LastInsertedId);
            }
            catch (Exception)
            {
                id = -1;
            }
            finally
            {
                conn.Close();
            }
            return id;
        }
        public static Drink GetDrinkById(int id)
        {

        }
        public static List<Drink> GetAllDrinks()
        {

        }

        /// <summary>
        /// Calculate the total cost of the order
        /// </summary>
        /// <returns> order price </returns>
        public decimal CalculatePrice()
        {
            return Price * Quantity;
        }

        /// <summary>
        /// Stringify the object
        /// </summary>
        /// <returns> the name of the drink </returns>
        public override string ToString()
        {
            return this.Name;
        }
    }
}
