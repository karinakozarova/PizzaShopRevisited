using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShop
{
    class Order
    {
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
        public Order(Customer Customer, List<OrderedPizza> pizzas = null, List<OrderedDrink> drinks = null)
        {
            this.Customer = Customer;
            this.pizzas = pizzas;
            this.drinks = drinks;
        }

        // methods
        /// <summary>
        /// Cancels the current order
        /// </summary>
        public void Cancel()
        {
            this.IsCancelled = true;
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

        public float CalculateTotalCost()
        {
            throw new NotImplementedException();
        }
    }
}
