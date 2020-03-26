using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShop
{
    public class OrderedPizza
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
        /// <summary>
        /// Create a new ordered pizza and save it to file
        /// </summary>
        /// <param name="pizza"> name of the pizza </param>
        /// <param name="quantity"> quantity of the pizza</param>
        /// <param name="isFilled"> is the pizza filled </param>
        /// <param name="isThick"> is the pizza thick</param>
        public OrderedPizza(Pizza pizza, int quantity, bool isFilled, bool isThick)
        {
            this.Pizza = pizza;
            this.Quantity = quantity;
            this.IsFilled = isFilled;
            this.IsThick = isThick;
            AddToFile(pizza, quantity, IsFilled, isThick);
        }
        /// <summary>
        /// creates an ordered pizza object without adding it to the file
        /// </summary>
        /// <param name="id"> id of the pizza (TODO)</param>
        /// <param name="pizza"> name of the pizza </param>
        /// <param name="quantity"> quantity of the pizza</param>
        /// <param name="isFilled"> is the pizza filled </param>
        /// <param name="isThick"> is the pizza thick</param>
        public OrderedPizza(int id, Pizza pizza, int quantity, bool isFilled, bool isThick)
        {
            this.Pizza = pizza;
            this.Quantity = quantity;
            this.IsFilled = isFilled;
            this.IsThick = isThick;
            this.Id = id;
        }

        // methods
        /// <summary>
        /// save pizza to the file
        /// </summary>
        /// <param name="pizza"> pizza object </param>
        /// <param name="quantity"> quantity of the pizza</param>
        /// <param name="isFilled"> is the pizza filled </param>
        /// <param name="isThick"> is the pizza thick</param>
        /// <returns></returns>
        public int AddToFile(Pizza pizza, int quantity, bool isFilled, bool isThick)
        {
            using (StreamWriter sw = File.AppendText(filename))
            {
                sw.WriteLine(string.Join(", ", OrderedPizza.PizzaOrderToCSV(pizza, quantity, isFilled, IsThick)));
                sw.Close();
            }
            return 1;
        }

        /// <summary>
        /// convert the data to a csv
        /// </summary>
        /// <param name="pizza"> pizza object </param>
        /// <param name="quantity"> quantity of the pizza</param>
        /// <param name="isFilled"> is the pizza filled </param>
        /// <param name="isThick"> is the pizza thick</param>
        /// <returns></returns>
        public static string PizzaOrderToCSV(Pizza pizza, int quantity, bool isFilled, bool IsThick)
        {
            return Pizza.PizzaToCSV(pizza.PizzaBaseName, pizza.ThicknessAdditionPrice, pizza.FilledAdditionPrice) + ',' + quantity + ',' + isFilled + ',' + IsThick;
        }

        /// <summary>
        /// deletes the content of the file
        /// </summary>
        public static void ClearFile()
        {
            Utils.ClearFile(filename);
        }

        /// <summary>
        /// get a list of all the ordered pizzas
        /// </summary>
        /// <returns> List<OrderedPizza> </returns>
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
        /// <summary>
        /// stringify the pizza
        /// </summary>
        /// <returns> string </returns>
        public override string ToString()
        {
            return Pizza.PizzaBaseName + " x " + this.Quantity + " = " + CalculatePrice();
        }

        public string PizzaQuantityAndPrice()
        {
            return $"{Quantity} X {GetBasePrice()}";
        }
        public string FullPizzaName()
        {
            return Pizza.PizzaBaseName + (IsThick ? " - thick" : "") + (IsFilled ? " - filled" : "");
        }

        /// <summary>
        /// Get price for the orderered pizza (only one ordered)
        /// </summary>
        /// <returns></returns>
        public float GetBasePrice()
        {
            float price = Pizza.BasePrice;
            if (this.IsFilled) price += this.Pizza.FilledAdditionPrice;
            if (this.IsThick) price += this.Pizza.ThicknessAdditionPrice;
            return price;
        }
        /// <summary>
        /// calculate the total cost of the order
        /// </summary>
        /// <returns></returns>
        public float CalculatePrice()
        {
            return GetBasePrice() * Quantity;
        }
    }
}
