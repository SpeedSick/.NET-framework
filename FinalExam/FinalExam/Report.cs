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
    public partial class Report : Form {
        public Report() {
            InitializeComponent();
        }

        private void getReportButton_Click(object sender, EventArgs e) {
            DataGridViewColumn c1 = new DataGridViewColumn();
            DataGridViewColumn c2 = new DataGridViewColumn();
            DataGridViewColumn c3 = new DataGridViewColumn();
            c1.Width = c2.Width = c3.Width = 100;
            c1.CellTemplate = new DataGridViewTextBoxCell();
            c2.CellTemplate = new DataGridViewTextBoxCell();
            c3.CellTemplate = new DataGridViewTextBoxCell();
            c1.HeaderText = "City";
            c2.HeaderText = "Total Cost";
            c3.HeaderText = "Percentage";
            reportView.Columns.Add(c1);
            reportView.Columns.Add(c2);
            reportView.Columns.Add(c3);
            int ly = dateFrom.Value.Year;
            int lm = dateFrom.Value.Month; ;
            int ld = dateFrom.Value.Day; ;
            int ry = dateTo.Value.Year;
            int rm = dateTo.Value.Month; ;
            int rd = dateTo.Value.Day;
            Dictionary<String, int> MAP = new Dictionary<string, int>();
            int all = 0;
            foreach(COrder x in DataContainer.allOrders) {
                MessageBox.Show(x.ToString());
                foreach(CEvent y in x.getEvents()) {
                    if(y.getYear() > ly || y.getYear() == ly && (y.getMonth() > lm || y.getMonth() == lm && (y.getDay() >= ld)))
                        if(y.getYear() < ry || y.getYear() == ry && (y.getMonth() < rm || y.getMonth() == rm && y.getDay() <= rd)) {
                            if(!MAP.ContainsKey(y.getCity())) {
                                MAP.Add(y.getCity(), 0);
                            }
                            MAP[y.getCity()] += y.getCost();
                            all += y.getCost();
                        }
                }
            }
            foreach(KeyValuePair<String, int> x in MAP) {
                double v = x.Value / (all + 0.0);
                reportView.Rows.Add(x.Key.ToString(), x.Value.ToString(), v.ToString());
            }

        }
    }
}
