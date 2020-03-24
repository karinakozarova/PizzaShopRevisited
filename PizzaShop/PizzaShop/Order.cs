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

        internal string OrderToCSV()
        {
            return IsCancelled + "," + OrderedAt + "," + Customer.CustomerToCSV(Customer) + PizzaOrdersToCSV(pizzas) + DrinkOrdersToCSV(drinks);
        }

        internal static string OrderToCSV(Customer customer, List<OrderedPizza> pizzas, List<OrderedDrink> drinks, bool IsCancelled, DateTime OrderedAt)
        {
            return IsCancelled + "," + OrderedAt + "," + Customer.CustomerToCSV(customer) + PizzaOrdersToCSV(pizzas) + DrinkOrdersToCSV(drinks);
        }

        private static string DrinkOrdersToCSV(List<OrderedDrink> drinks)
        {
            string result = "";
            foreach(OrderedDrink d in drinks)
            {
                result += ",";
                result += OrderedDrink.DrinkOrderToCSV(d.Drink, d.Quantity);
            }
            return result;
        }

        private static string PizzaOrdersToCSV(List<OrderedPizza> pizzas)
        {
            string result = "";
            foreach (OrderedPizza p in pizzas)
            {
                result += ",";
                result += OrderedPizza.PizzaOrderToCSV(p.Pizza, p.Quantity, p.IsFilled, p.IsThick);
            }
            return result;
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
        public void Cancel()
        {
            string previousValue = this.OrderToCSV();
            this.IsCancelled = true;
            string newValue = this.OrderToCSV();

            string text = File.ReadAllText(filename);
            text = text.Replace(previousValue, newValue);
            File.WriteAllText(filename, text);
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
            return o.IsCancelled + "," + o.OrderedAt + "," + o.Customer + o.PizzasToCSV() + o.DrinksToCSV();
        }

        public string DrinksToCSV()
        {
            string result = "";
            foreach(OrderedDrink d in drinks)
            {
                result += ',';
                result += OrderedDrink.DrinkOrderToCSV(d.Drink, d.Quantity);
            }
            return result;
        }

        private string PizzasToCSV()
        {
            string result = "";
            foreach (OrderedPizza p in pizzas)
            {
                result += ',';
                result += OrderedPizza.PizzaOrderToCSV(p.Pizza, p.Quantity, p.IsFilled, p.IsThick); 
            }
            return result;
        }

        public float CalculateTotalCost()
        {
            throw new NotImplementedException();
        }
    }
}
