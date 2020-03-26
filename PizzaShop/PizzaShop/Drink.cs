using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace PizzaShop
{
    public class Drink
    {
        const string filename = "drink";

        public string Name
        {
            get;
            set;
        }

        // TODO: this can have restictions on the minimum price in the future
        public float Price
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
        /// <summary>
        /// Creates a drink and adds it to file
        /// </summary>
        /// <param name="name"> drink name</param>
        /// <param name="price"> price name </param>
        public Drink(string name, float price)
        {
            this.Name = name;
            this.Price = price;
            AddDrinkToFile(name, price);
        }

        /// <summary>
        /// creates a drink object
        /// </summary>
        /// <param name="id"> id of the drink</param>
        /// <param name="name"> name of the drink</param>
        /// <param name="price"> price of the drink</param>
        public Drink(int id, string name, float price)
        {
            this.Name = name;
            this.Price = price;
            this.Id = id;
        }


        /// <summary>
        /// saves the drink to a file
        /// </summary>
        /// <param name="name"> name of the drink</param>
        /// <param name="price"> price of the drink</param>
        /// <returns></returns>
        public static int AddDrinkToFile(string name, float price)
        {
            using (StreamWriter sw = File.AppendText(filename))
            {
                sw.WriteLine(string.Join(", ", Drink.DrinkToCSV(name, price)));
                sw.Close();
            }

            return 1; // TODO: return the last id
        }

        /// <summary>
        /// Get all drinks from file
        /// </summary>
        /// <returns>list of drinks</returns>
        public static List<Drink> GetAllDrinks()
        {
            List<Drink> drinks = new List<Drink>();
            if (!File.Exists(filename))
            {
                Utils.CreateEmptyFile(filename);
            }
            using (StreamReader file = new StreamReader(filename))
            {
                string line;

                while ((line = file.ReadLine()) != null)
                {
                    List<String> data = line.Split(',').ToList();
                    Drink d = new Drink(1, data[0], float.Parse(data[1]));
                    drinks.Add(d);
                }
                file.Close();
            }
            return drinks;
        }

        /// <summary>
        /// formats the drink data to a csv string
        /// </summary>
        /// <param name="name"> name of the drink</param>
        /// <param name="price"> price of the drink</param>
        /// <returns></returns>
        public static string DrinkToCSV(string name, float price)
        {
            return name + ',' + price;
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
