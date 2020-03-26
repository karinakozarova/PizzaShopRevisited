namespace PizzaShop
{
    partial class OrderedItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.itemName = new System.Windows.Forms.Label();
            this.quantityAndPriceLbl = new System.Windows.Forms.Label();
            this.totalLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // itemName
            // 
            this.itemName.AutoSize = true;
            this.itemName.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemName.Location = new System.Drawing.Point(35, 21);
            this.itemName.Name = "itemName";
            this.itemName.Size = new System.Drawing.Size(104, 44);
            this.itemName.TabIndex = 2;
            this.itemName.Text = "Total:";
            // 
            // quantityAndPriceLbl
            // 
            this.quantityAndPriceLbl.AutoSize = true;
            this.quantityAndPriceLbl.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityAndPriceLbl.Location = new System.Drawing.Point(128, 75);
            this.quantityAndPriceLbl.Name = "quantityAndPriceLbl";
            this.quantityAndPriceLbl.Size = new System.Drawing.Size(104, 44);
            this.quantityAndPriceLbl.TabIndex = 3;
            this.quantityAndPriceLbl.Text = "Total:";
            // 
            // totalLbl
            // 
            this.totalLbl.AutoSize = true;
            this.totalLbl.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLbl.Location = new System.Drawing.Point(562, 75);
            this.totalLbl.Name = "totalLbl";
            this.totalLbl.Size = new System.Drawing.Size(104, 44);
            this.totalLbl.TabIndex = 4;
            this.totalLbl.Text = "Total:";
            // 
            // OrderedItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.totalLbl);
            this.Controls.Add(this.quantityAndPriceLbl);
            this.Controls.Add(this.itemName);
            this.Name = "OrderedItem";
            this.Size = new System.Drawing.Size(701, 141);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label itemName;
        private System.Windows.Forms.Label quantityAndPriceLbl;
        private System.Windows.Forms.Label totalLbl;
    }
}
