using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PizzaShop
{
    public partial class AddDrinkToOrder : Form
    {
        public AddDrinkToOrder()
        {
            InitializeComponent();

            drinksTbx.Items.Clear();
            List<Drink> drinks = Drink.GetAllDrinks();
            foreach (Drink d in drinks)
            {
                drinksTbx.Items.Add(d);
            }
        }

        private void addPizzaToOrderBttn_Click(object sender, EventArgs e)
        {
            if (QuantityInput.Value == 0)
            {
                MessageBox.Show("Enter quantity!");
                return;
            }
            if (drinksTbx.SelectedIndex == -1)
            {
                MessageBox.Show("Select a drink!");
                return;
            }
            try
            {
                int quantity = Convert.ToInt32(QuantityInput.Value);
                Drink drink = (Drink)drinksTbx.SelectedItem;
                new OrderedDrink(drink, quantity);
                foreach (Form form in Application.OpenForms)
                {
                    if (form is Form1)
                    {
                        Form1 currentform = (Form1)form;
                        currentform.PopulateAll();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Couldn't parse the information.");
            }
            this.Close();
        }
    }
}
