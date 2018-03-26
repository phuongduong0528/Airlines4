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

namespace Airlines.FormApplication
{
    public partial class Summary : Form
    {
        public Summary()
        {
            InitializeComponent();
        }

        private async void Summary_Load(object sender, EventArgs e)
        {
            List<SurveyResult> list = new List<SurveyResult>();
            SurveyResult survey = await Program.Instance.SurveyResultController.AllResult();
            list.Add(survey);
            allresultDgv.DataSource = list;
            allresultDgv.Columns[0].Visible = false;
            label2.Text = $"Sample size: {survey.All}";
        }

        private void allresultDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Detail_Result form = new Detail_Result();
            form.Show();
        }
    }
}
