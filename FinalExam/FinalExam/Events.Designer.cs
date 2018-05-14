namespace FinalExam
{
    partial class Events
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
            this.eventCity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.eventCost = new System.Windows.Forms.TextBox();
            this.eventDate = new System.Windows.Forms.DateTimePicker();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.eventCostHelp = new System.Windows.Forms.TextBox();
            this.dateEventHelp = new System.Windows.Forms.TextBox();
            this.AddEventButton = new System.Windows.Forms.Button();
            this.DeleteEventButton = new System.Windows.Forms.Button();
            this.eventList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // eventCity
            // 
            this.eventCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eventCity.Location = new System.Drawing.Point(12, 102);
            this.eventCity.Name = "eventCity";
            this.eventCity.Size = new System.Drawing.Size(217, 28);
            this.eventCity.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(371, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Events";
            // 
            // eventCost
            // 
            this.eventCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eventCost.Location = new System.Drawing.Point(262, 102);
            this.eventCost.Name = "eventCost";
            this.eventCost.Size = new System.Drawing.Size(209, 28);
            this.eventCost.TabIndex = 3;
            // 
            // eventDate
            // 
            this.eventDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eventDate.Location = new System.Drawing.Point(501, 102);
            this.eventDate.Name = "eventDate";
            this.eventDate.Size = new System.Drawing.Size(200, 28);
            this.eventDate.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(12, 58);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(217, 28);
            this.textBox3.TabIndex = 5;
            this.textBox3.Text = "City of Event";
            // 
            // eventCostHelp
            // 
            this.eventCostHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eventCostHelp.Location = new System.Drawing.Point(262, 58);
            this.eventCostHelp.Name = "eventCostHelp";
            this.eventCostHelp.ReadOnly = true;
            this.eventCostHelp.Size = new System.Drawing.Size(209, 28);
            this.eventCostHelp.TabIndex = 7;
            this.eventCostHelp.Text = "Cost of Event";
            // 
            // dateEventHelp
            // 
            this.dateEventHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateEventHelp.Location = new System.Drawing.Point(501, 58);
            this.dateEventHelp.Name = "dateEventHelp";
            this.dateEventHelp.ReadOnly = true;
            this.dateEventHelp.Size = new System.Drawing.Size(200, 28);
            this.dateEventHelp.TabIndex = 8;
            this.dateEventHelp.Text = "Date of Event";
            // 
            // AddEventButton
            // 
            this.AddEventButton.Location = new System.Drawing.Point(719, 58);
            this.AddEventButton.Name = "AddEventButton";
            this.AddEventButton.Size = new System.Drawing.Size(69, 72);
            this.AddEventButton.TabIndex = 9;
            this.AddEventButton.Text = "Add Event";
            this.AddEventButton.UseVisualStyleBackColor = true;
            this.AddEventButton.Click += new System.EventHandler(this.AddEventButton_Click);
            // 
            // DeleteEventButton
            // 
            this.DeleteEventButton.Location = new System.Drawing.Point(719, 237);
            this.DeleteEventButton.Name = "DeleteEventButton";
            this.DeleteEventButton.Size = new System.Drawing.Size(69, 97);
            this.DeleteEventButton.TabIndex = 11;
            this.DeleteEventButton.Text = "Delete Event";
            this.DeleteEventButton.UseVisualStyleBackColor = true;
            this.DeleteEventButton.Click += new System.EventHandler(this.DeleteEventButton_Click);
            // 
            // eventList
            // 
            this.eventList.FormattingEnabled = true;
            this.eventList.ItemHeight = 16;
            this.eventList.Location = new System.Drawing.Point(13, 237);
            this.eventList.Name = "eventList";
            this.eventList.Size = new System.Drawing.Size(688, 100);
            this.eventList.TabIndex = 12;
            // 
            // Events
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.eventList);
            this.Controls.Add(this.DeleteEventButton);
            this.Controls.Add(this.AddEventButton);
            this.Controls.Add(this.dateEventHelp);
            this.Controls.Add(this.eventCostHelp);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.eventDate);
            this.Controls.Add(this.eventCost);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.eventCity);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Events";
            this.Text = "Events";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox eventCity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox eventCost;
        private System.Windows.Forms.DateTimePicker eventDate;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox eventCostHelp;
        private System.Windows.Forms.TextBox dateEventHelp;
        private System.Windows.Forms.Button AddEventButton;
        private System.Windows.Forms.Button DeleteEventButton;
        private System.Windows.Forms.ListBox eventList;
    }
}