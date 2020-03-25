using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace PizzaShop
{
    class Shop
    {
        const string filename = "shop";
        public String Name
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

        /// <summary>
        /// Get all shop orders
        /// </summary>
        /// <returns></returns>
        private List<Order> GetOrdersFromFile()
        {
            List<Order> orders = new List<Order>();

            try
            {
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
            } catch(Exception )
            {
                // filename was null
            }
            return orders;
        }

        //public Shop(string name, List<Order> orders)
        //{
        //    Utils.ClearFile(name);
        //    orders = new List<Order>();
        //    this.Name = name;
        //    foreach (Order o in orders) this.orders.Add(o);
        //    AddShopToFile(name, orders);
        //}

        //public Shop(int id, string name, List<Order> orders)
        //{
        //    orders = new List<Order>();
        //    this.Name = name;
        //    foreach (Order o in orders) this.orders.Add(o);
        //    AddShopToFile(name, orders);
        //}

        /// <summary>
        /// Save the shop
        /// </summary>
        private void AddShopToFile()
        {
            AddShopToFile(Name, orders);
        }

        /// <summary>
        /// save shop to file
        /// </summary>
        /// <param name="name"></param>
        /// <param name="orders"></param>
        /// <returns></returns>
        private int AddShopToFile(string name, List<Order> orders)
        {
            using (StreamWriter sw = File.AppendText(name))
            {
                sw.WriteLine(name);
                sw.WriteLine(string.Join(", ", Shop.ToCSV(orders)));
                sw.Close();
            }
            return 1; // TODO: return the last id
        }

        /// <summary>
        /// convert the orders to CSV
        /// </summary>
        /// <param name="orders"></param>
        /// <returns></returns>
        private static string ToCSV(List<Order> orders)
        {
            string shops = "";
            foreach(Order o in orders)
            {
                shops += Order.OrderToCSV(o);
                shops += '\n';
            }
            return shops;
        }

        /// <summary>
        /// Calculate the total shop revenue
        /// </summary>
        /// <returns></returns>
        public float GetRevenue()
        {
            float total = 0.0f;
            foreach (Order o in orders)
            {
                total += o.CalculateTotalCost();
            }
            return total;
        }
        /// <summary>
        /// calculate today's revenue
        /// </summary>
        /// <returns></returns>
        public float GetDailyRevenue()
        {
            return GetRevenueForDay(Utils.GetDateTime());
        }

        /// <summary>
        /// get revenue for a specific date
        /// </summary>
        /// <param name="day"> day for the calculation </param>
        /// <returns></returns>
        public float GetRevenueForDay(DateTime day)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///  get the orders list
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// stringify the shop
        /// </summary>
        /// <returns> shop as string </returns>
        public override string ToString()
        {
            return Name;
        }

        /// <summary>
        /// create a new shop
        /// </summary>
        /// <param name="order"></param>
        public void AddOrder(Order order)
        {
            orders.Add(order);
            Utils.ClearFile(Name);
            this.AddShopToFile();
        }

        /// <summary>
        /// Get all orders from a file
        /// </summary>
        /// <param name="filename"> the name of the file </param>
        /// <returns></returns>
        public static Shop OrdersFromFile(string filename)
        {
            Shop s = null;
            try
            {
                using (StreamReader file = new StreamReader(filename))
                {
                    string shopName = file.ReadLine();
                    s = new Shop(shopName);

                    string line;
                    List<Order> orders = new List<Order>();
                    while ((line = file.ReadLine()) != null)
                    {
                        if (line == "ORDER")
                        {
                            // get base information for the order
                            line = file.ReadLine();
                            List<String> data = line.Split(',').ToList();
                            bool IsCancelled = Convert.ToBoolean(data[0]);
                            DateTime createdAt = Convert.ToDateTime(data[1]);

                            Customer c = null;
                            if (data.Count == 4) { c = new Customer(1, data[2], data[3]); }
                            else { c = new Customer(1, data[2]); }
                            line = file.ReadLine();
                            if (line == "PIZZAS")
                            {
                                List<OrderedDrink> orderedDrinks = new List<OrderedDrink>(); ;
                                List<OrderedPizza> orderedPizzas = new List<OrderedPizza>();

                                while ((line = file.ReadLine()) != "DRINKS")
                                {
                                    List<String> pizzas = line.Split(',').ToList();
                                    Pizza pizza = new Pizza(1, pizzas[0], float.Parse(pizzas[1]), float.Parse(pizzas[2]));

                                    OrderedPizza p = new OrderedPizza(pizza, Convert.ToInt32(pizzas[3]), Convert.ToBoolean(pizzas[4]), Convert.ToBoolean(pizzas[5])); ;
                                    orderedPizzas.Add(p);
                                }

                                while ((line = file.ReadLine()) != "ENDORDER" && line != "")
                                {
                                    List<String> drinks = line.Split(',').ToList();
                                    Drink drink = new Drink(1, drinks[0], float.Parse(drinks[1]));
                                    OrderedDrink d = new OrderedDrink(drink, Convert.ToInt32(drinks[2]));
                                    orderedDrinks.Add(d);
                                }
                                Order o = new Order(c, orderedPizzas, orderedDrinks);
                                orders.Add(o);
                            }
                        }
                    }
                    file.Close();
                    foreach (Order o in orders) s.AddOrder(o);
                }
            } catch (Exception)
            {
               if(filename != null) using (File.Create(filename));
            }
            return s;
        }
    }
}
