﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace PizzaShop
{
    public class OrderedDrink
    {
        // constants
        const string filename = "orderedDrink";

        // properties
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
        public Drink Drink
        {
            get;
            private set;
        }

        // constructors

        /// <summary>
        /// Create a new Drink Order object and save it to the file
        /// </summary>
        /// <param name="drink"> drink object </param>
        /// <param name="quantity"> ordered quantity </param>
        public OrderedDrink(Drink drink, int quantity)
        {
            this.Drink = drink;
            this.Quantity = quantity;
            // TODO: clear file here
            AddOrderedDrinkToFile(drink, quantity);
        }

        /// <summary>
        /// Create a new Drink Order object 
        /// </summary>
        /// <param name="id"> id in the file </param>
        /// <param name="drink"> drink object </param>
        /// <param name="quantity"> ordered quantity </param>
        public OrderedDrink(int id, Drink drink, int quantity)
        {
            this.Drink = drink;
            this.Quantity = quantity;
            this.Id = id;
        }

        internal string DrinkQuantityAndPrice()
        {
            return $"{Quantity} X {Drink.Price}";
        }


        // methods
        /// <summary>
        /// saves the order data to a file
        /// </summary>
        /// <param name="drink"> ordered drink</param>
        /// <param name="quantity"> quantity of the ordered drinks</param>
        /// <returns></returns>
        public static int AddOrderedDrinkToFile(Drink drink, int quantity)
        {
            using (StreamWriter sw = File.AppendText(filename))
            {
                sw.WriteLine(string.Join(", ", OrderedDrink.DrinkOrderToCSV(drink, quantity)));
                sw.Close();
            }

            return 1;
        }

        /// <summary>
        /// Transforms the OrderedDrink to a CSV string
        /// </summary>
        /// <param name="drink"> the drink object </param>
        /// <param name="quantity"> ordered quantity</param>
        /// <returns></returns>
        public static string DrinkOrderToCSV(Drink drink, int quantity)
        {
            return Drink.DrinkToCSV(drink.Name, drink.Price) + ',' + quantity;
        }

        /// <summary>
        /// Get all the saved drinks from file
        /// </summary>
        /// <returns> list of drinks </returns>
        public static List<OrderedDrink> GetAllDrinks()
        {
            List<OrderedDrink> drinks = new List<OrderedDrink>();
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
                    Drink drink = new Drink(1, data[0], float.Parse(data[1]));
                    OrderedDrink ordered = new OrderedDrink(1, drink, Convert.ToInt32(data[2]));
                    drinks.Add(ordered);
                }
                file.Close();
            }
            return drinks;
        }

        /// <summary>
        /// Stringify the object
        /// </summary>
        /// <returns> the name of the drink </returns>
        public override string ToString()
        {
            return $"{this.Drink.Name} {this.Quantity} X {this.Drink.Price}";
        }
        /// <summary>
        /// Clears the content of the ordered drink file
        /// </summary>
        public static void ClearFile()
        {
            Utils.ClearFile(filename);
        }

        /// <summary>
        /// calculates the total price of a drink
        /// </summary>
        /// <returns></returns>
        public float CalculatePrice()
        {
            return Drink.Price * Quantity;
        }

        public string GetDrinkName()
        {
            return Drink.Name;
        }
    }
}
