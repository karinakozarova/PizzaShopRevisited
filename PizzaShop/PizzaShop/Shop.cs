using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace PizzaShop
{
    class Shop
    {
        const string filename = "shop";
        String Name
        {
            get;
            set;
        }

        List<Order> orders;

        public Shop(string name)
        {
            this.Name = name;
            orders = GetOrdersFromFile();
        }

        private List<Order> GetOrdersFromFile()
        {
            List<Order> orders = new List<Order>();
            using (StreamReader file = new StreamReader(Name))
            {
                string line = file.ReadLine(); // reads shop name
                while ((line = file.ReadLine()) != null)
                {
                    List<String> data = line.Split(',').ToList();
                   // orders.Add(new Order(new Customer(1, "d", "d"))); // TODO: fix this
                }
                file.Close();
            }
            return orders;
        }

        public Shop(string name, List<Order> orders)
        {
            Utils.ClearFile(name);
            orders = new List<Order>();
            this.Name = name;
            foreach (Order o in orders) this.orders.Add(o);
            AddShopToFile(name, orders);
        }

        public Shop(int id, string name, List<Order> orders)
        {
            orders = new List<Order>();
            this.Name = name;
            foreach (Order o in orders) this.orders.Add(o);
            AddShopToFile(name, orders);
        }

        private void AddShopToFile()
        {
            AddShopToFile(Name, orders);
        }

        private int AddShopToFile(string name, List<Order> orders)
        {
            using (StreamWriter sw = File.AppendText(Name))
            {
                sw.WriteLine(name);
                sw.WriteLine(string.Join(", ", Shop.ToCSV(orders)));
                sw.Close();
            }

            return 1; // TODO: return the last id
        }

        private static string ToCSV(List<Order> orders)
        {
            string shops = "";
            foreach(Order o in orders)
            {
                //if(shops.Length != 0) shops += ",";
                shops += Order.OrderToCSV(o);
                shops += '\n';
            }
            return shops;
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
            return orders;
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

        internal void AddOrder(Order order)
        {
            orders.Add(order);
            Utils.ClearFile(Name);
            AddShopToFile();
        }
    }
}
