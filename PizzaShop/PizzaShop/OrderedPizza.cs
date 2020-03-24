using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShop
{
    class OrderedPizza
    {
        // constants
        const string filename = "orderedPizza";

        //properties
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

        public bool IsThick
        {
            get;
            set;
        }
        public bool IsFilled
        {
            get;
            set;
        }

        public Pizza Pizza
        {
            get;set;
        }

        // constructors
        public OrderedPizza(Pizza pizza, int quantity, bool isFilled, bool isThick)
        {
            this.Pizza = pizza;
            this.Quantity = quantity;
            this.IsFilled = isFilled;
            this.IsThick = isThick;
            AddToFile(pizza, quantity, IsFilled, isThick);
        }

        public OrderedPizza(int id, Pizza pizza, int quantity, bool isFilled, bool isThick)
        {
            this.Pizza = pizza;
            this.Quantity = quantity;
            this.IsFilled = isFilled;
            this.IsThick = isThick;
            this.Id = id;
        }

        // methods
        public int AddToFile(Pizza pizza, int quantity, bool isFilled, bool isThick)
        {
            using (StreamWriter sw = File.AppendText(filename))
            {
                sw.WriteLine(string.Join(", ", OrderedPizza.PizzaOrderToCSV(pizza, quantity, isFilled, IsThick)));
                sw.Close();
            }
            return 1;
        }

        public static string PizzaOrderToCSV(Pizza pizza, int quantity, bool isFilled, bool IsThick)
        {
            return Pizza.PizzaToCSV(pizza.PizzaBaseName, pizza.ThicknessAdditionPrice, pizza.FilledAdditionPrice) + ',' + quantity + ',' + isFilled + ',' + IsThick;
        }

        public static void ClearFile()
        {
            System.IO.File.WriteAllText(filename, string.Empty);
        }

        public OrderedPizza GetOrderedPizzaById(int id)
        {
            throw new NotImplementedException();
        }

        public static List<OrderedPizza> GetAllOrderedPizzas()
        {
            List<OrderedPizza> pizzas = new List<OrderedPizza>();
            using (StreamReader file = new StreamReader(filename))
            {
                string line;

                while ((line = file.ReadLine()) != null)
                {
                    List<String> data = line.Split(',').ToList();
                    Pizza pizza = new Pizza(1, data[0], float.Parse(data[1]), float.Parse(data[2]));
                    OrderedPizza ordered = new OrderedPizza(1, pizza, Convert.ToInt32(data[3]), bool.Parse(data[4]), bool.Parse(data[5]));
                    pizzas.Add(ordered);
                }
                file.Close();
            }
            return pizzas;
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return Pizza.PizzaBaseName + " x " + this.Quantity;
        }

        public float CalculatePrice()
        {
            float price = Pizza.BasePrice;
            if (this.IsFilled) price += this.Pizza.FilledAdditionPrice;
            if (this.IsThick) price += this.Pizza.ThicknessAdditionPrice;

            return price * Quantity;
        }
    }
}
