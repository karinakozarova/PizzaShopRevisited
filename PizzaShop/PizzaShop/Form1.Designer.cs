namespace PizzaShop
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.customerNameTbx = new System.Windows.Forms.TextBox();
            this.emailNameTbx = new System.Windows.Forms.TextBox();
            this.addNewCustomerBttn = new System.Windows.Forms.Button();
            this.exportCustomersBttn = new System.Windows.Forms.Button();
            this.importCustomersBttn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.customersLbx = new System.Windows.Forms.ListBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.drinkNameTbx = new System.Windows.Forms.TextBox();
            this.drinkPriceBttn = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.addDrinkBttn = new System.Windows.Forms.Button();
            this.drinksLbx = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pizzaNameTbx = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pizzaThickPriceInput = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.filledPizzaPriceInput = new System.Windows.Forms.NumericUpDown();
            this.addPizzaBttn = new System.Windows.Forms.Button();
            this.pizzasLbx = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drinkPriceBttn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaThickPriceInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filledPizzaPriceInput)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1189, 553);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 42);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1181, 507);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Shop";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 42);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1181, 507);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Orders";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.customersLbx);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.importCustomersBttn);
            this.tabPage3.Controls.Add(this.exportCustomersBttn);
            this.tabPage3.Controls.Add(this.addNewCustomerBttn);
            this.tabPage3.Controls.Add(this.emailNameTbx);
            this.tabPage3.Controls.Add(this.customerNameTbx);
            this.tabPage3.Location = new System.Drawing.Point(4, 42);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1181, 507);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Customers";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // customerNameTbx
            // 
            this.customerNameTbx.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameTbx.Location = new System.Drawing.Point(47, 65);
            this.customerNameTbx.Name = "customerNameTbx";
            this.customerNameTbx.Size = new System.Drawing.Size(382, 47);
            this.customerNameTbx.TabIndex = 0;
            // 
            // emailNameTbx
            // 
            this.emailNameTbx.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailNameTbx.Location = new System.Drawing.Point(47, 180);
            this.emailNameTbx.Name = "emailNameTbx";
            this.emailNameTbx.Size = new System.Drawing.Size(382, 47);
            this.emailNameTbx.TabIndex = 1;
            // 
            // addNewCustomerBttn
            // 
            this.addNewCustomerBttn.Location = new System.Drawing.Point(47, 258);
            this.addNewCustomerBttn.Name = "addNewCustomerBttn";
            this.addNewCustomerBttn.Size = new System.Drawing.Size(382, 55);
            this.addNewCustomerBttn.TabIndex = 2;
            this.addNewCustomerBttn.Text = "Add Customer";
            this.addNewCustomerBttn.UseVisualStyleBackColor = true;
            this.addNewCustomerBttn.Click += new System.EventHandler(this.addNewCustomerBttn_Click);
            // 
            // exportCustomersBttn
            // 
            this.exportCustomersBttn.Location = new System.Drawing.Point(47, 350);
            this.exportCustomersBttn.Name = "exportCustomersBttn";
            this.exportCustomersBttn.Size = new System.Drawing.Size(324, 55);
            this.exportCustomersBttn.TabIndex = 3;
            this.exportCustomersBttn.Text = "Export all customers";
            this.exportCustomersBttn.UseVisualStyleBackColor = true;
            // 
            // importCustomersBttn
            // 
            this.importCustomersBttn.Location = new System.Drawing.Point(47, 411);
            this.importCustomersBttn.Name = "importCustomersBttn";
            this.importCustomersBttn.Size = new System.Drawing.Size(300, 55);
            this.importCustomersBttn.TabIndex = 4;
            this.importCustomersBttn.Text = "Import customers";
            this.importCustomersBttn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 39);
            this.label2.TabIndex = 6;
            this.label2.Text = "Email";
            // 
            // customersLbx
            // 
            this.customersLbx.FormattingEnabled = true;
            this.customersLbx.ItemHeight = 33;
            this.customersLbx.Location = new System.Drawing.Point(529, 49);
            this.customersLbx.Name = "customersLbx";
            this.customersLbx.Size = new System.Drawing.Size(618, 400);
            this.customersLbx.TabIndex = 7;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.drinksLbx);
            this.tabPage4.Controls.Add(this.addDrinkBttn);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.drinkPriceBttn);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.drinkNameTbx);
            this.tabPage4.Location = new System.Drawing.Point(4, 42);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1181, 507);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Drinks";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.pizzasLbx);
            this.tabPage5.Controls.Add(this.addPizzaBttn);
            this.tabPage5.Controls.Add(this.label8);
            this.tabPage5.Controls.Add(this.filledPizzaPriceInput);
            this.tabPage5.Controls.Add(this.label7);
            this.tabPage5.Controls.Add(this.pizzaThickPriceInput);
            this.tabPage5.Controls.Add(this.label5);
            this.tabPage5.Controls.Add(this.pizzaNameTbx);
            this.tabPage5.Location = new System.Drawing.Point(4, 42);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1181, 507);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Pizzas";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 39);
            this.label3.TabIndex = 7;
            this.label3.Text = "Name";
            // 
            // drinkNameTbx
            // 
            this.drinkNameTbx.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinkNameTbx.Location = new System.Drawing.Point(57, 74);
            this.drinkNameTbx.Name = "drinkNameTbx";
            this.drinkNameTbx.Size = new System.Drawing.Size(382, 47);
            this.drinkNameTbx.TabIndex = 6;
            // 
            // drinkPriceBttn
            // 
            this.drinkPriceBttn.DecimalPlaces = 2;
            this.drinkPriceBttn.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinkPriceBttn.Location = new System.Drawing.Point(160, 137);
            this.drinkPriceBttn.Name = "drinkPriceBttn";
            this.drinkPriceBttn.Size = new System.Drawing.Size(279, 47);
            this.drinkPriceBttn.TabIndex = 8;
            this.drinkPriceBttn.ThousandsSeparator = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 39);
            this.label4.TabIndex = 9;
            this.label4.Text = "Price";
            // 
            // addDrinkBttn
            // 
            this.addDrinkBttn.Location = new System.Drawing.Point(57, 202);
            this.addDrinkBttn.Name = "addDrinkBttn";
            this.addDrinkBttn.Size = new System.Drawing.Size(382, 55);
            this.addDrinkBttn.TabIndex = 10;
            this.addDrinkBttn.Text = "Add Drink";
            this.addDrinkBttn.UseVisualStyleBackColor = true;
            this.addDrinkBttn.Click += new System.EventHandler(this.addDrinkBttn_Click);
            // 
            // drinksLbx
            // 
            this.drinksLbx.ItemHeight = 33;
            this.drinksLbx.Location = new System.Drawing.Point(514, 45);
            this.drinksLbx.Name = "drinksLbx";
            this.drinksLbx.Size = new System.Drawing.Size(618, 400);
            this.drinksLbx.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 39);
            this.label5.TabIndex = 9;
            this.label5.Text = "Name";
            // 
            // pizzaNameTbx
            // 
            this.pizzaNameTbx.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pizzaNameTbx.Location = new System.Drawing.Point(50, 74);
            this.pizzaNameTbx.Name = "pizzaNameTbx";
            this.pizzaNameTbx.Size = new System.Drawing.Size(389, 47);
            this.pizzaNameTbx.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(43, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 39);
            this.label7.TabIndex = 13;
            this.label7.Text = "Thick price";
            // 
            // pizzaThickPriceInput
            // 
            this.pizzaThickPriceInput.DecimalPlaces = 2;
            this.pizzaThickPriceInput.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pizzaThickPriceInput.Location = new System.Drawing.Point(220, 143);
            this.pizzaThickPriceInput.Name = "pizzaThickPriceInput";
            this.pizzaThickPriceInput.Size = new System.Drawing.Size(219, 47);
            this.pizzaThickPriceInput.TabIndex = 12;
            this.pizzaThickPriceInput.ThousandsSeparator = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(43, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(173, 39);
            this.label8.TabIndex = 15;
            this.label8.Text = "Filled price";
            // 
            // filledPizzaPriceInput
            // 
            this.filledPizzaPriceInput.DecimalPlaces = 2;
            this.filledPizzaPriceInput.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filledPizzaPriceInput.Location = new System.Drawing.Point(220, 216);
            this.filledPizzaPriceInput.Name = "filledPizzaPriceInput";
            this.filledPizzaPriceInput.Size = new System.Drawing.Size(219, 47);
            this.filledPizzaPriceInput.TabIndex = 14;
            this.filledPizzaPriceInput.ThousandsSeparator = true;
            // 
            // addPizzaBttn
            // 
            this.addPizzaBttn.Location = new System.Drawing.Point(44, 307);
            this.addPizzaBttn.Name = "addPizzaBttn";
            this.addPizzaBttn.Size = new System.Drawing.Size(395, 55);
            this.addPizzaBttn.TabIndex = 16;
            this.addPizzaBttn.Text = "Add Pizza";
            this.addPizzaBttn.UseVisualStyleBackColor = true;
            this.addPizzaBttn.Click += new System.EventHandler(this.addPizzaBttn_Click);
            // 
            // pizzasLbx
            // 
            this.pizzasLbx.ItemHeight = 33;
            this.pizzasLbx.Location = new System.Drawing.Point(498, 49);
            this.pizzasLbx.Name = "pizzasLbx";
            this.pizzasLbx.Size = new System.Drawing.Size(618, 400);
            this.pizzasLbx.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 577);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drinkPriceBttn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaThickPriceInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filledPizzaPriceInput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button importCustomersBttn;
        private System.Windows.Forms.Button exportCustomersBttn;
        private System.Windows.Forms.Button addNewCustomerBttn;
        private System.Windows.Forms.TextBox emailNameTbx;
        private System.Windows.Forms.TextBox customerNameTbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox customersLbx;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown drinkPriceBttn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox drinkNameTbx;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button addDrinkBttn;
        private System.Windows.Forms.ListBox drinksLbx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox pizzaNameTbx;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown filledPizzaPriceInput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown pizzaThickPriceInput;
        private System.Windows.Forms.Button addPizzaBttn;
        private System.Windows.Forms.ListBox pizzasLbx;
    }
}

