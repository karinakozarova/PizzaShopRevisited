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
            }if (isFilledChbx.Checked)
            {
                isFilled = true;
            }

            int quantity = Convert.ToInt32(QuantityInput.Value);
            Pizza pizza = (Pizza) pizzaTbx.SelectedItem;
            new OrderedPizza(pizza, quantity, isFilled, isThick);
            this.Close();
        } 
    }
}
