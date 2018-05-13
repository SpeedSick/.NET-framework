using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam {
    public class COrder {
        private int id {
            get;
            set;
        }
        private int cost { get; set; }
        private List<CEvent> events { get; set; }
        private String city { get; set; }

        public int getId() { return this.id; }
        public int getCost() { return this.cost; }
        public List<CEvent> getEvents() { return this.events; }
        public String getCity() { return this.city; }

        public void setId(int _id) { this.id = _id; }
        public void setCost(int _cost) { this.cost = _cost; }
        public void setEvents(List<CEvent> _events) { this.events = _events; }
        public void setCity(String _city) { this.city = _city; }

        public COrder() { }
        
        public bool Equals(COrder e) {
            return id == e.id;
        }

        public COrder(String s) {
            String[] tmp = s.Split('#');
            for (int i = 1; i < tmp.Length; ++i)
                events.Add(new CEvent(tmp[i]));
            tmp = tmp[0].Split(';');
            id = int.Parse(tmp[0]);
            cost = int.Parse(tmp[1]);
            city = tmp[2];
        }
        public override String ToString() {
            String res = "";
            res = res + id.ToString();
            res = res + ";";
            res = res + cost.ToString();
            res = res + ";";
            res = res + city;

            foreach(CEvent x in events) {
                res = res + x;
                if (x != events.Last())
                    res = res + "#";
            }
            return res;
        }
    }
}
