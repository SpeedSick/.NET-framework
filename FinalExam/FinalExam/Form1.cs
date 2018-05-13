using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FinalExam {
    public partial class Form1 : Form {
        private Events events { get; set; }
        private Order orders { get; set; }
        private Report reports { get; set; }

        

        public Form1() {
            InitializeComponent();
            DataContainer.allEvents = DataContainer.loadEvents();
            DataContainer.allOrders = DataContainer.loadOrders();
        }

        private void eventButton_Click(object sender, EventArgs e) {
            events.TopLevel = false;
            content.Controls.Clear();
            content.Controls.Add(events);
            events.Show();
        }

        private void orderButton_Click(object sender, EventArgs e) {
            orders.TopLevel = false;
            content.Controls.Clear();
            content.Controls.Add(orders);
            orders.Show();
        }

        private void reportButton_Click(object sender, EventArgs e) {
            reports.TopLevel = false;
            content.Controls.Clear();
            content.Controls.Add(reports);
            reports.Show();
        }
    }
}
