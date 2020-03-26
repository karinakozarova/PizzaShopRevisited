namespace PizzaShop
{
    partial class Receipt
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
            this.shopNameLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.totalLbl = new System.Windows.Forms.Label();
            this.orderInformationLbl = new System.Windows.Forms.Label();
            this.flwOrderedItems = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // shopNameLbl
            // 
            this.shopNameLbl.AutoSize = true;
            this.shopNameLbl.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shopNameLbl.Location = new System.Drawing.Point(27, 31);
            this.shopNameLbl.Name = "shopNameLbl";
            this.shopNameLbl.Size = new System.Drawing.Size(110, 44);
            this.shopNameLbl.TabIndex = 0;
            this.shopNameLbl.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 523);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 44);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total:";
            // 
            // totalLbl
            // 
            this.totalLbl.AutoSize = true;
            this.totalLbl.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLbl.Location = new System.Drawing.Point(413, 523);
            this.totalLbl.Name = "totalLbl";
            this.totalLbl.Size = new System.Drawing.Size(116, 44);
            this.totalLbl.TabIndex = 2;
            this.totalLbl.Text = "label3";
            // 
            // orderInformationLbl
            // 
            this.orderInformationLbl.AutoSize = true;
            this.orderInformationLbl.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderInformationLbl.Location = new System.Drawing.Point(27, 596);
            this.orderInformationLbl.Name = "orderInformationLbl";
            this.orderInformationLbl.Size = new System.Drawing.Size(105, 39);
            this.orderInformationLbl.TabIndex = 3;
            this.orderInformationLbl.Text = "label4";
            // 
            // flwOrderedItems
            // 
            this.flwOrderedItems.AutoScroll = true;
            this.flwOrderedItems.AutoSize = true;
            this.flwOrderedItems.Location = new System.Drawing.Point(36, 109);
            this.flwOrderedItems.Name = "flwOrderedItems";
            this.flwOrderedItems.Size = new System.Drawing.Size(726, 383);
            this.flwOrderedItems.TabIndex = 4;
            // 
            // Receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 686);
            this.Controls.Add(this.flwOrderedItems);
            this.Controls.Add(this.orderInformationLbl);
            this.Controls.Add(this.totalLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.shopNameLbl);
            this.Name = "Receipt";
            this.Text = "Receipt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label shopNameLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label totalLbl;
        private System.Windows.Forms.Label orderInformationLbl;
        private System.Windows.Forms.FlowLayoutPanel flwOrderedItems;
    }
}