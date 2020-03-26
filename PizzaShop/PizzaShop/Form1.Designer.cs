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
            this.shopNameLbl = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dateRevenueLbl = new System.Windows.Forms.Label();
            this.dailyRevenueLbl = new System.Windows.Forms.Label();
            this.totalRevenueLbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.revenueDateTime = new System.Windows.Forms.Label();
            this.revenueDateTImePicker = new System.Windows.Forms.DateTimePicker();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.clearBttn = new System.Windows.Forms.Button();
            this.customerOrderTbx = new System.Windows.Forms.ComboBox();
            this.saveOrderBttn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.addDrinkToOrderBttn = new System.Windows.Forms.Button();
            this.addPizzaToOrderBttn = new System.Windows.Forms.Button();
            this.orderedDrinksLbx = new System.Windows.Forms.ListBox();
            this.orderedPizzasLbx = new System.Windows.Forms.ListBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.viewReceiptBttn = new System.Windows.Forms.Button();
            this.cancelOrderBttn = new System.Windows.Forms.Button();
            this.allOrdersLbx = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.deleteCustomerBttn = new System.Windows.Forms.Button();
            this.editCustomerBtn = new System.Windows.Forms.Button();
            this.customersLbx = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.importCustomersBttn = new System.Windows.Forms.Button();
            this.exportCustomersBttn = new System.Windows.Forms.Button();
            this.addNewCustomerBttn = new System.Windows.Forms.Button();
            this.emailNameTbx = new System.Windows.Forms.TextBox();
            this.customerNameTbx = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.drinksLbx = new System.Windows.Forms.ListBox();
            this.addDrinkBttn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.drinkPriceBttn = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.drinkNameTbx = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.pizzasLbx = new System.Windows.Forms.ListBox();
            this.addPizzaBttn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.filledPizzaPriceInput = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.pizzaThickPriceInput = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.pizzaNameTbx = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drinkPriceBttn)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filledPizzaPriceInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaThickPriceInput)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1189, 570);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.shopNameLbl);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.dateRevenueLbl);
            this.tabPage1.Controls.Add(this.dailyRevenueLbl);
            this.tabPage1.Controls.Add(this.totalRevenueLbl);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.revenueDateTime);
            this.tabPage1.Controls.Add(this.revenueDateTImePicker);
            this.tabPage1.Location = new System.Drawing.Point(4, 42);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1181, 524);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Shop";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // shopNameLbl
            // 
            this.shopNameLbl.AutoSize = true;
            this.shopNameLbl.Font = new System.Drawing.Font("Montserrat", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shopNameLbl.Location = new System.Drawing.Point(628, 243);
            this.shopNameLbl.Name = "shopNameLbl";
            this.shopNameLbl.Size = new System.Drawing.Size(476, 99);
            this.shopNameLbl.TabIndex = 8;
            this.shopNameLbl.Text = "Welcome to";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Montserrat", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(523, 111);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(636, 132);
            this.label11.TabIndex = 7;
            this.label11.Text = "Welcome to";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(53, 353);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(277, 50);
            this.label10.TabIndex = 6;
            this.label10.Text = "Daily revenue:";
            // 
            // dateRevenueLbl
            // 
            this.dateRevenueLbl.AutoSize = true;
            this.dateRevenueLbl.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateRevenueLbl.Location = new System.Drawing.Point(362, 177);
            this.dateRevenueLbl.Name = "dateRevenueLbl";
            this.dateRevenueLbl.Size = new System.Drawing.Size(46, 50);
            this.dateRevenueLbl.TabIndex = 5;
            this.dateRevenueLbl.Text = "0";
            // 
            // dailyRevenueLbl
            // 
            this.dailyRevenueLbl.AutoSize = true;
            this.dailyRevenueLbl.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dailyRevenueLbl.Location = new System.Drawing.Point(362, 353);
            this.dailyRevenueLbl.Name = "dailyRevenueLbl";
            this.dailyRevenueLbl.Size = new System.Drawing.Size(46, 50);
            this.dailyRevenueLbl.TabIndex = 4;
            this.dailyRevenueLbl.Text = "0";
            // 
            // totalRevenueLbl
            // 
            this.totalRevenueLbl.AutoSize = true;
            this.totalRevenueLbl.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalRevenueLbl.Location = new System.Drawing.Point(351, 39);
            this.totalRevenueLbl.Name = "totalRevenueLbl";
            this.totalRevenueLbl.Size = new System.Drawing.Size(46, 50);
            this.totalRevenueLbl.TabIndex = 3;
            this.totalRevenueLbl.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(53, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(274, 50);
            this.label6.TabIndex = 2;
            this.label6.Text = "Total revenue:";
            // 
            // revenueDateTime
            // 
            this.revenueDateTime.AutoSize = true;
            this.revenueDateTime.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.revenueDateTime.Location = new System.Drawing.Point(46, 177);
            this.revenueDateTime.Name = "revenueDateTime";
            this.revenueDateTime.Size = new System.Drawing.Size(310, 50);
            this.revenueDateTime.TabIndex = 1;
            this.revenueDateTime.Text = "See revenue for:";
            // 
            // revenueDateTImePicker
            // 
            this.revenueDateTImePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.revenueDateTImePicker.Location = new System.Drawing.Point(62, 247);
            this.revenueDateTImePicker.Name = "revenueDateTImePicker";
            this.revenueDateTImePicker.Size = new System.Drawing.Size(396, 32);
            this.revenueDateTImePicker.TabIndex = 0;
            this.revenueDateTImePicker.ValueChanged += new System.EventHandler(this.revenueDateTImePicker_ValueChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.clearBttn);
            this.tabPage2.Controls.Add(this.customerOrderTbx);
            this.tabPage2.Controls.Add(this.saveOrderBttn);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.addDrinkToOrderBttn);
            this.tabPage2.Controls.Add(this.addPizzaToOrderBttn);
            this.tabPage2.Controls.Add(this.orderedDrinksLbx);
            this.tabPage2.Controls.Add(this.orderedPizzasLbx);
            this.tabPage2.Location = new System.Drawing.Point(4, 42);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1181, 524);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Orders";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // clearBttn
            // 
            this.clearBttn.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBttn.Location = new System.Drawing.Point(32, 389);
            this.clearBttn.Name = "clearBttn";
            this.clearBttn.Size = new System.Drawing.Size(625, 63);
            this.clearBttn.TabIndex = 21;
            this.clearBttn.Text = "Clear";
            this.clearBttn.UseVisualStyleBackColor = true;
            this.clearBttn.Click += new System.EventHandler(this.clearBttn_Click);
            // 
            // customerOrderTbx
            // 
            this.customerOrderTbx.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerOrderTbx.FormattingEnabled = true;
            this.customerOrderTbx.Location = new System.Drawing.Point(32, 95);
            this.customerOrderTbx.Name = "customerOrderTbx";
            this.customerOrderTbx.Size = new System.Drawing.Size(612, 47);
            this.customerOrderTbx.TabIndex = 20;
            // 
            // saveOrderBttn
            // 
            this.saveOrderBttn.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveOrderBttn.Location = new System.Drawing.Point(32, 320);
            this.saveOrderBttn.Name = "saveOrderBttn";
            this.saveOrderBttn.Size = new System.Drawing.Size(625, 63);
            this.saveOrderBttn.TabIndex = 19;
            this.saveOrderBttn.Text = "Save order";
            this.saveOrderBttn.UseVisualStyleBackColor = true;
            this.saveOrderBttn.Click += new System.EventHandler(this.saveOrderBttn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Montserrat", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(22, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(320, 55);
            this.label9.TabIndex = 18;
            this.label9.Text = "Add new order";
            // 
            // addDrinkToOrderBttn
            // 
            this.addDrinkToOrderBttn.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDrinkToOrderBttn.Location = new System.Drawing.Point(373, 148);
            this.addDrinkToOrderBttn.Name = "addDrinkToOrderBttn";
            this.addDrinkToOrderBttn.Size = new System.Drawing.Size(271, 60);
            this.addDrinkToOrderBttn.TabIndex = 17;
            this.addDrinkToOrderBttn.Text = "Add drink ";
            this.addDrinkToOrderBttn.UseVisualStyleBackColor = true;
            this.addDrinkToOrderBttn.Click += new System.EventHandler(this.addDrinkToOrderBttn_Click);
            // 
            // addPizzaToOrderBttn
            // 
            this.addPizzaToOrderBttn.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPizzaToOrderBttn.Location = new System.Drawing.Point(32, 148);
            this.addPizzaToOrderBttn.Name = "addPizzaToOrderBttn";
            this.addPizzaToOrderBttn.Size = new System.Drawing.Size(335, 60);
            this.addPizzaToOrderBttn.TabIndex = 16;
            this.addPizzaToOrderBttn.Text = "Add pizza ";
            this.addPizzaToOrderBttn.UseVisualStyleBackColor = true;
            this.addPizzaToOrderBttn.Click += new System.EventHandler(this.addPizzaToOrderBttn_Click);
            // 
            // orderedDrinksLbx
            // 
            this.orderedDrinksLbx.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderedDrinksLbx.ItemHeight = 39;
            this.orderedDrinksLbx.Location = new System.Drawing.Point(686, 253);
            this.orderedDrinksLbx.Name = "orderedDrinksLbx";
            this.orderedDrinksLbx.Size = new System.Drawing.Size(467, 199);
            this.orderedDrinksLbx.TabIndex = 13;
            // 
            // orderedPizzasLbx
            // 
            this.orderedPizzasLbx.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderedPizzasLbx.ItemHeight = 39;
            this.orderedPizzasLbx.Location = new System.Drawing.Point(686, 28);
            this.orderedPizzasLbx.Name = "orderedPizzasLbx";
            this.orderedPizzasLbx.Size = new System.Drawing.Size(467, 199);
            this.orderedPizzasLbx.TabIndex = 12;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.viewReceiptBttn);
            this.tabPage6.Controls.Add(this.cancelOrderBttn);
            this.tabPage6.Controls.Add(this.allOrdersLbx);
            this.tabPage6.Location = new System.Drawing.Point(4, 42);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(1181, 524);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Order actions";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // viewReceiptBttn
            // 
            this.viewReceiptBttn.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewReceiptBttn.Location = new System.Drawing.Point(30, 424);
            this.viewReceiptBttn.Name = "viewReceiptBttn";
            this.viewReceiptBttn.Size = new System.Drawing.Size(625, 63);
            this.viewReceiptBttn.TabIndex = 22;
            this.viewReceiptBttn.Text = "View receipt";
            this.viewReceiptBttn.UseVisualStyleBackColor = true;
            this.viewReceiptBttn.Click += new System.EventHandler(this.viewReceiptBttn_Click);
            // 
            // cancelOrderBttn
            // 
            this.cancelOrderBttn.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelOrderBttn.Location = new System.Drawing.Point(685, 424);
            this.cancelOrderBttn.Name = "cancelOrderBttn";
            this.cancelOrderBttn.Size = new System.Drawing.Size(462, 63);
            this.cancelOrderBttn.TabIndex = 20;
            this.cancelOrderBttn.Text = "Cancel order";
            this.cancelOrderBttn.UseVisualStyleBackColor = true;
            this.cancelOrderBttn.Click += new System.EventHandler(this.cancelOrderBttn_Click);
            // 
            // allOrdersLbx
            // 
            this.allOrdersLbx.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allOrdersLbx.HorizontalScrollbar = true;
            this.allOrdersLbx.ItemHeight = 39;
            this.allOrdersLbx.Location = new System.Drawing.Point(21, 32);
            this.allOrdersLbx.Name = "allOrdersLbx";
            this.allOrdersLbx.Size = new System.Drawing.Size(1126, 355);
            this.allOrdersLbx.TabIndex = 13;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.deleteCustomerBttn);
            this.tabPage3.Controls.Add(this.editCustomerBtn);
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
            this.tabPage3.Size = new System.Drawing.Size(1181, 524);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Customers";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // deleteCustomerBttn
            // 
            this.deleteCustomerBttn.Location = new System.Drawing.Point(524, 411);
            this.deleteCustomerBttn.Name = "deleteCustomerBttn";
            this.deleteCustomerBttn.Size = new System.Drawing.Size(224, 93);
            this.deleteCustomerBttn.TabIndex = 10;
            this.deleteCustomerBttn.Text = "Delete selected customer";
            this.deleteCustomerBttn.UseVisualStyleBackColor = true;
            this.deleteCustomerBttn.Click += new System.EventHandler(this.deleteCustomerBttn_Click);
            // 
            // editCustomerBtn
            // 
            this.editCustomerBtn.Location = new System.Drawing.Point(768, 411);
            this.editCustomerBtn.Name = "editCustomerBtn";
            this.editCustomerBtn.Size = new System.Drawing.Size(374, 93);
            this.editCustomerBtn.TabIndex = 9;
            this.editCustomerBtn.Text = "Edit selected customer";
            this.editCustomerBtn.UseVisualStyleBackColor = true;
            this.editCustomerBtn.Click += new System.EventHandler(this.editCustomerBtn_Click);
            // 
            // customersLbx
            // 
            this.customersLbx.FormattingEnabled = true;
            this.customersLbx.ItemHeight = 33;
            this.customersLbx.Location = new System.Drawing.Point(524, 23);
            this.customersLbx.Name = "customersLbx";
            this.customersLbx.Size = new System.Drawing.Size(618, 367);
            this.customersLbx.TabIndex = 7;
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
            // importCustomersBttn
            // 
            this.importCustomersBttn.Location = new System.Drawing.Point(47, 439);
            this.importCustomersBttn.Name = "importCustomersBttn";
            this.importCustomersBttn.Size = new System.Drawing.Size(300, 55);
            this.importCustomersBttn.TabIndex = 4;
            this.importCustomersBttn.Text = "Import customers";
            this.importCustomersBttn.UseVisualStyleBackColor = true;
            // 
            // exportCustomersBttn
            // 
            this.exportCustomersBttn.Location = new System.Drawing.Point(47, 378);
            this.exportCustomersBttn.Name = "exportCustomersBttn";
            this.exportCustomersBttn.Size = new System.Drawing.Size(324, 55);
            this.exportCustomersBttn.TabIndex = 3;
            this.exportCustomersBttn.Text = "Export all customers";
            this.exportCustomersBttn.UseVisualStyleBackColor = true;
            // 
            // addNewCustomerBttn
            // 
            this.addNewCustomerBttn.Location = new System.Drawing.Point(47, 249);
            this.addNewCustomerBttn.Name = "addNewCustomerBttn";
            this.addNewCustomerBttn.Size = new System.Drawing.Size(382, 55);
            this.addNewCustomerBttn.TabIndex = 2;
            this.addNewCustomerBttn.Text = "Add Customer";
            this.addNewCustomerBttn.UseVisualStyleBackColor = true;
            this.addNewCustomerBttn.Click += new System.EventHandler(this.addNewCustomerBttn_Click);
            // 
            // emailNameTbx
            // 
            this.emailNameTbx.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailNameTbx.Location = new System.Drawing.Point(47, 180);
            this.emailNameTbx.Name = "emailNameTbx";
            this.emailNameTbx.Size = new System.Drawing.Size(382, 47);
            this.emailNameTbx.TabIndex = 1;
            // 
            // customerNameTbx
            // 
            this.customerNameTbx.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameTbx.Location = new System.Drawing.Point(47, 65);
            this.customerNameTbx.Name = "customerNameTbx";
            this.customerNameTbx.Size = new System.Drawing.Size(382, 47);
            this.customerNameTbx.TabIndex = 0;
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
            this.tabPage4.Size = new System.Drawing.Size(1181, 524);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Drinks";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // drinksLbx
            // 
            this.drinksLbx.ItemHeight = 33;
            this.drinksLbx.Location = new System.Drawing.Point(514, 45);
            this.drinksLbx.Name = "drinksLbx";
            this.drinksLbx.Size = new System.Drawing.Size(618, 400);
            this.drinksLbx.TabIndex = 11;
            // 
            // addDrinkBttn
            // 
            this.addDrinkBttn.Location = new System.Drawing.Point(57, 216);
            this.addDrinkBttn.Name = "addDrinkBttn";
            this.addDrinkBttn.Size = new System.Drawing.Size(382, 55);
            this.addDrinkBttn.TabIndex = 10;
            this.addDrinkBttn.Text = "Add Drink";
            this.addDrinkBttn.UseVisualStyleBackColor = true;
            this.addDrinkBttn.Click += new System.EventHandler(this.addDrinkBttn_Click);
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
            this.tabPage5.Size = new System.Drawing.Size(1181, 524);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Pizzas";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // pizzasLbx
            // 
            this.pizzasLbx.ItemHeight = 33;
            this.pizzasLbx.Location = new System.Drawing.Point(498, 49);
            this.pizzasLbx.Name = "pizzasLbx";
            this.pizzasLbx.Size = new System.Drawing.Size(618, 400);
            this.pizzasLbx.TabIndex = 17;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 584);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drinkPriceBttn)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filledPizzaPriceInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaThickPriceInput)).EndInit();
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
        private System.Windows.Forms.Label revenueDateTime;
        private System.Windows.Forms.DateTimePicker revenueDateTImePicker;
        private System.Windows.Forms.Label dailyRevenueLbl;
        private System.Windows.Forms.Label totalRevenueLbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox orderedDrinksLbx;
        private System.Windows.Forms.ListBox orderedPizzasLbx;
        private System.Windows.Forms.Button addDrinkToOrderBttn;
        private System.Windows.Forms.Button addPizzaToOrderBttn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button saveOrderBttn;
        private System.Windows.Forms.ComboBox customerOrderTbx;
        private System.Windows.Forms.Button clearBttn;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.ListBox allOrdersLbx;
        private System.Windows.Forms.Button cancelOrderBttn;
        private System.Windows.Forms.Button viewReceiptBttn;
        private System.Windows.Forms.Button editCustomerBtn;
        private System.Windows.Forms.Button deleteCustomerBttn;
        private System.Windows.Forms.Label dateRevenueLbl;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label shopNameLbl;
        private System.Windows.Forms.Label label11;
    }
}

