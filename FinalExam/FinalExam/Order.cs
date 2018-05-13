using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalExam {
    public partial class Order : Form {
        private int currentCost { get; set; }

        public Order() {
            InitializeComponent();
            currentCost = 0;
            foreach (CEvent x in DataContainer.allEvents)
                EventList.Items.Add(x);
        }
        public int getCost(String s) {
            String[] tmp = s.Split(';');
            return int.Parse(tmp[1]);
        }
        public String getCity(String s) {
            String[] tmp = s.Split(';');
            return tmp[2];
        }

        private void buttonAddToOrder_Click(object sender, EventArgs e) {
            if(EventList.SelectedItems.Count > 0) {
                for (int i = 0; i < EventList.SelectedItems.Count; ++i) { 
                    if (CurrentOrder.Items.Contains(EventList.SelectedItems[i])) {
                        MessageBox.Show("one of the selected events is already on the current order");
                        return;
                    }
                    if(CurrentOrder.Items.Count > 0) {
                        String city = getCity(CurrentOrder.Items[0].ToString());
                        String currentCity = getCity(EventList.SelectedItems[i].ToString());
                        if (city.Equals(currentCity) == false) {
                            MessageBox.Show("events in the order should be from the same city!");
                            return;
                        }
                    }
                    {
                        String city = getCity(EventList.SelectedItems[0].ToString());
                        String currentCity = getCity(EventList.SelectedItems[i].ToString());
                        if(city.Equals(currentCity) == false) {
                            MessageBox.Show("events in the order should be from the same city!");
                            return;
                        }
                    }
                }
                for (int i = 0; i < EventList.SelectedItems.Count; ++i) {
                    CurrentOrder.Items.Add(EventList.SelectedItems[i]);
                    int eventCost = getCost(EventList.SelectedItems[i].ToString());
                    currentCost += eventCost;
                }

                OrderCost.Text = currentCost.ToString();
                MessageBox.Show("Done");
            } else {
                MessageBox.Show("no event is selected");
            }
        }

        private void buttonDeleteFromOrder_Click(object sender, EventArgs e) {
            if(CurrentOrder.SelectedItems.Count > 0) {
                for(int i = 0; i < CurrentOrder.SelectedItems.Count; ++i) {
                    int eventCost = getCost(CurrentOrder.SelectedItems[i].ToString());
                    currentCost -= currentCost;
                }
                CurrentOrder.Items.Remove(CurrentOrder.SelectedItems);
                MessageBox.Show("Done");
            } else {
                MessageBox.Show("no event is selected");
            }
        }

        private void CompleteOrder_Click(object sender, EventArgs e) {
            if(CurrentOrder.Items.Count > 0) {
                COrder tmp = new COrder();
                tmp.setId(++DataContainer.orderId);
                tmp.setCost(0);
                List<CEvent> cur = new List<CEvent>();
                for (int i = 0; i < CurrentOrder.Items.Count; ++i) {
                    CEvent toAdd = new CEvent(CurrentOrder.Items[i].ToString());
                    cur.Add(toAdd);
                    tmp.setCost(tmp.getCost() + toAdd.getCost());
                    tmp.setCity(toAdd.getCity());
                }
                tmp.setEvents(cur);
                DataContainer.updateOrders(tmp);
            } else {
                MessageBox.Show("empty order");
            }
        }
    }
}
