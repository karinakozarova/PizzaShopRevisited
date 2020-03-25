using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace PizzaShop
{
    public class Customer
    {
        // class constants
        const string filename = "customer";

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
        public Customer(string name, string email)
        {
            AddCustomerToFile(name, email);
            this.Name = name;
            this.Email = email;
        }  
        
        /// <summary>
        /// Creates a new customer and adds it to the database
        /// </summary>
        /// <param name="name"> name of customer </param>
        /// <param name="addToDB"> should it be added to the database </param>
        public Customer(string name)
        {
            AddCustomerToFile(name, "");
            this.Name = name;
            this.Email = "";
        }
        /// <summary>
        /// Creates a new customer and adds it to the database
        /// </summary>
        /// <param name="name"> name of customer </param>
        /// <param name="addToDB"> should it be added to the database </param>
        public Customer(int id, string name)
        {
            this.Id = id;
            this.Name = name;
            this.Email = "";
        }

        /// <summary>
        /// Creates a new customer object without adding it to the file
        /// </summary>
        /// <param name="id"> the current id in the db </param>
        /// <param name="name"> name of customer </param>
        /// <param name="email"> email of customer </param>
        public Customer(int id, string name, string email)
        {
            this.Id = id;
            this.Name = name;
            this.Email = email;
        }

        /// <summary>
        /// Edit the data of a customer
        /// </summary>
        /// <param name="name"> customer name </param>
        /// <param name="email"> customer email</param>
        public void EditCustomer(string name, string email)
        {
            string previousValue = this.CustomerToCSV();
            this.Name = name;
            this.Email = email;
            string newValue = this.CustomerToCSV();

            string text = File.ReadAllText(filename);
            text = text.Replace(previousValue, newValue);
            File.WriteAllText(filename, text);
        }

        /// <summary>
        /// Deletes a customer
        /// </summary>
        public void Delete()
        {
            var tempFile = Path.GetTempFileName();
            var linesToKeep = File.ReadLines(filename).Where(l => l != this.CustomerToCSV());
            File.WriteAllLines(tempFile, linesToKeep);
            File.Delete(filename);
            File.Move(tempFile, filename);
        }


        /// <summary>
        /// Adds a customer to the file
        /// </summary>
        /// <param name="name"> the name of the customer </param>
        /// <param name="email"> the email of the customer </param>
        /// <returns> the id of the added customer or -1 if it wasnt succesfull </returns>
        public static int AddCustomerToFile(string name, string email)
        {
            using (StreamWriter sw = File.AppendText(filename))
            {
                sw.WriteLine(string.Join(", ", Customer.CustomerToCSV(name, email)));
                sw.Close();
            }

            return 1;

        }

        /// <summary>
        /// get all the customers from the file
        /// </summary>
        /// <returns> a list with all the customers </returns>
        public static List<Customer> GetAllCustomers()
        {
            List<Customer> customers = new List<Customer>();
            using (StreamReader file = new StreamReader(filename))
            {
                string line;

                while ((line = file.ReadLine()) != null)
                {
                    List<String> data = line.Split(',').ToList();
                    customers.Add(new Customer(1, data[0], data[1]));
                }
                file.Close();
            }
            return customers;
        }

        /// <summary>
        /// transforms the object to a CSV
        /// </summary>
        /// <returns></returns>
        public string CustomerToCSV()
        {
            return this.Name + ',' + this.Email;
        }

        /// <summary>
        /// data to a CSV
        /// </summary>
        /// <param name="name"> the name of the customer </param>
        /// <param name="email"> the email of the customer </param>
        /// <returns></returns>
        private static string CustomerToCSV(string name, string email)
        {
            return name + ',' + email;
        }

        /// <summary>
        /// customer object to a CSV
        /// </summary>
        /// <param name="c"> customer </param>
        /// <returns></returns>
        public static string CustomerToCSV(Customer c)
        {
            return c.Name + ',' + c.Email;
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
