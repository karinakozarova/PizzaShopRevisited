using System;
using System.Windows.Forms;

namespace PizzaShop
{
    public partial class EditCustomer : Form
    {
        Customer customer;
        public EditCustomer(Customer c)
        {
            InitializeComponent();
            customerNameTbx.Text = c.Name;
            emailNameTbx.Text = c.Email;
            customer = c;
        }

        private void addNewCustomerBttn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(customerNameTbx.Text))
            {
                MessageBox.Show("Please enter a name");
                return;
            }

            if (!String.IsNullOrEmpty(emailNameTbx.Text) && !Utils.IsValidEmail(emailNameTbx.Text))
            {
                MessageBox.Show("Enter valid email");
                return;
            }

            customer.EditCustomer(customerNameTbx.Text, emailNameTbx.Text);
            foreach (Form form in Application.OpenForms)
            {
                if (form is Form1)
                {
                    Form1 currentform = (Form1)form;
                    currentform.PopulateAll();
                }
            }
            this.Hide();
        }
    }
}
