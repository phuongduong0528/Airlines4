using Airlines.Services.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Airlines.FormApplication
{
    public partial class Detail_Result : Form
    {

        List<List<SurveyResult>> list;

        public Detail_Result()
        {
            InitializeComponent();
            list = new List<List<SurveyResult>>();
        }

        public void LoadData(Chart chart,List<SurveyResult> l)
        {
            Series series;
            double total = 0;
            double percent_total = 0;
            double percent_item;

            chart.Series.Clear();
            foreach(SurveyResult sr in l)
            {
                total += (double)sr.All;
            }
            for (int i = 6; i >= 0; i--)
            {
                if (i == 0)
                    percent_item = 100 - percent_total;
                else
                {
                    percent_item = (l[i].All / total) * 100;
                }
                percent_total += percent_item;
                series = chart.Series.Add($"Mark {i + 1}");
                series.ChartType = SeriesChartType.StackedBar100;
                series.Points.Add(new DataPoint()
                {
                    YValues = new[] {percent_item},
                    ToolTip = $"{l[i].All} - {percent_item:F1}%"
                });
            }
        }

        public async Task Loadgridview_and_chart()
        {
            list = await Program.Instance.SurveyResultController.SurveyResultFilter(7, 2017, genderCbx.SelectedIndex, ageCbx.SelectedIndex);
            q1Dgv.DataSource = list[0];
            q2Dgv.DataSource = list[1];
            q3Dgv.DataSource = list[2];
            q4Dgv.DataSource = list[3];
            LoadData(q1chart, list[0]);
            LoadData(q2chart, list[1]);
            LoadData(q3chart, list[2]);
            LoadData(q4chart, list[3]);
        }

        private async void Detail_Result_Load(object sender, EventArgs e)
        {
            genderCbx.SelectedIndex = 2;
            ageCbx.SelectedIndex = 4;
            dateCbx.SelectedIndex = 0;
            await Loadgridview_and_chart();
        }

        private async void genderCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            await Loadgridview_and_chart();
        }

        private async void ageCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            await Loadgridview_and_chart();
        }
    }
}
