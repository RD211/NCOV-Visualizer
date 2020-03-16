namespace VIZ_NCOV
{
    partial class CountryPopUp
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.card_country = new Bunifu.Framework.UI.BunifuCards();
            this.lbl_activeChart = new System.Windows.Forms.Label();
            this.cbox_active = new Bunifu.Framework.UI.BunifuCheckbox();
            this.lbl_recoveredChart = new System.Windows.Forms.Label();
            this.cbox_recovered = new Bunifu.Framework.UI.BunifuCheckbox();
            this.lbl_deadChart = new System.Windows.Forms.Label();
            this.cbox_dead = new Bunifu.Framework.UI.BunifuCheckbox();
            this.lbl_infectedChart = new System.Windows.Forms.Label();
            this.cbox_infected = new Bunifu.Framework.UI.BunifuCheckbox();
            this.btn_expand = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_close = new Bunifu.Framework.UI.BunifuImageButton();
            this.lbl_recoveredCounter = new System.Windows.Forms.Label();
            this.lbl_deadCounter = new System.Windows.Forms.Label();
            this.lbl_infectedCounter = new System.Windows.Forms.Label();
            this.lbl_activeCounter = new System.Windows.Forms.Label();
            this.lbl_active = new System.Windows.Forms.Label();
            this.lbl_country = new System.Windows.Forms.Label();
            this.lbl_infected = new System.Windows.Forms.Label();
            this.chart_country = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbl_dead = new System.Windows.Forms.Label();
            this.lbl_recovered = new System.Windows.Forms.Label();
            this.timer_move = new System.Windows.Forms.Timer(this.components);
            this.card_country.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_expand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_country)).BeginInit();
            this.SuspendLayout();
            // 
            // card_country
            // 
            this.card_country.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.card_country.BackColor = System.Drawing.Color.White;
            this.card_country.BorderRadius = 15;
            this.card_country.BottomSahddow = true;
            this.card_country.color = System.Drawing.Color.Transparent;
            this.card_country.Controls.Add(this.lbl_activeChart);
            this.card_country.Controls.Add(this.cbox_active);
            this.card_country.Controls.Add(this.lbl_recoveredChart);
            this.card_country.Controls.Add(this.cbox_recovered);
            this.card_country.Controls.Add(this.lbl_deadChart);
            this.card_country.Controls.Add(this.cbox_dead);
            this.card_country.Controls.Add(this.lbl_infectedChart);
            this.card_country.Controls.Add(this.cbox_infected);
            this.card_country.Controls.Add(this.btn_expand);
            this.card_country.Controls.Add(this.btn_close);
            this.card_country.Controls.Add(this.lbl_recoveredCounter);
            this.card_country.Controls.Add(this.lbl_deadCounter);
            this.card_country.Controls.Add(this.lbl_infectedCounter);
            this.card_country.Controls.Add(this.lbl_activeCounter);
            this.card_country.Controls.Add(this.lbl_active);
            this.card_country.Controls.Add(this.lbl_country);
            this.card_country.Controls.Add(this.lbl_infected);
            this.card_country.Controls.Add(this.chart_country);
            this.card_country.Controls.Add(this.lbl_dead);
            this.card_country.Controls.Add(this.lbl_recovered);
            this.card_country.LeftSahddow = true;
            this.card_country.Location = new System.Drawing.Point(3, 3);
            this.card_country.Name = "card_country";
            this.card_country.RightSahddow = true;
            this.card_country.ShadowDepth = 10;
            this.card_country.Size = new System.Drawing.Size(392, 382);
            this.card_country.TabIndex = 6;
            this.card_country.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BunifuCards1_MouseDown);
            this.card_country.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BunifuCards1_MouseUp);
            // 
            // lbl_activeChart
            // 
            this.lbl_activeChart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_activeChart.AutoSize = true;
            this.lbl_activeChart.Font = new System.Drawing.Font("NeoSans", 13F, System.Drawing.FontStyle.Bold);
            this.lbl_activeChart.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_activeChart.Location = new System.Drawing.Point(223, 268);
            this.lbl_activeChart.Name = "lbl_activeChart";
            this.lbl_activeChart.Size = new System.Drawing.Size(63, 18);
            this.lbl_activeChart.TabIndex = 25;
            this.lbl_activeChart.Text = "Active";
            // 
            // cbox_active
            // 
            this.cbox_active.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbox_active.BackColor = System.Drawing.Color.DarkRed;
            this.cbox_active.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cbox_active.Checked = true;
            this.cbox_active.CheckedOnColor = System.Drawing.Color.DarkRed;
            this.cbox_active.Font = new System.Drawing.Font("NeoSans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_active.ForeColor = System.Drawing.Color.White;
            this.cbox_active.Location = new System.Drawing.Point(330, 266);
            this.cbox_active.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.cbox_active.Name = "cbox_active";
            this.cbox_active.Size = new System.Drawing.Size(20, 20);
            this.cbox_active.TabIndex = 24;
            this.cbox_active.OnChange += new System.EventHandler(this.UpdateCheckBoxStatus);
            // 
            // lbl_recoveredChart
            // 
            this.lbl_recoveredChart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_recoveredChart.AutoSize = true;
            this.lbl_recoveredChart.Font = new System.Drawing.Font("NeoSans", 13F, System.Drawing.FontStyle.Bold);
            this.lbl_recoveredChart.ForeColor = System.Drawing.Color.MediumBlue;
            this.lbl_recoveredChart.Location = new System.Drawing.Point(223, 346);
            this.lbl_recoveredChart.Name = "lbl_recoveredChart";
            this.lbl_recoveredChart.Size = new System.Drawing.Size(101, 18);
            this.lbl_recoveredChart.TabIndex = 23;
            this.lbl_recoveredChart.Text = "Recovered";
            // 
            // cbox_recovered
            // 
            this.cbox_recovered.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbox_recovered.BackColor = System.Drawing.Color.Blue;
            this.cbox_recovered.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cbox_recovered.Checked = true;
            this.cbox_recovered.CheckedOnColor = System.Drawing.Color.Blue;
            this.cbox_recovered.Font = new System.Drawing.Font("NeoSans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_recovered.ForeColor = System.Drawing.Color.White;
            this.cbox_recovered.Location = new System.Drawing.Point(330, 344);
            this.cbox_recovered.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.cbox_recovered.Name = "cbox_recovered";
            this.cbox_recovered.Size = new System.Drawing.Size(20, 20);
            this.cbox_recovered.TabIndex = 22;
            this.cbox_recovered.OnChange += new System.EventHandler(this.UpdateCheckBoxStatus);
            // 
            // lbl_deadChart
            // 
            this.lbl_deadChart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_deadChart.AutoSize = true;
            this.lbl_deadChart.Font = new System.Drawing.Font("NeoSans", 13F, System.Drawing.FontStyle.Bold);
            this.lbl_deadChart.ForeColor = System.Drawing.Color.Black;
            this.lbl_deadChart.Location = new System.Drawing.Point(223, 320);
            this.lbl_deadChart.Name = "lbl_deadChart";
            this.lbl_deadChart.Size = new System.Drawing.Size(53, 18);
            this.lbl_deadChart.TabIndex = 21;
            this.lbl_deadChart.Text = "Dead";
            // 
            // cbox_dead
            // 
            this.cbox_dead.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbox_dead.BackColor = System.Drawing.Color.Black;
            this.cbox_dead.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cbox_dead.Checked = true;
            this.cbox_dead.CheckedOnColor = System.Drawing.Color.Black;
            this.cbox_dead.Font = new System.Drawing.Font("NeoSans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_dead.ForeColor = System.Drawing.Color.White;
            this.cbox_dead.Location = new System.Drawing.Point(330, 318);
            this.cbox_dead.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.cbox_dead.Name = "cbox_dead";
            this.cbox_dead.Size = new System.Drawing.Size(20, 20);
            this.cbox_dead.TabIndex = 20;
            this.cbox_dead.OnChange += new System.EventHandler(this.UpdateCheckBoxStatus);
            // 
            // lbl_infectedChart
            // 
            this.lbl_infectedChart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_infectedChart.AutoSize = true;
            this.lbl_infectedChart.Font = new System.Drawing.Font("NeoSans", 13F, System.Drawing.FontStyle.Bold);
            this.lbl_infectedChart.ForeColor = System.Drawing.Color.Red;
            this.lbl_infectedChart.Location = new System.Drawing.Point(223, 294);
            this.lbl_infectedChart.Name = "lbl_infectedChart";
            this.lbl_infectedChart.Size = new System.Drawing.Size(83, 18);
            this.lbl_infectedChart.TabIndex = 19;
            this.lbl_infectedChart.Text = "Infected";
            // 
            // cbox_infected
            // 
            this.cbox_infected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbox_infected.BackColor = System.Drawing.Color.Red;
            this.cbox_infected.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cbox_infected.Checked = true;
            this.cbox_infected.CheckedOnColor = System.Drawing.Color.Red;
            this.cbox_infected.Font = new System.Drawing.Font("NeoSans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_infected.ForeColor = System.Drawing.Color.White;
            this.cbox_infected.Location = new System.Drawing.Point(330, 292);
            this.cbox_infected.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.cbox_infected.Name = "cbox_infected";
            this.cbox_infected.Size = new System.Drawing.Size(20, 20);
            this.cbox_infected.TabIndex = 18;
            this.cbox_infected.OnChange += new System.EventHandler(this.UpdateCheckBoxStatus);
            // 
            // btn_expand
            // 
            this.btn_expand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_expand.BackColor = System.Drawing.Color.Transparent;
            this.btn_expand.Image = global::VIZ_NCOV.Properties.Resources.expand;
            this.btn_expand.ImageActive = global::VIZ_NCOV.Properties.Resources.expand;
            this.btn_expand.Location = new System.Drawing.Point(364, 356);
            this.btn_expand.Name = "btn_expand";
            this.btn_expand.Size = new System.Drawing.Size(25, 23);
            this.btn_expand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_expand.TabIndex = 14;
            this.btn_expand.TabStop = false;
            this.btn_expand.Tag = "Expand";
            this.btn_expand.Zoom = 10;
            this.btn_expand.Click += new System.EventHandler(this.Btn_expand_Click);
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.Image = global::VIZ_NCOV.Properties.Resources.close;
            this.btn_close.ImageActive = global::VIZ_NCOV.Properties.Resources.close;
            this.btn_close.Location = new System.Drawing.Point(362, 7);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(25, 23);
            this.btn_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_close.TabIndex = 13;
            this.btn_close.TabStop = false;
            this.btn_close.Zoom = 10;
            this.btn_close.Click += new System.EventHandler(this.Btn_close_Click);
            // 
            // lbl_recoveredCounter
            // 
            this.lbl_recoveredCounter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_recoveredCounter.BackColor = System.Drawing.Color.Transparent;
            this.lbl_recoveredCounter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_recoveredCounter.Font = new System.Drawing.Font("NeoSans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_recoveredCounter.ForeColor = System.Drawing.Color.MediumBlue;
            this.lbl_recoveredCounter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_recoveredCounter.Location = new System.Drawing.Point(128, 131);
            this.lbl_recoveredCounter.Name = "lbl_recoveredCounter";
            this.lbl_recoveredCounter.Size = new System.Drawing.Size(261, 28);
            this.lbl_recoveredCounter.TabIndex = 10;
            this.lbl_recoveredCounter.Text = "9000000";
            this.lbl_recoveredCounter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_recoveredCounter.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BunifuCards1_MouseDown);
            this.lbl_recoveredCounter.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BunifuCards1_MouseUp);
            // 
            // lbl_deadCounter
            // 
            this.lbl_deadCounter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_deadCounter.BackColor = System.Drawing.Color.Transparent;
            this.lbl_deadCounter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_deadCounter.Font = new System.Drawing.Font("NeoSans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_deadCounter.ForeColor = System.Drawing.Color.Black;
            this.lbl_deadCounter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_deadCounter.Location = new System.Drawing.Point(128, 103);
            this.lbl_deadCounter.Name = "lbl_deadCounter";
            this.lbl_deadCounter.Size = new System.Drawing.Size(261, 28);
            this.lbl_deadCounter.TabIndex = 9;
            this.lbl_deadCounter.Text = "9000000";
            this.lbl_deadCounter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_deadCounter.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BunifuCards1_MouseDown);
            this.lbl_deadCounter.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BunifuCards1_MouseUp);
            // 
            // lbl_infectedCounter
            // 
            this.lbl_infectedCounter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_infectedCounter.BackColor = System.Drawing.Color.Transparent;
            this.lbl_infectedCounter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_infectedCounter.Font = new System.Drawing.Font("NeoSans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_infectedCounter.ForeColor = System.Drawing.Color.Red;
            this.lbl_infectedCounter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_infectedCounter.Location = new System.Drawing.Point(128, 75);
            this.lbl_infectedCounter.Name = "lbl_infectedCounter";
            this.lbl_infectedCounter.Size = new System.Drawing.Size(261, 28);
            this.lbl_infectedCounter.TabIndex = 8;
            this.lbl_infectedCounter.Text = "9000000";
            this.lbl_infectedCounter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_infectedCounter.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BunifuCards1_MouseDown);
            this.lbl_infectedCounter.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BunifuCards1_MouseUp);
            // 
            // lbl_activeCounter
            // 
            this.lbl_activeCounter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_activeCounter.BackColor = System.Drawing.Color.Transparent;
            this.lbl_activeCounter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_activeCounter.Font = new System.Drawing.Font("NeoSans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_activeCounter.ForeColor = System.Drawing.Color.IndianRed;
            this.lbl_activeCounter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_activeCounter.Location = new System.Drawing.Point(128, 47);
            this.lbl_activeCounter.Name = "lbl_activeCounter";
            this.lbl_activeCounter.Size = new System.Drawing.Size(261, 28);
            this.lbl_activeCounter.TabIndex = 7;
            this.lbl_activeCounter.Text = "9000000";
            this.lbl_activeCounter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_activeCounter.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BunifuCards1_MouseDown);
            this.lbl_activeCounter.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BunifuCards1_MouseUp);
            // 
            // lbl_active
            // 
            this.lbl_active.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_active.BackColor = System.Drawing.Color.Transparent;
            this.lbl_active.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_active.Font = new System.Drawing.Font("NeoSans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_active.ForeColor = System.Drawing.Color.IndianRed;
            this.lbl_active.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_active.Location = new System.Drawing.Point(6, 47);
            this.lbl_active.Name = "lbl_active";
            this.lbl_active.Size = new System.Drawing.Size(110, 28);
            this.lbl_active.TabIndex = 6;
            this.lbl_active.Text = "Active:";
            this.lbl_active.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_active.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BunifuCards1_MouseDown);
            this.lbl_active.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BunifuCards1_MouseUp);
            // 
            // lbl_country
            // 
            this.lbl_country.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_country.BackColor = System.Drawing.Color.Transparent;
            this.lbl_country.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_country.Font = new System.Drawing.Font("NeoSans", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_country.ForeColor = System.Drawing.Color.Black;
            this.lbl_country.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_country.Location = new System.Drawing.Point(0, 10);
            this.lbl_country.Name = "lbl_country";
            this.lbl_country.Size = new System.Drawing.Size(392, 37);
            this.lbl_country.TabIndex = 3;
            this.lbl_country.Text = "Country";
            this.lbl_country.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_country.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BunifuCards1_MouseDown);
            this.lbl_country.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BunifuCards1_MouseUp);
            // 
            // lbl_infected
            // 
            this.lbl_infected.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_infected.BackColor = System.Drawing.Color.Transparent;
            this.lbl_infected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_infected.Font = new System.Drawing.Font("NeoSans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_infected.ForeColor = System.Drawing.Color.Red;
            this.lbl_infected.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_infected.Location = new System.Drawing.Point(3, 75);
            this.lbl_infected.Name = "lbl_infected";
            this.lbl_infected.Size = new System.Drawing.Size(113, 28);
            this.lbl_infected.TabIndex = 0;
            this.lbl_infected.Text = "Infected:";
            this.lbl_infected.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_infected.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BunifuCards1_MouseDown);
            this.lbl_infected.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BunifuCards1_MouseUp);
            // 
            // chart_country
            // 
            this.chart_country.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("NeoSans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisX2.TitleFont = new System.Drawing.Font("NeoSans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("NeoSans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY2.TitleFont = new System.Drawing.Font("NeoSans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.Name = "ChartArea1";
            this.chart_country.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_country.Legends.Add(legend1);
            this.chart_country.Location = new System.Drawing.Point(0, 170);
            this.chart_country.Name = "chart_country";
            this.chart_country.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            this.chart_country.Size = new System.Drawing.Size(389, 212);
            this.chart_country.SuppressExceptions = true;
            this.chart_country.TabIndex = 5;
            this.chart_country.Text = "chart1";
            this.chart_country.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BunifuCards1_MouseDown);
            this.chart_country.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BunifuCards1_MouseUp);
            // 
            // lbl_dead
            // 
            this.lbl_dead.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_dead.BackColor = System.Drawing.Color.Transparent;
            this.lbl_dead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_dead.Font = new System.Drawing.Font("NeoSans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dead.ForeColor = System.Drawing.Color.Black;
            this.lbl_dead.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_dead.Location = new System.Drawing.Point(3, 103);
            this.lbl_dead.Name = "lbl_dead";
            this.lbl_dead.Size = new System.Drawing.Size(113, 28);
            this.lbl_dead.TabIndex = 1;
            this.lbl_dead.Text = "Dead:";
            this.lbl_dead.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_dead.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BunifuCards1_MouseDown);
            this.lbl_dead.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BunifuCards1_MouseUp);
            // 
            // lbl_recovered
            // 
            this.lbl_recovered.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_recovered.BackColor = System.Drawing.Color.Transparent;
            this.lbl_recovered.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_recovered.Font = new System.Drawing.Font("NeoSans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_recovered.ForeColor = System.Drawing.Color.MediumBlue;
            this.lbl_recovered.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_recovered.Location = new System.Drawing.Point(3, 131);
            this.lbl_recovered.Name = "lbl_recovered";
            this.lbl_recovered.Size = new System.Drawing.Size(113, 28);
            this.lbl_recovered.TabIndex = 2;
            this.lbl_recovered.Text = "Recovered:";
            this.lbl_recovered.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_recovered.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BunifuCards1_MouseDown);
            this.lbl_recovered.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BunifuCards1_MouseUp);
            // 
            // timer_move
            // 
            this.timer_move.Enabled = true;
            this.timer_move.Interval = 50;
            this.timer_move.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // CountryPopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.card_country);
            this.Name = "CountryPopUp";
            this.Size = new System.Drawing.Size(398, 388);
            this.card_country.ResumeLayout(false);
            this.card_country.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_expand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_country)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards card_country;
        private System.Windows.Forms.Label lbl_recoveredCounter;
        private System.Windows.Forms.Label lbl_deadCounter;
        private System.Windows.Forms.Label lbl_infectedCounter;
        private System.Windows.Forms.Label lbl_activeCounter;
        private System.Windows.Forms.Label lbl_active;
        private System.Windows.Forms.Label lbl_country;
        private System.Windows.Forms.Label lbl_infected;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_country;
        private System.Windows.Forms.Label lbl_dead;
        private System.Windows.Forms.Label lbl_recovered;
        private System.Windows.Forms.Timer timer_move;
        private Bunifu.Framework.UI.BunifuImageButton btn_close;
        private Bunifu.Framework.UI.BunifuImageButton btn_expand;
        private System.Windows.Forms.Label lbl_activeChart;
        private Bunifu.Framework.UI.BunifuCheckbox cbox_active;
        private System.Windows.Forms.Label lbl_recoveredChart;
        private Bunifu.Framework.UI.BunifuCheckbox cbox_recovered;
        private System.Windows.Forms.Label lbl_deadChart;
        private Bunifu.Framework.UI.BunifuCheckbox cbox_dead;
        private System.Windows.Forms.Label lbl_infectedChart;
        private Bunifu.Framework.UI.BunifuCheckbox cbox_infected;
    }
}
