using System;
using System.Collections.Generic;
using System.IO;

namespace PizzaShop
{
    public class Order
    {
        const string filename = "orders";
        // properties
        public DateTime OrderedAt
        {
            get;
            set;
        }
        public bool IsCancelled
        {
            get;
            set;
        }
        public Customer Customer
        {
            get;
            set;
        }

        // fields
        private List<OrderedPizza> pizzas;
        private List<OrderedDrink> drinks;

        // constructors
        /// <summary>
        /// Add new Order
        /// </summary>
        /// <param name="Customer"> customer who ordered</param>
        /// <param name="pizzas"> list of ordered pizzas </param>
        /// <param name="drinks">list of ordered drinks</param>
        /// <param name="temporary"> should it be added to the file</param>
        public Order(Customer Customer, List<OrderedPizza> pizzas = null, List<OrderedDrink> drinks = null, bool temporary = false)
        {
            this.Customer = Customer;
            this.pizzas = pizzas;
            this.drinks = drinks;
            this.IsCancelled = false;
            this.OrderedAt = Utils.GetDateTime();
            if (!temporary) AddOrderToFile(Customer, pizzas, drinks, IsCancelled, OrderedAt);
        }

        /// <summary>
        /// Add new Order
        /// </summary>
        /// <param name="Customer"> customer who ordered</param>
        /// <param name="isCancelled"> is the order cancelled</param>
        /// <param name="orderedAt"> when was it ordered</param>
        /// <param name="pizzas"> list of ordered pizzas </param>
        /// <param name="drinks">list of ordered drinks</param>
        /// <param name="temporary"> should it be added to the file</param>
        public Order(Customer Customer, bool isCancelled, DateTime orderedAt, List<OrderedPizza> pizzas = null, List<OrderedDrink> drinks = null, bool temporary = false)
        {
            this.Customer = Customer;
            this.pizzas = pizzas;
            this.drinks = drinks;
            this.IsCancelled = isCancelled;
            this.OrderedAt = orderedAt;
            if (!temporary) AddOrderToFile(Customer, pizzas, drinks, IsCancelled, OrderedAt);
        }

        /// <summary>
        /// Add new Order to file
        /// </summary>
        /// <param name="Customer"> customer who ordered</param>
        /// <param name="isCancelled"> is the order cancelled</param>
        /// <param name="orderedAt"> when was it ordered</param>
        /// <param name="pizzas"> list of ordered pizzas </param>
        /// <param name="drinks">list of ordered drinks</param>
        /// <returns></returns>
        private int AddOrderToFile(Customer customer, List<OrderedPizza> pizzas, List<OrderedDrink> drinks, bool IsCancelled, DateTime OrderedAt)
        {
            using (StreamWriter sw = File.AppendText(filename))
            {
                sw.WriteLine(string.Join(", ", Order.OrderToCSV(customer, pizzas, drinks, IsCancelled, OrderedAt)));
                sw.Close();
            }

            return 1; // TODO: return the last id
        }

        // methods
        /// <summary>
        /// Cancels the current order
        /// </summary>
        public void Cancel(string shopName = "")
        {
            string previousValue = this.OrderToCSV();
            this.IsCancelled = true;
            string newValue = this.OrderToCSV();

            string text = File.ReadAllText(filename);
            text = text.Replace(previousValue, newValue);
            File.WriteAllText(filename, text);

            if (shopName != "")
            {
                string shopfile = File.ReadAllText(shopName);
                shopfile = shopfile.Replace(previousValue, newValue);
                File.WriteAllText(shopName, shopfile);
            }
        }

        /// <summary>
        /// Conver order object to CSV
        /// </summary>
        /// <param name="o"> Order</param>
        /// <returns></returns>
        internal static string OrderToCSV(Order o)
        {
            return "ORDER" + Environment.NewLine + o.IsCancelled + "," + o.OrderedAt + "," + o.Customer + Environment.NewLine + o.PizzasToCSV() + o.DrinksToCSV() + Environment.NewLine + "ENDORDER";
        }

        /// <summary>
        /// Conver order to CSV
        /// </summary>
        /// <returns></returns>
        internal string OrderToCSV()
        {
            return OrderToCSV(this);
        }

        /// <summary>
        /// Conver order to CSV
        /// </summary>
        /// <param name="customer"> customer who ordered</param>
        /// <param name="IsCancelled"> is the order cancelled</param>
        /// <param name="OrderedAt"> when was it ordered</param>
        /// <param name="pizzas"> list of ordered pizzas </param>
        /// <param name="drinks">list of ordered drinks</param>
        /// <returns> csv string</returns>
        internal static string OrderToCSV(Customer customer, List<OrderedPizza> pizzas, List<OrderedDrink> drinks, bool IsCancelled, DateTime OrderedAt)
        {
            Order o = new Order(customer, pizzas, drinks, true);
            return OrderToCSV(o);
        }

        /// <summary>
        /// Convert the order drinks to cSV
        /// </summary>
        /// <returns> csv string</returns>
        public string DrinksToCSV()
        {
            string result = "DRINKS";
            result += Environment.NewLine;
            foreach (OrderedDrink d in drinks)
            {
                result += OrderedDrink.DrinkOrderToCSV(d.Drink, d.Quantity);
                result += Environment.NewLine;
            }
            return result;
        }

        /// <summary>
        /// Convert the order pizzas to cSV
        /// </summary>
        /// <returns> csv string</returns>
        private string PizzasToCSV()
        {
            string result = "PIZZAS";
            result += Environment.NewLine;
            foreach (OrderedPizza p in pizzas)
            {
                result += OrderedPizza.PizzaOrderToCSV(p.Pizza, p.Quantity, p.IsFilled, p.IsThick);
                result += Environment.NewLine;
            }
            return result;
        }

        /// <summary>
        /// delete content of the file where they are saved
        /// </summary>
        internal static void ClearFile()
        {
            Utils.ClearFile(filename);
        }

        /// <summary>
        /// Calculate the total price of the order
        /// </summary>
        /// <returns> price </returns>
        public float CalculateTotalCost()
        {
            float total = 0.0f;
            foreach (OrderedPizza p in pizzas)
            {
                total += p.CalculatePrice();
            }

            foreach (OrderedDrink d in drinks)
            {
                total += d.CalculatePrice();
            }

            return total;
        }

        /// <summary>
        /// get all pizzas from order
        /// </summary>
        /// <returns> list of pizzas </returns>
        public List<OrderedPizza> GetPizzas()
        {
            return pizzas;
        }

        /// <summary>
        /// get all drinks from order
        /// </summary>
        /// <returns> list of drinks </returns>
        public List<OrderedDrink> GetDrinks()
        {
            return drinks;
        }

        /// <summary>
        /// converts order to string
        /// </summary>
        /// <returns> order as string</returns>
        public override string ToString()
        {
            return (IsCancelled ? "CANCELLED" : "" ) + $"({this.OrderedAt}){this.Customer} ordered {this.drinks.Count} drinks and {this.pizzas.Count} pizzas";
        }
    }
}
