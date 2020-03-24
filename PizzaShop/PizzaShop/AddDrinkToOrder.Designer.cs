namespace PizzaShop
{
    partial class AddDrinkToOrder
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
            this.addPizzaToOrderBttn = new System.Windows.Forms.Button();
            this.QuantityInput = new System.Windows.Forms.NumericUpDown();
            this.drinksTbx = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityInput)).BeginInit();
            this.SuspendLayout();
            // 
            // addPizzaToOrderBttn
            // 
            this.addPizzaToOrderBttn.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPizzaToOrderBttn.Location = new System.Drawing.Point(21, 108);
            this.addPizzaToOrderBttn.Name = "addPizzaToOrderBttn";
            this.addPizzaToOrderBttn.Size = new System.Drawing.Size(495, 53);
            this.addPizzaToOrderBttn.TabIndex = 28;
            this.addPizzaToOrderBttn.Text = "Add drink";
            this.addPizzaToOrderBttn.UseVisualStyleBackColor = true;
            this.addPizzaToOrderBttn.Click += new System.EventHandler(this.addPizzaToOrderBttn_Click);
            // 
            // QuantityInput
            // 
            this.QuantityInput.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityInput.Location = new System.Drawing.Point(388, 42);
            this.QuantityInput.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.QuantityInput.Name = "QuantityInput";
            this.QuantityInput.Size = new System.Drawing.Size(128, 42);
            this.QuantityInput.TabIndex = 27;
            // 
            // drinksTbx
            // 
            this.drinksTbx.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinksTbx.FormattingEnabled = true;
            this.drinksTbx.Location = new System.Drawing.Point(21, 41);
            this.drinksTbx.Name = "drinksTbx";
            this.drinksTbx.Size = new System.Drawing.Size(329, 47);
            this.drinksTbx.TabIndex = 26;
            // 
            // AddDrinkToOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 194);
            this.Controls.Add(this.addPizzaToOrderBttn);
            this.Controls.Add(this.QuantityInput);
            this.Controls.Add(this.drinksTbx);
            this.Name = "AddDrinkToOrder";
            this.Text = "AddDrinkToOrder";
            ((System.ComponentModel.ISupportInitialize)(this.QuantityInput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addPizzaToOrderBttn;
        private System.Windows.Forms.NumericUpDown QuantityInput;
        private System.Windows.Forms.ComboBox drinksTbx;
    }
}