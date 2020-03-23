using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShop
{
    class Customer
    {
        // class constants
        const string tableName = "customer";

        // properties
        public int Id
        {
            get;
            private set;
        }

        public string Name
        {
            get;
            set;
        }
        public string Email
        {
            get;
            set;
        }

        // constructors
        /// <summary>
        /// Creates a new customer and adds it to the database
        /// </summary>
        /// <param name="name"> name of customer </param>
        /// <param name="email"> customer email </param>
        /// <param name="addToDB"> should it be added to the database </param>
        public Customer(string name, string email, bool addToDB = true)
        {
            if (addToDB)
            {
                this.Id = AddCustomerToDb(name, email);
            }
            this.Name = name;
            this.Email = email;
        }

        /// <summary>
        /// Creates a new customer object without adding it to the database
        /// </summary>
        /// <param name="id"> the current id in the db </param>
        /// <param name="name"> name of customer </param>
        /// <param name="email"> email of customer </param>
        public Customer(int id,string name, string email)
        {
            this.Id = id;
            this.Name = name;
            this.Email = email;
        }

        // methods

        /// <summary>
        /// Adds a customer to the database
        /// </summary>
        /// <param name="name"> the name of the customer </param>
        /// <param name="email"> the email of the customer </param>
        /// <returns> the id of the added customer or -1 if it wasnt succesfull </returns>
        public static int AddCustomerToDb(string name, string email)
        {
            MySqlConnection conn = Utils.GetConnection();
            int id;
            try
            {
                string sql = "INSERT INTO " + tableName + "(name, email) VALUES (@name, @email);";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@email", email);
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

        /// <summary>
        /// returns the customer with a specified id
        /// </summary>
        /// <param name="id"> the id of the person we are searching for </param>
        /// <returns> the customer if found, null if not</returns>
        public static Customer GetCustomerById(int id)
        {
            MySqlConnection conn = Utils.GetConnection();

            Customer customer = null;
            try
            {
                string sql = "SELECT name, email FROM " + tableName + " WHERE id=@id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);
                conn.Open();
                MySqlDataReader row = cmd.ExecuteReader();

                while (row.Read())
                {
                    customer = new Customer(id, row[0].ToString(), row[1].ToString());
                }
            }
            catch (Exception){}
            finally
            {
                conn.Close();
            }
            return customer;

        }

        /// <summary>
        /// get all the customers from the database
        /// </summary>
        /// <returns> a list with all the customers </returns>
        public static List<Customer> GetAllCustomers()
        {
            MySqlConnection conn = Utils.GetConnection();

            List<Customer> customers = new List<Customer>();
            try
            {
                string sql = "SELECT id, name, email FROM " + tableName;
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                MySqlDataReader row = cmd.ExecuteReader();

                while (row.Read())
                {
                    customers.Add(new Customer(Convert.ToInt32(row[0]), row[1].ToString(), row[2].ToString()));
                }
            }
            catch (Exception){}
            finally
            {
                conn.Close();
            }
            return customers;
        }

        /// <summary>
        /// Stringify the object
        /// </summary>
        /// <returns> the name of the customer </returns>
        public override string ToString()
        {
            return this.Name;
        }
    }
}
