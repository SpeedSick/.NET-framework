namespace FinalExam
{
    partial class Order
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
            this.buttonAddToOrder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.EventList = new System.Windows.Forms.ListBox();
            this.buttonDeleteFromOrder = new System.Windows.Forms.Button();
            this.CurrentOrder = new System.Windows.Forms.ListBox();
            this.OrderCost = new System.Windows.Forms.TextBox();
            this.CompleteOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAddToOrder
            // 
            this.buttonAddToOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddToOrder.Location = new System.Drawing.Point(370, 50);
            this.buttonAddToOrder.Name = "buttonAddToOrder";
            this.buttonAddToOrder.Size = new System.Drawing.Size(314, 48);
            this.buttonAddToOrder.TabIndex = 0;
            this.buttonAddToOrder.Text = "Add event to current order";
            this.buttonAddToOrder.UseVisualStyleBackColor = true;
            this.buttonAddToOrder.Click += new System.EventHandler(this.buttonAddToOrder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(364, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Orders";
            // 
            // EventList
            // 
            this.EventList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EventList.FormattingEnabled = true;
            this.EventList.ItemHeight = 22;
            this.EventList.Location = new System.Drawing.Point(12, 50);
            this.EventList.Name = "EventList";
            this.EventList.ScrollAlwaysVisible = true;
            this.EventList.Size = new System.Drawing.Size(337, 48);
            this.EventList.TabIndex = 2;
            // 
            // buttonDeleteFromOrder
            // 
            this.buttonDeleteFromOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeleteFromOrder.Location = new System.Drawing.Point(370, 128);
            this.buttonDeleteFromOrder.Name = "buttonDeleteFromOrder";
            this.buttonDeleteFromOrder.Size = new System.Drawing.Size(314, 92);
            this.buttonDeleteFromOrder.TabIndex = 4;
            this.buttonDeleteFromOrder.Text = "Delete event from current order";
            this.buttonDeleteFromOrder.UseVisualStyleBackColor = true;
            this.buttonDeleteFromOrder.Click += new System.EventHandler(this.buttonDeleteFromOrder_Click);
            // 
            // CurrentOrder
            // 
            this.CurrentOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurrentOrder.FormattingEnabled = true;
            this.CurrentOrder.ItemHeight = 22;
            this.CurrentOrder.Location = new System.Drawing.Point(12, 128);
            this.CurrentOrder.Name = "CurrentOrder";
            this.CurrentOrder.ScrollAlwaysVisible = true;
            this.CurrentOrder.Size = new System.Drawing.Size(337, 92);
            this.CurrentOrder.TabIndex = 5;
            // 
            // OrderCost
            // 
            this.OrderCost.Location = new System.Drawing.Point(13, 249);
            this.OrderCost.Name = "OrderCost";
            this.OrderCost.ReadOnly = true;
            this.OrderCost.Size = new System.Drawing.Size(336, 22);
            this.OrderCost.TabIndex = 6;
            // 
            // CompleteOrder
            // 
            this.CompleteOrder.Location = new System.Drawing.Point(370, 313);
            this.CompleteOrder.Name = "CompleteOrder";
            this.CompleteOrder.Size = new System.Drawing.Size(99, 75);
            this.CompleteOrder.TabIndex = 8;
            this.CompleteOrder.Text = "Complete Order";
            this.CompleteOrder.UseVisualStyleBackColor = true;
            this.CompleteOrder.Click += new System.EventHandler(this.CompleteOrder_Click);
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CompleteOrder);
            this.Controls.Add(this.OrderCost);
            this.Controls.Add(this.CurrentOrder);
            this.Controls.Add(this.buttonDeleteFromOrder);
            this.Controls.Add(this.EventList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAddToOrder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Order";
            this.Text = "Order";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddToOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox EventList;
        private System.Windows.Forms.Button buttonDeleteFromOrder;
        private System.Windows.Forms.ListBox CurrentOrder;
        private System.Windows.Forms.TextBox OrderCost;
        private System.Windows.Forms.Button CompleteOrder;
    }
}