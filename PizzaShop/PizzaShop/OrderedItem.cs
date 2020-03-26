using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaShop
{
    public partial class OrderedItem : UserControl
    {

        public OrderedItem(string name, string quantity, float total)
        {
            InitializeComponent();
            
            itemName.Text = name;
            quantityAndPriceLbl.Text = quantity;
            totalLbl.Text = total.ToString();
        }
    }
}
