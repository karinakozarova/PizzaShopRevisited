using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PizzaShop
{
    public partial class Form1 : Form
    {
        Shop s;
        public Form1()
        {
            InitializeComponent();
            s = Shop.OrdersFromFile("My Shop");
            s.Name = "My Shop";
            shopNameLbl.Text = s.Name;
            PopulateAll();
            revenueDateTImePicker.Value = DateTime.Today;
        }

        private void PopulateRevenues()
        {
            totalRevenueLbl.Text = s.GetRevenue().ToString();
            dailyRevenueLbl.Text = s.GetDailyRevenue().ToString();
        }

        public void PopulateAll()
        {
            RefreshCustomers();
            RefreshDrinks();
            RefreshPizzas();
            ReloadDrinks();
            ReloadPizzas();
            PopulateOrders();
            PopulateRevenues();
        }

        private void PopulateOrders()
        {
            List<Order> orders = s.GetOrders();
            List<Order> sortedOrders = orders.OrderByDescending(o => o.CalculateTotalCost()).ToList();

            allOrdersLbx.Items.Clear();
            foreach (Order o in sortedOrders)
            {
                allOrdersLbx.Items.Add(o);
            }
        }

        private void RefreshCustomers()
        {
            customersLbx.Items.Clear();
            customerOrderTbx.Items.Clear();
            List<Customer> customers = Customer.GetAllCustomers();
            foreach (Customer c in customers)
            {
                customersLbx.Items.Add(c);
                customerOrderTbx.Items.Add(c);
            }
        }

        private void RefreshDrinks()
        {
            drinksLbx.Items.Clear();
            List<Drink> drinks = Drink.GetAllDrinks();
            foreach (Drink d in drinks)
            {
                drinksLbx.Items.Add(d);

            }
        }
        private void RefreshPizzas()
        {
            pizzasLbx.Items.Clear();
            List<Pizza> pizzas = Pizza.GetAllPizzas();
            foreach (Pizza p in pizzas)
            {
                pizzasLbx.Items.Add(p);
            }
        }

        private void addNewCustomerBttn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(customerNameTbx.Text))
            {
                MessageBox.Show("Enter name");
                return;
            }

            if (!String.IsNullOrEmpty(emailNameTbx.Text) && !Utils.IsValidEmail(emailNameTbx.Text))
            {
                MessageBox.Show("Enter valid email");
                return;
            }
            Customer c = new Customer(customerNameTbx.Text, emailNameTbx.Text);
            RefreshCustomers();
        }

        private void addDrinkBttn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(drinkNameTbx.Text))
            {
                MessageBox.Show("Enter name");
                return;
            }

            if (drinkPriceBttn.Value == 0)
            {
                MessageBox.Show("Enter price");
                return;
            }
            float price = (float)drinkPriceBttn.Value;

            Drink d = new Drink(drinkNameTbx.Text, price);
            RefreshDrinks();
        }

        private void addPizzaBttn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(pizzaNameTbx.Text))
            {
                MessageBox.Show("Enter name");
                return;
            }


            if (pizzaThickPriceInput.Value == 0)
            {
                MessageBox.Show("Enter price");
                return;
            }
            if (filledPizzaPriceInput.Value == 0)
            {
                MessageBox.Show("Enter price");
                return;
            }

            float filled = (float)filledPizzaPriceInput.Value;
            float thick = (float)pizzaThickPriceInput.Value;

            Pizza p = new Pizza(pizzaNameTbx.Text, thick, filled);
            RefreshPizzas();
        }

        private void revenueDateTImePicker_ValueChanged(object sender, EventArgs e)
        {
            float result = s.GetRevenueForDay(revenueDateTImePicker.Value);
            dateRevenueLbl.Text = result.ToString();
        }

        private void addPizzaToOrderBttn_Click(object sender, EventArgs e)
        {
            (new AddPizzaToOrder()).Show();
            ReloadPizzas();
        }

        private void ReloadDrinks()
        {
            orderedDrinksLbx.Items.Clear();
            List<OrderedDrink> drinks = OrderedDrink.GetAllDrinks();
            foreach (OrderedDrink d in drinks)
            {
                orderedDrinksLbx.Items.Add(d);
            }
        }
        private void ReloadPizzas()
        {
            orderedPizzasLbx.Items.Clear();
            List<OrderedPizza> pizzas = OrderedPizza.GetAllOrderedPizzas();
            foreach (OrderedPizza d in pizzas)
            {
                orderedPizzasLbx.Items.Add(d);
            }
        }

        private void addDrinkToOrderBttn_Click(object sender, EventArgs e)
        {
            (new AddDrinkToOrder()).Show();
            ReloadDrinks();
        }

        private void ClearOrder()
        {
            orderedDrinksLbx.Items.Clear();
            orderedPizzasLbx.Items.Clear();
        }

        private void ClearOrderFiles()
        {
            OrderedDrink.ClearFile();
            OrderedPizza.ClearFile();
            Order.ClearFile();
            ClearOrder();
        }
        private void clearBttn_Click(object sender, EventArgs e)
        {
            ClearOrderFiles();
        }

        private void saveOrderBttn_Click(object sender, EventArgs e)
        {
            if (orderedDrinksLbx.Items.Count == 0 || orderedPizzasLbx.Items.Count == 0)
            {
                MessageBox.Show("An order must have at least one pizza and one drink.");
                return;
            }

            if (customerOrderTbx.SelectedIndex == -1)
            {
                MessageBox.Show("Select a customer.");
                return;
            }

            try
            {
                List<OrderedPizza> pizzas = new List<OrderedPizza>();
                List<OrderedDrink> drinks = new List<OrderedDrink>();
                foreach (OrderedPizza p in orderedPizzasLbx.Items)
                {
                    pizzas.Add(p);
                }
                foreach (OrderedDrink d in orderedDrinksLbx.Items)
                {
                    drinks.Add(d);
                }
                Customer customer = (Customer)customerOrderTbx.SelectedItem;
                s.AddOrder(new Order(customer, pizzas, drinks, true));
                ClearOrderFiles();
                PopulateAll();
                MessageBox.Show("Order was successfully added");
            }
            catch (Exception)
            {
                MessageBox.Show("Couldn't parse the information.");
            }
        }

        private void cancelOrderBttn_Click(object sender, EventArgs e)
        {
            if (allOrdersLbx.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the order to Cancel");
                return;
            }

            try
            {
                Order o = (Order)allOrdersLbx.SelectedItem;
                o.Cancel(s.Name);
            }
            catch (Exception)
            {
                MessageBox.Show("Couldn't parse the information.");
            }
            PopulateOrders();
        }

        private void editCustomerBtn_Click(object sender, EventArgs e)
        {
            if (customersLbx.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the customer to Edit");
                return;
            }

            Customer customer = (Customer)customersLbx.SelectedItem;
            (new EditCustomer(customer)).Show();
        }

        private void deleteCustomerBttn_Click(object sender, EventArgs e)
        {
            if (customersLbx.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the customer to Edit");
                return;
            }
            try
            {
                Customer customer = (Customer)customersLbx.SelectedItem;

                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show("Are you sure you want to delete this customer?", "Delete Customer", buttons);
                if (result == DialogResult.Yes)
                {
                    customer.Delete();
                }
                PopulateAll();
            }
            catch (Exception)
            {
                MessageBox.Show("Couldn't parse the information.");
            }
        }

        private void viewReceiptBttn_Click(object sender, EventArgs e)
        {

        }
    }
}
