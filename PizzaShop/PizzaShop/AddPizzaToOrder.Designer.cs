namespace PizzaShop
{
    partial class AddPizzaToOrder
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
            this.pizzaTbx = new System.Windows.Forms.ComboBox();
            this.isThickCheckBox = new System.Windows.Forms.CheckBox();
            this.isFilledChbx = new System.Windows.Forms.CheckBox();
            this.QuantityInput = new System.Windows.Forms.NumericUpDown();
            this.addPizzaToOrderBttn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityInput)).BeginInit();
            this.SuspendLayout();
            // 
            // pizzaTbx
            // 
            this.pizzaTbx.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pizzaTbx.FormattingEnabled = true;
            this.pizzaTbx.Location = new System.Drawing.Point(30, 33);
            this.pizzaTbx.Name = "pizzaTbx";
            this.pizzaTbx.Size = new System.Drawing.Size(372, 47);
            this.pizzaTbx.TabIndex = 21;
            // 
            // isThickCheckBox
            // 
            this.isThickCheckBox.AutoSize = true;
            this.isThickCheckBox.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isThickCheckBox.Location = new System.Drawing.Point(30, 97);
            this.isThickCheckBox.Name = "isThickCheckBox";
            this.isThickCheckBox.Size = new System.Drawing.Size(105, 37);
            this.isThickCheckBox.TabIndex = 22;
            this.isThickCheckBox.Text = "Thick";
            this.isThickCheckBox.UseVisualStyleBackColor = true;
            // 
            // isFilledChbx
            // 
            this.isFilledChbx.AutoSize = true;
            this.isFilledChbx.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isFilledChbx.Location = new System.Drawing.Point(166, 97);
            this.isFilledChbx.Name = "isFilledChbx";
            this.isFilledChbx.Size = new System.Drawing.Size(105, 37);
            this.isFilledChbx.TabIndex = 23;
            this.isFilledChbx.Text = "Filled";
            this.isFilledChbx.UseVisualStyleBackColor = true;
            // 
            // QuantityInput
            // 
            this.QuantityInput.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityInput.Location = new System.Drawing.Point(437, 34);
            this.QuantityInput.Name = "QuantityInput";
            this.QuantityInput.Size = new System.Drawing.Size(154, 42);
            this.QuantityInput.TabIndex = 24;
            // 
            // addPizzaToOrderBttn
            // 
            this.addPizzaToOrderBttn.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPizzaToOrderBttn.Location = new System.Drawing.Point(30, 156);
            this.addPizzaToOrderBttn.Name = "addPizzaToOrderBttn";
            this.addPizzaToOrderBttn.Size = new System.Drawing.Size(561, 48);
            this.addPizzaToOrderBttn.TabIndex = 25;
            this.addPizzaToOrderBttn.Text = "Add pizza ";
            this.addPizzaToOrderBttn.UseVisualStyleBackColor = true;
            this.addPizzaToOrderBttn.Click += new System.EventHandler(this.addPizzaToOrderBttn_Click);
            // 
            // AddPizzaToOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 228);
            this.Controls.Add(this.addPizzaToOrderBttn);
            this.Controls.Add(this.QuantityInput);
            this.Controls.Add(this.isFilledChbx);
            this.Controls.Add(this.isThickCheckBox);
            this.Controls.Add(this.pizzaTbx);
            this.Name = "AddPizzaToOrder";
            this.Text = "AddPizzaToOrder";
            ((System.ComponentModel.ISupportInitialize)(this.QuantityInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox pizzaTbx;
        private System.Windows.Forms.CheckBox isThickCheckBox;
        private System.Windows.Forms.CheckBox isFilledChbx;
        private System.Windows.Forms.NumericUpDown QuantityInput;
        private System.Windows.Forms.Button addPizzaToOrderBttn;
    }
}