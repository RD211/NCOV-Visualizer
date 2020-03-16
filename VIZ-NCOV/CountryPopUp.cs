using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace VIZ_NCOV
{
    #region CountryPopUp Class
    public partial class CountryPopUp : UserControl
    {
        #region Variables
        private readonly Country country;
        private readonly int time;
        private readonly List<DateTime> dates;
        private readonly Form father;
        #endregion
        void DrawGraph()
        {
            this.chart_country.Series.Clear();
            this.chart_country.ForeColor = Color.White;

            this.chart_country.Series.Add("Infections");
            this.chart_country.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            this.chart_country.Series[0].Color = Color.Red;
            this.chart_country.Series[0].BorderWidth = 3;

            this.chart_country.Series.Add("Dead");
            this.chart_country.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            this.chart_country.Series[1].Color = Color.Black;
            this.chart_country.Series[1].BorderWidth = 3;


            this.chart_country.Series.Add("Recovered");
            this.chart_country.Series[2].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            this.chart_country.Series[2].Color = Color.Blue;
            this.chart_country.Series[2].BorderWidth = 3;

            this.chart_country.Series.Add("Active");
            this.chart_country.Series[3].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            this.chart_country.Series[3].Color = Color.IndianRed;
            this.chart_country.Series[3].BorderWidth = 3;

            for (int i = 0; i < time; i++)
            {
                if (cbox_infected.Checked)
                    this.chart_country.Series[0].Points.AddXY(dates[i], country.infected[i]);
                if (cbox_dead.Checked)
                    this.chart_country.Series[1].Points.AddXY(dates[i], country.dead[i]);
                if (cbox_recovered.Checked)
                    this.chart_country.Series[2].Points.AddXY(dates[i], country.recovered[i]);
                if (cbox_active.Checked)
                    this.chart_country.Series[3].Points.AddXY(dates[i], country.infected[i] - country.recovered[i] - country.dead[i]);
            }
            this.chart_country.Legends[0].Font = new Font("NeoSans", 12, FontStyle.Bold);
        }
        #region Constructor
        public CountryPopUp(Country country, int time, List<DateTime> dates, Form father)
        {
            this.country = country;
            this.time = time;
            this.dates = dates;
            this.father = father;
            InitializeComponent();
            this.lbl_country.Text = country.name;
            this.lbl_infectedCounter.Text = country.infected[time].ToString("#,##0");
            this.lbl_deadCounter.Text = country.dead[time].ToString("#,##0");
            this.lbl_recoveredCounter.Text = country.recovered[time].ToString("#,##0");
            this.lbl_activeCounter.Text = (country.infected[time] - country.recovered[time] - country.dead[time]).ToString("#,##0");
            DrawGraph();
            this.lbl_active.ForeColor = Color.IndianRed;
            this.lbl_activeCounter.ForeColor = Color.IndianRed;

            this.lbl_infected.ForeColor = Color.Red;
            this.lbl_infectedCounter.ForeColor = Color.Red;

            this.lbl_dead.ForeColor = Color.Black;
            this.lbl_deadCounter.ForeColor = Color.Black;

            this.lbl_recovered.ForeColor = Color.Blue;
            this.lbl_recoveredCounter.ForeColor = Color.Blue;

            this.lbl_country.ForeColor = Color.Black;
        }
        #endregion

        int xDiff = 0, yDiff = 0;
        bool moveNow = false;
        private void BunifuCards1_MouseDown(object sender, MouseEventArgs e)
        {
            xDiff = this.PointToClient(MousePosition).X;
            yDiff = this.PointToClient(MousePosition).Y;
            moveNow = true;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (moveNow)
            {
                try
                {
                    this.Location = new Point(father.PointToClient(MousePosition).X - xDiff, father.PointToClient(MousePosition).Y - yDiff);
                }
                catch { }
            }
            if (father.Controls.Count > 60)
                this.Btn_close_Click(null, null);
        }

        private void Btn_expand_Click(object sender, EventArgs e)
        {
            if (btn_expand.Tag.ToString() == "Expand")
            {
                this.Width = (int)(this.Width * 1.5);
                this.Height = (int)(this.Height * 1.5);
                btn_expand.Tag = "Contract";
            }
            else
            {
                this.Width = (int)(this.Width / 1.5);
                this.Height = (int)(this.Height / 1.5);
                btn_expand.Tag = "Expand";
            }
        }

        private void Btn_close_Click(object sender, EventArgs e)
        {
            this.father.Controls.Remove(this);
        }

        #region Global Chart checkbox change event
        private void UpdateCheckBoxStatus(object sender, EventArgs e)
        {
            DrawGraph();
        }
        #endregion

        private void BunifuCards1_MouseUp(object sender, MouseEventArgs e)
        {
            moveNow = false;
        }
    }
    #endregion
}
