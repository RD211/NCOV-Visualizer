using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using QuickType;

namespace VIZ_NCOV
{
    #region Dashboard Class
    public partial class Dashboard : Form
    {
        #region Variables
        Bitmap bmp = new Bitmap(2000, 2000);
        readonly List<DateTime> dates = new List<DateTime>();
        readonly Dictionary<string, Country> countries = new Dictionary<string, Country>();
        Color mainColor = Color.Blue;
        bool showDead = true, showInfected = true, showRecovered = true, showActive = true;
        #endregion

        #region Constructor
        public Dashboard()
        {
            InitializeComponent();
        }
        #endregion

        #region Get Border data
        void UpdateBorders()
        {
            string textJson = "";
            string resource_data = Properties.Resources.Countries;
            textJson= resource_data;
            bmp = new Bitmap(this.pbox_map.Width, this.pbox_map.Height);
            var welcome = WelcomeContinent.FromJson(textJson);

            welcome.Features.ForEach((feature) => {
                Country country = new Country(feature.Properties.Name, feature.Id);
                feature.Geometry.Coordinates.ForEach((polygon) =>
                {
                    Polygon poly = new Polygon();
                    polygon.ForEach((line) =>
                    {
                        if (feature.Geometry.Type == GeometryType.Polygon)
                        {
                            double lng = (double)line[0].Double;
                            double lat = (double)line[1].Double;
                            PointD point = new PointD(lat, lng);
                            poly.AddPoint(point);
                        }
                        else
                        {
                            Polygon poly2 = new Polygon();
                            line.ForEach((coord) =>
                            {
                                double lng = (double)coord.DoubleArray[0];
                                double lat = (double)coord.DoubleArray[1];
                                PointD point = new PointD(lat, lng);
                                poly2.AddPoint(point);
                            });
                            poly2.AddPoint(poly2.polygonPoints[0]);
                            country.AddPoly(poly2);
                        }

                    });
                    if (feature.Geometry.Type == GeometryType.Polygon)
                    {
                        poly.AddPoint(poly.polygonPoints[0]);
                        country.AddPoly(poly);
                    }
                });
                try
                {
                    countries.Add(country.iso, country);
                }
                catch { }
            });

        }
        #endregion

        #region Draw map
        void DrawMap()
        {
            if (pbox_map.Width == 0) return;
            var saved = new Dictionary<string, Country>();
            int maximInfected = 0;
            foreach (var country in countries.Values)
            {
                if(country.infected.Count>1)
                    maximInfected = Math.Max(maximInfected, country.infected.Last());
            }
            bmp = new Bitmap(this.pbox_map.Width*2, this.pbox_map.Height*2);
            Graphics g = Graphics.FromImage(bmp);
            countries.Values.ToList().ForEach((country) => {
                country.polygons.ForEach((poly) => {
                    Brush brsh;
                    var imagePoly = HelperFunctions.PolygonToImagePoly(poly, bmp.Size).ToArray();
                    brsh = new SolidBrush(Color.FromArgb(255, 255, 255));
                    try
                    {
                        g.FillPolygon(brsh, imagePoly);
                    }
                    catch { }
                    if (country.infected.Count>0 && country.infected[slider_timeline.Value]>0)
                    {
                        
                    var clr = Color.FromArgb(Math.Max(20, Math.Min(255, (int)(255 * (((double)country.infected[slider_timeline.Value] * 5) / ((double)maximInfected))))), mainColor);
                        if(mainColor==Color.Transparent)
                        {
                            clr = Color.FromArgb(Math.Max(20, Math.Min(255, (int)(255 * (((double)country.infected[slider_timeline.Value] * 5) / ((double)maximInfected))))), HelperFunctions.GetRandomColor());
                        }
                        brsh = new SolidBrush(clr);
                        try
                        {
                            g.FillPolygon(brsh, imagePoly);
                        }
                        catch { }

                    }

                });
            });
            countries.Values.ToList().ForEach((country) => {
                country.polygons.ForEach((poly) => {

                    Pen pn = new Pen(mainColor, 3);
                    if (mainColor == Color.Transparent)
                        pn.Color = HelperFunctions.GetRandomColor();
                    try
                    {
                        g.DrawPolygon(pn, HelperFunctions.PolygonToImagePoly(poly, bmp.Size).ToArray());
                    }
                    catch { }
                });
            });
            this.pbox_map.Image = bmp;
        }
        #endregion

        #region Process Data
        void ProcessData()
        {
            Dictionary<string, string> savedLocations = new Dictionary<string, string>();
            StreamReader reader = new StreamReader("infected.csv");
            var dates = HelperFunctions.SplitCsv(reader.ReadLine());
            dates.Skip(4).ToList().ForEach((date) => this.dates.Add(DateTime.Parse(date)));
            while(!reader.EndOfStream)
            {
                var entry = HelperFunctions.SplitCsv(reader.ReadLine());
                PointD coords = new PointD(double.Parse(entry[2]), double.Parse(entry[3]));
               
                List<int> infected = new List<int>();
                entry.Skip(4).ToList().ForEach((infection) =>

                {
                    try { infected.Add(int.Parse(infection)); }
                    catch { try { infected.Add(infected.Last()); } catch { infected.Add(0); } }
                    
                    });
                if (savedLocations.ContainsKey(entry[1]))
                {
                    if (countries[savedLocations[entry[1]]].infected.Count == 0)
                    {
                        countries[savedLocations[entry[1]]].infected = infected;
                    }
                    else
                    {
                        for (int i = 0; i < countries[savedLocations[entry[1]]].infected.Count; i++)
                        {
                            countries[savedLocations[entry[1]]].infected[i] += infected[i];
                        }
                    }
                    continue;
                }
                foreach (var country in countries.Values)
                {
                    bool inside = false;
                    foreach(var poly in country.polygons)
                    {
                        if (HelperFunctions.IsPointInPolygon(poly, HelperFunctions.CoordinateToPoint(coords,bmp.Size), bmp.Size))
                        {
                            inside = true;
                        }
                    }
                    if(inside)
                    {
                        savedLocations.Add(entry[1], country.iso);
                        if(country.infected.Count==0)
                            country.infected = infected;
                        else
                        {
                            for (int i = 0; i < country.infected.Count; i++)
                                country.infected[i] += infected[i];
                            this.slider_timeline.Maximum = country.infected.Count-1;
                        }
                        break;
                    }
                }
            }
            reader = new StreamReader("dead.csv");
            reader.ReadLine();
            while (!reader.EndOfStream)
            {
                var entry = HelperFunctions.SplitCsv(reader.ReadLine());
                PointD coords = new PointD(double.Parse(entry[2]), double.Parse(entry[3]));
                List<int> dead = new List<int>();
                entry.Skip(4).ToList().ForEach((death) =>

                {
                    try { dead.Add(int.Parse(death)); }
                    catch { try { dead.Add(dead.Last()); } catch { dead.Add(0); } }

                });
                if (savedLocations.ContainsKey(entry[1]))
                {
                    if (countries[savedLocations[entry[1]]].dead.Count == 0)
                    {
                        countries[savedLocations[entry[1]]].dead = dead;
                    }
                    else
                    {
                        for (int i = 0; i < countries[savedLocations[entry[1]]].dead.Count; i++)
                        {
                            countries[savedLocations[entry[1]]].dead[i] += dead[i];
                        }
                    }
                    continue;
                }
                foreach (var country in countries.Values)
                {
                    bool inside = false;
                    foreach (var poly in country.polygons)
                    {
                        if (HelperFunctions.IsPointInPolygon(poly, HelperFunctions.CoordinateToPoint(coords, bmp.Size), bmp.Size))
                        {
                            inside = true;
                        }
                    }

                    if (inside)
                    {
                        if (country.dead.Count == 0)
                            country.dead = dead;
                        else
                        {
                            for (int i = 0; i < country.dead.Count; i++)
                                country.dead[i] += dead[i];
                        }
                        break;
                    }
                }
            }
            reader = new StreamReader("recovered.csv");
            reader.ReadLine();
            while (!reader.EndOfStream)
            {
                var entry = HelperFunctions.SplitCsv(reader.ReadLine());
                PointD coords = new PointD(double.Parse(entry[2]), double.Parse(entry[3]));
                List<int> recovered = new List<int>();
                entry.Skip(4).ToList().ForEach((recover) =>

                {
                    try { recovered.Add(int.Parse(recover)); }
                    catch { try { recovered.Add(recovered.Last()); } catch { recovered.Add(0); } }

                }); if (savedLocations.ContainsKey(entry[1]))
                {
                    if (countries[savedLocations[entry[1]]].recovered.Count == 0)
                    {
                        countries[savedLocations[entry[1]]].recovered = recovered;
                    }
                    else
                    {
                        for (int i = 0; i < countries[savedLocations[entry[1]]].recovered.Count; i++)
                        {
                            countries[savedLocations[entry[1]]].recovered[i] += recovered[i];
                        }
                    }
                    continue;
                }
                foreach (var country in countries.Values)
                {
                    bool inside = false;
                    foreach (var poly in country.polygons)
                    {
                        if (HelperFunctions.IsPointInPolygon(poly, HelperFunctions.CoordinateToPoint(coords, bmp.Size), bmp.Size))
                        {
                            inside = true;
                        }
                    }
                    if (inside)
                    {
                        if (country.recovered.Count == 0)
                            country.recovered = recovered;
                        else
                        {
                            for (int i = 0; i < country.recovered.Count; i++)
                                country.recovered[i] += recovered[i];
                        }
                        break;
                    }
                }
            }

            reader.Close();
        }
        #endregion

        #region Update Grid and Map and other Info
        void UpdateInformation()
        {
            datagrid_infected.Rows.Clear();
            List<int> sumInfected = new List<int>(slider_timeline.Value),
                sumDead = new List<int>(slider_timeline.Value),
                sumRecovered = new List<int>(slider_timeline.Value);
            for (int i = 0; i <= slider_timeline.Value; i++)
            {
                sumInfected.Add(0);
                sumDead.Add(0);
                sumRecovered.Add(0);
            }
            this.countries.Values.ToList().ForEach((country) => {
                int infect = 0;
                int dead = 0;
                int recovered = 0;
                if (country.infected.Count != 0)
                {
                    infect = country.infected[slider_timeline.Value];
                    for (int i = 0; i <= slider_timeline.Value; i++)
                    {
                        sumInfected[i] += country.infected[i];
                    }

                }
                if (country.dead.Count != 0)
                {
                    dead = country.dead[slider_timeline.Value];
                    for (int i = 0; i <= slider_timeline.Value; i++)
                    {
                        sumDead[i] += country.dead[i];
                    }
                }
                if (country.recovered.Count != 0)
                {
                    recovered = country.recovered[slider_timeline.Value];
                    for (int i = 0; i <= slider_timeline.Value; i++)
                    {
                        sumRecovered[i] += country.recovered[i];
                    }
                }
                datagrid_infected.Rows.Add(country.name,infect-dead-recovered, infect, dead,
               recovered, ((double)dead / (double)Math.Max(1, infect) * 100).ToString("F2")+"%");
            });
            this.lbl_deadCounter.Text = sumDead.Last().ToString("#,##0");
            this.lbl_infectedCounter.Text = sumInfected.Last().ToString("#,##0");
            this.lbl_recoveredCounter.Text = sumRecovered.Last().ToString("#,##0");
            this.lbl_deathRateCounter.Text = (((double)sumDead.Last() / (double)sumInfected.Last()) * 100).ToString("F2") + "%";
            this.lbl_activeCounter.Text = (sumInfected.Last() - sumDead.Last() - sumRecovered.Last()).ToString("#,##0");

            this.chart_global.Series.Clear();
            this.chart_global.Series.Add("Infected");
            this.chart_global.Series.Add("Dead");
            this.chart_global.Series.Add("Recovered");
            this.chart_global.Series.Add("Active");

            for (int i = 0;i<=slider_timeline.Value;i++)
            {
                if(showInfected)
                this.chart_global.Series[0].Points.AddXY(dates[i], sumInfected[i]);
                if(showDead)
                this.chart_global.Series[1].Points.AddXY(dates[i], sumDead[i]);
                if(showRecovered)
                this.chart_global.Series[2].Points.AddXY(dates[i], sumRecovered[i]);
                if(showActive)
                this.chart_global.Series[3].Points.AddXY(dates[i], sumInfected[i] - sumDead[i] - sumRecovered[i]);
            }

            this.chart_global.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            this.chart_global.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            this.chart_global.Series[2].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            this.chart_global.Series[3].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            this.chart_global.Series[0].Color = Color.Red;
            this.chart_global.Series[1].Color = Color.Black;
            this.chart_global.Series[2].Color = Color.Blue;
            this.chart_global.Series[3].Color = Color.IndianRed;

            this.chart_global.Legends[0].Font = new Font("NeoSans",20,FontStyle.Bold);
            this.chart_global.Series[0].BorderWidth = 5;
            this.chart_global.Series[1].BorderWidth = 5;
            this.chart_global.Series[2].BorderWidth = 5;
            this.chart_global.Series[3].BorderWidth = 5;


            DrawMap();
        }
        #endregion

        #region Form Load
        private void Form1_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;
            foreach(var control in this.Controls.OfType<BunifuTileButton>())
            {
                control.colorActive = Color.FromArgb(100,control.BackColor);

            }
            using (var client = new WebClient())
            {
                try
                {
                    client.DownloadFile("https://raw.githubusercontent.com/CSSEGISandData/COVID-19/master/csse_covid_19_data/csse_covid_19_time_series/time_series_19-covid-Confirmed.csv", "test.csv");
                    client.DownloadFile("https://raw.githubusercontent.com/CSSEGISandData/COVID-19/master/csse_covid_19_data/csse_covid_19_time_series/time_series_19-covid-Confirmed.csv", "infected.csv");
                    client.DownloadFile("https://raw.githubusercontent.com/CSSEGISandData/COVID-19/master/csse_covid_19_data/csse_covid_19_time_series/time_series_19-covid-Deaths.csv", "dead.csv");
                    client.DownloadFile("https://raw.githubusercontent.com/CSSEGISandData/COVID-19/master/csse_covid_19_data/csse_covid_19_time_series/time_series_19-covid-Recovered.csv", "recovered.csv");
                }
                catch { MessageBox.Show("Failed to retrieve updated data\nLoading old data"); }
            }
            UpdateBorders();
            ChangeColor(Color.Black);
            ProcessData();
            this.card_grid.Hide();
            this.card_chart.Hide();
            this.slider_timeline.Value = this.slider_timeline.Maximum;
            this.datetime_timeline.MinDate = dates.First();

            this.datetime_timeline.MaxDate = dates.Last();
            this.datetime_timeline.Value = dates.Last();

            UpdateInformation();
        }
        #endregion

        #region Country Click
        CountryPopUp customCountryPopUp;
        private void CountryPopUpEvent(object sender, EventArgs e)
        {
            try
            {
                foreach (var country in countries.Values)
                {
                    bool here = false;
                    foreach (var poly in country.polygons)
                    {
                        if (HelperFunctions.IsPointInPolygon(poly, new PointF((pbox_map.PointToClient(MousePosition)).X * 2,
                            (pbox_map.PointToClient(MousePosition)).Y * 2),
                            bmp.Size))
                        {
                            here = true;
                        }
                    }
                    if (here)
                    {
                        customCountryPopUp = new CountryPopUp(country, this.slider_timeline.Value, dates, this)
                        {
                            Location = this.PointToClient(MousePosition)
                        };
                        this.Controls.Add(customCountryPopUp);
                        customCountryPopUp.BringToFront();
                        customCountryPopUp.BringToFront();
                        break;
                    }
                }
            }
            catch { }
        }
        #endregion

        #region Show map Button click
        private void Btn_map_Click(object sender, EventArgs e)
        {
            this.card_map.Show();
            this.card_grid.Hide();
            this.card_chart.Hide();
            this.card_map.BringToFront();
        }
        #endregion

        #region Show table Button click
        private void Btn_table_Click(object sender, EventArgs e)
        {
            this.card_grid.Show();
            this.card_map.Hide();
            this.card_chart.Hide();
            this.card_grid.BringToFront();
        }
        #endregion

        #region Show who page Button click
        private void Btn_who_Click(object sender, EventArgs e) => System.Diagnostics.Process.Start("https://www.who.int/emergencies/diseases/novel-coronavirus-2019");
        #endregion

        #region Show Chart Button click
        private void Btn_chart_Click(object sender, EventArgs e)
        {
            this.card_grid.Hide();
            this.card_map.Hide();
            this.card_chart.Show();
            this.card_chart.BringToFront();
        }
        #endregion

        #region Resize event
        private void Dashboard_SizeChanged(object sender, EventArgs e)
        {
            UpdateInformation();
        }
        #endregion

        #region Change Color Theme
        void ChangeColor(Color color)
        {
            this.mainColor = color;
            DrawMap();

            this.datagrid_infected.HeaderForeColor = mainColor;
            if (mainColor == Color.Transparent)
                this.datagrid_infected.HeaderForeColor = HelperFunctions.GetRandomColor();
            lbl_colorMap.ForeColor = mainColor;
            if (mainColor == Color.Transparent)
                lbl_colorMap.ForeColor = HelperFunctions.GetRandomColor();
        }
        #endregion

        #region Date timeline changed event
        private void Datetime_timeline_ValueChanged(object sender, EventArgs e)
        {
            this.slider_timeline.Value = (int)(this.datetime_timeline.Value - this.datetime_timeline.MinDate).TotalDays;
            UpdateInformation();
        }
        #endregion

        #region Color Button Click
        private void BunifuTileButton1_Click(object sender, EventArgs e)
        {
            var button = (BunifuTileButton)sender;
            if (button.BackColor == Color.Transparent)
                ChangeColor(Color.Empty);
            else
                ChangeColor(button.BackColor);
        }
        #endregion

        #region Rainbow Panel Click
        private void Panel_rainbow_Click(object sender, EventArgs e)
        {
            ChangeColor(Color.Transparent);
        }
        #endregion

        #region Timeline bar scroll event
        private void MetroTrackBar1_Scroll(object sender, ScrollEventArgs e)
        {
            this.datetime_timeline.Value = dates[slider_timeline.Value];
            UpdateInformation();
        }
        #endregion

        #region Text changed on textbox color changer
        private void Txt_colorChanger_TextChanged(object sender, EventArgs e)
        {
            if (txt_colorChanger.Text.Contains("#"))
            {
                try
                {
                    ChangeColor(System.Drawing.ColorTranslator.FromHtml(txt_colorChanger.Text));
                }
                catch { }
            }
            else
            {
                ChangeColor(Color.FromName(txt_colorChanger.Text));
            }
        }
        #endregion

        #region Global Chart checkbox change event
        private void UpdateCheckBoxStatus(object sender, EventArgs e)
        {
            showInfected = cbox_infected.Checked;
            showActive = cbox_active.Checked;
            showRecovered = cbox_recovered.Checked;
            showDead = cbox_dead.Checked;
            UpdateInformation();
        }
        #endregion
    }
    #endregion
}
