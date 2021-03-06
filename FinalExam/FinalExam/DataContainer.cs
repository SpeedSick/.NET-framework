﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace FinalExam {
    public static class DataContainer {
        public static int eventId = 0;
        public static int orderId = 0;
        public static List<CEvent> allEvents { get; set; } = new List<CEvent>();
        public static List<COrder> allOrders { get; set; } = new List<COrder>();
        

        public static List<CEvent> loadEvents() {
            List<CEvent> newEvents = new List<CEvent>();
            using (StreamReader re = new StreamReader("Events.txt")) {
                String s;
                while ((s = re.ReadLine()) != null) {
                    CEvent cur = new CEvent(s);
                    eventId = Math.Max(eventId, cur.getId());
                    newEvents.Add(cur);
                }
            }
            return newEvents;

        }
        public static List<COrder> loadOrders() {
            List<COrder> newOrders = new List<COrder>();
            using (StreamReader re = new StreamReader("Orders.txt")) {
                String s;
                while ((s = re.ReadLine()) != null) {
                    COrder cur = new COrder(s);
                    orderId = Math.Max(orderId, cur.getId());
                    newOrders.Add(cur);
                }
            }
            return newOrders;
        }

        public static void updateEvents(CEvent e, int type = 0) {
            
            if (type == 0)
                allEvents.Add(e);
            else {
                CEvent toRemove = e;
                foreach(CEvent x in allEvents) {
                    if (x.ToString().Equals(e.ToString()))
                        toRemove = x;
                }
                allEvents.Remove(toRemove);
            }
            using (StreamWriter wr = new StreamWriter("Events.txt")) {
                foreach (CEvent x in allEvents) {
                    wr.WriteLine(x.ToString());
                }
            }
        }
        public static void updateOrders(COrder e, int type = 0) {
            if (type == 0)
                allOrders.Add(e);
            else {
                allOrders.Remove(e);
            }
            using (StreamWriter wr = new StreamWriter("Orders.txt")) {
                foreach (COrder x in allOrders) {
                    wr.WriteLine(x.ToString());
                }
            }
        }
    }
}
