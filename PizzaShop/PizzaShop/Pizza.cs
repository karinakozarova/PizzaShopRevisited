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

        public Pizza(string PizzaBaseName, float ThicknessAdditionPrice, float FilledAdditionPrice)
        {
            this.PizzaBaseName = PizzaBaseName;
            this.ThicknessAdditionPrice = ThicknessAdditionPrice;
            this.FilledAdditionPrice = FilledAdditionPrice;
            AddPizzaToFile(PizzaBaseName, ThicknessAdditionPrice, FilledAdditionPrice);
        }


        public Pizza(int Id, string PizzaBaseName, float ThicknessAdditionPrice, float FilledAdditionPrice)
        {
            this.PizzaBaseName = PizzaBaseName;
            this.ThicknessAdditionPrice = ThicknessAdditionPrice;
            this.FilledAdditionPrice = FilledAdditionPrice;
            this.Id = Id;
        }
       

        public int AddPizzaToFile(string PizzaBaseName, float ThicknessAdditionPrice, float FilledAdditionPrice)
        {
            using (StreamWriter sw = File.AppendText(fileName))
            {
                sw.WriteLine(string.Join(", ", Pizza.PizzaToCSV(PizzaBaseName, ThicknessAdditionPrice, FilledAdditionPrice)));
                sw.Close();
            }

            return 1;
        }

        public static string PizzaToCSV(string pizzaBaseName, float thicknessAdditionPrice, float filledAdditionPrice)
        {
            return pizzaBaseName  + ',' + thicknessAdditionPrice + ',' + filledAdditionPrice;
        }

        public static Pizza GetPizzaById(int id)
        {
            throw new NotImplementedException();
        }
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

        public override string ToString()
        {
            return this.PizzaBaseName;
        }
    }
}
