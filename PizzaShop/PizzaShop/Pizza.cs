using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace PizzaShop
{
    class Pizza
    {
        public const float BasePrice = 5.99f;

        const string fileName = "pizza";
        int Id
        {
            get; set;
        }
        public String PizzaBaseName
        {
            get;
            set;
        }
        public float ThicknessAdditionPrice
        {
            get;
            set;
        }
        public float FilledAdditionPrice
        {
            get;
            set;
        }

        /// <summary>
        /// Create a new pizza and save it to file
        /// </summary>
        /// <param name="PizzaBaseName"> name of the pizza </param>
        /// <param name="ThicknessAdditionPrice"> thickness price </param>
        /// <param name="FilledAdditionPrice"> fillness price</param>
        public Pizza(string PizzaBaseName, float ThicknessAdditionPrice, float FilledAdditionPrice)
        {
            this.PizzaBaseName = PizzaBaseName;
            this.ThicknessAdditionPrice = ThicknessAdditionPrice;
            this.FilledAdditionPrice = FilledAdditionPrice;
            AddPizzaToFile(PizzaBaseName, ThicknessAdditionPrice, FilledAdditionPrice);
        }

        /// <summary>
        /// Create a pizza object
        /// </summary>
        /// <param name="Id"> id (TODO)</param>
        /// <param name="PizzaBaseName"> name of the pizza </param>
        /// <param name="ThicknessAdditionPrice"> thickness price </param>
        /// <param name="FilledAdditionPrice"> fillness price</param>
        public Pizza(int Id, string PizzaBaseName, float ThicknessAdditionPrice, float FilledAdditionPrice)
        {
            this.PizzaBaseName = PizzaBaseName;
            this.ThicknessAdditionPrice = ThicknessAdditionPrice;
            this.FilledAdditionPrice = FilledAdditionPrice;
            this.Id = Id;
        }

        /// <summary>
        /// Add the pizza to a file
        /// </summary>
        /// <param name="PizzaBaseName"> name of the pizza </param>
        /// <param name="ThicknessAdditionPrice"> thickness price </param>
        /// <param name="FilledAdditionPrice"> fillness price</param>
        /// <returns></returns>
        public int AddPizzaToFile(string PizzaBaseName, float ThicknessAdditionPrice, float FilledAdditionPrice)
        {
            using (StreamWriter sw = File.AppendText(fileName))
            {
                sw.WriteLine(string.Join(", ", Pizza.PizzaToCSV(PizzaBaseName, ThicknessAdditionPrice, FilledAdditionPrice)));
                sw.Close();
            }

            return 1;
        }

        /// <summary>
        /// change object to CSV
        /// </summary>
        /// <param name="PizzaBaseName"> name of the pizza </param>
        /// <param name="ThicknessAdditionPrice"> thickness price </param>
        /// <param name="FilledAdditionPrice"> fillness price</param>
        /// <returns></returns>
        public static string PizzaToCSV(string pizzaBaseName, float thicknessAdditionPrice, float filledAdditionPrice)
        {
            return pizzaBaseName  + ',' + thicknessAdditionPrice + ',' + filledAdditionPrice;
        }
        /// <summary>
        /// Get all ordered pizzas from file
        /// </summary>
        /// <returns> List<Pizza></returns>
        public static List<Pizza> GetAllPizzas()
        {
            List<Pizza> pizzas = new List<Pizza>();
            using (StreamReader file = new StreamReader(fileName))
            {
                string line;

                while ((line = file.ReadLine()) != null)
                {
                    List<String> data = line.Split(',').ToList();
                    pizzas.Add(new Pizza(1, data[0], float.Parse(data[1]), float.Parse(data[2])));
                }
                file.Close();
            }
            return pizzas;
        }

        /// <summary>
        /// stringify the object
        /// </summary>
        /// <returns> pizza to string</returns>
        public override string ToString()
        {
            return this.PizzaBaseName;
        }
    }
}
