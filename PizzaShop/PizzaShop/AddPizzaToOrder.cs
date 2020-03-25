using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PizzaShop
{
    public partial class AddPizzaToOrder : Form
    {
        public AddPizzaToOrder()
        {
            InitializeComponent();
            pizzaTbx.Items.Clear();
            List<Pizza> pizzas = Pizza.GetAllPizzas();
            foreach (Pizza p in pizzas)
            {
                pizzaTbx.Items.Add(p);
            }
        }

        private void addPizzaToOrderBttn_Click(object sender, EventArgs e)
        {
            if (QuantityInput.Value == 0)
            {
                MessageBox.Show("Enter quantity!");
                return;
            }
            if (pizzaTbx.SelectedIndex == -1)
            {
                MessageBox.Show("Select a pizza!");
                return;
            }

            bool isThick = false;
            bool isFilled = false;

            if (isThickCheckBox.Checked)
            {
                isThick = true;
            }
            if (isFilledChbx.Checked)
            {
                isFilled = true;
            }
            try
            {
                int quantity = Convert.ToInt32(QuantityInput.Value);
                Pizza pizza = (Pizza)pizzaTbx.SelectedItem;
                new OrderedPizza(pizza, quantity, isFilled, isThick);
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
