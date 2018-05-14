using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalExam
{
    public partial class Events : Form
    {
        public Events()
        {
            InitializeComponent();

            foreach (CEvent x in DataContainer.allEvents)
                eventList.Items.Add(x.ToString());
        }

        public bool isNumber(string s) {
            for (int i = 0; i < s.Length; ++i)
                if (s[i] < '0' || s[i] > '9') return false;
            return true;
        }

        private void AddEventButton_Click(object sender, EventArgs e) {
            String city = eventCity.Text.ToString().ToLower();
            if(!isNumber(eventCost.Text.ToString())) {
                MessageBox.Show("cost should be non-negative number and less than 1000000000");
                return;
            }
            int cost = int.Parse(eventCost.Text.ToString());
            int month = eventDate.Value.Month;
            int day = eventDate.Value.Day;
            int year = eventDate.Value.Year;
            int id = ++DataContainer.eventId;
            CEvent cur = new CEvent(id, city, year, month, day, cost);
            DataContainer.updateEvents(cur);
            eventList.Items.Add(cur.ToString());
        }

        private void DeleteEventButton_Click(object sender, EventArgs e) {
            if(eventList.SelectedItems.Count > 0) {
                for(int i = 0; i < eventList.SelectedItems.Count; ++i) {
                    String cur = eventList.SelectedItems[i].ToString();
                    foreach (COrder x in DataContainer.allOrders) {
                        if(x.getEvents().Contains(new CEvent(cur))) {
                            MessageBox.Show("this event is already ordered");
                            return;
                        }
                    }
                }
                for(int i = 0; i < eventList.SelectedItems.Count; ++i) {
                    String cur = eventList.SelectedItems[i].ToString();
                    DataContainer.updateEvents(new CEvent(cur), 1);
                    eventList.Items.Remove(eventList.SelectedItems[i]);
                }
            } else {
                MessageBox.Show("no event is selected");
            }
        }
    }
}
