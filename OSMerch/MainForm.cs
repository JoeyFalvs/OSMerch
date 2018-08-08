using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Net;

namespace OSMerch
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private bool mousedown = false;
        private Point start;
        private int selected = 0;
        private Item Item = new Item();
        private int highmargin;
        private int lowmargin;
        private int highwait;
        private int lowwait;
        private int averagewait;
        private int maximum;
        private int minimum;
        private int average;

        public void LoadPics(string id)
        {

        }

        public void Load()
        {
            pnlTop.Width = this.Width - pnlNavigation.Width;
            pnlTop.Left = pnlNavigation.Width;
            pnlRight.Left = this.Width - pnlRight.Width;
            pnlRight.Height = this.Height - pnlTop.Height;
            pnlBottom.Left = pnlNavigation.Width;
            pnlBottom.Width = this.Width - pnlNavigation.Width - pnlRight.Width;
            pnlBottom.Top = this.Height - pnlBottom.Height;
            mainTab.Left = pnlLeftTop.Width - 2;
            mainTab.Width = this.Width - (pnlLeftTop.Width + pnlRight.Width);
            mainTab.Height = this.Height - pnlBottom.Height;
            mainTab.Top = pnlTop.Height - 27;
            webFlipRS.Width = mainTab.Width - 10;
            webFlipRS.Height = mainTab.Height;
            webFlipRS.Top = 0;
            pnlNavigation.Height = this.Height;
            pnlLeftTop.Height = this.Height / 2 + 30;
            txtHistory.Width = mainTab.Width - txtHistory.Left - 16 ;
            txtHistory.Height = mainTab.Height - txtHistory.Top - 40;

            txtHistory.Font = new Font("Times New Roman", (mainTab.Width / 120) + 2);
        }

        private void UpdateGraph(int time)
        {
            foreach (var series in chartPrices.Series)
            {
                series.Points.Clear();
            }
            Item item = new Item();
            
            item.Load(Convert.ToString(Item.GetId(txtSearch.Text)));
            
            double[] prices = new double[10000];
            prices = item.PriceHistory;
            for (int i = 0; i < 179; i++)
            {
                double price = prices[i];
                if (i > time)
                {
                    chartPrices.Series["Price"].Points.AddXY(i - time, price);
                }
            }
            lblPrice.Text = "Price: " + prices[179];
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            Load();
            if (!Directory.Exists(@"ItemData")) Directory.CreateDirectory("ItemData");
            if (!Directory.Exists(@"ProgramData")) Directory.CreateDirectory("ProgramData");

        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            Load();
            
        }

        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            mousedown = true;
            start = new Point(e.X, e.Y);
        }

        private void pnlTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousedown == true)
            {
                Point point = PointToScreen(e.Location);
                Location = new Point(point.X - this.start.X, point.Y - this.start.Y);
            }
        }

        private void pnlTop_MouseUp(object sender, MouseEventArgs e)
        {
            mousedown = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinMax_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
            Load();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            
            
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            mainTab.SelectedIndex = 0;
            btnHome.BackColor = Color.FromArgb(183, 175, 156);
            btnHistory.BackColor = Color.FromArgb(211, 204, 186);
            btnGraph.BackColor = Color.FromArgb(211, 204, 186);

        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            mainTab.SelectedIndex = 1;
            btnHistory.BackColor = Color.FromArgb(183, 175, 156);
            btnHome.BackColor = Color.FromArgb(211, 204, 186);
            btnGraph.BackColor = Color.FromArgb(211, 204, 186);
        }

        private void btnGraph_Click(object sender, EventArgs e)
        {
            mainTab.SelectedIndex = 2;
            btnHistory.BackColor = Color.FromArgb(211, 204, 186);
            btnHome.BackColor = Color.FromArgb(211, 204, 186);
            btnGraph.BackColor = Color.FromArgb(183, 175, 156);

        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            
        }

        private void btnHistorySearch_Click(object sender, EventArgs e)
        {
            string id = Convert.ToString(Item.GetId(txtSearch.Text));
            if (mainTab.SelectedIndex == 2)
            {
                re:
                using (WebClient client = new WebClient())
                {
                    if (!File.Exists(@"ItemData\Icon_" + id + ".png"))
                    {
                        try
                        {
                            client.DownloadFile(@"http://services.runescape.com/m=itemdb_oldschool/1532444471455_obj_big.gif?id=" + id, @"ItemData\icon_" + id + ".png");
                            client.Dispose();

                        }
                        catch (Exception)
                        {

                        }
                        Debug.Write(id);
                    }
                    try
                    {

                        picItemIcon.Image = Image.FromFile(@"ItemData\icon_" + id + ".png");
                    }
                    catch (Exception)
                    {

                    }

                    lblName.Text = Item.Name;
                    lblID.Text = Item.Id.ToString();
                }
                if (txtSearch.Text.Length > 1)
                {
                    Item Item = new Item();

                    using (WebClient client = new WebClient())
                    {
                        try
                        {
                            txtHistory.Clear();
                            var web = (HttpWebRequest)WebRequest.Create("https://api.rsbuddy.com/grandExchange?a=graph&i=" + id);
                            web.Method = "GET";
                            using (var res = new StreamReader(web.GetResponse().GetResponseStream()))
                            {
                                string line = "";
                                while ((line = res.ReadLine()) != null)
                                {
                                    txtHistory.AppendText(line + System.Environment.NewLine);
                                }
                            }
                        }
                        catch (Exception)
                        {

                        }
                    }

                }
                if (txtHistory.Text.Equals("")) goto re;
                endd:;
            }
            else
            {
                using (WebClient client = new WebClient())
                {
                    if (!File.Exists(@"ItemData\Icon_" + id + ".png"))
                    {
                        try
                        {
                            client.DownloadFile(@"http://services.runescape.com/m=itemdb_oldschool/1532444471455_obj_big.gif?id=" + id, @"ItemData\icon_" + id + ".png");
                            client.Dispose();

                        }
                        catch (Exception)
                        {

                        }
                        Debug.Write(id);
                    }
                    try
                    {

                        picItemIcon.Image = Image.FromFile(@"ItemData\icon_" + id + ".png");
                    }
                    catch (Exception)
                    {

                    }

                    lblName.Text = Item.Name;
                    lblID.Text = Item.Id.ToString();
                }
            }
        }

        private void bgwLoadHistory_DoWork(object sender, DoWorkEventArgs e)
        {
            
        }

        private void btnHistoryHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature pulls data from OSbuddy's server \nIf you are flipping a very low demand Item, you can use this instead of price checking \nGoing below 30 Minute intervals will cause data loss", "Help");
        }

        private void pnlLeftTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void webFlipRS_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void MainForm_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void tkbrLowMargin_Scroll(object sender, EventArgs e)
        {

        }

        private void btn90Days_Click(object sender, EventArgs e)
        {
            UpdateGraph(90);
            btn30Days.BackColor = Color.FromArgb(211, 204, 186);
            btn90Days.BackColor = Color.FromArgb(183, 175, 156);
            btn180Days.BackColor = Color.FromArgb(211, 204, 186);
        }

        private void btn180Days_Click(object sender, EventArgs e)
        {
            UpdateGraph(0);
            btn30Days.BackColor = Color.FromArgb(211, 204, 186);
            btn90Days.BackColor = Color.FromArgb(211, 204, 186);
            btn180Days.BackColor = Color.FromArgb(183, 175, 156);
        }

        private void btn30Days_Click(object sender, EventArgs e)
        {
            UpdateGraph(150);
            btn30Days.BackColor = Color.FromArgb(183, 175, 156);
            btn90Days.BackColor = Color.FromArgb(211, 204, 186);
            btn180Days.BackColor = Color.FromArgb(211, 204, 186);
        }

        private void picTwitch_Click(object sender, EventArgs e)
        {
            Process.Start(@"https://www.twitch.tv/aitak82");
        }

        private void picDiscord_Click(object sender, EventArgs e)
        {
            Process.Start(@"https://discord.gg/SWVDEdh");
        }

        private void pnlNavigation_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

