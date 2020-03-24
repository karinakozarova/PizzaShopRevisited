using System;
using System.Collections.Generic;

namespace PizzaShop
{
    class Shop
    {
        String Name
        {
            get;
            set;
        }

        List<Order> orders;

        public Shop(string name)
        {
            this.Name = name;
        }
        public Shop(string name, List<Order> orders)
        {
            this.Name = name;
            foreach (Order o in orders) this.orders.Add(o);
            AddShopToFile(name, orders);
        }

        private void AddShopToFile(string name, List<Order> orders)
        {
            throw new NotImplementedException();
        }

        public Shop(int id, string name, List<Order> orders)
        {
            this.Name = name;
            foreach (Order o in orders) this.orders.Add(o);
        }

        public float GetRevenue()
        {
            float total = 0;
            foreach (Order o in orders)
            {
                total += o.CalculateTotalCost();
            }
            return total;
        }
        public float GetDailyRevenue()
        {
            throw new NotImplementedException();
        }

        public float GetRevenueForDay(DateTime day)
        {
            throw new NotImplementedException();
        }

        public List<Order> GetOrders()
        {
            throw new NotImplementedException();
        }

        public bool ExportOrders()
        {
            throw new NotImplementedException();
        }
        public bool ImportOrders()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
