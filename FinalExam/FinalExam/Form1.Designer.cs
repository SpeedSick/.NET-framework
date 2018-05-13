namespace FinalExam
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.eventButton = new System.Windows.Forms.Button();
            this.orderButton = new System.Windows.Forms.Button();
            this.reportButton = new System.Windows.Forms.Button();
            this.content = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.Controls.Add(this.reportButton);
            this.panel1.Controls.Add(this.orderButton);
            this.panel1.Controls.Add(this.eventButton);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1289, 159);
            this.panel1.TabIndex = 0;
            // 
            // eventButton
            // 
            this.eventButton.Image = ((System.Drawing.Image)(resources.GetObject("eventButton.Image")));
            this.eventButton.Location = new System.Drawing.Point(36, 28);
            this.eventButton.Name = "eventButton";
            this.eventButton.Size = new System.Drawing.Size(104, 91);
            this.eventButton.TabIndex = 0;
            this.eventButton.UseVisualStyleBackColor = true;
            this.eventButton.Click += new System.EventHandler(this.eventButton_Click);
            // 
            // orderButton
            // 
            this.orderButton.Image = ((System.Drawing.Image)(resources.GetObject("orderButton.Image")));
            this.orderButton.Location = new System.Drawing.Point(575, 28);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(104, 91);
            this.orderButton.TabIndex = 1;
            this.orderButton.UseVisualStyleBackColor = true;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // reportButton
            // 
            this.reportButton.Image = ((System.Drawing.Image)(resources.GetObject("reportButton.Image")));
            this.reportButton.Location = new System.Drawing.Point(1104, 28);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(104, 91);
            this.reportButton.TabIndex = 2;
            this.reportButton.UseVisualStyleBackColor = true;
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
            // 
            // content
            // 
            this.content.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.content.Location = new System.Drawing.Point(0, 165);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(1289, 585);
            this.content.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 748);
            this.Controls.Add(this.content);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button reportButton;
        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.Button eventButton;
        private System.Windows.Forms.Panel content;
    }
}

