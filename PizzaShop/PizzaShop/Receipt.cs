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
    public partial class Receipt : Form
    {
        Shop s;
        Order order;
        List<OrderedItem> controls;
   

    public Receipt(Shop s, Order selectedItem)
        {
            InitializeComponent();
            this.s = s;
            this.order = selectedItem;
            shopNameLbl.Text = s.Name;
            orderInformationLbl.Text = $"ORDERED BY {order.Customer} ON {order.OrderedAt}";
            totalLbl.Text = order.CalculateTotalCost().ToString();
            if(order.IsCancelled) this.BackColor = Color.IndianRed;
            else this.BackColor = Color.LightGreen;

            controls = new List<OrderedItem>();
            foreach (OrderedPizza pizza in selectedItem.GetPizzas())
            {
                controls.Add(new OrderedItem(pizza.FullPizzaName(), pizza.PizzaQuantityAndPrice(), pizza.CalculatePrice()));
            }
            
            foreach (OrderedDrink drink in selectedItem.GetDrinks())
            {
                controls.Add(new OrderedItem(drink.GetDrinkName(), drink.DrinkQuantityAndPrice(), drink.CalculatePrice()));
            }

            foreach (OrderedItem item in controls)
            {
                flwOrderedItems.Controls.Add(item);
            }
        }
    }
}
