namespace PizzaShop
{
    partial class EditCustomer
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addNewCustomerBttn = new System.Windows.Forms.Button();
            this.emailNameTbx = new System.Windows.Forms.TextBox();
            this.customerNameTbx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 39);
            this.label2.TabIndex = 11;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 39);
            this.label1.TabIndex = 10;
            this.label1.Text = "Name";
            // 
            // addNewCustomerBttn
            // 
            this.addNewCustomerBttn.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewCustomerBttn.Location = new System.Drawing.Point(19, 261);
            this.addNewCustomerBttn.Name = "addNewCustomerBttn";
            this.addNewCustomerBttn.Size = new System.Drawing.Size(382, 55);
            this.addNewCustomerBttn.TabIndex = 9;
            this.addNewCustomerBttn.Text = "Add Customer";
            this.addNewCustomerBttn.UseVisualStyleBackColor = true;
            // 
            // emailNameTbx
            // 
            this.emailNameTbx.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailNameTbx.Location = new System.Drawing.Point(19, 183);
            this.emailNameTbx.Name = "emailNameTbx";
            this.emailNameTbx.Size = new System.Drawing.Size(382, 47);
            this.emailNameTbx.TabIndex = 8;
            // 
            // customerNameTbx
            // 
            this.customerNameTbx.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameTbx.Location = new System.Drawing.Point(19, 68);
            this.customerNameTbx.Name = "customerNameTbx";
            this.customerNameTbx.Size = new System.Drawing.Size(382, 47);
            this.customerNameTbx.TabIndex = 7;
            // 
            // EditCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 344);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addNewCustomerBttn);
            this.Controls.Add(this.emailNameTbx);
            this.Controls.Add(this.customerNameTbx);
            this.Name = "EditCustomer";
            this.Text = "EditCustomer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addNewCustomerBttn;
        private System.Windows.Forms.TextBox emailNameTbx;
        private System.Windows.Forms.TextBox customerNameTbx;
    }
}