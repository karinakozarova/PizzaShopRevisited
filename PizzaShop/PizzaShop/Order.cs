using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShop
{
    class Order
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
        public Order(Customer Customer, List<OrderedPizza> pizzas = null, List<OrderedDrink> drinks = null, bool temporary = false)
        {
            this.Customer = Customer;
            this.pizzas = pizzas;
            this.drinks = drinks;
            this.IsCancelled = false;
            this.OrderedAt = Utils.GetDateTime();
            if(!temporary) AddOrderToFile(Customer, pizzas , drinks, IsCancelled, OrderedAt);
        }

        private int AddOrderToFile(Customer customer, List<OrderedPizza> pizzas, List<OrderedDrink> drinks, bool IsCancelled, DateTime OrderedAt)
        {
            using (StreamWriter sw = File.AppendText(filename))
            {
                sw.WriteLine(string.Join(", ", Order.OrderToCSV(customer, pizzas, drinks, IsCancelled, OrderedAt)));
                sw.Close();
            }

            return 1; // TODO: return the last id
        }

        public Order(int id,Customer Customer, List<OrderedPizza> pizzas = null, List<OrderedDrink> drinks = null)
        {
            this.Customer = Customer;
            this.pizzas = pizzas;
            this.drinks = drinks;
            this.IsCancelled = false;
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
                File.WriteAllText(filename, text);
            }
        }

        public void GenerateReceipt()
        {
            throw new NotImplementedException();
        }

        public string GetReceipt()
        {
            throw new NotImplementedException();
        }

        public List<Order> GetAllOrders()
        {
            throw new NotImplementedException();
        }

        public List<Order> GetOrders(String filter)
        {
            throw new NotImplementedException();
        }

        internal static string OrderToCSV(Order o)
        {
            return "ORDER" + Environment.NewLine + o.IsCancelled + "," + o.OrderedAt + "," + o.Customer + Environment.NewLine + o.PizzasToCSV() + o.DrinksToCSV() + Environment.NewLine + "ENDORDER";
        }

        internal string OrderToCSV()
        {
            return OrderToCSV(this);
        }

        internal static string OrderToCSV(Customer customer, List<OrderedPizza> pizzas, List<OrderedDrink> drinks, bool IsCancelled, DateTime OrderedAt)
        {
            Order o = new Order(customer, pizzas, drinks, true);
            return OrderToCSV(o);
        }

        

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

        internal static void ClearFile()
        {
            Utils.ClearFile(filename);
        }

        public float CalculateTotalCost()
        {
            float total = 0.0f;
            foreach(OrderedPizza p in pizzas)
            {
                total += p.CalculatePrice();
            }

            foreach(OrderedDrink d in drinks)
            {
                total += d.CalculatePrice();
            }

            return total;
        }

        public override string ToString()
        {
            return IsCancelled ? "CANCELLED": "" + $"({this.OrderedAt}){this.Customer} ordered {this.drinks.Count} drinks and {this.pizzas.Count} pizzas";
        }
    }
}
