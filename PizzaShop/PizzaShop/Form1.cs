using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaShop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            RefreshCustomers();
            RefreshDrinks();
            RefreshPizzas();
        }

        private void RefreshCustomers()
        {
            customersLbx.Items.Clear();
            List<Customer> customers = Customer.GetAllCustomers();
            foreach (Customer c in customers)
            {
                customersLbx.Items.Add(c);
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

            if (!String.IsNullOrEmpty(emailNameTbx.Text) && !Utils.IsValidEmail(emailNameTbx.Text)){
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

            if(drinkPriceBttn.Value == 0)
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
    }
}
