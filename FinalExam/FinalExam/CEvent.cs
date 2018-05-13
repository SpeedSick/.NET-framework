using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam {
    public class CEvent {
        private int id { get; set; }
        private String city { get; set; }
        private int month { get; set; }
        private int day { get; set; }
        private int year { get; set; }
        private int cost { get; set; }

        public int getId() { return this.id; }
        public String getCity() { return this.city; }
        public int getMonth() { return this.month; }
        public int getDay() { return this.day; }
        public int getYear() { return this.year; }
        public int getCost() { return this.cost; }

        public void setId(int _id) { this.id = _id; }
        public void setCity(String _city) { this.city = _city; }
        public void setMonth(int _month) { this.month = _month; }
        public void setDay(int _day) { this.day = _day; }
        public void setYear(int _year) { this.year = _year; }
        public void setCost(int _cost) { this.cost = _cost; }
        
        public CEvent() { }
        public CEvent(int _id, String _city, int _year, int _month, int _day, int _cost) {
            this.id = _id;
            this.month = _month;
            this.day = _day;
            this.city = _city;
            this.year = _year;
            this.cost = _cost;
        }

        public bool Equals(CEvent e) {
            return id == e.id;
        }
        public CEvent(String s) {
            String[] tmp = s.Split(';');
            id = int.Parse(tmp[0]);
            city = tmp[2];
            cost = int.Parse(tmp[3]);
            tmp = tmp[1].Split('.');
            year = int.Parse(tmp[0]);
            month = int.Parse(tmp[1]);
            day = int.Parse(tmp[2]);
        }

        public override string ToString() {
            return this.id + ";" +
                this.year + "." + this.month + "." + this.day + ";" + 
                this.city + ";" + 
                this.cost;
        }
    }
}
