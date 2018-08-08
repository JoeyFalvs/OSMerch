namespace OSMerch
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series21 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series22 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series23 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series24 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblVersion = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnState = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.mainTab = new System.Windows.Forms.TabControl();
            this.tabGraph = new System.Windows.Forms.TabPage();
            this.btn180Days = new System.Windows.Forms.Button();
            this.btn90Days = new System.Windows.Forms.Button();
            this.numericHighMargin = new System.Windows.Forms.Label();
            this.lblLowMargin = new System.Windows.Forms.Label();
            this.numericLowMargin = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.chartPrices = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn30Days = new System.Windows.Forms.Button();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.webFlipRS = new System.Windows.Forms.WebBrowser();
            this.tabHistory = new System.Windows.Forms.TabPage();
            this.lblBlankTip = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnHistoryHelp = new System.Windows.Forms.Button();
            this.txtIntervals = new System.Windows.Forms.TextBox();
            this.lblHistoryIntervals = new System.Windows.Forms.Label();
            this.lblHistoryWarning = new System.Windows.Forms.Label();
            this.lblHistoryName = new System.Windows.Forms.Label();
            this.txtHistory = new System.Windows.Forms.TextBox();
            this.tabHelp = new System.Windows.Forms.TabPage();
            this.acid = new System.Windows.Forms.TabPage();
            this.bgwLoadHistory = new System.ComponentModel.BackgroundWorker();
            this.pnlLeftTop = new System.Windows.Forms.Panel();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblBuy = new System.Windows.Forms.Label();
            this.lblSell = new System.Windows.Forms.Label();
            this.btnHistorySearch = new System.Windows.Forms.Button();
            this.lblRatio = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.picProgramIcon = new System.Windows.Forms.PictureBox();
            this.picItemIcon = new System.Windows.Forms.PictureBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.btnGraph = new System.Windows.Forms.Button();
            this.pnlNavigation = new System.Windows.Forms.Panel();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.picTwitch = new System.Windows.Forms.PictureBox();
            this.lblTwitch = new System.Windows.Forms.Label();
            this.lblDiscord = new System.Windows.Forms.Label();
            this.picDiscord = new System.Windows.Forms.PictureBox();
            this.pnlTop.SuspendLayout();
            this.mainTab.SuspendLayout();
            this.tabGraph.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericLowMargin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPrices)).BeginInit();
            this.tabHome.SuspendLayout();
            this.tabHistory.SuspendLayout();
            this.pnlLeftTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProgramIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picItemIcon)).BeginInit();
            this.pnlNavigation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTwitch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDiscord)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlTop.Controls.Add(this.lblVersion);
            this.pnlTop.Controls.Add(this.btnMinimize);
            this.pnlTop.Controls.Add(this.btnState);
            this.pnlTop.Controls.Add(this.btnExit);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1572, 30);
            this.pnlTop.TabIndex = 1;
            this.pnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseDown);
            this.pnlTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseMove);
            this.pnlTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseUp);
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(12, 6);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(150, 19);
            this.lblVersion.TabIndex = 8;
            this.lblVersion.Text = "RSFlip - Version 0.010";
            // 
            // btnMinimize
            // 
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnMinimize.Location = new System.Drawing.Point(1482, 0);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(30, 30);
            this.btnMinimize.TabIndex = 7;
            this.btnMinimize.Text = "_";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnState
            // 
            this.btnState.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnState.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnState.FlatAppearance.BorderSize = 0;
            this.btnState.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnState.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnState.Location = new System.Drawing.Point(1512, 0);
            this.btnState.Margin = new System.Windows.Forms.Padding(4);
            this.btnState.Name = "btnState";
            this.btnState.Size = new System.Drawing.Size(30, 30);
            this.btnState.TabIndex = 5;
            this.btnState.Text = "☐";
            this.btnState.UseVisualStyleBackColor = false;
            this.btnState.Click += new System.EventHandler(this.btnMinMax_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(1542, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(30, 30);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(1562, 30);
            this.pnlRight.Margin = new System.Windows.Forms.Padding(4);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(10, 759);
            this.pnlRight.TabIndex = 3;
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 774);
            this.pnlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1562, 15);
            this.pnlBottom.TabIndex = 4;
            // 
            // mainTab
            // 
            this.mainTab.Controls.Add(this.tabHome);
            this.mainTab.Controls.Add(this.tabHistory);
            this.mainTab.Controls.Add(this.tabGraph);
            this.mainTab.Controls.Add(this.tabHelp);
            this.mainTab.Controls.Add(this.acid);
            this.mainTab.Location = new System.Drawing.Point(291, 0);
            this.mainTab.Name = "mainTab";
            this.mainTab.SelectedIndex = 0;
            this.mainTab.Size = new System.Drawing.Size(1271, 777);
            this.mainTab.TabIndex = 5;
            // 
            // tabGraph
            // 
            this.tabGraph.Controls.Add(this.btn30Days);
            this.tabGraph.Controls.Add(this.btn180Days);
            this.tabGraph.Controls.Add(this.btn90Days);
            this.tabGraph.Controls.Add(this.numericHighMargin);
            this.tabGraph.Controls.Add(this.lblLowMargin);
            this.tabGraph.Controls.Add(this.numericLowMargin);
            this.tabGraph.Controls.Add(this.numericUpDown1);
            this.tabGraph.Controls.Add(this.chartPrices);
            this.tabGraph.Location = new System.Drawing.Point(4, 28);
            this.tabGraph.Name = "tabGraph";
            this.tabGraph.Padding = new System.Windows.Forms.Padding(3);
            this.tabGraph.Size = new System.Drawing.Size(1263, 745);
            this.tabGraph.TabIndex = 2;
            this.tabGraph.Text = "Graph";
            this.tabGraph.UseVisualStyleBackColor = true;
            // 
            // btn180Days
            // 
            this.btn180Days.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(204)))), ((int)(((byte)(186)))));
            this.btn180Days.FlatAppearance.BorderSize = 0;
            this.btn180Days.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn180Days.Location = new System.Drawing.Point(834, 15);
            this.btn180Days.Name = "btn180Days";
            this.btn180Days.Size = new System.Drawing.Size(231, 48);
            this.btn180Days.TabIndex = 13;
            this.btn180Days.Text = "180 Days";
            this.btn180Days.UseVisualStyleBackColor = false;
            this.btn180Days.Click += new System.EventHandler(this.btn180Days_Click);
            // 
            // btn90Days
            // 
            this.btn90Days.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(204)))), ((int)(((byte)(186)))));
            this.btn90Days.FlatAppearance.BorderSize = 0;
            this.btn90Days.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn90Days.Location = new System.Drawing.Point(475, 15);
            this.btn90Days.Name = "btn90Days";
            this.btn90Days.Size = new System.Drawing.Size(231, 48);
            this.btn90Days.TabIndex = 12;
            this.btn90Days.Text = "90 Days";
            this.btn90Days.UseVisualStyleBackColor = false;
            this.btn90Days.Click += new System.EventHandler(this.btn90Days_Click);
            // 
            // numericHighMargin
            // 
            this.numericHighMargin.AutoSize = true;
            this.numericHighMargin.Location = new System.Drawing.Point(1146, 30);
            this.numericHighMargin.Name = "numericHighMargin";
            this.numericHighMargin.Size = new System.Drawing.Size(84, 19);
            this.numericHighMargin.TabIndex = 6;
            this.numericHighMargin.Text = "Low Margin";
            this.numericHighMargin.Visible = false;
            // 
            // lblLowMargin
            // 
            this.lblLowMargin.AutoSize = true;
            this.lblLowMargin.Location = new System.Drawing.Point(1163, 15);
            this.lblLowMargin.Name = "lblLowMargin";
            this.lblLowMargin.Size = new System.Drawing.Size(84, 19);
            this.lblLowMargin.TabIndex = 5;
            this.lblLowMargin.Text = "Low Margin";
            this.lblLowMargin.Visible = false;
            // 
            // numericLowMargin
            // 
            this.numericLowMargin.Location = new System.Drawing.Point(1137, 37);
            this.numericLowMargin.Name = "numericLowMargin";
            this.numericLowMargin.Size = new System.Drawing.Size(120, 26);
            this.numericLowMargin.TabIndex = 2;
            this.numericLowMargin.Visible = false;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(1137, 2);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.Visible = false;
            // 
            // chartPrices
            // 
            chartArea6.Name = "ChartArea1";
            this.chartPrices.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chartPrices.Legends.Add(legend6);
            this.chartPrices.Location = new System.Drawing.Point(10, 69);
            this.chartPrices.Name = "chartPrices";
            this.chartPrices.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Aqua,
        System.Drawing.Color.Lime,
        System.Drawing.Color.Red,
        System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))))};
            this.chartPrices.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series21.BorderWidth = 2;
            series21.ChartArea = "ChartArea1";
            series21.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series21.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            series21.Legend = "Legend1";
            series21.Name = "Price";
            series22.ChartArea = "ChartArea1";
            series22.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series22.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            series22.Legend = "Legend1";
            series22.Name = "Average";
            series23.ChartArea = "ChartArea1";
            series23.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series23.Legend = "Legend1";
            series23.Name = "Low Margin";
            series24.ChartArea = "ChartArea1";
            series24.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series24.Legend = "Legend1";
            series24.Name = "High Margin";
            this.chartPrices.Series.Add(series21);
            this.chartPrices.Series.Add(series22);
            this.chartPrices.Series.Add(series23);
            this.chartPrices.Series.Add(series24);
            this.chartPrices.Size = new System.Drawing.Size(1247, 670);
            this.chartPrices.TabIndex = 0;
            this.chartPrices.Click += new System.EventHandler(this.chart1_Click);
            // 
            // btn30Days
            // 
            this.btn30Days.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(204)))), ((int)(((byte)(186)))));
            this.btn30Days.FlatAppearance.BorderSize = 0;
            this.btn30Days.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn30Days.Location = new System.Drawing.Point(107, 15);
            this.btn30Days.Name = "btn30Days";
            this.btn30Days.Size = new System.Drawing.Size(231, 48);
            this.btn30Days.TabIndex = 11;
            this.btn30Days.Text = "30 Days";
            this.btn30Days.UseVisualStyleBackColor = false;
            this.btn30Days.Click += new System.EventHandler(this.btn30Days_Click);
            // 
            // tabHome
            // 
            this.tabHome.Controls.Add(this.webFlipRS);
            this.tabHome.Location = new System.Drawing.Point(4, 28);
            this.tabHome.Name = "tabHome";
            this.tabHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabHome.Size = new System.Drawing.Size(1263, 745);
            this.tabHome.TabIndex = 0;
            this.tabHome.Text = "Home";
            this.tabHome.UseVisualStyleBackColor = true;
            // 
            // webFlipRS
            // 
            this.webFlipRS.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.webFlipRS.Location = new System.Drawing.Point(3, 3);
            this.webFlipRS.MinimumSize = new System.Drawing.Size(20, 20);
            this.webFlipRS.Name = "webFlipRS";
            this.webFlipRS.ScriptErrorsSuppressed = true;
            this.webFlipRS.Size = new System.Drawing.Size(1247, 739);
            this.webFlipRS.TabIndex = 0;
            this.webFlipRS.Url = new System.Uri("http://www.flip.rs", System.UriKind.Absolute);
            this.webFlipRS.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webFlipRS_DocumentCompleted);
            // 
            // tabHistory
            // 
            this.tabHistory.Controls.Add(this.lblBlankTip);
            this.tabHistory.Controls.Add(this.txtTime);
            this.tabHistory.Controls.Add(this.lblTime);
            this.tabHistory.Controls.Add(this.btnHistoryHelp);
            this.tabHistory.Controls.Add(this.txtIntervals);
            this.tabHistory.Controls.Add(this.lblHistoryIntervals);
            this.tabHistory.Controls.Add(this.lblHistoryWarning);
            this.tabHistory.Controls.Add(this.lblHistoryName);
            this.tabHistory.Controls.Add(this.txtHistory);
            this.tabHistory.Location = new System.Drawing.Point(4, 28);
            this.tabHistory.Name = "tabHistory";
            this.tabHistory.Padding = new System.Windows.Forms.Padding(3);
            this.tabHistory.Size = new System.Drawing.Size(1263, 745);
            this.tabHistory.TabIndex = 1;
            this.tabHistory.Text = "History";
            this.tabHistory.UseVisualStyleBackColor = true;
            // 
            // lblBlankTip
            // 
            this.lblBlankTip.AutoSize = true;
            this.lblBlankTip.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlankTip.Location = new System.Drawing.Point(394, 9);
            this.lblBlankTip.Name = "lblBlankTip";
            this.lblBlankTip.Size = new System.Drawing.Size(104, 19);
            this.lblBlankTip.TabIndex = 19;
            this.lblBlankTip.Text = "Blank = 7 Days";
            this.lblBlankTip.Visible = false;
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(101, 6);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(287, 26);
            this.txtTime.TabIndex = 18;
            this.txtTime.Visible = false;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(12, 9);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(83, 19);
            this.lblTime.TabIndex = 17;
            this.lblTime.Text = "Time (Unix):";
            this.lblTime.Visible = false;
            // 
            // btnHistoryHelp
            // 
            this.btnHistoryHelp.Location = new System.Drawing.Point(1220, 8);
            this.btnHistoryHelp.Name = "btnHistoryHelp";
            this.btnHistoryHelp.Size = new System.Drawing.Size(27, 27);
            this.btnHistoryHelp.TabIndex = 16;
            this.btnHistoryHelp.Text = "?";
            this.btnHistoryHelp.UseVisualStyleBackColor = true;
            this.btnHistoryHelp.Click += new System.EventHandler(this.btnHistoryHelp_Click);
            // 
            // txtIntervals
            // 
            this.txtIntervals.Location = new System.Drawing.Point(639, 6);
            this.txtIntervals.Name = "txtIntervals";
            this.txtIntervals.Size = new System.Drawing.Size(80, 26);
            this.txtIntervals.TabIndex = 15;
            this.txtIntervals.Text = "30";
            // 
            // lblHistoryIntervals
            // 
            this.lblHistoryIntervals.AutoSize = true;
            this.lblHistoryIntervals.Location = new System.Drawing.Point(532, 9);
            this.lblHistoryIntervals.Name = "lblHistoryIntervals";
            this.lblHistoryIntervals.Size = new System.Drawing.Size(101, 19);
            this.lblHistoryIntervals.TabIndex = 14;
            this.lblHistoryIntervals.Text = "Intervals (Min):";
            // 
            // lblHistoryWarning
            // 
            this.lblHistoryWarning.AutoSize = true;
            this.lblHistoryWarning.ForeColor = System.Drawing.Color.Red;
            this.lblHistoryWarning.Location = new System.Drawing.Point(725, 12);
            this.lblHistoryWarning.Name = "lblHistoryWarning";
            this.lblHistoryWarning.Size = new System.Drawing.Size(489, 19);
            this.lblHistoryWarning.TabIndex = 13;
            this.lblHistoryWarning.Text = "Warning: Due to RSbuddy\'s API being unstable, results may take a few seconds\r\n";
            // 
            // lblHistoryName
            // 
            this.lblHistoryName.AutoSize = true;
            this.lblHistoryName.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistoryName.Location = new System.Drawing.Point(6, 6);
            this.lblHistoryName.Name = "lblHistoryName";
            this.lblHistoryName.Size = new System.Drawing.Size(0, 36);
            this.lblHistoryName.TabIndex = 10;
            // 
            // txtHistory
            // 
            this.txtHistory.Location = new System.Drawing.Point(6, 37);
            this.txtHistory.Multiline = true;
            this.txtHistory.Name = "txtHistory";
            this.txtHistory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtHistory.Size = new System.Drawing.Size(1242, 702);
            this.txtHistory.TabIndex = 0;
            // 
            // tabHelp
            // 
            this.tabHelp.Location = new System.Drawing.Point(4, 28);
            this.tabHelp.Name = "tabHelp";
            this.tabHelp.Size = new System.Drawing.Size(1263, 745);
            this.tabHelp.TabIndex = 3;
            this.tabHelp.Text = "Help";
            this.tabHelp.UseVisualStyleBackColor = true;
            // 
            // acid
            // 
            this.acid.Location = new System.Drawing.Point(4, 28);
            this.acid.Name = "acid";
            this.acid.Size = new System.Drawing.Size(1263, 745);
            this.acid.TabIndex = 4;
            this.acid.Text = "tabAcid";
            this.acid.UseVisualStyleBackColor = true;
            // 
            // bgwLoadHistory
            // 
            this.bgwLoadHistory.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwLoadHistory_DoWork);
            // 
            // pnlLeftTop
            // 
            this.pnlLeftTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(204)))), ((int)(((byte)(186)))));
            this.pnlLeftTop.Controls.Add(this.lblPrice);
            this.pnlLeftTop.Controls.Add(this.lblBuy);
            this.pnlLeftTop.Controls.Add(this.lblSell);
            this.pnlLeftTop.Controls.Add(this.btnHistorySearch);
            this.pnlLeftTop.Controls.Add(this.lblRatio);
            this.pnlLeftTop.Controls.Add(this.txtSearch);
            this.pnlLeftTop.Controls.Add(this.picProgramIcon);
            this.pnlLeftTop.Controls.Add(this.picItemIcon);
            this.pnlLeftTop.Controls.Add(this.lblTitle);
            this.pnlLeftTop.Location = new System.Drawing.Point(0, 0);
            this.pnlLeftTop.Name = "pnlLeftTop";
            this.pnlLeftTop.Size = new System.Drawing.Size(301, 494);
            this.pnlLeftTop.TabIndex = 17;
            this.pnlLeftTop.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlLeftTop_Paint);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(204)))), ((int)(((byte)(186)))));
            this.lblPrice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPrice.Location = new System.Drawing.Point(17, 226);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(43, 19);
            this.lblPrice.TabIndex = 13;
            this.lblPrice.Text = "Price:";
            // 
            // lblBuy
            // 
            this.lblBuy.AutoSize = true;
            this.lblBuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(204)))), ((int)(((byte)(186)))));
            this.lblBuy.Location = new System.Drawing.Point(17, 245);
            this.lblBuy.Name = "lblBuy";
            this.lblBuy.Size = new System.Drawing.Size(55, 19);
            this.lblBuy.TabIndex = 14;
            this.lblBuy.Text = "Bought:";
            this.lblBuy.Visible = false;
            // 
            // lblSell
            // 
            this.lblSell.AutoSize = true;
            this.lblSell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(204)))), ((int)(((byte)(186)))));
            this.lblSell.Location = new System.Drawing.Point(17, 264);
            this.lblSell.Name = "lblSell";
            this.lblSell.Size = new System.Drawing.Size(40, 19);
            this.lblSell.TabIndex = 15;
            this.lblSell.Text = "Sold:";
            this.lblSell.Visible = false;
            // 
            // btnHistorySearch
            // 
            this.btnHistorySearch.Location = new System.Drawing.Point(217, 186);
            this.btnHistorySearch.Name = "btnHistorySearch";
            this.btnHistorySearch.Size = new System.Drawing.Size(75, 26);
            this.btnHistorySearch.TabIndex = 12;
            this.btnHistorySearch.Text = "Search";
            this.btnHistorySearch.UseVisualStyleBackColor = true;
            this.btnHistorySearch.Click += new System.EventHandler(this.btnHistorySearch_Click);
            // 
            // lblRatio
            // 
            this.lblRatio.AutoSize = true;
            this.lblRatio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(204)))), ((int)(((byte)(186)))));
            this.lblRatio.Location = new System.Drawing.Point(16, 283);
            this.lblRatio.Name = "lblRatio";
            this.lblRatio.Size = new System.Drawing.Size(71, 19);
            this.lblRatio.TabIndex = 16;
            this.lblRatio.Text = "B/S Ratio:";
            this.lblRatio.Visible = false;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(204)))), ((int)(((byte)(186)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(21, 187);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(186, 25);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(204)))), ((int)(((byte)(186)))));
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(42)))), ((int)(((byte)(69)))));
            this.lblTitle.Location = new System.Drawing.Point(76, 4);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(234, 61);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "OSMerch";
            // 
            // picProgramIcon
            // 
            this.picProgramIcon.Image = ((System.Drawing.Image)(resources.GetObject("picProgramIcon.Image")));
            this.picProgramIcon.Location = new System.Drawing.Point(17, 4);
            this.picProgramIcon.Name = "picProgramIcon";
            this.picProgramIcon.Size = new System.Drawing.Size(70, 57);
            this.picProgramIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picProgramIcon.TabIndex = 12;
            this.picProgramIcon.TabStop = false;
            // 
            // picItemIcon
            // 
            this.picItemIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(204)))), ((int)(((byte)(186)))));
            this.picItemIcon.Location = new System.Drawing.Point(16, 84);
            this.picItemIcon.Name = "picItemIcon";
            this.picItemIcon.Size = new System.Drawing.Size(70, 68);
            this.picItemIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picItemIcon.TabIndex = 7;
            this.picItemIcon.TabStop = false;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(175)))), ((int)(((byte)(156)))));
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.Black;
            this.btnHome.Location = new System.Drawing.Point(0, 330);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(298, 48);
            this.btnHome.TabIndex = 6;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(204)))), ((int)(((byte)(186)))));
            this.btnHistory.FlatAppearance.BorderSize = 0;
            this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistory.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistory.ForeColor = System.Drawing.Color.Black;
            this.btnHistory.Location = new System.Drawing.Point(0, 378);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(298, 48);
            this.btnHistory.TabIndex = 8;
            this.btnHistory.Text = "History (Beta)";
            this.btnHistory.UseVisualStyleBackColor = false;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(204)))), ((int)(((byte)(186)))));
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(94, 105);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 23);
            this.lblName.TabIndex = 9;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(204)))), ((int)(((byte)(186)))));
            this.lblID.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(93, 123);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 17);
            this.lblID.TabIndex = 10;
            // 
            // btnGraph
            // 
            this.btnGraph.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(204)))), ((int)(((byte)(186)))));
            this.btnGraph.FlatAppearance.BorderSize = 0;
            this.btnGraph.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGraph.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGraph.ForeColor = System.Drawing.Color.Black;
            this.btnGraph.Location = new System.Drawing.Point(0, 426);
            this.btnGraph.Name = "btnGraph";
            this.btnGraph.Size = new System.Drawing.Size(298, 48);
            this.btnGraph.TabIndex = 11;
            this.btnGraph.Text = "Graph (Beta)";
            this.btnGraph.UseVisualStyleBackColor = false;
            this.btnGraph.Click += new System.EventHandler(this.btnGraph_Click);
            // 
            // pnlNavigation
            // 
            this.pnlNavigation.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pnlNavigation.Controls.Add(this.lblDiscord);
            this.pnlNavigation.Controls.Add(this.picDiscord);
            this.pnlNavigation.Controls.Add(this.lblTwitch);
            this.pnlNavigation.Controls.Add(this.picTwitch);
            this.pnlNavigation.Controls.Add(this.pnlLeft);
            this.pnlNavigation.Controls.Add(this.btnGraph);
            this.pnlNavigation.Controls.Add(this.lblID);
            this.pnlNavigation.Controls.Add(this.lblName);
            this.pnlNavigation.Controls.Add(this.btnHistory);
            this.pnlNavigation.Controls.Add(this.btnHome);
            this.pnlNavigation.Controls.Add(this.pnlLeftTop);
            this.pnlNavigation.Location = new System.Drawing.Point(0, 30);
            this.pnlNavigation.Margin = new System.Windows.Forms.Padding(4);
            this.pnlNavigation.Name = "pnlNavigation";
            this.pnlNavigation.Size = new System.Drawing.Size(298, 789);
            this.pnlNavigation.TabIndex = 0;
            this.pnlNavigation.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlNavigation_Paint);
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(10, 789);
            this.pnlLeft.TabIndex = 1;
            // 
            // picTwitch
            // 
            this.picTwitch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picTwitch.Image = ((System.Drawing.Image)(resources.GetObject("picTwitch.Image")));
            this.picTwitch.Location = new System.Drawing.Point(16, 613);
            this.picTwitch.Name = "picTwitch";
            this.picTwitch.Size = new System.Drawing.Size(40, 40);
            this.picTwitch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTwitch.TabIndex = 18;
            this.picTwitch.TabStop = false;
            this.picTwitch.Click += new System.EventHandler(this.picTwitch_Click);
            // 
            // lblTwitch
            // 
            this.lblTwitch.AutoSize = true;
            this.lblTwitch.Location = new System.Drawing.Point(62, 623);
            this.lblTwitch.Name = "lblTwitch";
            this.lblTwitch.Size = new System.Drawing.Size(67, 19);
            this.lblTwitch.TabIndex = 19;
            this.lblTwitch.Text = "- Aitak82";
            // 
            // lblDiscord
            // 
            this.lblDiscord.Location = new System.Drawing.Point(63, 675);
            this.lblDiscord.Name = "lblDiscord";
            this.lblDiscord.Size = new System.Drawing.Size(195, 40);
            this.lblDiscord.TabIndex = 21;
            this.lblDiscord.Text = "Join Our Discord: https://discord.gg/SWVDEdh";
            // 
            // picDiscord
            // 
            this.picDiscord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picDiscord.Image = ((System.Drawing.Image)(resources.GetObject("picDiscord.Image")));
            this.picDiscord.Location = new System.Drawing.Point(17, 675);
            this.picDiscord.Name = "picDiscord";
            this.picDiscord.Size = new System.Drawing.Size(40, 40);
            this.picDiscord.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDiscord.TabIndex = 20;
            this.picDiscord.TabStop = false;
            this.picDiscord.Click += new System.EventHandler(this.picDiscord_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1572, 789);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlNavigation);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.mainTab);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "OSMerch";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(79)))), ((int)(((byte)(34)))));
            this.Click += new System.EventHandler(this.MainForm_Click);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.mainTab.ResumeLayout(false);
            this.tabGraph.ResumeLayout(false);
            this.tabGraph.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericLowMargin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPrices)).EndInit();
            this.tabHome.ResumeLayout(false);
            this.tabHistory.ResumeLayout(false);
            this.tabHistory.PerformLayout();
            this.pnlLeftTop.ResumeLayout(false);
            this.pnlLeftTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProgramIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picItemIcon)).EndInit();
            this.pnlNavigation.ResumeLayout(false);
            this.pnlNavigation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTwitch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDiscord)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Button btnState;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.TabControl mainTab;
        private System.Windows.Forms.TabPage tabHome;
        private System.Windows.Forms.TabPage tabHistory;
        private System.Windows.Forms.TextBox txtHistory;
        private System.Windows.Forms.Label lblHistoryName;
        private System.ComponentModel.BackgroundWorker bgwLoadHistory;
        private System.Windows.Forms.Label lblHistoryWarning;
        private System.Windows.Forms.Button btnHistoryHelp;
        private System.Windows.Forms.TextBox txtIntervals;
        private System.Windows.Forms.Label lblHistoryIntervals;
        private System.Windows.Forms.WebBrowser webFlipRS;
        private System.Windows.Forms.TabPage tabGraph;
        private System.Windows.Forms.TabPage tabHelp;
        private System.Windows.Forms.TabPage acid;
        private System.Windows.Forms.Panel pnlLeftTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox picProgramIcon;
        private System.Windows.Forms.PictureBox picItemIcon;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnHistorySearch;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnGraph;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblBuy;
        private System.Windows.Forms.Label lblSell;
        private System.Windows.Forms.Label lblRatio;
        private System.Windows.Forms.Panel pnlNavigation;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblBlankTip;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label numericHighMargin;
        private System.Windows.Forms.Label lblLowMargin;
        private System.Windows.Forms.NumericUpDown numericLowMargin;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPrices;
        private System.Windows.Forms.Button btn180Days;
        private System.Windows.Forms.Button btn90Days;
        private System.Windows.Forms.Button btn30Days;
        private System.Windows.Forms.Label lblDiscord;
        private System.Windows.Forms.PictureBox picDiscord;
        private System.Windows.Forms.Label lblTwitch;
        private System.Windows.Forms.PictureBox picTwitch;
    }
}

